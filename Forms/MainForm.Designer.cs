namespace PyInstaLive_GUI
{
    partial class MainForm
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
            this.FFmpegBinaryLabel = new System.Windows.Forms.Label();
            this.PyInstaLiveBinaryLabel = new System.Windows.Forms.Label();
            this.FFmpegBinaryPathTextBox = new System.Windows.Forms.TextBox();
            this.PyInstaLiveBinaryPathTextBox = new System.Windows.Forms.TextBox();
            this.FFmpegLocateButton = new System.Windows.Forms.Button();
            this.PyInstaLiveLocateButton = new System.Windows.Forms.Button();
            this.ComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.PyInstaLiveIniLocateButton = new System.Windows.Forms.Button();
            this.PyInstaliveIniFileTextBox = new System.Windows.Forms.TextBox();
            this.PyInstaLiveIniFileLabel = new System.Windows.Forms.Label();
            this.ConfigurationGroupbox = new System.Windows.Forms.GroupBox();
            this.DownloadUserTextBox = new System.Windows.Forms.TextBox();
            this.DownloadUserLabel = new System.Windows.Forms.Label();
            this.SkipMergeCheckBox = new System.Windows.Forms.CheckBox();
            this.DoHeartbeatCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearTempFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.UseLocksCheckBox = new System.Windows.Forms.CheckBox();
            this.ProxyTextBox = new System.Windows.Forms.TextBox();
            this.ProxyLabel = new System.Windows.Forms.Label();
            this.RunAtFinishTextBox = new System.Windows.Forms.TextBox();
            this.RunAtFinishLabel = new System.Windows.Forms.Label();
            this.RunAtStartTextBox = new System.Windows.Forms.TextBox();
            this.RunAtStartLabel = new System.Windows.Forms.Label();
            this.LogToFileCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowCookieExpiryCheckBox = new System.Windows.Forms.CheckBox();
            this.DownloadLabel = new System.Windows.Forms.Label();
            this.DownloadCommentsCheckBox = new System.Windows.Forms.CheckBox();
            this.DownloadReplaysCheckBox = new System.Windows.Forms.CheckBox();
            this.DownloadLivestreamsCheckBox = new System.Windows.Forms.CheckBox();
            this.DownloadPathSelectButton = new System.Windows.Forms.Button();
            this.DownloadPathTextBox = new System.Windows.Forms.TextBox();
            this.DownloadPathLabel = new System.Windows.Forms.Label();
            this.PyInstaLiveIniTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.FinalCommandStringTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ComponentsGroupBox.SuspendLayout();
            this.ConfigurationGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FFmpegBinaryLabel
            // 
            this.FFmpegBinaryLabel.AutoSize = true;
            this.FFmpegBinaryLabel.Location = new System.Drawing.Point(20, 25);
            this.FFmpegBinaryLabel.Name = "FFmpegBinaryLabel";
            this.FFmpegBinaryLabel.Size = new System.Drawing.Size(83, 13);
            this.FFmpegBinaryLabel.TabIndex = 0;
            this.FFmpegBinaryLabel.Text = "FFmpeg binary";
            // 
            // PyInstaLiveBinaryLabel
            // 
            this.PyInstaLiveBinaryLabel.AutoSize = true;
            this.PyInstaLiveBinaryLabel.Location = new System.Drawing.Point(6, 53);
            this.PyInstaLiveBinaryLabel.Name = "PyInstaLiveBinaryLabel";
            this.PyInstaLiveBinaryLabel.Size = new System.Drawing.Size(97, 13);
            this.PyInstaLiveBinaryLabel.TabIndex = 1;
            this.PyInstaLiveBinaryLabel.Text = "PyInstaLive binary";
            // 
            // FFmpegBinaryPathTextBox
            // 
            this.FFmpegBinaryPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FFmpegBinaryPathTextBox.Location = new System.Drawing.Point(109, 21);
            this.FFmpegBinaryPathTextBox.Name = "FFmpegBinaryPathTextBox";
            this.FFmpegBinaryPathTextBox.ReadOnly = true;
            this.FFmpegBinaryPathTextBox.Size = new System.Drawing.Size(646, 22);
            this.FFmpegBinaryPathTextBox.TabIndex = 2;
            // 
            // PyInstaLiveBinaryPathTextBox
            // 
            this.PyInstaLiveBinaryPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PyInstaLiveBinaryPathTextBox.Location = new System.Drawing.Point(109, 49);
            this.PyInstaLiveBinaryPathTextBox.Name = "PyInstaLiveBinaryPathTextBox";
            this.PyInstaLiveBinaryPathTextBox.ReadOnly = true;
            this.PyInstaLiveBinaryPathTextBox.Size = new System.Drawing.Size(646, 22);
            this.PyInstaLiveBinaryPathTextBox.TabIndex = 3;
            // 
            // FFmpegLocateButton
            // 
            this.FFmpegLocateButton.Enabled = false;
            this.FFmpegLocateButton.Location = new System.Drawing.Point(768, 19);
            this.FFmpegLocateButton.Name = "FFmpegLocateButton";
            this.FFmpegLocateButton.Size = new System.Drawing.Size(79, 24);
            this.FFmpegLocateButton.TabIndex = 5;
            this.FFmpegLocateButton.Text = "Locate...";
            this.FFmpegLocateButton.UseVisualStyleBackColor = true;
            this.FFmpegLocateButton.Click += new System.EventHandler(this.FFmpegLocateButtonClicked);
            // 
            // PyInstaLiveLocateButton
            // 
            this.PyInstaLiveLocateButton.Location = new System.Drawing.Point(768, 49);
            this.PyInstaLiveLocateButton.Name = "PyInstaLiveLocateButton";
            this.PyInstaLiveLocateButton.Size = new System.Drawing.Size(79, 24);
            this.PyInstaLiveLocateButton.TabIndex = 6;
            this.PyInstaLiveLocateButton.Text = "Locate...";
            this.PyInstaLiveLocateButton.UseVisualStyleBackColor = true;
            this.PyInstaLiveLocateButton.Click += new System.EventHandler(this.PyInstaLiveLocateButtonClicked);
            // 
            // ComponentsGroupBox
            // 
            this.ComponentsGroupBox.Controls.Add(this.PyInstaLiveIniLocateButton);
            this.ComponentsGroupBox.Controls.Add(this.PyInstaliveIniFileTextBox);
            this.ComponentsGroupBox.Controls.Add(this.PyInstaLiveIniFileLabel);
            this.ComponentsGroupBox.Controls.Add(this.PyInstaLiveBinaryPathTextBox);
            this.ComponentsGroupBox.Controls.Add(this.PyInstaLiveLocateButton);
            this.ComponentsGroupBox.Controls.Add(this.FFmpegBinaryLabel);
            this.ComponentsGroupBox.Controls.Add(this.FFmpegLocateButton);
            this.ComponentsGroupBox.Controls.Add(this.PyInstaLiveBinaryLabel);
            this.ComponentsGroupBox.Controls.Add(this.FFmpegBinaryPathTextBox);
            this.ComponentsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ComponentsGroupBox.Name = "ComponentsGroupBox";
            this.ComponentsGroupBox.Size = new System.Drawing.Size(860, 113);
            this.ComponentsGroupBox.TabIndex = 6;
            this.ComponentsGroupBox.TabStop = false;
            this.ComponentsGroupBox.Text = "Components";
            // 
            // PyInstaLiveIniLocateButton
            // 
            this.PyInstaLiveIniLocateButton.Location = new System.Drawing.Point(768, 75);
            this.PyInstaLiveIniLocateButton.Name = "PyInstaLiveIniLocateButton";
            this.PyInstaLiveIniLocateButton.Size = new System.Drawing.Size(79, 24);
            this.PyInstaLiveIniLocateButton.TabIndex = 7;
            this.PyInstaLiveIniLocateButton.Text = "Locate...";
            this.PyInstaLiveIniLocateButton.UseVisualStyleBackColor = true;
            this.PyInstaLiveIniLocateButton.Click += new System.EventHandler(this.PyInstaLiveIniLocateButtonClicked);
            // 
            // PyInstaliveIniFileTextBox
            // 
            this.PyInstaliveIniFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PyInstaliveIniFileTextBox.Location = new System.Drawing.Point(109, 77);
            this.PyInstaliveIniFileTextBox.Name = "PyInstaliveIniFileTextBox";
            this.PyInstaliveIniFileTextBox.ReadOnly = true;
            this.PyInstaliveIniFileTextBox.Size = new System.Drawing.Size(646, 22);
            this.PyInstaliveIniFileTextBox.TabIndex = 4;
            // 
            // PyInstaLiveIniFileLabel
            // 
            this.PyInstaLiveIniFileLabel.AutoSize = true;
            this.PyInstaLiveIniFileLabel.Location = new System.Drawing.Point(6, 81);
            this.PyInstaLiveIniFileLabel.Name = "PyInstaLiveIniFileLabel";
            this.PyInstaLiveIniFileLabel.Size = new System.Drawing.Size(97, 13);
            this.PyInstaLiveIniFileLabel.TabIndex = 6;
            this.PyInstaLiveIniFileLabel.Text = "PyInstaLive.ini file";
            // 
            // ConfigurationGroupbox
            // 
            this.ConfigurationGroupbox.Controls.Add(this.DownloadUserTextBox);
            this.ConfigurationGroupbox.Controls.Add(this.DownloadUserLabel);
            this.ConfigurationGroupbox.Controls.Add(this.SkipMergeCheckBox);
            this.ConfigurationGroupbox.Controls.Add(this.DoHeartbeatCheckBox);
            this.ConfigurationGroupbox.Controls.Add(this.ClearTempFilesCheckBox);
            this.ConfigurationGroupbox.Controls.Add(this.UseLocksCheckBox);
            this.ConfigurationGroupbox.Controls.Add(this.ProxyTextBox);
            this.ConfigurationGroupbox.Controls.Add(this.ProxyLabel);
            this.ConfigurationGroupbox.Controls.Add(this.RunAtFinishTextBox);
            this.ConfigurationGroupbox.Controls.Add(this.RunAtFinishLabel);
            this.ConfigurationGroupbox.Controls.Add(this.RunAtStartTextBox);
            this.ConfigurationGroupbox.Controls.Add(this.RunAtStartLabel);
            this.ConfigurationGroupbox.Controls.Add(this.LogToFileCheckBox);
            this.ConfigurationGroupbox.Controls.Add(this.ShowCookieExpiryCheckBox);
            this.ConfigurationGroupbox.Controls.Add(this.DownloadLabel);
            this.ConfigurationGroupbox.Controls.Add(this.DownloadCommentsCheckBox);
            this.ConfigurationGroupbox.Controls.Add(this.DownloadReplaysCheckBox);
            this.ConfigurationGroupbox.Controls.Add(this.DownloadLivestreamsCheckBox);
            this.ConfigurationGroupbox.Controls.Add(this.DownloadPathSelectButton);
            this.ConfigurationGroupbox.Controls.Add(this.DownloadPathTextBox);
            this.ConfigurationGroupbox.Controls.Add(this.DownloadPathLabel);
            this.ConfigurationGroupbox.Controls.Add(this.PyInstaLiveIniTextBox);
            this.ConfigurationGroupbox.Controls.Add(this.PasswordTextBox);
            this.ConfigurationGroupbox.Controls.Add(this.PasswordLabel);
            this.ConfigurationGroupbox.Controls.Add(this.UsernameTextBox);
            this.ConfigurationGroupbox.Controls.Add(this.UsernameLabel);
            this.ConfigurationGroupbox.Location = new System.Drawing.Point(12, 131);
            this.ConfigurationGroupbox.Name = "ConfigurationGroupbox";
            this.ConfigurationGroupbox.Size = new System.Drawing.Size(860, 440);
            this.ConfigurationGroupbox.TabIndex = 7;
            this.ConfigurationGroupbox.TabStop = false;
            this.ConfigurationGroupbox.Text = "Configuration";
            // 
            // DownloadUserTextBox
            // 
            this.DownloadUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DownloadUserTextBox.Location = new System.Drawing.Point(102, 119);
            this.DownloadUserTextBox.Name = "DownloadUserTextBox";
            this.DownloadUserTextBox.Size = new System.Drawing.Size(314, 22);
            this.DownloadUserTextBox.TabIndex = 120;
            this.DownloadUserTextBox.Text = "johndoe";
            this.DownloadUserTextBox.TextChanged += new System.EventHandler(this.TextBoxesTextChanged);
            // 
            // DownloadUserLabel
            // 
            this.DownloadUserLabel.AutoSize = true;
            this.DownloadUserLabel.Location = new System.Drawing.Point(10, 123);
            this.DownloadUserLabel.Name = "DownloadUserLabel";
            this.DownloadUserLabel.Size = new System.Drawing.Size(86, 13);
            this.DownloadUserLabel.TabIndex = 119;
            this.DownloadUserLabel.Text = "Download user";
            // 
            // SkipMergeCheckBox
            // 
            this.SkipMergeCheckBox.AutoSize = true;
            this.SkipMergeCheckBox.Location = new System.Drawing.Point(11, 315);
            this.SkipMergeCheckBox.Name = "SkipMergeCheckBox";
            this.SkipMergeCheckBox.Size = new System.Drawing.Size(244, 17);
            this.SkipMergeCheckBox.TabIndex = 118;
            this.SkipMergeCheckBox.Text = "Do not merge downloaded livestream files";
            this.SkipMergeCheckBox.UseVisualStyleBackColor = true;
            this.SkipMergeCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxesStateChanged);
            // 
            // DoHeartbeatCheckBox
            // 
            this.DoHeartbeatCheckBox.AutoSize = true;
            this.DoHeartbeatCheckBox.Location = new System.Drawing.Point(11, 292);
            this.DoHeartbeatCheckBox.Name = "DoHeartbeatCheckBox";
            this.DoHeartbeatCheckBox.Size = new System.Drawing.Size(173, 17);
            this.DoHeartbeatCheckBox.TabIndex = 117;
            this.DoHeartbeatCheckBox.Text = "Send heartbeat to Instagram";
            this.DoHeartbeatCheckBox.UseVisualStyleBackColor = true;
            this.DoHeartbeatCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxesStateChanged);
            // 
            // ClearTempFilesCheckBox
            // 
            this.ClearTempFilesCheckBox.AutoSize = true;
            this.ClearTempFilesCheckBox.Enabled = false;
            this.ClearTempFilesCheckBox.Location = new System.Drawing.Point(11, 269);
            this.ClearTempFilesCheckBox.Name = "ClearTempFilesCheckBox";
            this.ClearTempFilesCheckBox.Size = new System.Drawing.Size(320, 17);
            this.ClearTempFilesCheckBox.TabIndex = 116;
            this.ClearTempFilesCheckBox.Text = "Clear temporary download segments on download finish";
            this.ClearTempFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseLocksCheckBox
            // 
            this.UseLocksCheckBox.AutoSize = true;
            this.UseLocksCheckBox.Enabled = false;
            this.UseLocksCheckBox.Location = new System.Drawing.Point(11, 246);
            this.UseLocksCheckBox.Name = "UseLocksCheckBox";
            this.UseLocksCheckBox.Size = new System.Drawing.Size(146, 17);
            this.UseLocksCheckBox.TabIndex = 115;
            this.UseLocksCheckBox.Text = "Use username lock files";
            this.UseLocksCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProxyTextBox
            // 
            this.ProxyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProxyTextBox.Enabled = false;
            this.ProxyTextBox.Location = new System.Drawing.Point(142, 402);
            this.ProxyTextBox.Name = "ProxyTextBox";
            this.ProxyTextBox.Size = new System.Drawing.Size(274, 22);
            this.ProxyTextBox.TabIndex = 114;
            // 
            // ProxyLabel
            // 
            this.ProxyLabel.AutoSize = true;
            this.ProxyLabel.Location = new System.Drawing.Point(29, 406);
            this.ProxyLabel.Name = "ProxyLabel";
            this.ProxyLabel.Size = new System.Drawing.Size(107, 13);
            this.ProxyLabel.TabIndex = 113;
            this.ProxyLabel.Text = "HTTP proxy address";
            // 
            // RunAtFinishTextBox
            // 
            this.RunAtFinishTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RunAtFinishTextBox.Enabled = false;
            this.RunAtFinishTextBox.Location = new System.Drawing.Point(142, 374);
            this.RunAtFinishTextBox.Name = "RunAtFinishTextBox";
            this.RunAtFinishTextBox.Size = new System.Drawing.Size(274, 22);
            this.RunAtFinishTextBox.TabIndex = 112;
            // 
            // RunAtFinishLabel
            // 
            this.RunAtFinishLabel.AutoSize = true;
            this.RunAtFinishLabel.Location = new System.Drawing.Point(6, 378);
            this.RunAtFinishLabel.Name = "RunAtFinishLabel";
            this.RunAtFinishLabel.Size = new System.Drawing.Size(130, 13);
            this.RunAtFinishLabel.TabIndex = 111;
            this.RunAtFinishLabel.Text = "Run command on finish";
            // 
            // RunAtStartTextBox
            // 
            this.RunAtStartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RunAtStartTextBox.Enabled = false;
            this.RunAtStartTextBox.Location = new System.Drawing.Point(142, 346);
            this.RunAtStartTextBox.Name = "RunAtStartTextBox";
            this.RunAtStartTextBox.Size = new System.Drawing.Size(274, 22);
            this.RunAtStartTextBox.TabIndex = 110;
            // 
            // RunAtStartLabel
            // 
            this.RunAtStartLabel.AutoSize = true;
            this.RunAtStartLabel.Location = new System.Drawing.Point(12, 350);
            this.RunAtStartLabel.Name = "RunAtStartLabel";
            this.RunAtStartLabel.Size = new System.Drawing.Size(124, 13);
            this.RunAtStartLabel.TabIndex = 109;
            this.RunAtStartLabel.Text = "Run command on start";
            // 
            // LogToFileCheckBox
            // 
            this.LogToFileCheckBox.AutoSize = true;
            this.LogToFileCheckBox.Enabled = false;
            this.LogToFileCheckBox.Location = new System.Drawing.Point(11, 223);
            this.LogToFileCheckBox.Name = "LogToFileCheckBox";
            this.LogToFileCheckBox.Size = new System.Drawing.Size(182, 17);
            this.LogToFileCheckBox.TabIndex = 108;
            this.LogToFileCheckBox.Text = "Log console output to text file";
            this.LogToFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowCookieExpiryCheckBox
            // 
            this.ShowCookieExpiryCheckBox.AutoSize = true;
            this.ShowCookieExpiryCheckBox.Enabled = false;
            this.ShowCookieExpiryCheckBox.Location = new System.Drawing.Point(11, 200);
            this.ShowCookieExpiryCheckBox.Name = "ShowCookieExpiryCheckBox";
            this.ShowCookieExpiryCheckBox.Size = new System.Drawing.Size(192, 17);
            this.ShowCookieExpiryCheckBox.TabIndex = 107;
            this.ShowCookieExpiryCheckBox.Text = "Show cookie file expiration date";
            this.ShowCookieExpiryCheckBox.UseVisualStyleBackColor = true;
            // 
            // DownloadLabel
            // 
            this.DownloadLabel.AutoSize = true;
            this.DownloadLabel.Location = new System.Drawing.Point(8, 169);
            this.DownloadLabel.Name = "DownloadLabel";
            this.DownloadLabel.Size = new System.Drawing.Size(91, 13);
            this.DownloadLabel.TabIndex = 106;
            this.DownloadLabel.Text = "Download items";
            // 
            // DownloadCommentsCheckBox
            // 
            this.DownloadCommentsCheckBox.AutoSize = true;
            this.DownloadCommentsCheckBox.Enabled = false;
            this.DownloadCommentsCheckBox.Location = new System.Drawing.Point(296, 168);
            this.DownloadCommentsCheckBox.Name = "DownloadCommentsCheckBox";
            this.DownloadCommentsCheckBox.Size = new System.Drawing.Size(80, 17);
            this.DownloadCommentsCheckBox.TabIndex = 105;
            this.DownloadCommentsCheckBox.Text = "Comments";
            this.DownloadCommentsCheckBox.UseVisualStyleBackColor = true;
            this.DownloadCommentsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxesStateChanged);
            // 
            // DownloadReplaysCheckBox
            // 
            this.DownloadReplaysCheckBox.AutoSize = true;
            this.DownloadReplaysCheckBox.Location = new System.Drawing.Point(225, 168);
            this.DownloadReplaysCheckBox.Name = "DownloadReplaysCheckBox";
            this.DownloadReplaysCheckBox.Size = new System.Drawing.Size(65, 17);
            this.DownloadReplaysCheckBox.TabIndex = 104;
            this.DownloadReplaysCheckBox.Text = "Replays";
            this.DownloadReplaysCheckBox.UseVisualStyleBackColor = true;
            this.DownloadReplaysCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxesStateChanged);
            // 
            // DownloadLivestreamsCheckBox
            // 
            this.DownloadLivestreamsCheckBox.AutoSize = true;
            this.DownloadLivestreamsCheckBox.Location = new System.Drawing.Point(135, 168);
            this.DownloadLivestreamsCheckBox.Name = "DownloadLivestreamsCheckBox";
            this.DownloadLivestreamsCheckBox.Size = new System.Drawing.Size(84, 17);
            this.DownloadLivestreamsCheckBox.TabIndex = 103;
            this.DownloadLivestreamsCheckBox.Text = "Livestreams";
            this.DownloadLivestreamsCheckBox.UseVisualStyleBackColor = true;
            this.DownloadLivestreamsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxesStateChanged);
            // 
            // DownloadPathSelectButton
            // 
            this.DownloadPathSelectButton.Location = new System.Drawing.Point(352, 77);
            this.DownloadPathSelectButton.Name = "DownloadPathSelectButton";
            this.DownloadPathSelectButton.Size = new System.Drawing.Size(64, 24);
            this.DownloadPathSelectButton.TabIndex = 8;
            this.DownloadPathSelectButton.Text = "Select...";
            this.DownloadPathSelectButton.UseVisualStyleBackColor = true;
            this.DownloadPathSelectButton.Click += new System.EventHandler(this.DownloadPathSelectButtonClicked);
            // 
            // DownloadPathTextBox
            // 
            this.DownloadPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DownloadPathTextBox.Location = new System.Drawing.Point(102, 78);
            this.DownloadPathTextBox.Name = "DownloadPathTextBox";
            this.DownloadPathTextBox.ReadOnly = true;
            this.DownloadPathTextBox.Size = new System.Drawing.Size(244, 22);
            this.DownloadPathTextBox.TabIndex = 102;
            // 
            // DownloadPathLabel
            // 
            this.DownloadPathLabel.AutoSize = true;
            this.DownloadPathLabel.Location = new System.Drawing.Point(8, 82);
            this.DownloadPathLabel.Name = "DownloadPathLabel";
            this.DownloadPathLabel.Size = new System.Drawing.Size(88, 13);
            this.DownloadPathLabel.TabIndex = 101;
            this.DownloadPathLabel.Text = "Download path";
            // 
            // PyInstaLiveIniTextBox
            // 
            this.PyInstaLiveIniTextBox.Location = new System.Drawing.Point(422, 21);
            this.PyInstaLiveIniTextBox.Multiline = true;
            this.PyInstaLiveIniTextBox.Name = "PyInstaLiveIniTextBox";
            this.PyInstaLiveIniTextBox.ReadOnly = true;
            this.PyInstaLiveIniTextBox.Size = new System.Drawing.Size(425, 403);
            this.PyInstaLiveIniTextBox.TabIndex = 100;
            this.PyInstaLiveIniTextBox.Text = "No pyinstalive.ini file loaded.";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Location = new System.Drawing.Point(102, 50);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(314, 22);
            this.PasswordTextBox.TabIndex = 9;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.TextBoxesTextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(40, 54);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Location = new System.Drawing.Point(102, 22);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(314, 22);
            this.UsernameTextBox.TabIndex = 8;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.TextBoxesTextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(38, 26);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // FinalCommandStringTextBox
            // 
            this.FinalCommandStringTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinalCommandStringTextBox.Enabled = false;
            this.FinalCommandStringTextBox.Location = new System.Drawing.Point(12, 577);
            this.FinalCommandStringTextBox.Name = "FinalCommandStringTextBox";
            this.FinalCommandStringTextBox.Size = new System.Drawing.Size(779, 22);
            this.FinalCommandStringTextBox.TabIndex = 8;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(797, 577);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 9;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteScriptButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.FinalCommandStringTextBox);
            this.Controls.Add(this.ConfigurationGroupbox);
            this.Controls.Add(this.ComponentsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PyInstaLive-GUI";
            this.ComponentsGroupBox.ResumeLayout(false);
            this.ComponentsGroupBox.PerformLayout();
            this.ConfigurationGroupbox.ResumeLayout(false);
            this.ConfigurationGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FFmpegBinaryLabel;
        private System.Windows.Forms.Label PyInstaLiveBinaryLabel;
        private System.Windows.Forms.TextBox FFmpegBinaryPathTextBox;
        private System.Windows.Forms.TextBox PyInstaLiveBinaryPathTextBox;
        private System.Windows.Forms.Button FFmpegLocateButton;
        private System.Windows.Forms.Button PyInstaLiveLocateButton;
        private System.Windows.Forms.GroupBox ComponentsGroupBox;
        private System.Windows.Forms.GroupBox ConfigurationGroupbox;
        private System.Windows.Forms.Button PyInstaLiveIniLocateButton;
        private System.Windows.Forms.TextBox PyInstaliveIniFileTextBox;
        private System.Windows.Forms.Label PyInstaLiveIniFileLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PyInstaLiveIniTextBox;
        private System.Windows.Forms.TextBox DownloadPathTextBox;
        private System.Windows.Forms.Label DownloadPathLabel;
        private System.Windows.Forms.Button DownloadPathSelectButton;
        private System.Windows.Forms.CheckBox DownloadReplaysCheckBox;
        private System.Windows.Forms.CheckBox DownloadLivestreamsCheckBox;
        private System.Windows.Forms.CheckBox DownloadCommentsCheckBox;
        private System.Windows.Forms.Label DownloadLabel;
        private System.Windows.Forms.CheckBox ShowCookieExpiryCheckBox;
        private System.Windows.Forms.CheckBox LogToFileCheckBox;
        private System.Windows.Forms.TextBox RunAtStartTextBox;
        private System.Windows.Forms.Label RunAtStartLabel;
        private System.Windows.Forms.TextBox RunAtFinishTextBox;
        private System.Windows.Forms.Label RunAtFinishLabel;
        private System.Windows.Forms.TextBox ProxyTextBox;
        private System.Windows.Forms.Label ProxyLabel;
        private System.Windows.Forms.CheckBox UseLocksCheckBox;
        private System.Windows.Forms.CheckBox ClearTempFilesCheckBox;
        private System.Windows.Forms.CheckBox DoHeartbeatCheckBox;
        private System.Windows.Forms.CheckBox SkipMergeCheckBox;
        private System.Windows.Forms.TextBox FinalCommandStringTextBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox DownloadUserTextBox;
        private System.Windows.Forms.Label DownloadUserLabel;
    }
}

