namespace DFTP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HostBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.BrowseLocalTextBox = new System.Windows.Forms.TextBox();
            this.BrowseFTPTextBox = new System.Windows.Forms.TextBox();
            this.BrowseLocalButton = new System.Windows.Forms.Button();
            this.RefreshContent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BrowseLocalDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.LocalFiles = new System.Windows.Forms.ListBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.OnlineFiles = new System.Windows.Forms.ListBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.UpdateOnlinePath = new System.Windows.Forms.Timer(this.components);
            this.UpdateListCheckBox = new System.Windows.Forms.CheckBox();
            this.FuncRefreshRate = new System.Windows.Forms.Timer(this.components);
            this.DeleteFromFtpButton = new System.Windows.Forms.Button();
            this.RenameOnlineButton = new System.Windows.Forms.Button();
            this.SavePathFTPDownloadDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // HostBox
            // 
            this.HostBox.BackColor = System.Drawing.SystemColors.Control;
            this.HostBox.Location = new System.Drawing.Point(47, 9);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(152, 20);
            this.HostBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameBox.Location = new System.Drawing.Point(266, 9);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(152, 20);
            this.UsernameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordBox.Location = new System.Drawing.Point(483, 9);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(152, 20);
            this.PasswordBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.SystemColors.Control;
            this.PortBox.Location = new System.Drawing.Point(673, 9);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(152, 20);
            this.PortBox.TabIndex = 6;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(831, 7);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(93, 23);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // BrowseLocalTextBox
            // 
            this.BrowseLocalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BrowseLocalTextBox.Location = new System.Drawing.Point(15, 52);
            this.BrowseLocalTextBox.Name = "BrowseLocalTextBox";
            this.BrowseLocalTextBox.Size = new System.Drawing.Size(366, 20);
            this.BrowseLocalTextBox.TabIndex = 9;
            // 
            // BrowseFTPTextBox
            // 
            this.BrowseFTPTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BrowseFTPTextBox.Location = new System.Drawing.Point(483, 52);
            this.BrowseFTPTextBox.Name = "BrowseFTPTextBox";
            this.BrowseFTPTextBox.Size = new System.Drawing.Size(404, 20);
            this.BrowseFTPTextBox.TabIndex = 10;
            // 
            // BrowseLocalButton
            // 
            this.BrowseLocalButton.Location = new System.Drawing.Point(387, 51);
            this.BrowseLocalButton.Name = "BrowseLocalButton";
            this.BrowseLocalButton.Size = new System.Drawing.Size(30, 23);
            this.BrowseLocalButton.TabIndex = 11;
            this.BrowseLocalButton.Text = "...";
            this.BrowseLocalButton.UseVisualStyleBackColor = true;
            this.BrowseLocalButton.Click += new System.EventHandler(this.BrowseLocalButton_Click);
            // 
            // RefreshContent
            // 
            this.RefreshContent.Location = new System.Drawing.Point(894, 51);
            this.RefreshContent.Name = "RefreshContent";
            this.RefreshContent.Size = new System.Drawing.Size(30, 23);
            this.RefreshContent.TabIndex = 12;
            this.RefreshContent.Text = "↺";
            this.RefreshContent.UseVisualStyleBackColor = true;
            this.RefreshContent.Click += new System.EventHandler(this.BrowseFTPButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Local";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "FTP";
            // 
            // BrowseLocalDialog
            // 
            this.BrowseLocalDialog.HelpRequest += new System.EventHandler(this.BrowseLocalDialog_HelpRequest);
            // 
            // LocalFiles
            // 
            this.LocalFiles.BackColor = System.Drawing.SystemColors.Control;
            this.LocalFiles.FormattingEnabled = true;
            this.LocalFiles.Location = new System.Drawing.Point(15, 79);
            this.LocalFiles.Name = "LocalFiles";
            this.LocalFiles.Size = new System.Drawing.Size(403, 290);
            this.LocalFiles.TabIndex = 15;
            this.LocalFiles.DoubleClick += new System.EventHandler(this.LocalFiles_DoubleClick);
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(15, 376);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 16;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // OnlineFiles
            // 
            this.OnlineFiles.BackColor = System.Drawing.SystemColors.Control;
            this.OnlineFiles.FormattingEnabled = true;
            this.OnlineFiles.Location = new System.Drawing.Point(483, 79);
            this.OnlineFiles.Name = "OnlineFiles";
            this.OnlineFiles.Size = new System.Drawing.Size(441, 290);
            this.OnlineFiles.TabIndex = 17;
            this.OnlineFiles.DoubleClick += new System.EventHandler(this.OnlineFiles_DoubleClick);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(483, 374);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 18;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // UpdateOnlinePath
            // 
            this.UpdateOnlinePath.Interval = 3000;
            this.UpdateOnlinePath.Tick += new System.EventHandler(this.UpdateOnlinePath_Tick);
            // 
            // UpdateListCheckBox
            // 
            this.UpdateListCheckBox.AutoSize = true;
            this.UpdateListCheckBox.Location = new System.Drawing.Point(844, 32);
            this.UpdateListCheckBox.Name = "UpdateListCheckBox";
            this.UpdateListCheckBox.Size = new System.Drawing.Size(80, 17);
            this.UpdateListCheckBox.TabIndex = 19;
            this.UpdateListCheckBox.Text = "Update List";
            this.UpdateListCheckBox.UseVisualStyleBackColor = true;
            this.UpdateListCheckBox.CheckedChanged += new System.EventHandler(this.UpdateListCheckBox_CheckedChanged);
            // 
            // FuncRefreshRate
            // 
            this.FuncRefreshRate.Tick += new System.EventHandler(this.FuncRefreshRate_Tick);
            // 
            // DeleteFromFtpButton
            // 
            this.DeleteFromFtpButton.Location = new System.Drawing.Point(565, 374);
            this.DeleteFromFtpButton.Name = "DeleteFromFtpButton";
            this.DeleteFromFtpButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteFromFtpButton.TabIndex = 20;
            this.DeleteFromFtpButton.Text = "Delete";
            this.DeleteFromFtpButton.UseVisualStyleBackColor = true;
            this.DeleteFromFtpButton.Click += new System.EventHandler(this.DeleteFromFtpButton_Click);
            // 
            // RenameOnlineButton
            // 
            this.RenameOnlineButton.Location = new System.Drawing.Point(644, 374);
            this.RenameOnlineButton.Name = "RenameOnlineButton";
            this.RenameOnlineButton.Size = new System.Drawing.Size(75, 23);
            this.RenameOnlineButton.TabIndex = 21;
            this.RenameOnlineButton.Text = "Rename";
            this.RenameOnlineButton.UseVisualStyleBackColor = true;
            this.RenameOnlineButton.Click += new System.EventHandler(this.RenameOnlineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(937, 421);
            this.Controls.Add(this.RenameOnlineButton);
            this.Controls.Add(this.DeleteFromFtpButton);
            this.Controls.Add(this.UpdateListCheckBox);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.OnlineFiles);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.LocalFiles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RefreshContent);
            this.Controls.Add(this.BrowseLocalButton);
            this.Controls.Add(this.BrowseFTPTextBox);
            this.Controls.Add(this.BrowseLocalTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(953, 460);
            this.MinimumSize = new System.Drawing.Size(953, 460);
            this.Name = "Form1";
            this.Text = "DFTP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox BrowseLocalTextBox;
        private System.Windows.Forms.TextBox BrowseFTPTextBox;
        private System.Windows.Forms.Button BrowseLocalButton;
        private System.Windows.Forms.Button RefreshContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog BrowseLocalDialog;
        private System.Windows.Forms.ListBox LocalFiles;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.ListBox OnlineFiles;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Timer UpdateOnlinePath;
        private System.Windows.Forms.CheckBox UpdateListCheckBox;
        private System.Windows.Forms.Timer FuncRefreshRate;
        private System.Windows.Forms.Button DeleteFromFtpButton;
        private System.Windows.Forms.Button RenameOnlineButton;
        private System.Windows.Forms.FolderBrowserDialog SavePathFTPDownloadDialog;
    }
}

