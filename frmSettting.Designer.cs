namespace SPC_SUPPORT_WIP
{
    partial class frmSettting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettting));
            this.btnSaveChanged = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Label();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbMachineName = new System.Windows.Forms.ComboBox();
            this.cbbSource = new System.Windows.Forms.ComboBox();
            this.lblchecknullmodel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.cbEnableCOM = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtStationTo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStationIndex = new System.Windows.Forms.TextBox();
            this.groupBoxDataMode = new System.Windows.Forms.GroupBox();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTestSend = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBoxComSerialPortSettings = new System.Windows.Forms.GroupBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblRefreshCOMPorts = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cboCOMPort = new System.Windows.Forms.ComboBox();
            this.btnTestConnect = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.cbbNamePC = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLastNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPCP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblBrowseICTLog = new System.Windows.Forms.Label();
            this.lblInputLog = new System.Windows.Forms.Label();
            this.txtCurrentStation = new System.Windows.Forms.TextBox();
            this.cbbModel = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimesleep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlengthBarcode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBoxDataMode.SuspendLayout();
            this.groupBoxComSerialPortSettings.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveChanged
            // 
            this.btnSaveChanged.BackColor = System.Drawing.Color.Green;
            this.btnSaveChanged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanged.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanged.Location = new System.Drawing.Point(267, 315);
            this.btnSaveChanged.Name = "btnSaveChanged";
            this.btnSaveChanged.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSaveChanged.Size = new System.Drawing.Size(101, 30);
            this.btnSaveChanged.TabIndex = 39;
            this.btnSaveChanged.Text = "Save change";
            this.btnSaveChanged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanged.UseVisualStyleBackColor = false;
            this.btnSaveChanged.Click += new System.EventHandler(this.btnSaveChanged_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnBackup);
            this.groupBox2.Controls.Add(this.txtBackup);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbbMachineName);
            this.groupBox2.Controls.Add(this.cbbSource);
            this.groupBox2.Controls.Add(this.lblchecknullmodel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblNameCustomer);
            this.groupBox2.Controls.Add(this.cbEnableCOM);
            this.groupBox2.Controls.Add(this.txtStationTo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtStationIndex);
            this.groupBox2.Controls.Add(this.groupBoxDataMode);
            this.groupBox2.Controls.Add(this.groupBoxComSerialPortSettings);
            this.groupBox2.Controls.Add(this.lblname);
            this.groupBox2.Controls.Add(this.cbbNamePC);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.txtLastNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPCP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtIndex);
            this.groupBox2.Controls.Add(this.lblBrowseICTLog);
            this.groupBox2.Controls.Add(this.lblInputLog);
            this.groupBox2.Controls.Add(this.txtCurrentStation);
            this.groupBox2.Controls.Add(this.cbbModel);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtTarget);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTimesleep);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtlengthBarcode);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtLocation);
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 273);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Configs";
            // 
            // btnBackup
            // 
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.Location = new System.Drawing.Point(284, 87);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(18, 23);
            this.btnBackup.TabIndex = 108;
            this.btnBackup.Visible = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackup.Location = new System.Drawing.Point(94, 87);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(184, 21);
            this.txtBackup.TabIndex = 107;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 106;
            this.label13.Text = "Backup:";
            // 
            // cbbMachineName
            // 
            this.cbbMachineName.AllowDrop = true;
            this.cbbMachineName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMachineName.FormattingEnabled = true;
            this.cbbMachineName.Location = new System.Drawing.Point(94, 168);
            this.cbbMachineName.Name = "cbbMachineName";
            this.cbbMachineName.Size = new System.Drawing.Size(184, 23);
            this.cbbMachineName.TabIndex = 105;
            // 
            // cbbSource
            // 
            this.cbbSource.AllowDrop = true;
            this.cbbSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSource.FormattingEnabled = true;
            this.cbbSource.Location = new System.Drawing.Point(94, 28);
            this.cbbSource.Name = "cbbSource";
            this.cbbSource.Size = new System.Drawing.Size(184, 23);
            this.cbbSource.TabIndex = 104;
            // 
            // lblchecknullmodel
            // 
            this.lblchecknullmodel.AutoSize = true;
            this.lblchecknullmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblchecknullmodel.Location = new System.Drawing.Point(336, 128);
            this.lblchecknullmodel.Name = "lblchecknullmodel";
            this.lblchecknullmodel.Size = new System.Drawing.Size(0, 15);
            this.lblchecknullmodel.TabIndex = 99;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 97;
            this.label14.Text = "Machine Name:";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.Location = new System.Drawing.Point(369, 195);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(0, 15);
            this.lblNameCustomer.TabIndex = 96;
            // 
            // cbEnableCOM
            // 
            this.cbEnableCOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbEnableCOM.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbEnableCOM.Checked = true;
            this.cbEnableCOM.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbEnableCOM.ForeColor = System.Drawing.Color.White;
            this.cbEnableCOM.Location = new System.Drawing.Point(666, 260);
            this.cbEnableCOM.Name = "cbEnableCOM";
            this.cbEnableCOM.Size = new System.Drawing.Size(20, 20);
            this.cbEnableCOM.TabIndex = 74;
            this.cbEnableCOM.Visible = false;
            this.cbEnableCOM.Click += new System.EventHandler(this.cbEnableCOM_Click);
            // 
            // txtStationTo
            // 
            this.txtStationTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationTo.Location = new System.Drawing.Point(216, 140);
            this.txtStationTo.Name = "txtStationTo";
            this.txtStationTo.ReadOnly = true;
            this.txtStationTo.Size = new System.Drawing.Size(62, 21);
            this.txtStationTo.TabIndex = 73;
            this.txtStationTo.Text = "0";
            this.txtStationTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStationTo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "To:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Station Index:";
            // 
            // txtStationIndex
            // 
            this.txtStationIndex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStationIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationIndex.Location = new System.Drawing.Point(94, 141);
            this.txtStationIndex.Name = "txtStationIndex";
            this.txtStationIndex.ReadOnly = true;
            this.txtStationIndex.Size = new System.Drawing.Size(67, 21);
            this.txtStationIndex.TabIndex = 70;
            this.txtStationIndex.Text = "0";
            this.txtStationIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStationIndex_KeyPress);
            // 
            // groupBoxDataMode
            // 
            this.groupBoxDataMode.Controls.Add(this.txtStop);
            this.groupBoxDataMode.Controls.Add(this.txtRun);
            this.groupBoxDataMode.Controls.Add(this.label17);
            this.groupBoxDataMode.Controls.Add(this.btnStop);
            this.groupBoxDataMode.Controls.Add(this.btnTestSend);
            this.groupBoxDataMode.Controls.Add(this.label19);
            this.groupBoxDataMode.Enabled = false;
            this.groupBoxDataMode.Location = new System.Drawing.Point(853, 286);
            this.groupBoxDataMode.Name = "groupBoxDataMode";
            this.groupBoxDataMode.Size = new System.Drawing.Size(128, 82);
            this.groupBoxDataMode.TabIndex = 69;
            this.groupBoxDataMode.TabStop = false;
            this.groupBoxDataMode.Text = "Data Mode";
            this.groupBoxDataMode.Visible = false;
            // 
            // txtStop
            // 
            this.txtStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtStop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStop.ForeColor = System.Drawing.Color.White;
            this.txtStop.Location = new System.Drawing.Point(39, 50);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(47, 22);
            this.txtStop.TabIndex = 0;
            this.txtStop.Text = "N";
            this.txtStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRun
            // 
            this.txtRun.BackColor = System.Drawing.Color.Green;
            this.txtRun.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRun.ForeColor = System.Drawing.Color.White;
            this.txtRun.Location = new System.Drawing.Point(39, 22);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(47, 22);
            this.txtRun.TabIndex = 0;
            this.txtRun.Text = "O";
            this.txtRun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Stop:";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(91, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnStop.Size = new System.Drawing.Size(31, 24);
            this.btnStop.TabIndex = 23;
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnTestSend
            // 
            this.btnTestSend.BackColor = System.Drawing.Color.Green;
            this.btnTestSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestSend.Enabled = false;
            this.btnTestSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestSend.ForeColor = System.Drawing.Color.White;
            this.btnTestSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestSend.Location = new System.Drawing.Point(92, 20);
            this.btnTestSend.Name = "btnTestSend";
            this.btnTestSend.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnTestSend.Size = new System.Drawing.Size(30, 25);
            this.btnTestSend.TabIndex = 23;
            this.btnTestSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestSend.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Run:";
            // 
            // groupBoxComSerialPortSettings
            // 
            this.groupBoxComSerialPortSettings.Controls.Add(this.btnConfig);
            this.groupBoxComSerialPortSettings.Controls.Add(this.lblRefreshCOMPorts);
            this.groupBoxComSerialPortSettings.Controls.Add(this.label20);
            this.groupBoxComSerialPortSettings.Controls.Add(this.cboCOMPort);
            this.groupBoxComSerialPortSettings.Controls.Add(this.btnTestConnect);
            this.groupBoxComSerialPortSettings.Location = new System.Drawing.Point(663, 286);
            this.groupBoxComSerialPortSettings.Name = "groupBoxComSerialPortSettings";
            this.groupBoxComSerialPortSettings.Size = new System.Drawing.Size(185, 82);
            this.groupBoxComSerialPortSettings.TabIndex = 68;
            this.groupBoxComSerialPortSettings.TabStop = false;
            this.groupBoxComSerialPortSettings.Text = "COM Serial Port Settings";
            this.groupBoxComSerialPortSettings.Visible = false;
            // 
            // btnConfig
            // 
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(197, 17);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(26, 23);
            this.btnConfig.TabIndex = 28;
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // lblRefreshCOMPorts
            // 
            this.lblRefreshCOMPorts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefreshCOMPorts.Location = new System.Drawing.Point(177, 20);
            this.lblRefreshCOMPorts.Name = "lblRefreshCOMPorts";
            this.lblRefreshCOMPorts.Size = new System.Drawing.Size(17, 21);
            this.lblRefreshCOMPorts.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "COM PLC:";
            // 
            // cboCOMPort
            // 
            this.cboCOMPort.FormattingEnabled = true;
            this.cboCOMPort.Location = new System.Drawing.Point(66, 18);
            this.cboCOMPort.Name = "cboCOMPort";
            this.cboCOMPort.Size = new System.Drawing.Size(77, 21);
            this.cboCOMPort.TabIndex = 0;
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnTestConnect.Enabled = false;
            this.btnTestConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnect.ForeColor = System.Drawing.Color.White;
            this.btnTestConnect.Image = global::SPC_SUPPORT_WIP.Properties.Resources.refesh_16;
            this.btnTestConnect.Location = new System.Drawing.Point(149, 17);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnTestConnect.Size = new System.Drawing.Size(19, 22);
            this.btnTestConnect.TabIndex = 23;
            this.btnTestConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestConnect.UseVisualStyleBackColor = false;
            this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.ForeColor = System.Drawing.Color.Blue;
            this.lblname.Location = new System.Drawing.Point(442, 197);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 13);
            this.lblname.TabIndex = 66;
            // 
            // cbbNamePC
            // 
            this.cbbNamePC.AllowDrop = true;
            this.cbbNamePC.Enabled = false;
            this.cbbNamePC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbNamePC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNamePC.FormattingEnabled = true;
            this.cbbNamePC.Location = new System.Drawing.Point(427, 160);
            this.cbbNamePC.Name = "cbbNamePC";
            this.cbbNamePC.Size = new System.Drawing.Size(184, 23);
            this.cbbNamePC.TabIndex = 65;
            this.cbbNamePC.TextChanged += new System.EventHandler(this.cbbNamePC_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(366, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "PC Name:";
            // 
            // txtTo
            // 
            this.txtTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(549, 93);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(62, 21);
            this.txtTo.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(374, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 61;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(564, 236);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 23);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "DELETE";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gold;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(565, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(61, 23);
            this.btnLogin.TabIndex = 58;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLastNumber
            // 
            this.txtLastNumber.AutoSize = true;
            this.txtLastNumber.Location = new System.Drawing.Point(522, 97);
            this.txtLastNumber.Name = "txtLastNumber";
            this.txtLastNumber.Size = new System.Drawing.Size(23, 13);
            this.txtLastNumber.TabIndex = 56;
            this.txtLastNumber.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "PCP/Sheet:";
            // 
            // txtPCP
            // 
            this.txtPCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCP.Location = new System.Drawing.Point(426, 62);
            this.txtPCP.Name = "txtPCP";
            this.txtPCP.ReadOnly = true;
            this.txtPCP.Size = new System.Drawing.Size(68, 21);
            this.txtPCP.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Index:";
            // 
            // txtIndex
            // 
            this.txtIndex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex.Location = new System.Drawing.Point(427, 94);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.ReadOnly = true;
            this.txtIndex.Size = new System.Drawing.Size(67, 21);
            this.txtIndex.TabIndex = 42;
            // 
            // lblBrowseICTLog
            // 
            this.lblBrowseICTLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBrowseICTLog.Image = ((System.Drawing.Image)(resources.GetObject("lblBrowseICTLog.Image")));
            this.lblBrowseICTLog.Location = new System.Drawing.Point(284, 30);
            this.lblBrowseICTLog.Name = "lblBrowseICTLog";
            this.lblBrowseICTLog.Size = new System.Drawing.Size(18, 23);
            this.lblBrowseICTLog.TabIndex = 28;
            this.lblBrowseICTLog.Click += new System.EventHandler(this.lblBrowseICTLog_Click);
            // 
            // lblInputLog
            // 
            this.lblInputLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInputLog.Image = ((System.Drawing.Image)(resources.GetObject("lblInputLog.Image")));
            this.lblInputLog.Location = new System.Drawing.Point(284, 58);
            this.lblInputLog.Name = "lblInputLog";
            this.lblInputLog.Size = new System.Drawing.Size(18, 23);
            this.lblInputLog.TabIndex = 29;
            this.lblInputLog.Click += new System.EventHandler(this.lblInputLog_Click);
            // 
            // txtCurrentStation
            // 
            this.txtCurrentStation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurrentStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentStation.Location = new System.Drawing.Point(94, 114);
            this.txtCurrentStation.Name = "txtCurrentStation";
            this.txtCurrentStation.ReadOnly = true;
            this.txtCurrentStation.Size = new System.Drawing.Size(184, 21);
            this.txtCurrentStation.TabIndex = 27;
            this.txtCurrentStation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentStation_KeyPress);
            // 
            // cbbModel
            // 
            this.cbbModel.AllowDrop = true;
            this.cbbModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbModel.FormattingEnabled = true;
            this.cbbModel.Location = new System.Drawing.Point(427, 127);
            this.cbbModel.Name = "cbbModel";
            this.cbbModel.Size = new System.Drawing.Size(184, 23);
            this.cbbModel.TabIndex = 38;
            this.cbbModel.TextChanged += new System.EventHandler(this.cbbModel_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Station:";
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.Location = new System.Drawing.Point(94, 58);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(184, 21);
            this.txtTarget.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Time Sleep:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Barcode Length: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Target:";
            // 
            // txtTimesleep
            // 
            this.txtTimesleep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTimesleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimesleep.Location = new System.Drawing.Point(94, 197);
            this.txtTimesleep.Name = "txtTimesleep";
            this.txtTimesleep.ReadOnly = true;
            this.txtTimesleep.Size = new System.Drawing.Size(184, 21);
            this.txtTimesleep.TabIndex = 31;
            this.txtTimesleep.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Source:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Location:";
            // 
            // txtlengthBarcode
            // 
            this.txtlengthBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlengthBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlengthBarcode.Location = new System.Drawing.Point(427, 29);
            this.txtlengthBarcode.Name = "txtlengthBarcode";
            this.txtlengthBarcode.ReadOnly = true;
            this.txtlengthBarcode.Size = new System.Drawing.Size(184, 21);
            this.txtlengthBarcode.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Model:";
            // 
            // txtLocation
            // 
            this.txtLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(549, 62);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(62, 21);
            this.txtLocation.TabIndex = 35;
            this.txtLocation.Text = "100000";
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthongbao.ForeColor = System.Drawing.Color.Green;
            this.lblthongbao.Location = new System.Drawing.Point(380, 323);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(0, 15);
            this.lblthongbao.TabIndex = 65;
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 29);
            this.panel3.TabIndex = 70;
            this.panel3.TabStop = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Image = global::SPC_SUPPORT_WIP.Properties.Resources.icons8_settings_16;
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(30, 30);
            this.linkLabel1.TabIndex = 25;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
            this.linkLabel2.Location = new System.Drawing.Point(610, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(30, 30);
            this.linkLabel2.TabIndex = 24;
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.groupBox2;
            this.bunifuDragControl3.Vertical = true;
            // 
            // frmSettting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 352);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveChanged);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettting_FormClosing);
            this.Load += new System.EventHandler(this.frmSettting_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxDataMode.ResumeLayout(false);
            this.groupBoxDataMode.PerformLayout();
            this.groupBoxComSerialPortSettings.ResumeLayout(false);
            this.groupBoxComSerialPortSettings.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanged;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxDataMode;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTestSend;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBoxComSerialPortSettings;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblRefreshCOMPorts;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboCOMPort;
        private System.Windows.Forms.Button btnTestConnect;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cbbNamePC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label txtLastNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPCP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblBrowseICTLog;
        private System.Windows.Forms.Label lblInputLog;
        private System.Windows.Forms.TextBox txtCurrentStation;
        private System.Windows.Forms.ComboBox cbbModel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimesleep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlengthBarcode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.TextBox txtStationTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStationIndex;
        private Bunifu.Framework.UI.BunifuCheckbox cbEnableCOM;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblchecknullmodel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.ComboBox cbbSource;
        private System.Windows.Forms.ComboBox cbbMachineName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label btnBackup;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Label label13;
    }
}
