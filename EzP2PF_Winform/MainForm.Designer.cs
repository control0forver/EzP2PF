namespace EzP2PF_Winform
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp1 = new System.Windows.Forms.SplitContainer();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_ServerFilesListUpdateInterval = new System.Windows.Forms.Label();
            this.lab_ServerStatus = new System.Windows.Forms.Label();
            this.txtbox_ServerPort = new System.Windows.Forms.TextBox();
            this.lab_ServerTitle = new System.Windows.Forms.Label();
            this.lab_ServerPort = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_StartServer = new System.Windows.Forms.Button();
            this.chkbox_ServerEnableIPv6 = new System.Windows.Forms.CheckBox();
            this.txtbox_FilesRootPath = new System.Windows.Forms.TextBox();
            this.lab_ServerRootPath = new System.Windows.Forms.Label();
            this.txtbox_ServerFilesListUpdateInterval = new System.Windows.Forms.TextBox();
            this.tabcontrol_ServerManage = new System.Windows.Forms.TabControl();
            this.ServerPage_FilesList = new System.Windows.Forms.TabPage();
            this.lstbox_ServerFilesList = new System.Windows.Forms.ListBox();
            this.ServerPage_ClientsList = new System.Windows.Forms.TabPage();
            this.tlp3 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_ClientServerConnectStatus = new System.Windows.Forms.Label();
            this.lab_ClientRecvSendFiles = new System.Windows.Forms.Label();
            this.lstbox_ClientServerFilesList = new System.Windows.Forms.ListBox();
            this.txtbox_ClientServer = new System.Windows.Forms.TextBox();
            this.lab_ClientServer = new System.Windows.Forms.Label();
            this.lab_ClientTItle = new System.Windows.Forms.Label();
            this.lab_ClientFilesOnServer = new System.Windows.Forms.Label();
            this.tabcontrol_UpDownLoad = new System.Windows.Forms.TabControl();
            this.ClientPage_Upload = new System.Windows.Forms.TabPage();
            this.tlp5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.lab_UploadFilePath = new System.Windows.Forms.Label();
            this.txtbox_UploadFilePath = new System.Windows.Forms.TextBox();
            this.uploadProgressInfo = new EzP2PF_Winform.ProgressFormControl();
            this.ClientPage_Download = new System.Windows.Forms.TabPage();
            this.tlp4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Download = new System.Windows.Forms.Button();
            this.txtbox_ClientSavePath = new System.Windows.Forms.TextBox();
            this.lab_SavePath = new System.Windows.Forms.Label();
            this.downloadProgressInfo = new EzP2PF_Winform.ProgressFormControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lab_ClientServerPing = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_PingServer = new System.Windows.Forms.Button();
            this.btn_UpdateFIlesList = new System.Windows.Forms.Button();
            this.lstbox_ServerClientsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tlp1)).BeginInit();
            this.tlp1.Panel1.SuspendLayout();
            this.tlp1.Panel2.SuspendLayout();
            this.tlp1.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabcontrol_ServerManage.SuspendLayout();
            this.ServerPage_FilesList.SuspendLayout();
            this.ServerPage_ClientsList.SuspendLayout();
            this.tlp3.SuspendLayout();
            this.tabcontrol_UpDownLoad.SuspendLayout();
            this.ClientPage_Upload.SuspendLayout();
            this.tlp5.SuspendLayout();
            this.ClientPage_Download.SuspendLayout();
            this.tlp4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.BackColor = System.Drawing.SystemColors.Control;
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Margin = new System.Windows.Forms.Padding(0);
            this.tlp1.Name = "tlp1";
            // 
            // tlp1.Panel1
            // 
            this.tlp1.Panel1.Controls.Add(this.tlp2);
            // 
            // tlp1.Panel2
            // 
            this.tlp1.Panel2.Controls.Add(this.tlp3);
            this.tlp1.Size = new System.Drawing.Size(1137, 771);
            this.tlp1.SplitterDistance = 377;
            this.tlp1.TabIndex = 0;
            // 
            // tlp2
            // 
            this.tlp2.BackColor = System.Drawing.Color.Coral;
            this.tlp2.ColumnCount = 1;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Controls.Add(this.lab_ServerFilesListUpdateInterval, 0, 8);
            this.tlp2.Controls.Add(this.lab_ServerStatus, 0, 4);
            this.tlp2.Controls.Add(this.txtbox_ServerPort, 0, 2);
            this.tlp2.Controls.Add(this.lab_ServerTitle, 0, 0);
            this.tlp2.Controls.Add(this.lab_ServerPort, 0, 1);
            this.tlp2.Controls.Add(this.flowLayoutPanel2, 0, 5);
            this.tlp2.Controls.Add(this.chkbox_ServerEnableIPv6, 0, 3);
            this.tlp2.Controls.Add(this.txtbox_FilesRootPath, 0, 7);
            this.tlp2.Controls.Add(this.lab_ServerRootPath, 0, 6);
            this.tlp2.Controls.Add(this.txtbox_ServerFilesListUpdateInterval, 0, 9);
            this.tlp2.Controls.Add(this.tabcontrol_ServerManage, 0, 10);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Font = new System.Drawing.Font("Arial", 9F);
            this.tlp2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tlp2.Location = new System.Drawing.Point(0, 0);
            this.tlp2.Margin = new System.Windows.Forms.Padding(0);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 11;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp2.Size = new System.Drawing.Size(377, 771);
            this.tlp2.TabIndex = 0;
            // 
            // lab_ServerFilesListUpdateInterval
            // 
            this.lab_ServerFilesListUpdateInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_ServerFilesListUpdateInterval.AutoSize = true;
            this.lab_ServerFilesListUpdateInterval.Location = new System.Drawing.Point(173, 283);
            this.lab_ServerFilesListUpdateInterval.Name = "lab_ServerFilesListUpdateInterval";
            this.lab_ServerFilesListUpdateInterval.Size = new System.Drawing.Size(201, 15);
            this.lab_ServerFilesListUpdateInterval.TabIndex = 13;
            this.lab_ServerFilesListUpdateInterval.Text = "List of FIles - Update Interval(in ms)";
            // 
            // lab_ServerStatus
            // 
            this.lab_ServerStatus.AutoSize = true;
            this.lab_ServerStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_ServerStatus.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ServerStatus.Location = new System.Drawing.Point(3, 163);
            this.lab_ServerStatus.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lab_ServerStatus.Name = "lab_ServerStatus";
            this.lab_ServerStatus.Size = new System.Drawing.Size(213, 25);
            this.lab_ServerStatus.TabIndex = 3;
            this.lab_ServerStatus.Text = "ServerStatus: Stopped";
            // 
            // txtbox_ServerPort
            // 
            this.txtbox_ServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_ServerPort.Location = new System.Drawing.Point(299, 88);
            this.txtbox_ServerPort.MaxLength = 6;
            this.txtbox_ServerPort.Name = "txtbox_ServerPort";
            this.txtbox_ServerPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_ServerPort.Size = new System.Drawing.Size(75, 21);
            this.txtbox_ServerPort.TabIndex = 2;
            this.txtbox_ServerPort.Text = "9920";
            // 
            // lab_ServerTitle
            // 
            this.lab_ServerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_ServerTitle.AutoSize = true;
            this.lab_ServerTitle.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold);
            this.lab_ServerTitle.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lab_ServerTitle.Location = new System.Drawing.Point(3, 21);
            this.lab_ServerTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.lab_ServerTitle.Name = "lab_ServerTitle";
            this.lab_ServerTitle.Size = new System.Drawing.Size(111, 36);
            this.lab_ServerTitle.TabIndex = 0;
            this.lab_ServerTitle.Text = "Server";
            // 
            // lab_ServerPort
            // 
            this.lab_ServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_ServerPort.AutoSize = true;
            this.lab_ServerPort.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ServerPort.ForeColor = System.Drawing.SystemColors.Info;
            this.lab_ServerPort.Location = new System.Drawing.Point(338, 65);
            this.lab_ServerPort.Name = "lab_ServerPort";
            this.lab_ServerPort.Size = new System.Drawing.Size(36, 16);
            this.lab_ServerPort.TabIndex = 0;
            this.lab_ServerPort.Text = "Port";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_StartServer);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 195);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(377, 35);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btn_StartServer
            // 
            this.btn_StartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartServer.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btn_StartServer.Location = new System.Drawing.Point(3, 3);
            this.btn_StartServer.Name = "btn_StartServer";
            this.btn_StartServer.Size = new System.Drawing.Size(85, 26);
            this.btn_StartServer.TabIndex = 1;
            this.btn_StartServer.Text = "Start";
            this.btn_StartServer.UseVisualStyleBackColor = true;
            this.btn_StartServer.Click += new System.EventHandler(this.btn_StartServer_Click);
            // 
            // chkbox_ServerEnableIPv6
            // 
            this.chkbox_ServerEnableIPv6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkbox_ServerEnableIPv6.AutoSize = true;
            this.chkbox_ServerEnableIPv6.Location = new System.Drawing.Point(143, 121);
            this.chkbox_ServerEnableIPv6.Name = "chkbox_ServerEnableIPv6";
            this.chkbox_ServerEnableIPv6.Size = new System.Drawing.Size(91, 19);
            this.chkbox_ServerEnableIPv6.TabIndex = 6;
            this.chkbox_ServerEnableIPv6.Text = "Enable IPv6";
            this.chkbox_ServerEnableIPv6.UseVisualStyleBackColor = true;
            // 
            // txtbox_FilesRootPath
            // 
            this.txtbox_FilesRootPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_FilesRootPath.Location = new System.Drawing.Point(3, 253);
            this.txtbox_FilesRootPath.Name = "txtbox_FilesRootPath";
            this.txtbox_FilesRootPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_FilesRootPath.Size = new System.Drawing.Size(371, 21);
            this.txtbox_FilesRootPath.TabIndex = 7;
            this.txtbox_FilesRootPath.Text = "./";
            // 
            // lab_ServerRootPath
            // 
            this.lab_ServerRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_ServerRootPath.AutoSize = true;
            this.lab_ServerRootPath.Location = new System.Drawing.Point(313, 230);
            this.lab_ServerRootPath.Name = "lab_ServerRootPath";
            this.lab_ServerRootPath.Size = new System.Drawing.Size(61, 15);
            this.lab_ServerRootPath.TabIndex = 8;
            this.lab_ServerRootPath.Text = "Root Path";
            // 
            // txtbox_ServerFilesListUpdateInterval
            // 
            this.txtbox_ServerFilesListUpdateInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_ServerFilesListUpdateInterval.Location = new System.Drawing.Point(3, 306);
            this.txtbox_ServerFilesListUpdateInterval.Name = "txtbox_ServerFilesListUpdateInterval";
            this.txtbox_ServerFilesListUpdateInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_ServerFilesListUpdateInterval.Size = new System.Drawing.Size(371, 21);
            this.txtbox_ServerFilesListUpdateInterval.TabIndex = 14;
            this.txtbox_ServerFilesListUpdateInterval.Text = "1500";
            // 
            // tabcontrol_ServerManage
            // 
            this.tabcontrol_ServerManage.Controls.Add(this.ServerPage_FilesList);
            this.tabcontrol_ServerManage.Controls.Add(this.ServerPage_ClientsList);
            this.tabcontrol_ServerManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol_ServerManage.Location = new System.Drawing.Point(3, 339);
            this.tabcontrol_ServerManage.Name = "tabcontrol_ServerManage";
            this.tabcontrol_ServerManage.SelectedIndex = 0;
            this.tabcontrol_ServerManage.Size = new System.Drawing.Size(371, 429);
            this.tabcontrol_ServerManage.TabIndex = 15;
            // 
            // ServerPage_FilesList
            // 
            this.ServerPage_FilesList.Controls.Add(this.lstbox_ServerFilesList);
            this.ServerPage_FilesList.Location = new System.Drawing.Point(4, 24);
            this.ServerPage_FilesList.Name = "ServerPage_FilesList";
            this.ServerPage_FilesList.Padding = new System.Windows.Forms.Padding(3);
            this.ServerPage_FilesList.Size = new System.Drawing.Size(363, 401);
            this.ServerPage_FilesList.TabIndex = 0;
            this.ServerPage_FilesList.Text = "Files";
            this.ServerPage_FilesList.UseVisualStyleBackColor = true;
            // 
            // lstbox_ServerFilesList
            // 
            this.lstbox_ServerFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbox_ServerFilesList.Font = new System.Drawing.Font("Arial", 9F);
            this.lstbox_ServerFilesList.FormattingEnabled = true;
            this.lstbox_ServerFilesList.ItemHeight = 15;
            this.lstbox_ServerFilesList.Location = new System.Drawing.Point(3, 3);
            this.lstbox_ServerFilesList.Name = "lstbox_ServerFilesList";
            this.lstbox_ServerFilesList.Size = new System.Drawing.Size(357, 395);
            this.lstbox_ServerFilesList.TabIndex = 4;
            // 
            // ServerPage_ClientsList
            // 
            this.ServerPage_ClientsList.Controls.Add(this.lstbox_ServerClientsList);
            this.ServerPage_ClientsList.Location = new System.Drawing.Point(4, 24);
            this.ServerPage_ClientsList.Name = "ServerPage_ClientsList";
            this.ServerPage_ClientsList.Padding = new System.Windows.Forms.Padding(3);
            this.ServerPage_ClientsList.Size = new System.Drawing.Size(363, 401);
            this.ServerPage_ClientsList.TabIndex = 1;
            this.ServerPage_ClientsList.Text = "Clients";
            this.ServerPage_ClientsList.UseVisualStyleBackColor = true;
            // 
            // tlp3
            // 
            this.tlp3.BackColor = System.Drawing.Color.Gray;
            this.tlp3.ColumnCount = 1;
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp3.Controls.Add(this.lab_ClientServerConnectStatus, 0, 3);
            this.tlp3.Controls.Add(this.lab_ClientRecvSendFiles, 0, 8);
            this.tlp3.Controls.Add(this.lstbox_ClientServerFilesList, 0, 7);
            this.tlp3.Controls.Add(this.txtbox_ClientServer, 0, 2);
            this.tlp3.Controls.Add(this.lab_ClientServer, 0, 1);
            this.tlp3.Controls.Add(this.lab_ClientTItle, 0, 0);
            this.tlp3.Controls.Add(this.lab_ClientFilesOnServer, 0, 6);
            this.tlp3.Controls.Add(this.tabcontrol_UpDownLoad, 0, 9);
            this.tlp3.Controls.Add(this.flowLayoutPanel1, 0, 5);
            this.tlp3.Controls.Add(this.lab_ClientServerPing, 0, 4);
            this.tlp3.Controls.Add(this.flowLayoutPanel3, 0, 10);
            this.tlp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp3.Font = new System.Drawing.Font("Arial", 10.5F);
            this.tlp3.ForeColor = System.Drawing.Color.Gainsboro;
            this.tlp3.Location = new System.Drawing.Point(0, 0);
            this.tlp3.Margin = new System.Windows.Forms.Padding(0);
            this.tlp3.Name = "tlp3";
            this.tlp3.RowCount = 11;
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp3.Size = new System.Drawing.Size(756, 771);
            this.tlp3.TabIndex = 1;
            // 
            // lab_ClientServerConnectStatus
            // 
            this.lab_ClientServerConnectStatus.AutoSize = true;
            this.lab_ClientServerConnectStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_ClientServerConnectStatus.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ClientServerConnectStatus.Location = new System.Drawing.Point(3, 118);
            this.lab_ClientServerConnectStatus.Name = "lab_ClientServerConnectStatus";
            this.lab_ClientServerConnectStatus.Size = new System.Drawing.Size(247, 18);
            this.lab_ClientServerConnectStatus.TabIndex = 10;
            this.lab_ClientServerConnectStatus.Text = "Server Connection: Disconnected";
            // 
            // lab_ClientRecvSendFiles
            // 
            this.lab_ClientRecvSendFiles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_ClientRecvSendFiles.AutoSize = true;
            this.lab_ClientRecvSendFiles.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ClientRecvSendFiles.Location = new System.Drawing.Point(317, 467);
            this.lab_ClientRecvSendFiles.Name = "lab_ClientRecvSendFiles";
            this.lab_ClientRecvSendFiles.Size = new System.Drawing.Size(121, 16);
            this.lab_ClientRecvSendFiles.TabIndex = 8;
            this.lab_ClientRecvSendFiles.Text = "Send/Recv Files";
            // 
            // lstbox_ClientServerFilesList
            // 
            this.lstbox_ClientServerFilesList.AllowDrop = true;
            this.lstbox_ClientServerFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbox_ClientServerFilesList.FormattingEnabled = true;
            this.lstbox_ClientServerFilesList.ItemHeight = 16;
            this.lstbox_ClientServerFilesList.Location = new System.Drawing.Point(3, 214);
            this.lstbox_ClientServerFilesList.Name = "lstbox_ClientServerFilesList";
            this.lstbox_ClientServerFilesList.ScrollAlwaysVisible = true;
            this.lstbox_ClientServerFilesList.Size = new System.Drawing.Size(750, 246);
            this.lstbox_ClientServerFilesList.TabIndex = 6;
            this.lstbox_ClientServerFilesList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstbox_ClientServerFilesList_DragDrop);
            this.lstbox_ClientServerFilesList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstbox_ClientServerFilesList_DragEnter);
            this.lstbox_ClientServerFilesList.DoubleClick += new System.EventHandler(this.lstbox_ClientServerFilesList_DoubleClick);
            // 
            // txtbox_ClientServer
            // 
            this.txtbox_ClientServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_ClientServer.Location = new System.Drawing.Point(3, 88);
            this.txtbox_ClientServer.Name = "txtbox_ClientServer";
            this.txtbox_ClientServer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_ClientServer.Size = new System.Drawing.Size(750, 24);
            this.txtbox_ClientServer.TabIndex = 3;
            this.txtbox_ClientServer.Text = "127.0.0.1:9920";
            // 
            // lab_ClientServer
            // 
            this.lab_ClientServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_ClientServer.AutoSize = true;
            this.lab_ClientServer.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ClientServer.Location = new System.Drawing.Point(698, 65);
            this.lab_ClientServer.Name = "lab_ClientServer";
            this.lab_ClientServer.Size = new System.Drawing.Size(55, 16);
            this.lab_ClientServer.TabIndex = 2;
            this.lab_ClientServer.Text = "Server";
            // 
            // lab_ClientTItle
            // 
            this.lab_ClientTItle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_ClientTItle.AutoSize = true;
            this.lab_ClientTItle.Font = new System.Drawing.Font("Arial", 23F);
            this.lab_ClientTItle.ForeColor = System.Drawing.Color.SkyBlue;
            this.lab_ClientTItle.Location = new System.Drawing.Point(3, 22);
            this.lab_ClientTItle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.lab_ClientTItle.Name = "lab_ClientTItle";
            this.lab_ClientTItle.Size = new System.Drawing.Size(93, 35);
            this.lab_ClientTItle.TabIndex = 1;
            this.lab_ClientTItle.Text = "Client";
            // 
            // lab_ClientFilesOnServer
            // 
            this.lab_ClientFilesOnServer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_ClientFilesOnServer.AutoSize = true;
            this.lab_ClientFilesOnServer.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ClientFilesOnServer.Location = new System.Drawing.Point(319, 195);
            this.lab_ClientFilesOnServer.Name = "lab_ClientFilesOnServer";
            this.lab_ClientFilesOnServer.Size = new System.Drawing.Size(117, 16);
            this.lab_ClientFilesOnServer.TabIndex = 7;
            this.lab_ClientFilesOnServer.Text = "Files On Server";
            // 
            // tabcontrol_UpDownLoad
            // 
            this.tabcontrol_UpDownLoad.Controls.Add(this.ClientPage_Upload);
            this.tabcontrol_UpDownLoad.Controls.Add(this.ClientPage_Download);
            this.tabcontrol_UpDownLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol_UpDownLoad.Location = new System.Drawing.Point(3, 486);
            this.tabcontrol_UpDownLoad.Name = "tabcontrol_UpDownLoad";
            this.tabcontrol_UpDownLoad.SelectedIndex = 0;
            this.tabcontrol_UpDownLoad.Size = new System.Drawing.Size(750, 246);
            this.tabcontrol_UpDownLoad.TabIndex = 9;
            // 
            // ClientPage_Upload
            // 
            this.ClientPage_Upload.BackColor = System.Drawing.Color.Gray;
            this.ClientPage_Upload.Controls.Add(this.tlp5);
            this.ClientPage_Upload.Location = new System.Drawing.Point(4, 25);
            this.ClientPage_Upload.Name = "ClientPage_Upload";
            this.ClientPage_Upload.Padding = new System.Windows.Forms.Padding(3);
            this.ClientPage_Upload.Size = new System.Drawing.Size(742, 217);
            this.ClientPage_Upload.TabIndex = 0;
            this.ClientPage_Upload.Text = "Upload";
            // 
            // tlp5
            // 
            this.tlp5.ColumnCount = 1;
            this.tlp5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp5.Controls.Add(this.btn_Upload, 0, 2);
            this.tlp5.Controls.Add(this.lab_UploadFilePath, 0, 0);
            this.tlp5.Controls.Add(this.txtbox_UploadFilePath, 0, 1);
            this.tlp5.Controls.Add(this.uploadProgressInfo, 0, 3);
            this.tlp5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp5.Location = new System.Drawing.Point(3, 3);
            this.tlp5.Margin = new System.Windows.Forms.Padding(0);
            this.tlp5.Name = "tlp5";
            this.tlp5.RowCount = 4;
            this.tlp5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp5.Size = new System.Drawing.Size(736, 211);
            this.tlp5.TabIndex = 0;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upload.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btn_Upload.Location = new System.Drawing.Point(648, 56);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(85, 26);
            this.btn_Upload.TabIndex = 8;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // lab_UploadFilePath
            // 
            this.lab_UploadFilePath.AutoSize = true;
            this.lab_UploadFilePath.Location = new System.Drawing.Point(3, 0);
            this.lab_UploadFilePath.Name = "lab_UploadFilePath";
            this.lab_UploadFilePath.Size = new System.Drawing.Size(63, 16);
            this.lab_UploadFilePath.TabIndex = 9;
            this.lab_UploadFilePath.Text = "File Path";
            // 
            // txtbox_UploadFilePath
            // 
            this.txtbox_UploadFilePath.AllowDrop = true;
            this.txtbox_UploadFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_UploadFilePath.Location = new System.Drawing.Point(3, 23);
            this.txtbox_UploadFilePath.Name = "txtbox_UploadFilePath";
            this.txtbox_UploadFilePath.Size = new System.Drawing.Size(730, 24);
            this.txtbox_UploadFilePath.TabIndex = 10;
            this.txtbox_UploadFilePath.Text = "C:\\";
            // 
            // uploadProgressInfo
            // 
            this.uploadProgressInfo.BackColor = System.Drawing.Color.DimGray;
            this.uploadProgressInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadProgressInfo.Location = new System.Drawing.Point(0, 86);
            this.uploadProgressInfo.Margin = new System.Windows.Forms.Padding(0);
            this.uploadProgressInfo.Name = "uploadProgressInfo";
            this.uploadProgressInfo.ObjectName = "name";
            this.uploadProgressInfo.ObjectProgress = 0;
            this.uploadProgressInfo.ObjectSize = ((uint)(0u));
            this.uploadProgressInfo.ObjectSizeUnit = "KB";
            this.uploadProgressInfo.ObjectSpeed = 0;
            this.uploadProgressInfo.ObjectSpeedUnit = "KB/s";
            this.uploadProgressInfo.ObjectTime = "0";
            this.uploadProgressInfo.Size = new System.Drawing.Size(736, 125);
            this.uploadProgressInfo.TabIndex = 11;
            // 
            // ClientPage_Download
            // 
            this.ClientPage_Download.BackColor = System.Drawing.Color.Gray;
            this.ClientPage_Download.Controls.Add(this.tlp4);
            this.ClientPage_Download.Location = new System.Drawing.Point(4, 25);
            this.ClientPage_Download.Name = "ClientPage_Download";
            this.ClientPage_Download.Padding = new System.Windows.Forms.Padding(3);
            this.ClientPage_Download.Size = new System.Drawing.Size(742, 217);
            this.ClientPage_Download.TabIndex = 1;
            this.ClientPage_Download.Text = "Download";
            // 
            // tlp4
            // 
            this.tlp4.ColumnCount = 1;
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp4.Controls.Add(this.btn_Download, 0, 2);
            this.tlp4.Controls.Add(this.txtbox_ClientSavePath, 0, 1);
            this.tlp4.Controls.Add(this.lab_SavePath, 0, 0);
            this.tlp4.Controls.Add(this.downloadProgressInfo, 0, 3);
            this.tlp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp4.Location = new System.Drawing.Point(3, 3);
            this.tlp4.Margin = new System.Windows.Forms.Padding(0);
            this.tlp4.Name = "tlp4";
            this.tlp4.RowCount = 4;
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp4.Size = new System.Drawing.Size(736, 211);
            this.tlp4.TabIndex = 1;
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Download.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btn_Download.Location = new System.Drawing.Point(648, 56);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(85, 26);
            this.btn_Download.TabIndex = 7;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // txtbox_ClientSavePath
            // 
            this.txtbox_ClientSavePath.AllowDrop = true;
            this.txtbox_ClientSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_ClientSavePath.Location = new System.Drawing.Point(3, 23);
            this.txtbox_ClientSavePath.Name = "txtbox_ClientSavePath";
            this.txtbox_ClientSavePath.Size = new System.Drawing.Size(730, 24);
            this.txtbox_ClientSavePath.TabIndex = 0;
            this.txtbox_ClientSavePath.Text = "C:\\";
            this.txtbox_ClientSavePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbox_ClientSavePath_DragDrop);
            this.txtbox_ClientSavePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbox_ClientSavePath_DragEnter);
            // 
            // lab_SavePath
            // 
            this.lab_SavePath.AutoSize = true;
            this.lab_SavePath.Location = new System.Drawing.Point(3, 0);
            this.lab_SavePath.Name = "lab_SavePath";
            this.lab_SavePath.Size = new System.Drawing.Size(72, 16);
            this.lab_SavePath.TabIndex = 1;
            this.lab_SavePath.Text = "Save Path";
            // 
            // downloadProgressInfo
            // 
            this.downloadProgressInfo.BackColor = System.Drawing.Color.DimGray;
            this.downloadProgressInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadProgressInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.downloadProgressInfo.Location = new System.Drawing.Point(0, 86);
            this.downloadProgressInfo.Margin = new System.Windows.Forms.Padding(0);
            this.downloadProgressInfo.Name = "downloadProgressInfo";
            this.downloadProgressInfo.ObjectName = "";
            this.downloadProgressInfo.ObjectProgress = 0;
            this.downloadProgressInfo.ObjectSize = ((uint)(0u));
            this.downloadProgressInfo.ObjectSizeUnit = "KB";
            this.downloadProgressInfo.ObjectSpeed = 0;
            this.downloadProgressInfo.ObjectSpeedUnit = "KB/s";
            this.downloadProgressInfo.ObjectTime = "0";
            this.downloadProgressInfo.Size = new System.Drawing.Size(736, 125);
            this.downloadProgressInfo.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Connect);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 158);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(756, 33);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btn_Connect
            // 
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btn_Connect.Location = new System.Drawing.Point(3, 3);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(93, 26);
            this.btn_Connect.TabIndex = 6;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lab_ClientServerPing
            // 
            this.lab_ClientServerPing.AutoSize = true;
            this.lab_ClientServerPing.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ClientServerPing.Location = new System.Drawing.Point(3, 138);
            this.lab_ClientServerPing.Name = "lab_ClientServerPing";
            this.lab_ClientServerPing.Size = new System.Drawing.Size(79, 16);
            this.lab_ClientServerPing.TabIndex = 12;
            this.lab_ClientServerPing.Text = "Ping: -1ms";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btn_PingServer);
            this.flowLayoutPanel3.Controls.Add(this.btn_UpdateFIlesList);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 738);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(750, 30);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // btn_PingServer
            // 
            this.btn_PingServer.Enabled = false;
            this.btn_PingServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PingServer.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btn_PingServer.Location = new System.Drawing.Point(3, 3);
            this.btn_PingServer.Name = "btn_PingServer";
            this.btn_PingServer.Size = new System.Drawing.Size(85, 26);
            this.btn_PingServer.TabIndex = 2;
            this.btn_PingServer.Text = "Ping";
            this.btn_PingServer.UseVisualStyleBackColor = true;
            this.btn_PingServer.Visible = false;
            this.btn_PingServer.Click += new System.EventHandler(this.btn_PingServer_Click);
            // 
            // btn_UpdateFIlesList
            // 
            this.btn_UpdateFIlesList.Enabled = false;
            this.btn_UpdateFIlesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateFIlesList.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btn_UpdateFIlesList.Location = new System.Drawing.Point(94, 3);
            this.btn_UpdateFIlesList.Name = "btn_UpdateFIlesList";
            this.btn_UpdateFIlesList.Size = new System.Drawing.Size(145, 26);
            this.btn_UpdateFIlesList.TabIndex = 3;
            this.btn_UpdateFIlesList.Text = "Update FilesList";
            this.btn_UpdateFIlesList.UseVisualStyleBackColor = true;
            this.btn_UpdateFIlesList.Visible = false;
            this.btn_UpdateFIlesList.Click += new System.EventHandler(this.btn_UpdateFIlesList_Click);
            // 
            // lstbox_ServerClientsList
            // 
            this.lstbox_ServerClientsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbox_ServerClientsList.FormattingEnabled = true;
            this.lstbox_ServerClientsList.ItemHeight = 15;
            this.lstbox_ServerClientsList.Location = new System.Drawing.Point(3, 3);
            this.lstbox_ServerClientsList.Name = "lstbox_ServerClientsList";
            this.lstbox_ServerClientsList.Size = new System.Drawing.Size(357, 395);
            this.lstbox_ServerClientsList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 771);
            this.Controls.Add(this.tlp1);
            this.Name = "MainForm";
            this.Text = "EzP2PF - Winform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlp1.Panel1.ResumeLayout(false);
            this.tlp1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlp1)).EndInit();
            this.tlp1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.tlp2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabcontrol_ServerManage.ResumeLayout(false);
            this.ServerPage_FilesList.ResumeLayout(false);
            this.ServerPage_ClientsList.ResumeLayout(false);
            this.tlp3.ResumeLayout(false);
            this.tlp3.PerformLayout();
            this.tabcontrol_UpDownLoad.ResumeLayout(false);
            this.ClientPage_Upload.ResumeLayout(false);
            this.tlp5.ResumeLayout(false);
            this.tlp5.PerformLayout();
            this.ClientPage_Download.ResumeLayout(false);
            this.tlp4.ResumeLayout(false);
            this.tlp4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer tlp1;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Label lab_ServerTitle;
        private System.Windows.Forms.Label lab_ServerPort;
        private System.Windows.Forms.TextBox txtbox_ServerPort;
        private System.Windows.Forms.Button btn_StartServer;
        private System.Windows.Forms.Label lab_ServerStatus;
        private System.Windows.Forms.ListBox lstbox_ServerFilesList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tlp3;
        private System.Windows.Forms.Label lab_ClientServerConnectStatus;
        private System.Windows.Forms.Label lab_ClientRecvSendFiles;
        private System.Windows.Forms.ListBox lstbox_ClientServerFilesList;
        private System.Windows.Forms.TextBox txtbox_ClientServer;
        private System.Windows.Forms.Label lab_ClientServer;
        private System.Windows.Forms.Label lab_ClientTItle;
        private System.Windows.Forms.Label lab_ClientFilesOnServer;
        private System.Windows.Forms.TabControl tabcontrol_UpDownLoad;
        private System.Windows.Forms.TabPage ClientPage_Upload;
        private System.Windows.Forms.TabPage ClientPage_Download;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TableLayoutPanel tlp4;
        private System.Windows.Forms.TextBox txtbox_ClientSavePath;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Label lab_SavePath;
        private System.Windows.Forms.TableLayoutPanel tlp5;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Label lab_UploadFilePath;
        private System.Windows.Forms.TextBox txtbox_UploadFilePath;
        private System.Windows.Forms.CheckBox chkbox_ServerEnableIPv6;
        private System.Windows.Forms.Label lab_ClientServerPing;
        private System.Windows.Forms.TextBox txtbox_FilesRootPath;
        private System.Windows.Forms.Label lab_ServerRootPath;
        private System.Windows.Forms.Label lab_ServerFilesListUpdateInterval;
        private System.Windows.Forms.TextBox txtbox_ServerFilesListUpdateInterval;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btn_PingServer;
        private System.Windows.Forms.Button btn_UpdateFIlesList;
        private ProgressFormControl uploadProgressInfo;
        private ProgressFormControl downloadProgressInfo;
        private System.Windows.Forms.TabControl tabcontrol_ServerManage;
        private System.Windows.Forms.TabPage ServerPage_FilesList;
        private System.Windows.Forms.TabPage ServerPage_ClientsList;
        private System.Windows.Forms.ListBox lstbox_ServerClientsList;
    }
}

