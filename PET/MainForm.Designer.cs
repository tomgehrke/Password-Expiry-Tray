namespace Pet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.passwordExpiresLabel = new System.Windows.Forms.Label();
            this.UserNameValueLabel = new System.Windows.Forms.Label();
            this.PasswordExpiresValueLabel = new System.Windows.Forms.Label();
            this.FullNameValueLabel = new System.Windows.Forms.Label();
            this.alertPanel = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.CheckExpirationTimer = new System.Windows.Forms.Timer(this.components);
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.MainContextMenuStrip.SuspendLayout();
            this.alertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateNowToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.MainContextMenuStrip.Name = "contextMenuStrip1";
            this.MainContextMenuStrip.ShowImageMargin = false;
            this.MainContextMenuStrip.Size = new System.Drawing.Size(157, 106);
            // 
            // updateNowToolStripMenuItem
            // 
            this.updateNowToolStripMenuItem.Name = "updateNowToolStripMenuItem";
            this.updateNowToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.updateNowToolStripMenuItem.Text = "Update now";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.ContextMenuStrip = this.MainContextMenuStrip;
            this.MainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainNotifyIcon.Icon")));
            this.MainNotifyIcon.Text = "Password Expiry Tray";
            this.MainNotifyIcon.Visible = true;
            this.MainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainNotifyIcon_MouseDoubleClick);
            // 
            // passwordExpiresLabel
            // 
            this.passwordExpiresLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordExpiresLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordExpiresLabel.Location = new System.Drawing.Point(15, 11);
            this.passwordExpiresLabel.Name = "passwordExpiresLabel";
            this.passwordExpiresLabel.Size = new System.Drawing.Size(575, 30);
            this.passwordExpiresLabel.TabIndex = 2;
            this.passwordExpiresLabel.Text = "Password Expires";
            this.passwordExpiresLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UserNameValueLabel
            // 
            this.UserNameValueLabel.AutoSize = true;
            this.UserNameValueLabel.Location = new System.Drawing.Point(17, 154);
            this.UserNameValueLabel.Name = "UserNameValueLabel";
            this.UserNameValueLabel.Size = new System.Drawing.Size(188, 25);
            this.UserNameValueLabel.TabIndex = 3;
            this.UserNameValueLabel.Text = "DOMAIN\\Username";
            this.UserNameValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PasswordExpiresValueLabel
            // 
            this.PasswordExpiresValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordExpiresValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordExpiresValueLabel.ForeColor = System.Drawing.Color.Snow;
            this.PasswordExpiresValueLabel.Location = new System.Drawing.Point(10, 40);
            this.PasswordExpiresValueLabel.Name = "PasswordExpiresValueLabel";
            this.PasswordExpiresValueLabel.Size = new System.Drawing.Size(580, 60);
            this.PasswordExpiresValueLabel.TabIndex = 4;
            this.PasswordExpiresValueLabel.Text = "January 1, 1970";
            this.PasswordExpiresValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FullNameValueLabel
            // 
            this.FullNameValueLabel.AutoSize = true;
            this.FullNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameValueLabel.Location = new System.Drawing.Point(17, 125);
            this.FullNameValueLabel.Name = "FullNameValueLabel";
            this.FullNameValueLabel.Size = new System.Drawing.Size(176, 29);
            this.FullNameValueLabel.TabIndex = 8;
            this.FullNameValueLabel.Text = "John Q Public";
            // 
            // alertPanel
            // 
            this.alertPanel.BackColor = System.Drawing.Color.Green;
            this.alertPanel.Controls.Add(this.PasswordExpiresValueLabel);
            this.alertPanel.Controls.Add(this.passwordExpiresLabel);
            this.alertPanel.Location = new System.Drawing.Point(2, 2);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.Size = new System.Drawing.Size(600, 110);
            this.alertPanel.TabIndex = 9;
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(22, 197);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(570, 100);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "This is some message text.";
            // 
            // CheckExpirationTimer
            // 
            this.CheckExpirationTimer.Tick += new System.EventHandler(this.CheckExpirationTimer_Tick);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(12, 312);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(580, 50);
            this.ChangePasswordButton.TabIndex = 11;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(608, 374);
            this.ControlBox = false;
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.FullNameValueLabel);
            this.Controls.Add(this.UserNameValueLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Expiry Tray";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.MainContextMenuStrip.ResumeLayout(false);
            this.alertPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.NotifyIcon MainNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem updateNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label passwordExpiresLabel;
        private System.Windows.Forms.Label UserNameValueLabel;
        private System.Windows.Forms.Label PasswordExpiresValueLabel;
        private System.Windows.Forms.Label FullNameValueLabel;
        private System.Windows.Forms.Panel alertPanel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Timer CheckExpirationTimer;
        private System.Windows.Forms.Button ChangePasswordButton;
    }
}

