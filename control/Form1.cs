using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace control
{
    public partial class Form1 : Form
    {

        private bool _ComHexSend = false;
        private bool _ComHexRecive = false;
        private bool _ComReciveCheck = false;
        private bool _SocketClientHexRecive = false;
        private bool _SocketClientHexSend = false;
        private bool _SocketClientIsConnected = false;
        private bool _SocketServerHexRecive = false;
        private bool _SocketServerHexSend = false;
        private bool _SocketServerIsConnected = false;
        Socket clientSocket;
        Socket serverSocket;
        List<Socket> socketList = new List<Socket>();
        private static byte[] data = new byte[2048];

        //变量定义
        delegate void UpdateComTextEventHandler(string text);           //串口委托
        UpdateComTextEventHandler updateComText;                        //串口事件
        

        //控制标志
        enum car_status
        {
            READY,
            MOVING
        };

        enum arm_status
        {
            READY,
            MOVING
        };

        Thread thread;
        static byte[] _ControlSocketClientData;
        int _ControlSocketClientLength = 0;
        
        
        /// <summary> 构造函数
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            //串口初始化
            comboBoxDatabits.SelectedIndex = 3;
            comboBoxBaudrate.SelectedIndex = 0;
            comboBoxParity.SelectedIndex = 0;
            comboBoxStopbits.SelectedIndex = 1;

            string[] ports = SerialPort.GetPortNames();
            comboBoxCom.Items.Clear();
            comboBoxCom.Items.AddRange(ports);
            if (comboBoxCom.Items.Count > 0)
                comboBoxCom.SelectedIndex = 0;

            //TCP Server初始化
            comboBoxSocketServerIp.Items.Add("127.0.0.1");
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        comboBoxSocketServerIp.Items.Add(IpEntry.AddressList[i].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comboBoxSocketServerIp.SelectedIndex = 0;

            //事件委托
            updateComText += new UpdateComTextEventHandler(UpdateTextBox);                    //委托方法
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataRecive);  //处理串口对象的数据接受事件的方法


            //控制部分线程初始化
            ThreadStart threadStart = new ThreadStart(control);
            thread = new Thread(threadStart);
            _ControlSocketClientData = new byte[1024];

        }

        /*
         * ************************************************************************************
         *                                      串口部分程序
         * ************************************************************************************
         */

        #region 串口部分程序
    
        /// <summary> 串口连接按钮，点击后自动填写参数，打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonComConnect_Click(object sender, EventArgs e)
        {
            comOpen();
        }

        /// <summary> 串口打开
        /// </summary>
        private void comOpen()
        {
            if (serialPort.IsOpen)
            {
                //串口已经打开，尝试关闭
                try
                {
                    serialPort.Close();
                    buttonComConnect.Text = "打开";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //串口没有打开，尝试打开
                try
                {
                    serialPort.PortName = comboBoxCom.SelectedItem.ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                serialPort.BaudRate = Convert.ToInt32(comboBoxBaudrate.SelectedItem.ToString());
                serialPort.Parity = (Parity)Convert.ToInt32(comboBoxParity.SelectedIndex.ToString());
                serialPort.StopBits = (StopBits)Convert.ToInt32(comboBoxStopbits.SelectedIndex.ToString());
                serialPort.DataBits = Convert.ToInt32(comboBoxDatabits.SelectedItem.ToString());
                try
                {
                    serialPort.Open();
                    buttonComConnect.Text = "关闭";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            comboBoxBaudrate.Enabled = !serialPort.IsOpen;
            comboBoxCom.Enabled = !serialPort.IsOpen; ;
            comboBoxDatabits.Enabled = !serialPort.IsOpen;
            comboBoxParity.Enabled = !serialPort.IsOpen;
            comboBoxStopbits.Enabled = !serialPort.IsOpen;
        }

        /// <summary> 串口信息刷新按钮，点击后刷新串口信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonComClear_Click(object sender, EventArgs e)
        {
            textBoxComRecive.Clear();
        }

        /// <summary> 串口数据发送按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonComSend_Click(object sender, EventArgs e)
        {
            //判断串口是否打开
            if (serialPort.IsOpen)
            {
                string data;

                //根据是否HEX发送处理
                if (_ComHexSend)
                {
                    try
                    {
                        string ori = textBoxComSend.Text;
                        data = ori.Replace(" ", "");
                        if ((data.Length % 2) != 0)
                            data += " ";
                        byte[] returnBytes = new byte[data.Length / 2];
                        for (int i = 0; i < returnBytes.Length; i++)
                            returnBytes[i] = Convert.ToByte(data.Substring(i * 2, 2), 16);
                        data = Encoding.ASCII.GetString(returnBytes);
                    }
                    catch (Exception ex)
                    {
                        //字符分割时异常处理
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    data = textBoxComSend.Text;
                }

                //是否需要校验位
                if (_ComReciveCheck)
                {
                    data = generateCheckedString(data);
                }

                //UI记录
                string boxData = "发->" + data + "\n";
                textBoxComRecive.AppendText(boxData);
                //串口发送
                serialPort.Write(data);
            }
            else
            {
                //串口没有打开
                MessageBox.Show("请先打开串口！");
            }
        }

        /// <summary> 串口接收数据处理函数，接收数据处理后委托UI更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataRecive(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(50);

            //提取串口信息
            byte[] buffer = Encoding.ASCII.GetBytes(serialPort.ReadExisting());
            string checkString = Encoding.ASCII.GetString(buffer);
            string newString = "";

            //是否需要校验
            if (_ComReciveCheck)
                if (!stringCheck(checkString))
                    return;

            //HEX显示或者字符显示
            if (_ComHexRecive)
            {
                foreach (byte b in buffer)
                {
                    newString += b.ToString("X").PadLeft(2, '0') + " ";
                }
            }
            else
            {
                newString = Encoding.ASCII.GetString(buffer);
            }


            this.Invoke(updateComText, new string[] { newString });    //控件基础句柄线程上，执行委托
        }

        /// <summary> 委托方法更新串口接收textBox区域内容
        /// </summary>
        /// <param name="text"></param>
        private void UpdateTextBox(string text)
        {
            string data = "收->";
            data += text + "\n";
            textBoxComRecive.AppendText(data);
        }

        private void buttonComRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxCom.Items.Clear();
            comboBoxCom.Items.AddRange(ports);
            if (comboBoxCom.Items.Count > 0)
                comboBoxCom.SelectedIndex = 0;
        }

        /// <summary> 校验勾选框打勾
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxComCheck_CheckedChanged(object sender, EventArgs e)
        {
            _ComReciveCheck = checkBoxComCheck.Checked;
        }

        /// <summary> HEX接收勾选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxComHexRecive_CheckedChanged(object sender, EventArgs e)
        {
            _ComHexRecive = checkBoxComHexRecive.Checked;
        }

        /// <summary> HEX发送勾选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxComHexSend_CheckedChanged(object sender, EventArgs e)
        {
            _ComHexSend = checkBoxComHexSend.Checked;
        }

        /// <summary> 字符串校验
        /// </summary>
        /// <param name="s">待校验的字符串</param>
        /// <returns>校验结果</returns>
        private bool stringCheck(string s)
        {
            return true;
        }

        /// <summary>生成字符串校验后序列
        /// </summary>
        /// <param name="s">待校验字符串</param>
        /// <returns>带校验的字符串</returns>
        private string generateCheckedString(string s)
        {
            return s;
        }

        #endregion



        /*
         * ************************************************************************************
         *                                  TCP Client 部分程序
         * ************************************************************************************
         */

        #region TCP Client程序

        /// <summary> Socket 连接打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSocketClientOpen_Click(object sender, EventArgs e)
        {
            socketClientOpen();
        }

        /// <summary> socket Client 打开连接
        /// </summary>
        private void socketClientOpen()
        {
            IPAddress ip;
            int port;

            //获取IP 和端口，并处理异常
            try
            {
                ip = IPAddress.Parse(textBoxSocketClientIp.Text);
                port = Convert.ToInt32(textBoxSocketClientPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IPEndPoint ipe = new IPEndPoint(ip, port);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            if (!_SocketClientIsConnected)
            {
                //连接服务器
                try
                {
                    clientSocket.Connect(ipe);
                    //更新UI
                    buttonSocketClientOpen.Text = "断开";
                    toolStripStatusLabelClient.Text = "连接成功";
                    //异步接收
                    clientSocket.BeginReceive(data, 0, 1024, SocketFlags.None, ClientReceiveCallBack, clientSocket);
                    _SocketClientIsConnected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _SocketClientIsConnected = false;
                }


            }
            else
            {
                try
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                }
                catch (Exception ex)
                {

                }
                try
                {
                    clientSocket.Close();
                }
                catch (Exception)
                {

                }

                _SocketClientIsConnected = false;
                buttonSocketClientOpen.Text = "连接";

            }

            //更新UI
            clientUIUpdate();
        }

        /// <summary> 异步接受数据
        /// </summary>
        /// <param name="result"></param>
        private void ClientReceiveCallBack(IAsyncResult result)
        {
            //声明一个空的Socket
            Socket clientSocket = null;
            //当客户端被暴力关掉后，会造成服务器端的报警，这里将它try catch起来，防止程序崩溃
            try
            {
                //将传入的clientSocket进行接收，并且完成接收数据的操作
                clientSocket = result.AsyncState as Socket;
                int length = clientSocket.EndReceive(result);
                string message = Encoding.ASCII.GetString(data, 0, length);
                string newString = "";

                //如果客户端正常关闭后，会向服务端发送长度为0的空数据，利用这一点将这个客户端关闭
                if (length == 0)
                {
                    this.Invoke(new Action(() =>
                    {
                        toolStripStatusLabelClient.Text = clientSocket.RemoteEndPoint.ToString() + "断开";
                        _SocketClientIsConnected = false;
                        clientUIUpdate();       //更新UI
                    }));
                    clientSocket.Close();
                    return;
                }

                Array.Copy(data, _ControlSocketClientData, length);     //控制用缓存
                _ControlSocketClientLength = length;

                //HEX显示或字符显示
                if (_SocketClientHexRecive)
                {
                    foreach (byte b in message)
                    {
                        newString += b.ToString("X").PadLeft(2, '0') + " ";
                    }
                }
                else
                {
                    newString = message;
                }

                this.Invoke(new Action(() =>
                {
                    textBoxSocketClientRecive.AppendText(newString + "\n");
                }));

                //重新调用开始接收数据
                clientSocket.BeginReceive(data, 0, 1024, SocketFlags.None, ClientReceiveCallBack, clientSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                if (clientSocket != null)
                {
                    clientSocket.Close();
                    _SocketClientIsConnected = false;
                    clientUIUpdate();       //更新UI
                }
            }
        }


        /// <summary> Socket 发送按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSocketClientSend_Click(object sender, EventArgs e)
        {
            string data = textBoxSocketClientSend.Text;
            byte[] byteData = new byte[1];

            //HEX发送或字符发送
            if (_SocketClientHexSend)
            {
                try
                {
                    string da = data.Replace(" ", "");
                    if ((da.Length % 2) != 0)
                    {
                        da += " ";
                    }
                    byteData = new byte[da.Length / 2];
                    for (int i = 0; i < byteData.Length; i++)
                    {
                        byteData[i] = Convert.ToByte(da.Substring(i * 2, 2), 16);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                byteData = Encoding.ASCII.GetBytes(data);
            }

            //异步发送
            try
            {
                clientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, ClientSendCallBack, clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SocketClientIsConnected = false;
                clientUIUpdate();
            }

        }

        /// <summary> Socket异步发送
        /// </summary>
        /// <param name="result"></param>
        private void ClientSendCallBack(IAsyncResult result)
        {
            try
            {
                Socket client = result.AsyncState as Socket;

                int btyesSent = client.EndSend(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SocketClientIsConnected = false;
                clientUIUpdate();
            }
        }

        /// <summary> Socket Client UI更新
        /// </summary>
        private void clientUIUpdate()
        {
            if (_SocketClientIsConnected)
            {
                buttonSocketClientOpen.Text = "断开";
            }
            else
            {
                buttonSocketClientOpen.Text = "连接";
                toolStripStatusLabelClient.Text = "连接断开";
            }
            textBoxSocketClientIp.Enabled = !_SocketClientIsConnected;
            textBoxSocketClientPort.Enabled = !_SocketClientIsConnected;
        }

        /// <summary> socket HEX接收勾选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSocketClientHexRecive_CheckedChanged(object sender, EventArgs e)
        {
            _SocketClientHexRecive = checkBoxSocketClientHexRecive.Checked;
        }

        /// <summary> socket HEX发送勾选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSocketClientHexSend_CheckedChanged(object sender, EventArgs e)
        {
            _SocketClientHexSend = checkBoxSocketClientHexSend.Checked;
        }

        /// <summary> 清空接收显示区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSocketClientClean_Click(object sender, EventArgs e)
        {
            textBoxSocketClientRecive.Clear();
        }

        #endregion

        


        /*
         * ************************************************************************************
         *                                  TCP Server 部分程序
         * ************************************************************************************
         */

        #region TCP Server程序

        /// <summary> Socket 连接打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSocketServerOpen_Click(object sender, EventArgs e)
        {
            socketServerOpen();
        }

        /// <summary> socket Server 打开等待连接
        /// </summary>
        private void socketServerOpen()
        {
            IPAddress ip;
            int port;

            //获取IP 和端口，并处理异常
            try
            {
                ip = IPAddress.Parse(comboBoxSocketServerIp.Text);
                port = Convert.ToInt32(textBoxSocketServerPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IPEndPoint ipe = new IPEndPoint(ip, port);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (!_SocketServerIsConnected)
            {
                try
                {
                    //TCP Server
                    serverSocket.Bind(ipe);                               //绑定
                    serverSocket.Listen(5);                               //连接数无限制
                    serverSocket.BeginAccept(AcceptCallBack, serverSocket);     //调用异步连接

                    toolStripStatusLabelServer.Text = "开始监听";
                    buttonSocketServerOpen.Text = "断开";
                    _SocketServerIsConnected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _SocketServerIsConnected = false;
                }


            }
            else
            {
                try
                {
                    serverSocket.Shutdown(SocketShutdown.Both);
                }
                catch (Exception)
                {

                }
                serverSocket.Close();
                _SocketServerIsConnected = false;
                toolStripStatusLabelServer.Text = "停止监听";
                buttonSocketServerOpen.Text = "连接";

            }


            serverUIUpdate();
        }

        /// <summary> 服务器端异步连接
        /// </summary>
        /// <param name="result"></param>
        private void AcceptCallBack(IAsyncResult result)
        {

            Socket serverSocket = result.AsyncState as Socket;
            //在接收到一台要连入的计算机后，我们要获得接入的计算机的信息，//就需要一个Socket专门用于和它通信。我们再声明一个clientSocket,//用于接收和发送接入方的数据
            Socket clientSocket = serverSocket.EndAccept(result);
            //在获得这个clientSocket后，使用BeginReceive方法来接收数据 
            clientSocket.BeginReceive(data, 0, 1024, SocketFlags.None, ServerReceiveCallBack, clientSocket);
            //建立了通信，开启接收数据后，我们要循环接收其他要连接的计算机，所以这里接着进行等待接收，这样就实现了一个循环不断的接收
            serverSocket.BeginAccept(AcceptCallBack, serverSocket);

            socketList.Add(clientSocket);

            this.Invoke(new Action(() =>
            {
                toolStripStatusLabelServer.Text = clientSocket.RemoteEndPoint.ToString() + "连接";
            }));

        }

        /// <summary> 异步接受数据
        /// </summary>
        /// <param name="result"></param>
        private void ServerReceiveCallBack(IAsyncResult result)
        {
            //声明一个空的Socket
            Socket clientSocket = null;
            //当客户端被暴力关掉后，会造成服务器端的报警，这里将它try catch起来，防止程序崩溃
            try
            {
                //将传入的clientSocket进行接收，并且完成接收数据的操作
                clientSocket = result.AsyncState as Socket;
                int length = clientSocket.EndReceive(result);
                string message = Encoding.ASCII.GetString(data, 0, length);
                string newString = "";

                //如果客户端正常关闭后，会向服务端发送长度为0的空数据，利用这一点将这个客户端关闭
                if (length == 0)
                {
                    this.Invoke(new Action(() =>
                    {
                        toolStripStatusLabelServer.Text = clientSocket.RemoteEndPoint.ToString() + "断开";
                        _SocketServerIsConnected = false;
                        serverUIUpdate();
                    }));
                    clientSocket.Close();
                    return;
                }

                //HEX显示或字符显示
                if (_SocketServerHexRecive)
                {
                    foreach (byte b in message)
                    {
                        newString += b.ToString("X").PadLeft(2, '0') + " ";
                    }
                }
                else
                {
                    newString = message;
                }

                this.Invoke(new Action(() =>
                {
                    textBoxSocketServerRecive.AppendText(newString + "\n");
                }));

                //重新调用开始接收数据
                clientSocket.BeginReceive(data, 0, 1024, SocketFlags.None, ServerReceiveCallBack, clientSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                if (clientSocket != null)
                {
                    clientSocket.Close();
                    _SocketServerIsConnected = false;
                    serverUIUpdate();               //更新UI
                }
            }

        }

        /// <summary> Socket 发送按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSocketServerSend_Click(object sender, EventArgs e)
        {
            string data = textBoxSocketServerSend.Text;
            byte[] byteData = new byte[1];

            //HEX发送或字符发送
            if (_SocketServerHexSend)
            {
                try
                {
                    string da = data.Replace(" ", "");
                    if ((da.Length % 2) != 0)
                    {
                        da += " ";
                    }
                    byteData = new byte[da.Length / 2];
                    for (int i = 0; i < byteData.Length; i++)
                    {
                        byteData[i] = Convert.ToByte(da.Substring(i * 2, 2), 16);
                    }

                }
                catch (Exception ex)
                {
                    _SocketServerIsConnected = false;
                    serverUIUpdate();                   //更新UI
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                byteData = Encoding.ASCII.GetBytes(data);
            }

            
            //TCP Server
            foreach (Socket clientSocket in socketList)
            {
                try
                {
                    clientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, ServerSendCallBack, clientSocket);
                }
                catch (Exception ex)
                {
                    _SocketServerIsConnected = false;
                    serverUIUpdate();                   //更新UI
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /// <summary> Socket异步发送
        /// </summary>
        /// <param name="result"></param>
        private void ServerSendCallBack(IAsyncResult result)
        {
            try
            {
                Socket client = result.AsyncState as Socket;

                int btyesSent = client.EndSend(result);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SocketServerIsConnected = false;
                serverUIUpdate();       //更新UI
            }
        }

        /// <summary> Socket Server更新UI
        /// </summary>
        private void serverUIUpdate()
        {
            if(_SocketServerIsConnected)
            {
                buttonSocketServerOpen.Text = "断开";
            }
            else
            {
                buttonSocketServerOpen.Text = "连接";
            }

            comboBoxSocketServerIp.Enabled = !_SocketServerIsConnected;
            textBoxSocketServerPort.Enabled = !_SocketServerIsConnected;
        }

        /// <summary> socket HEX接收勾选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSocketServerHexRecive_CheckedChanged(object sender, EventArgs e)
        {
            _SocketServerHexRecive = checkBoxSocketServerHexRecive.Checked;
        }

        /// <summary> socket HEX发送勾选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSocketServerHexSend_CheckedChanged(object sender, EventArgs e)
        {
            _SocketServerHexSend = checkBoxSocketServerHexSend.Checked;
        }

        /// <summary> socket接受区域清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSocketServerClean_Click(object sender, EventArgs e)
        {
            textBoxSocketServerRecive.Clear();
        }

        #endregion




        /*
         * ************************************************************************************
         *                                  运动控制部分程序
         * ************************************************************************************
         */

        #region

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonControl_Click(object sender, EventArgs e)
        {
            /*
            //初始化串口
            if(!serialPort.IsOpen)
            {
                MessageBox.Show("请先打开串口！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //初始化客户端
            if(!_SocketClientIsConnected)
            {
                MessageBox.Show("请先打开TCP 客户端", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //初始化服务端
            if(!_SocketServerIsConnected)
            {
                MessageBox.Show("请先打开TCP服务端", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
            

            if(thread.ThreadState != ThreadState.Unstarted && thread.ThreadState != ThreadState.Aborted && thread.ThreadState!= ThreadState.Stopped)
            {
                thread.Abort();
                buttonControl.Text = "开始";
            }
            else
            {
                ThreadStart threadStart = new ThreadStart(control);
                thread = new Thread(threadStart);
                thread.Start();
                buttonControl.Text = "停止";
            }
            
        }

        /// <summary> 控制线程
        /// </summary>
        private void control()
        {
            byte[] json = Encoding.ASCII.GetBytes("{\"name\":\"task_4_1\"}");       //出发
            byte[] byteData = carPacketCreate(2002, 1,json);

            _ControlSocketClientLength = 0;
            if (socketClientSend(byteData) == -1)
                return;

            Thread.Sleep(5000);
            //处理接收数据
            if (_ControlSocketClientLength == 0)
            {
                MessageBox.Show("AGV指令超时！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_ControlSocketClientLength != 16)
            {
                MessageBox.Show("AGV指令错误!","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //循环查询运动状态



            //机械臂
            

            //执行完成
            this.Invoke(new Action(() =>
            {
                buttonControl.Text = "开始";
            }));
        }

        /// <summary> 生成AGV通信包
        /// </summary>
        /// <param name="APICode"></param>
        /// <param name="packetId"></param>
        /// <param name="json"></param>
        /// <returns></returns>
        private byte[] carPacketCreate(int APICode, int packetId,byte[] json)
        {
            byte[] data = new byte[16 + json.Length];
            int length = json.Length;

            data[0] = 90;
            data[1] = 1;
            data[2] = (byte)((packetId >> 8) & 0xFF);
            data[3] = (byte)(packetId & 0xFF);
            data[4] = (byte)((length >> 24) & 0xFF);
            data[5] = (byte)((length >> 16) & 0xFF);
            data[6] = (byte)((length >> 8) & 0xFF);
            data[7] = (byte)(length & 0xFF);
            data[8] = (byte)((APICode >> 8) & 0xFF);
            data[9] = (byte)(APICode & 0xFF);
            data[10] = 0;
            data[11] = 0;
            data[12] = 0;
            data[13] = 0;
            data[14] = 0;
            data[15] = 0;

            Array.Copy(json, 0, data, 16, json.Length);
            

            return data;
        }

        /// <summary> socket client 发送数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns>异常 -1 正常 0</returns>
        private int socketClientSend(byte[] data)
        {
            //异步发送
            try
            {
                clientSocket.BeginSend(data, 0, data.Length, SocketFlags.None, ClientSendCallBack, clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SocketClientIsConnected = false;
                clientUIUpdate();
                return -1;
            }

            string newString = "";
            foreach (byte b in data)
            {
                newString += b.ToString("X").PadLeft(2, '0') + " ";
            }

            this.Invoke(new Action(() => 
            {
                textBoxSocketClientRecive.AppendText(newString + "\n");
            }));

            return 0;
        }

        #endregion


    }
}
