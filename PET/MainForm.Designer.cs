namespace PET
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
            this.userNameValueLabel = new System.Windows.Forms.Label();
            this.passwordExpiresValueLabel = new System.Windows.Forms.Label();
            this.fullNameValueLabel = new System.Windows.Forms.Label();
            this.alertPanel = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
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
            this.passwordExpiresLabel.Location = new System.Drawing.Point(3, 11);
            this.passwordExpiresLabel.Name = "passwordExpiresLabel";
            this.passwordExpiresLabel.Size = new System.Drawing.Size(693, 25);
            this.passwordExpiresLabel.TabIndex = 2;
            this.passwordExpiresLabel.Text = "Password Expires";
            this.passwordExpiresLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userNameValueLabel
            // 
            this.userNameValueLabel.AutoSize = true;
            this.userNameValueLabel.Location = new System.Drawing.Point(47, 161);
            this.userNameValueLabel.Name = "userNameValueLabel";
            this.userNameValueLabel.Size = new System.Drawing.Size(188, 25);
            this.userNameValueLabel.TabIndex = 3;
            this.userNameValueLabel.Text = "DOMAIN\\Username";
            // 
            // passwordExpiresValueLabel
            // 
            this.passwordExpiresValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordExpiresValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordExpiresValueLabel.ForeColor = System.Drawing.Color.Snow;
            this.passwordExpiresValueLabel.Location = new System.Drawing.Point(3, 33);
            this.passwordExpiresValueLabel.Name = "passwordExpiresValueLabel";
            this.passwordExpiresValueLabel.Size = new System.Drawing.Size(693, 71);
            this.passwordExpiresValueLabel.TabIndex = 4;
            this.passwordExpiresValueLabel.Text = "January 1, 1970";
            this.passwordExpiresValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fullNameValueLabel
            // 
            this.fullNameValueLabel.AutoSize = true;
            this.fullNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameValueLabel.Location = new System.Drawing.Point(47, 132);
            this.fullNameValueLabel.Name = "fullNameValueLabel";
            this.fullNameValueLabel.Size = new System.Drawing.Size(176, 29);
            this.fullNameValueLabel.TabIndex = 8;
            this.fullNameValueLabel.Text = "John Q Public";
            // 
            // alertPanel
            // 
            this.alertPanel.BackColor = System.Drawing.Color.Green;
            this.alertPanel.Controls.Add(this.passwordExpiresValueLabel);
            this.alertPanel.Controls.Add(this.passwordExpiresLabel);
            this.alertPanel.Location = new System.Drawing.Point(2, 2);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.Size = new System.Drawing.Size(699, 104);
            this.alertPanel.TabIndex = 9;
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(44, 207);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(605, 95);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "This is some message text.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(704, 334);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.fullNameValueLabel);
            this.Controls.Add(this.userNameValueLabel);
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
        private System.Windows.Forms.Label userNameValueLabel;
        private System.Windows.Forms.Label passwordExpiresValueLabel;
        private System.Windows.Forms.Label fullNameValueLabel;
        private System.Windows.Forms.Panel alertPanel;
        private System.Windows.Forms.Label messageLabel;
    }
}

