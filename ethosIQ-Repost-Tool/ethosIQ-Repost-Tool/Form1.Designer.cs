namespace ethosIQ_Repost_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generateReportGroupBox = new System.Windows.Forms.GroupBox();
            this.repostProgressBar = new System.Windows.Forms.ProgressBar();
            this.multiMediaCheckBox = new System.Windows.Forms.CheckBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.thirtyMinuteRadioButton = new System.Windows.Forms.RadioButton();
            this.fifteenRadioButton = new System.Windows.Forms.RadioButton();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.repostButton = new System.Windows.Forms.Button();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.collectionDatabaseGroupBox = new System.Windows.Forms.GroupBox();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.checkDatabaseConnectionButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.databaseTypeTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.dataSourceLabel = new System.Windows.Forms.Label();
            this.databaseTypeLabel = new System.Windows.Forms.Label();
            this.remoteFTPConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.checkFTPConnectionButton = new System.Windows.Forms.Button();
            this.ftpDataGridView = new System.Windows.Forms.DataGridView();
            this.loadConfigurationWorker = new System.ComponentModel.BackgroundWorker();
            this.checkFTPConnectionWorker = new System.ComponentModel.BackgroundWorker();
            this.checkCollectionDatabaseConnectionWorker = new System.ComponentModel.BackgroundWorker();
            this.repostWorker = new System.ComponentModel.BackgroundWorker();
            this.DestinationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTPType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateReportGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.collectionDatabaseGroupBox.SuspendLayout();
            this.remoteFTPConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftpDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // generateReportGroupBox
            // 
            this.generateReportGroupBox.Controls.Add(this.repostProgressBar);
            this.generateReportGroupBox.Controls.Add(this.multiMediaCheckBox);
            this.generateReportGroupBox.Controls.Add(this.stopButton);
            this.generateReportGroupBox.Controls.Add(this.thirtyMinuteRadioButton);
            this.generateReportGroupBox.Controls.Add(this.fifteenRadioButton);
            this.generateReportGroupBox.Controls.Add(this.intervalLabel);
            this.generateReportGroupBox.Controls.Add(this.repostButton);
            this.generateReportGroupBox.Controls.Add(this.toDatePicker);
            this.generateReportGroupBox.Controls.Add(this.fromDatePicker);
            this.generateReportGroupBox.Controls.Add(this.fromLabel);
            this.generateReportGroupBox.Controls.Add(this.toLabel);
            this.generateReportGroupBox.Location = new System.Drawing.Point(12, 424);
            this.generateReportGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.generateReportGroupBox.Name = "generateReportGroupBox";
            this.generateReportGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.generateReportGroupBox.Size = new System.Drawing.Size(499, 159);
            this.generateReportGroupBox.TabIndex = 0;
            this.generateReportGroupBox.TabStop = false;
            this.generateReportGroupBox.Text = "Generate Report";
            this.generateReportGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // repostProgressBar
            // 
            this.repostProgressBar.Location = new System.Drawing.Point(7, 129);
            this.repostProgressBar.Name = "repostProgressBar";
            this.repostProgressBar.Size = new System.Drawing.Size(487, 23);
            this.repostProgressBar.Step = 1;
            this.repostProgressBar.TabIndex = 10;
            // 
            // multiMediaCheckBox
            // 
            this.multiMediaCheckBox.AutoSize = true;
            this.multiMediaCheckBox.Location = new System.Drawing.Point(197, 69);
            this.multiMediaCheckBox.Name = "multiMediaCheckBox";
            this.multiMediaCheckBox.Size = new System.Drawing.Size(92, 20);
            this.multiMediaCheckBox.TabIndex = 9;
            this.multiMediaCheckBox.Text = "Multimedia";
            this.multiMediaCheckBox.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(345, 98);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(132, 23);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // thirtyMinuteRadioButton
            // 
            this.thirtyMinuteRadioButton.AutoSize = true;
            this.thirtyMinuteRadioButton.Location = new System.Drawing.Point(71, 98);
            this.thirtyMinuteRadioButton.Name = "thirtyMinuteRadioButton";
            this.thirtyMinuteRadioButton.Size = new System.Drawing.Size(89, 20);
            this.thirtyMinuteRadioButton.TabIndex = 7;
            this.thirtyMinuteRadioButton.TabStop = true;
            this.thirtyMinuteRadioButton.Text = "30 Minutes";
            this.thirtyMinuteRadioButton.UseVisualStyleBackColor = true;
            // 
            // fifteenRadioButton
            // 
            this.fifteenRadioButton.AutoSize = true;
            this.fifteenRadioButton.Location = new System.Drawing.Point(71, 70);
            this.fifteenRadioButton.Name = "fifteenRadioButton";
            this.fifteenRadioButton.Size = new System.Drawing.Size(89, 20);
            this.fifteenRadioButton.TabIndex = 6;
            this.fifteenRadioButton.TabStop = true;
            this.fifteenRadioButton.Text = "15 Minutes";
            this.fifteenRadioButton.UseVisualStyleBackColor = true;
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(8, 74);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(57, 16);
            this.intervalLabel.TabIndex = 5;
            this.intervalLabel.Text = "Interval: ";
            // 
            // repostButton
            // 
            this.repostButton.Location = new System.Drawing.Point(345, 69);
            this.repostButton.Name = "repostButton";
            this.repostButton.Size = new System.Drawing.Size(132, 23);
            this.repostButton.TabIndex = 4;
            this.repostButton.Text = "Repost";
            this.repostButton.UseVisualStyleBackColor = true;
            this.repostButton.Click += new System.EventHandler(this.repostButton_Click);
            // 
            // toDatePicker
            // 
            this.toDatePicker.CustomFormat = "MM/dd/yyyy  hh:mm:ss  tt";
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDatePicker.Location = new System.Drawing.Point(295, 32);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(182, 22);
            this.toDatePicker.TabIndex = 3;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "MM/dd/yyyy  hh:mm:ss  tt";
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(58, 32);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(182, 22);
            this.fromDatePicker.TabIndex = 2;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(7, 37);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(45, 16);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "From: ";
            this.fromLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(261, 37);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(28, 16);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "To:";
            this.toLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ethosIQ_Repost_Tool.Properties.Resources.ethosIQ;
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // collectionDatabaseGroupBox
            // 
            this.collectionDatabaseGroupBox.Controls.Add(this.connectedLabel);
            this.collectionDatabaseGroupBox.Controls.Add(this.checkDatabaseConnectionButton);
            this.collectionDatabaseGroupBox.Controls.Add(this.statusLabel);
            this.collectionDatabaseGroupBox.Controls.Add(this.passwordTextBox);
            this.collectionDatabaseGroupBox.Controls.Add(this.usernameTextBox);
            this.collectionDatabaseGroupBox.Controls.Add(this.passwordLabel);
            this.collectionDatabaseGroupBox.Controls.Add(this.usernameLabel);
            this.collectionDatabaseGroupBox.Controls.Add(this.portTextBox);
            this.collectionDatabaseGroupBox.Controls.Add(this.hostTextBox);
            this.collectionDatabaseGroupBox.Controls.Add(this.dataSourceTextBox);
            this.collectionDatabaseGroupBox.Controls.Add(this.databaseTypeTextBox);
            this.collectionDatabaseGroupBox.Controls.Add(this.portLabel);
            this.collectionDatabaseGroupBox.Controls.Add(this.hostLabel);
            this.collectionDatabaseGroupBox.Controls.Add(this.dataSourceLabel);
            this.collectionDatabaseGroupBox.Controls.Add(this.databaseTypeLabel);
            this.collectionDatabaseGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionDatabaseGroupBox.Location = new System.Drawing.Point(13, 93);
            this.collectionDatabaseGroupBox.Name = "collectionDatabaseGroupBox";
            this.collectionDatabaseGroupBox.Size = new System.Drawing.Size(499, 140);
            this.collectionDatabaseGroupBox.TabIndex = 2;
            this.collectionDatabaseGroupBox.TabStop = false;
            this.collectionDatabaseGroupBox.Text = "Collection Database";
            this.collectionDatabaseGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(344, 80);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(91, 16);
            this.connectedLabel.TabIndex = 14;
            this.connectedLabel.Text = "Disconnected";
            // 
            // checkDatabaseConnectionButton
            // 
            this.checkDatabaseConnectionButton.Location = new System.Drawing.Point(344, 108);
            this.checkDatabaseConnectionButton.Name = "checkDatabaseConnectionButton";
            this.checkDatabaseConnectionButton.Size = new System.Drawing.Size(132, 23);
            this.checkDatabaseConnectionButton.TabIndex = 13;
            this.checkDatabaseConnectionButton.Text = "Check Connection";
            this.checkDatabaseConnectionButton.UseVisualStyleBackColor = true;
            this.checkDatabaseConnectionButton.Click += new System.EventHandler(this.checkDatabaseConnectionButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(287, 80);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 16);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Status: ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(344, 48);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(149, 22);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(344, 19);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(149, 22);
            this.usernameTextBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(264, 51);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 16);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(261, 23);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 16);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username: ";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(125, 108);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(121, 22);
            this.portTextBox.TabIndex = 7;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(125, 77);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(121, 22);
            this.hostTextBox.TabIndex = 6;
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.Location = new System.Drawing.Point(125, 48);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(121, 22);
            this.dataSourceTextBox.TabIndex = 5;
            // 
            // databaseTypeTextBox
            // 
            this.databaseTypeTextBox.Location = new System.Drawing.Point(125, 19);
            this.databaseTypeTextBox.Name = "databaseTypeTextBox";
            this.databaseTypeTextBox.Size = new System.Drawing.Size(121, 22);
            this.databaseTypeTextBox.TabIndex = 4;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(81, 111);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(38, 16);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port: ";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(77, 80);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(42, 16);
            this.hostLabel.TabIndex = 2;
            this.hostLabel.Text = "Host: ";
            // 
            // dataSourceLabel
            // 
            this.dataSourceLabel.AutoSize = true;
            this.dataSourceLabel.Location = new System.Drawing.Point(30, 51);
            this.dataSourceLabel.Name = "dataSourceLabel";
            this.dataSourceLabel.Size = new System.Drawing.Size(89, 16);
            this.dataSourceLabel.TabIndex = 1;
            this.dataSourceLabel.Text = "Data Source: ";
            this.dataSourceLabel.Click += new System.EventHandler(this.dataSourceLabel_Click);
            // 
            // databaseTypeLabel
            // 
            this.databaseTypeLabel.AutoSize = true;
            this.databaseTypeLabel.Location = new System.Drawing.Point(10, 22);
            this.databaseTypeLabel.Name = "databaseTypeLabel";
            this.databaseTypeLabel.Size = new System.Drawing.Size(109, 16);
            this.databaseTypeLabel.TabIndex = 0;
            this.databaseTypeLabel.Text = "Database Type: ";
            this.databaseTypeLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // remoteFTPConfigurationGroupBox
            // 
            this.remoteFTPConfigurationGroupBox.Controls.Add(this.checkFTPConnectionButton);
            this.remoteFTPConfigurationGroupBox.Controls.Add(this.ftpDataGridView);
            this.remoteFTPConfigurationGroupBox.Location = new System.Drawing.Point(12, 234);
            this.remoteFTPConfigurationGroupBox.Name = "remoteFTPConfigurationGroupBox";
            this.remoteFTPConfigurationGroupBox.Size = new System.Drawing.Size(500, 191);
            this.remoteFTPConfigurationGroupBox.TabIndex = 3;
            this.remoteFTPConfigurationGroupBox.TabStop = false;
            this.remoteFTPConfigurationGroupBox.Text = "Remote FTP Configuration";
            this.remoteFTPConfigurationGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // checkFTPConnectionButton
            // 
            this.checkFTPConnectionButton.Location = new System.Drawing.Point(345, 162);
            this.checkFTPConnectionButton.Name = "checkFTPConnectionButton";
            this.checkFTPConnectionButton.Size = new System.Drawing.Size(132, 23);
            this.checkFTPConnectionButton.TabIndex = 1;
            this.checkFTPConnectionButton.Text = "Check Connection";
            this.checkFTPConnectionButton.UseVisualStyleBackColor = true;
            this.checkFTPConnectionButton.Click += new System.EventHandler(this.checkFTPConnectionButton_Click);
            // 
            // ftpDataGridView
            // 
            this.ftpDataGridView.AllowUserToAddRows = false;
            this.ftpDataGridView.AllowUserToDeleteRows = false;
            this.ftpDataGridView.AllowUserToOrderColumns = true;
            this.ftpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DestinationName,
            this.FTPType,
            this.Host,
            this.Directory,
            this.Port,
            this.Username});
            this.ftpDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ftpDataGridView.Location = new System.Drawing.Point(7, 22);
            this.ftpDataGridView.Name = "ftpDataGridView";
            this.ftpDataGridView.ReadOnly = true;
            this.ftpDataGridView.Size = new System.Drawing.Size(487, 134);
            this.ftpDataGridView.TabIndex = 0;
            this.ftpDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // loadConfigurationWorker
            // 
            this.loadConfigurationWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadConfigurationWorker_DoWork);
            // 
            // checkFTPConnectionWorker
            // 
            this.checkFTPConnectionWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkFTPConnectionWorker_DoWork);
            // 
            // checkCollectionDatabaseConnectionWorker
            // 
            this.checkCollectionDatabaseConnectionWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkCollectionDatabaseConnectionWorker_DoWork);
            // 
            // repostWorker
            // 
            this.repostWorker.WorkerReportsProgress = true;
            this.repostWorker.WorkerSupportsCancellation = true;
            this.repostWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.repostWorker_DoWork);
            this.repostWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.repostWorker_ProgressChanged);
            // 
            // DestinationName
            // 
            this.DestinationName.HeaderText = "Name";
            this.DestinationName.Name = "DestinationName";
            this.DestinationName.ReadOnly = true;
            // 
            // FTPType
            // 
            this.FTPType.HeaderText = "FTP Type";
            this.FTPType.Name = "FTPType";
            this.FTPType.ReadOnly = true;
            // 
            // Host
            // 
            this.Host.HeaderText = "Host";
            this.Host.Name = "Host";
            this.Host.ReadOnly = true;
            // 
            // Directory
            // 
            this.Directory.HeaderText = "FTP Directory";
            this.Directory.Name = "Directory";
            this.Directory.ReadOnly = true;
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 588);
            this.Controls.Add(this.remoteFTPConfigurationGroupBox);
            this.Controls.Add(this.collectionDatabaseGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generateReportGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ethosIQ Repost Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.generateReportGroupBox.ResumeLayout(false);
            this.generateReportGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.collectionDatabaseGroupBox.ResumeLayout(false);
            this.collectionDatabaseGroupBox.PerformLayout();
            this.remoteFTPConfigurationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftpDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generateReportGroupBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox collectionDatabaseGroupBox;
        private System.Windows.Forms.Label databaseTypeLabel;
        private System.Windows.Forms.Button repostButton;
        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.TextBox databaseTypeTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label dataSourceLabel;
        private System.Windows.Forms.Button checkDatabaseConnectionButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.GroupBox remoteFTPConfigurationGroupBox;
        private System.Windows.Forms.RadioButton thirtyMinuteRadioButton;
        private System.Windows.Forms.RadioButton fifteenRadioButton;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.DataGridView ftpDataGridView;
        private System.ComponentModel.BackgroundWorker loadConfigurationWorker;
        private System.Windows.Forms.Button checkFTPConnectionButton;
        private System.ComponentModel.BackgroundWorker checkFTPConnectionWorker;
        private System.ComponentModel.BackgroundWorker checkCollectionDatabaseConnectionWorker;
        private System.ComponentModel.BackgroundWorker repostWorker;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.CheckBox multiMediaCheckBox;
        private System.Windows.Forms.ProgressBar repostProgressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTPType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Host;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    }
}

