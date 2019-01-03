namespace control
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCom = new System.Windows.Forms.TabPage();
            this.checkBoxComCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxComHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxComHexRecive = new System.Windows.Forms.CheckBox();
            this.buttonComClear = new System.Windows.Forms.Button();
            this.buttonComSend = new System.Windows.Forms.Button();
            this.textBoxComSend = new System.Windows.Forms.TextBox();
            this.textBoxComRecive = new System.Windows.Forms.TextBox();
            this.labelStopbits = new System.Windows.Forms.Label();
            this.buttonComRefresh = new System.Windows.Forms.Button();
            this.buttonComConnect = new System.Windows.Forms.Button();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.comboBoxStopbits = new System.Windows.Forms.ComboBox();
            this.labelDatabits = new System.Windows.Forms.Label();
            this.comboBoxDatabits = new System.Windows.Forms.ComboBox();
            this.tabPageTCPClient = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxSocketClientIp = new System.Windows.Forms.TextBox();
            this.textBoxTcpClient = new System.Windows.Forms.TextBox();
            this.buttonSocketClientSend = new System.Windows.Forms.Button();
            this.textBoxSocketClientSend = new System.Windows.Forms.TextBox();
            this.textBoxSocketClientRecive = new System.Windows.Forms.TextBox();
            this.buttonSocketClientClean = new System.Windows.Forms.Button();
            this.textBoxSocketClientPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonSocketClientOpen = new System.Windows.Forms.Button();
            this.checkBoxSocketClientHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxSocketClientHexRecive = new System.Windows.Forms.CheckBox();
            this.tabPageTCPServer = new System.Windows.Forms.TabPage();
            this.comboBoxSocketServerIp = new System.Windows.Forms.ComboBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxTcpServer = new System.Windows.Forms.TextBox();
            this.buttonSocketServerSend = new System.Windows.Forms.Button();
            this.textBoxSocketServerSend = new System.Windows.Forms.TextBox();
            this.textBoxSocketServerRecive = new System.Windows.Forms.TextBox();
            this.buttonSocketServerClean = new System.Windows.Forms.Button();
            this.textBoxSocketServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSocketServerOpen = new System.Windows.Forms.Button();
            this.checkBoxSocketServerHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxSocketServerHexRecive = new System.Windows.Forms.CheckBox();
            this.tabPageControl = new System.Windows.Forms.TabPage();
            this.buttonControl = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageCom.SuspendLayout();
            this.tabPageTCPClient.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPageTCPServer.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.tabPageControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCom);
            this.tabControl1.Controls.Add(this.tabPageTCPClient);
            this.tabControl1.Controls.Add(this.tabPageTCPServer);
            this.tabControl1.Controls.Add(this.tabPageControl);
            this.tabControl1.Location = new System.Drawing.Point(24, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1408, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCom
            // 
            this.tabPageCom.Controls.Add(this.checkBoxComCheck);
            this.tabPageCom.Controls.Add(this.checkBoxComHexSend);
            this.tabPageCom.Controls.Add(this.checkBoxComHexRecive);
            this.tabPageCom.Controls.Add(this.buttonComClear);
            this.tabPageCom.Controls.Add(this.buttonComSend);
            this.tabPageCom.Controls.Add(this.textBoxComSend);
            this.tabPageCom.Controls.Add(this.textBoxComRecive);
            this.tabPageCom.Controls.Add(this.labelStopbits);
            this.tabPageCom.Controls.Add(this.buttonComRefresh);
            this.tabPageCom.Controls.Add(this.buttonComConnect);
            this.tabPageCom.Controls.Add(this.comboBoxCom);
            this.tabPageCom.Controls.Add(this.labelCom);
            this.tabPageCom.Controls.Add(this.comboBoxParity);
            this.tabPageCom.Controls.Add(this.labelBaudrate);
            this.tabPageCom.Controls.Add(this.labelParity);
            this.tabPageCom.Controls.Add(this.comboBoxBaudrate);
            this.tabPageCom.Controls.Add(this.comboBoxStopbits);
            this.tabPageCom.Controls.Add(this.labelDatabits);
            this.tabPageCom.Controls.Add(this.comboBoxDatabits);
            this.tabPageCom.Location = new System.Drawing.Point(8, 39);
            this.tabPageCom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageCom.Name = "tabPageCom";
            this.tabPageCom.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageCom.Size = new System.Drawing.Size(1392, 511);
            this.tabPageCom.TabIndex = 0;
            this.tabPageCom.Text = "串口";
            this.tabPageCom.UseVisualStyleBackColor = true;
            // 
            // checkBoxComCheck
            // 
            this.checkBoxComCheck.AutoSize = true;
            this.checkBoxComCheck.Location = new System.Drawing.Point(218, 334);
            this.checkBoxComCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxComCheck.Name = "checkBoxComCheck";
            this.checkBoxComCheck.Size = new System.Drawing.Size(90, 28);
            this.checkBoxComCheck.TabIndex = 38;
            this.checkBoxComCheck.Text = "校验";
            this.checkBoxComCheck.UseVisualStyleBackColor = true;
            this.checkBoxComCheck.CheckedChanged += new System.EventHandler(this.checkBoxComCheck_CheckedChanged);
            // 
            // checkBoxComHexSend
            // 
            this.checkBoxComHexSend.AutoSize = true;
            this.checkBoxComHexSend.Location = new System.Drawing.Point(16, 328);
            this.checkBoxComHexSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxComHexSend.Name = "checkBoxComHexSend";
            this.checkBoxComHexSend.Size = new System.Drawing.Size(126, 28);
            this.checkBoxComHexSend.TabIndex = 37;
            this.checkBoxComHexSend.Text = "HEX发送";
            this.checkBoxComHexSend.UseVisualStyleBackColor = true;
            this.checkBoxComHexSend.CheckedChanged += new System.EventHandler(this.checkBoxComHexSend_CheckedChanged);
            // 
            // checkBoxComHexRecive
            // 
            this.checkBoxComHexRecive.AutoSize = true;
            this.checkBoxComHexRecive.Location = new System.Drawing.Point(16, 284);
            this.checkBoxComHexRecive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxComHexRecive.Name = "checkBoxComHexRecive";
            this.checkBoxComHexRecive.Size = new System.Drawing.Size(126, 28);
            this.checkBoxComHexRecive.TabIndex = 36;
            this.checkBoxComHexRecive.Text = "HEX接收";
            this.checkBoxComHexRecive.UseVisualStyleBackColor = true;
            this.checkBoxComHexRecive.CheckedChanged += new System.EventHandler(this.checkBoxComHexRecive_CheckedChanged);
            // 
            // buttonComClear
            // 
            this.buttonComClear.Location = new System.Drawing.Point(198, 276);
            this.buttonComClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonComClear.Name = "buttonComClear";
            this.buttonComClear.Size = new System.Drawing.Size(150, 46);
            this.buttonComClear.TabIndex = 35;
            this.buttonComClear.Text = "清空";
            this.buttonComClear.UseVisualStyleBackColor = true;
            this.buttonComClear.Click += new System.EventHandler(this.buttonComClear_Click);
            // 
            // buttonComSend
            // 
            this.buttonComSend.Location = new System.Drawing.Point(1230, 378);
            this.buttonComSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonComSend.Name = "buttonComSend";
            this.buttonComSend.Size = new System.Drawing.Size(150, 46);
            this.buttonComSend.TabIndex = 34;
            this.buttonComSend.Text = "发送";
            this.buttonComSend.UseVisualStyleBackColor = true;
            this.buttonComSend.Click += new System.EventHandler(this.buttonComSend_Click);
            // 
            // textBoxComSend
            // 
            this.textBoxComSend.Location = new System.Drawing.Point(360, 378);
            this.textBoxComSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxComSend.Name = "textBoxComSend";
            this.textBoxComSend.Size = new System.Drawing.Size(854, 35);
            this.textBoxComSend.TabIndex = 33;
            // 
            // textBoxComRecive
            // 
            this.textBoxComRecive.Location = new System.Drawing.Point(360, 18);
            this.textBoxComRecive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxComRecive.Multiline = true;
            this.textBoxComRecive.Name = "textBoxComRecive";
            this.textBoxComRecive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxComRecive.Size = new System.Drawing.Size(1016, 344);
            this.textBoxComRecive.TabIndex = 32;
            // 
            // labelStopbits
            // 
            this.labelStopbits.AutoSize = true;
            this.labelStopbits.Location = new System.Drawing.Point(12, 178);
            this.labelStopbits.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStopbits.Name = "labelStopbits";
            this.labelStopbits.Size = new System.Drawing.Size(82, 24);
            this.labelStopbits.TabIndex = 26;
            this.labelStopbits.Text = "停止位";
            // 
            // buttonComRefresh
            // 
            this.buttonComRefresh.Location = new System.Drawing.Point(198, 378);
            this.buttonComRefresh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonComRefresh.Name = "buttonComRefresh";
            this.buttonComRefresh.Size = new System.Drawing.Size(150, 46);
            this.buttonComRefresh.TabIndex = 31;
            this.buttonComRefresh.Text = "刷新";
            this.buttonComRefresh.UseVisualStyleBackColor = true;
            this.buttonComRefresh.Click += new System.EventHandler(this.buttonComRefresh_Click);
            // 
            // buttonComConnect
            // 
            this.buttonComConnect.Location = new System.Drawing.Point(16, 378);
            this.buttonComConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonComConnect.Name = "buttonComConnect";
            this.buttonComConnect.Size = new System.Drawing.Size(150, 46);
            this.buttonComConnect.TabIndex = 20;
            this.buttonComConnect.Text = "打开";
            this.buttonComConnect.UseVisualStyleBackColor = true;
            this.buttonComConnect.Click += new System.EventHandler(this.buttonComConnect_Click);
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(106, 18);
            this.comboBoxCom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(238, 32);
            this.comboBoxCom.TabIndex = 30;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(12, 24);
            this.labelCom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(82, 24);
            this.labelCom.TabIndex = 21;
            this.labelCom.Text = "串口号";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(106, 224);
            this.comboBoxParity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(238, 32);
            this.comboBoxParity.TabIndex = 29;
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(12, 74);
            this.labelBaudrate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(82, 24);
            this.labelBaudrate.TabIndex = 22;
            this.labelBaudrate.Text = "波特率";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(12, 230);
            this.labelParity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(82, 24);
            this.labelParity.TabIndex = 28;
            this.labelParity.Text = "校验位";
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(106, 68);
            this.comboBoxBaudrate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(238, 32);
            this.comboBoxBaudrate.TabIndex = 23;
            // 
            // comboBoxStopbits
            // 
            this.comboBoxStopbits.FormattingEnabled = true;
            this.comboBoxStopbits.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "1.5"});
            this.comboBoxStopbits.Location = new System.Drawing.Point(106, 172);
            this.comboBoxStopbits.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxStopbits.Name = "comboBoxStopbits";
            this.comboBoxStopbits.Size = new System.Drawing.Size(238, 32);
            this.comboBoxStopbits.TabIndex = 27;
            // 
            // labelDatabits
            // 
            this.labelDatabits.AutoSize = true;
            this.labelDatabits.Location = new System.Drawing.Point(12, 126);
            this.labelDatabits.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDatabits.Name = "labelDatabits";
            this.labelDatabits.Size = new System.Drawing.Size(82, 24);
            this.labelDatabits.TabIndex = 24;
            this.labelDatabits.Text = "数据位";
            // 
            // comboBoxDatabits
            // 
            this.comboBoxDatabits.FormattingEnabled = true;
            this.comboBoxDatabits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDatabits.Location = new System.Drawing.Point(106, 120);
            this.comboBoxDatabits.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxDatabits.Name = "comboBoxDatabits";
            this.comboBoxDatabits.Size = new System.Drawing.Size(238, 32);
            this.comboBoxDatabits.TabIndex = 25;
            // 
            // tabPageTCPClient
            // 
            this.tabPageTCPClient.Controls.Add(this.statusStrip1);
            this.tabPageTCPClient.Controls.Add(this.textBoxSocketClientIp);
            this.tabPageTCPClient.Controls.Add(this.textBoxTcpClient);
            this.tabPageTCPClient.Controls.Add(this.buttonSocketClientSend);
            this.tabPageTCPClient.Controls.Add(this.textBoxSocketClientSend);
            this.tabPageTCPClient.Controls.Add(this.textBoxSocketClientRecive);
            this.tabPageTCPClient.Controls.Add(this.buttonSocketClientClean);
            this.tabPageTCPClient.Controls.Add(this.textBoxSocketClientPort);
            this.tabPageTCPClient.Controls.Add(this.labelPort);
            this.tabPageTCPClient.Controls.Add(this.labelIPAddress);
            this.tabPageTCPClient.Controls.Add(this.labelType);
            this.tabPageTCPClient.Controls.Add(this.buttonSocketClientOpen);
            this.tabPageTCPClient.Controls.Add(this.checkBoxSocketClientHexSend);
            this.tabPageTCPClient.Controls.Add(this.checkBoxSocketClientHexRecive);
            this.tabPageTCPClient.Location = new System.Drawing.Point(8, 39);
            this.tabPageTCPClient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageTCPClient.Name = "tabPageTCPClient";
            this.tabPageTCPClient.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageTCPClient.Size = new System.Drawing.Size(1392, 511);
            this.tabPageTCPClient.TabIndex = 1;
            this.tabPageTCPClient.Text = "TCP Client";
            this.tabPageTCPClient.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelClient});
            this.statusStrip1.Location = new System.Drawing.Point(6, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1380, 22);
            this.statusStrip1.TabIndex = 48;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelClient
            // 
            this.toolStripStatusLabelClient.Name = "toolStripStatusLabelClient";
            this.toolStripStatusLabelClient.Size = new System.Drawing.Size(0, 17);
            // 
            // textBoxSocketClientIp
            // 
            this.textBoxSocketClientIp.Location = new System.Drawing.Point(12, 122);
            this.textBoxSocketClientIp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSocketClientIp.Name = "textBoxSocketClientIp";
            this.textBoxSocketClientIp.Size = new System.Drawing.Size(270, 35);
            this.textBoxSocketClientIp.TabIndex = 47;
            this.textBoxSocketClientIp.Text = "192.168.192.10";
            // 
            // textBoxTcpClient
            // 
            this.textBoxTcpClient.Enabled = false;
            this.textBoxTcpClient.Location = new System.Drawing.Point(14, 48);
            this.textBoxTcpClient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxTcpClient.Name = "textBoxTcpClient";
            this.textBoxTcpClient.Size = new System.Drawing.Size(270, 35);
            this.textBoxTcpClient.TabIndex = 46;
            this.textBoxTcpClient.Text = "TCP Client";
            // 
            // buttonSocketClientSend
            // 
            this.buttonSocketClientSend.Location = new System.Drawing.Point(1230, 360);
            this.buttonSocketClientSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSocketClientSend.Name = "buttonSocketClientSend";
            this.buttonSocketClientSend.Size = new System.Drawing.Size(150, 46);
            this.buttonSocketClientSend.TabIndex = 44;
            this.buttonSocketClientSend.Text = "发送";
            this.buttonSocketClientSend.UseVisualStyleBackColor = true;
            this.buttonSocketClientSend.Click += new System.EventHandler(this.buttonSocketClientSend_Click);
            // 
            // textBoxSocketClientSend
            // 
            this.textBoxSocketClientSend.Location = new System.Drawing.Point(300, 360);
            this.textBoxSocketClientSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSocketClientSend.Name = "textBoxSocketClientSend";
            this.textBoxSocketClientSend.Size = new System.Drawing.Size(914, 35);
            this.textBoxSocketClientSend.TabIndex = 43;
            // 
            // textBoxSocketClientRecive
            // 
            this.textBoxSocketClientRecive.Location = new System.Drawing.Point(300, 16);
            this.textBoxSocketClientRecive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSocketClientRecive.Multiline = true;
            this.textBoxSocketClientRecive.Name = "textBoxSocketClientRecive";
            this.textBoxSocketClientRecive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSocketClientRecive.Size = new System.Drawing.Size(1076, 324);
            this.textBoxSocketClientRecive.TabIndex = 42;
            // 
            // buttonSocketClientClean
            // 
            this.buttonSocketClientClean.Location = new System.Drawing.Point(12, 298);
            this.buttonSocketClientClean.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSocketClientClean.Name = "buttonSocketClientClean";
            this.buttonSocketClientClean.Size = new System.Drawing.Size(276, 46);
            this.buttonSocketClientClean.TabIndex = 41;
            this.buttonSocketClientClean.Text = "清空";
            this.buttonSocketClientClean.UseVisualStyleBackColor = true;
            this.buttonSocketClientClean.Click += new System.EventHandler(this.buttonSocketClientClean_Click);
            // 
            // textBoxSocketClientPort
            // 
            this.textBoxSocketClientPort.Location = new System.Drawing.Point(12, 200);
            this.textBoxSocketClientPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSocketClientPort.Name = "textBoxSocketClientPort";
            this.textBoxSocketClientPort.Size = new System.Drawing.Size(272, 35);
            this.textBoxSocketClientPort.TabIndex = 40;
            this.textBoxSocketClientPort.Text = "8080";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(8, 170);
            this.labelPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(82, 24);
            this.labelPort.TabIndex = 39;
            this.labelPort.Text = "端口号";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(8, 92);
            this.labelIPAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(82, 24);
            this.labelIPAddress.TabIndex = 38;
            this.labelIPAddress.Text = "IP地址";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(8, 16);
            this.labelType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(106, 24);
            this.labelType.TabIndex = 37;
            this.labelType.Text = "协议类型";
            // 
            // buttonSocketClientOpen
            // 
            this.buttonSocketClientOpen.Location = new System.Drawing.Point(12, 356);
            this.buttonSocketClientOpen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSocketClientOpen.Name = "buttonSocketClientOpen";
            this.buttonSocketClientOpen.Size = new System.Drawing.Size(276, 46);
            this.buttonSocketClientOpen.TabIndex = 35;
            this.buttonSocketClientOpen.Text = "连接";
            this.buttonSocketClientOpen.UseVisualStyleBackColor = true;
            this.buttonSocketClientOpen.Click += new System.EventHandler(this.buttonSocketClientOpen_Click);
            // 
            // checkBoxSocketClientHexSend
            // 
            this.checkBoxSocketClientHexSend.AutoSize = true;
            this.checkBoxSocketClientHexSend.Location = new System.Drawing.Point(156, 254);
            this.checkBoxSocketClientHexSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxSocketClientHexSend.Name = "checkBoxSocketClientHexSend";
            this.checkBoxSocketClientHexSend.Size = new System.Drawing.Size(126, 28);
            this.checkBoxSocketClientHexSend.TabIndex = 34;
            this.checkBoxSocketClientHexSend.Text = "HEX发送";
            this.checkBoxSocketClientHexSend.UseVisualStyleBackColor = true;
            this.checkBoxSocketClientHexSend.CheckedChanged += new System.EventHandler(this.checkBoxSocketClientHexSend_CheckedChanged);
            // 
            // checkBoxSocketClientHexRecive
            // 
            this.checkBoxSocketClientHexRecive.AutoSize = true;
            this.checkBoxSocketClientHexRecive.Location = new System.Drawing.Point(12, 254);
            this.checkBoxSocketClientHexRecive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxSocketClientHexRecive.Name = "checkBoxSocketClientHexRecive";
            this.checkBoxSocketClientHexRecive.Size = new System.Drawing.Size(126, 28);
            this.checkBoxSocketClientHexRecive.TabIndex = 33;
            this.checkBoxSocketClientHexRecive.Text = "HEX接收";
            this.checkBoxSocketClientHexRecive.UseVisualStyleBackColor = true;
            this.checkBoxSocketClientHexRecive.CheckedChanged += new System.EventHandler(this.checkBoxSocketClientHexRecive_CheckedChanged);
            // 
            // tabPageTCPServer
            // 
            this.tabPageTCPServer.Controls.Add(this.comboBoxSocketServerIp);
            this.tabPageTCPServer.Controls.Add(this.statusStrip2);
            this.tabPageTCPServer.Controls.Add(this.textBoxTcpServer);
            this.tabPageTCPServer.Controls.Add(this.buttonSocketServerSend);
            this.tabPageTCPServer.Controls.Add(this.textBoxSocketServerSend);
            this.tabPageTCPServer.Controls.Add(this.textBoxSocketServerRecive);
            this.tabPageTCPServer.Controls.Add(this.buttonSocketServerClean);
            this.tabPageTCPServer.Controls.Add(this.textBoxSocketServerPort);
            this.tabPageTCPServer.Controls.Add(this.label1);
            this.tabPageTCPServer.Controls.Add(this.label2);
            this.tabPageTCPServer.Controls.Add(this.label3);
            this.tabPageTCPServer.Controls.Add(this.buttonSocketServerOpen);
            this.tabPageTCPServer.Controls.Add(this.checkBoxSocketServerHexSend);
            this.tabPageTCPServer.Controls.Add(this.checkBoxSocketServerHexRecive);
            this.tabPageTCPServer.Location = new System.Drawing.Point(8, 39);
            this.tabPageTCPServer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageTCPServer.Name = "tabPageTCPServer";
            this.tabPageTCPServer.Size = new System.Drawing.Size(1392, 511);
            this.tabPageTCPServer.TabIndex = 2;
            this.tabPageTCPServer.Text = "TCP Server";
            this.tabPageTCPServer.UseVisualStyleBackColor = true;
            // 
            // comboBoxSocketServerIp
            // 
            this.comboBoxSocketServerIp.FormattingEnabled = true;
            this.comboBoxSocketServerIp.Location = new System.Drawing.Point(10, 128);
            this.comboBoxSocketServerIp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxSocketServerIp.Name = "comboBoxSocketServerIp";
            this.comboBoxSocketServerIp.Size = new System.Drawing.Size(272, 32);
            this.comboBoxSocketServerIp.TabIndex = 63;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelServer});
            this.statusStrip2.Location = new System.Drawing.Point(0, 489);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip2.Size = new System.Drawing.Size(1392, 22);
            this.statusStrip2.TabIndex = 62;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabelServer
            // 
            this.toolStripStatusLabelServer.Name = "toolStripStatusLabelServer";
            this.toolStripStatusLabelServer.Size = new System.Drawing.Size(0, 17);
            // 
            // textBoxTcpServer
            // 
            this.textBoxTcpServer.Enabled = false;
            this.textBoxTcpServer.Location = new System.Drawing.Point(12, 54);
            this.textBoxTcpServer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxTcpServer.Name = "textBoxTcpServer";
            this.textBoxTcpServer.Size = new System.Drawing.Size(270, 35);
            this.textBoxTcpServer.TabIndex = 60;
            this.textBoxTcpServer.Text = "TCP Server";
            // 
            // buttonSocketServerSend
            // 
            this.buttonSocketServerSend.Location = new System.Drawing.Point(1228, 366);
            this.buttonSocketServerSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSocketServerSend.Name = "buttonSocketServerSend";
            this.buttonSocketServerSend.Size = new System.Drawing.Size(150, 46);
            this.buttonSocketServerSend.TabIndex = 59;
            this.buttonSocketServerSend.Text = "发送";
            this.buttonSocketServerSend.UseVisualStyleBackColor = true;
            this.buttonSocketServerSend.Click += new System.EventHandler(this.buttonSocketServerSend_Click);
            // 
            // textBoxSocketServerSend
            // 
            this.textBoxSocketServerSend.Location = new System.Drawing.Point(298, 366);
            this.textBoxSocketServerSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSocketServerSend.Name = "textBoxSocketServerSend";
            this.textBoxSocketServerSend.Size = new System.Drawing.Size(914, 35);
            this.textBoxSocketServerSend.TabIndex = 58;
            // 
            // textBoxSocketServerRecive
            // 
            this.textBoxSocketServerRecive.Location = new System.Drawing.Point(298, 22);
            this.textBoxSocketServerRecive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSocketServerRecive.Multiline = true;
            this.textBoxSocketServerRecive.Name = "textBoxSocketServerRecive";
            this.textBoxSocketServerRecive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSocketServerRecive.Size = new System.Drawing.Size(1076, 324);
            this.textBoxSocketServerRecive.TabIndex = 57;
            // 
            // buttonSocketServerClean
            // 
            this.buttonSocketServerClean.Location = new System.Drawing.Point(10, 304);
            this.buttonSocketServerClean.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSocketServerClean.Name = "buttonSocketServerClean";
            this.buttonSocketServerClean.Size = new System.Drawing.Size(276, 46);
            this.buttonSocketServerClean.TabIndex = 56;
            this.buttonSocketServerClean.Text = "清空";
            this.buttonSocketServerClean.UseVisualStyleBackColor = true;
            this.buttonSocketServerClean.Click += new System.EventHandler(this.buttonSocketServerClean_Click);
            // 
            // textBoxSocketServerPort
            // 
            this.textBoxSocketServerPort.Location = new System.Drawing.Point(10, 206);
            this.textBoxSocketServerPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSocketServerPort.Name = "textBoxSocketServerPort";
            this.textBoxSocketServerPort.Size = new System.Drawing.Size(272, 35);
            this.textBoxSocketServerPort.TabIndex = 55;
            this.textBoxSocketServerPort.Text = "5000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "IP地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "协议类型";
            // 
            // buttonSocketServerOpen
            // 
            this.buttonSocketServerOpen.Location = new System.Drawing.Point(10, 362);
            this.buttonSocketServerOpen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSocketServerOpen.Name = "buttonSocketServerOpen";
            this.buttonSocketServerOpen.Size = new System.Drawing.Size(276, 46);
            this.buttonSocketServerOpen.TabIndex = 51;
            this.buttonSocketServerOpen.Text = "连接";
            this.buttonSocketServerOpen.UseVisualStyleBackColor = true;
            this.buttonSocketServerOpen.Click += new System.EventHandler(this.buttonSocketServerOpen_Click);
            // 
            // checkBoxSocketServerHexSend
            // 
            this.checkBoxSocketServerHexSend.AutoSize = true;
            this.checkBoxSocketServerHexSend.Location = new System.Drawing.Point(154, 260);
            this.checkBoxSocketServerHexSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxSocketServerHexSend.Name = "checkBoxSocketServerHexSend";
            this.checkBoxSocketServerHexSend.Size = new System.Drawing.Size(126, 28);
            this.checkBoxSocketServerHexSend.TabIndex = 50;
            this.checkBoxSocketServerHexSend.Text = "HEX发送";
            this.checkBoxSocketServerHexSend.UseVisualStyleBackColor = true;
            this.checkBoxSocketServerHexSend.CheckedChanged += new System.EventHandler(this.checkBoxSocketServerHexSend_CheckedChanged);
            // 
            // checkBoxSocketServerHexRecive
            // 
            this.checkBoxSocketServerHexRecive.AutoSize = true;
            this.checkBoxSocketServerHexRecive.Location = new System.Drawing.Point(10, 260);
            this.checkBoxSocketServerHexRecive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxSocketServerHexRecive.Name = "checkBoxSocketServerHexRecive";
            this.checkBoxSocketServerHexRecive.Size = new System.Drawing.Size(126, 28);
            this.checkBoxSocketServerHexRecive.TabIndex = 49;
            this.checkBoxSocketServerHexRecive.Text = "HEX接收";
            this.checkBoxSocketServerHexRecive.UseVisualStyleBackColor = true;
            this.checkBoxSocketServerHexRecive.CheckedChanged += new System.EventHandler(this.checkBoxSocketServerHexRecive_CheckedChanged);
            // 
            // tabPageControl
            // 
            this.tabPageControl.Controls.Add(this.buttonControl);
            this.tabPageControl.Location = new System.Drawing.Point(8, 39);
            this.tabPageControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageControl.Name = "tabPageControl";
            this.tabPageControl.Size = new System.Drawing.Size(1392, 511);
            this.tabPageControl.TabIndex = 3;
            this.tabPageControl.Text = "控制";
            this.tabPageControl.UseVisualStyleBackColor = true;
            // 
            // buttonControl
            // 
            this.buttonControl.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonControl.Location = new System.Drawing.Point(6, 6);
            this.buttonControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(402, 494);
            this.buttonControl.TabIndex = 0;
            this.buttonControl.Text = "开始";
            this.buttonControl.UseVisualStyleBackColor = true;
            this.buttonControl.Click += new System.EventHandler(this.buttonControl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 590);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCom.ResumeLayout(false);
            this.tabPageCom.PerformLayout();
            this.tabPageTCPClient.ResumeLayout(false);
            this.tabPageTCPClient.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageTCPServer.ResumeLayout(false);
            this.tabPageTCPServer.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabPageControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCom;
        private System.Windows.Forms.CheckBox checkBoxComCheck;
        private System.Windows.Forms.CheckBox checkBoxComHexSend;
        private System.Windows.Forms.CheckBox checkBoxComHexRecive;
        private System.Windows.Forms.Button buttonComClear;
        private System.Windows.Forms.Button buttonComSend;
        private System.Windows.Forms.TextBox textBoxComSend;
        private System.Windows.Forms.TextBox textBoxComRecive;
        private System.Windows.Forms.Label labelStopbits;
        private System.Windows.Forms.Button buttonComRefresh;
        private System.Windows.Forms.Button buttonComConnect;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.ComboBox comboBoxStopbits;
        private System.Windows.Forms.Label labelDatabits;
        private System.Windows.Forms.ComboBox comboBoxDatabits;
        private System.Windows.Forms.TabPage tabPageTCPClient;
        private System.Windows.Forms.TabPage tabPageTCPServer;
        private System.Windows.Forms.TabPage tabPageControl;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button buttonSocketClientSend;
        private System.Windows.Forms.TextBox textBoxSocketClientSend;
        private System.Windows.Forms.TextBox textBoxSocketClientRecive;
        private System.Windows.Forms.Button buttonSocketClientClean;
        private System.Windows.Forms.TextBox textBoxSocketClientPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonSocketClientOpen;
        private System.Windows.Forms.CheckBox checkBoxSocketClientHexSend;
        private System.Windows.Forms.CheckBox checkBoxSocketClientHexRecive;
        private System.Windows.Forms.TextBox textBoxTcpClient;
        private System.Windows.Forms.TextBox textBoxSocketClientIp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClient;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelServer;
        private System.Windows.Forms.TextBox textBoxTcpServer;
        private System.Windows.Forms.Button buttonSocketServerSend;
        private System.Windows.Forms.TextBox textBoxSocketServerSend;
        private System.Windows.Forms.TextBox textBoxSocketServerRecive;
        private System.Windows.Forms.Button buttonSocketServerClean;
        private System.Windows.Forms.TextBox textBoxSocketServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSocketServerOpen;
        private System.Windows.Forms.CheckBox checkBoxSocketServerHexSend;
        private System.Windows.Forms.CheckBox checkBoxSocketServerHexRecive;
        private System.Windows.Forms.ComboBox comboBoxSocketServerIp;
        private System.Windows.Forms.Button buttonControl;
    }
}

