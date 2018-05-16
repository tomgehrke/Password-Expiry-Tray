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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordExpiresLabel = new System.Windows.Forms.Label();
            this.userNameValueLabel = new System.Windows.Forms.Label();
            this.passwordExpiresValueLabel = new System.Windows.Forms.Label();
            this.passwordLastChangedValueLabel = new System.Windows.Forms.Label();
            this.passwordLastSetLabel = new System.Windows.Forms.Label();
            this.fullNameValueLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.MainContextMenuStrip.SuspendLayout();
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
            this.MainContextMenuStrip.Size = new System.Drawing.Size(182, 106);
            // 
            // updateNowToolStripMenuItem
            // 
            this.updateNowToolStripMenuItem.Name = "updateNowToolStripMenuItem";
            this.updateNowToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.updateNowToolStripMenuItem.Text = "Update now";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.settingsToolStripMenuItem.Text = "Settings...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
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
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(33, 46);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(108, 25);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Username:";
            // 
            // passwordExpiresLabel
            // 
            this.passwordExpiresLabel.AutoSize = true;
            this.passwordExpiresLabel.Location = new System.Drawing.Point(33, 71);
            this.passwordExpiresLabel.Name = "passwordExpiresLabel";
            this.passwordExpiresLabel.Size = new System.Drawing.Size(174, 25);
            this.passwordExpiresLabel.TabIndex = 2;
            this.passwordExpiresLabel.Text = "Password Expires:";
            // 
            // userNameValueLabel
            // 
            this.userNameValueLabel.AutoSize = true;
            this.userNameValueLabel.Location = new System.Drawing.Point(213, 46);
            this.userNameValueLabel.Name = "userNameValueLabel";
            this.userNameValueLabel.Size = new System.Drawing.Size(188, 25);
            this.userNameValueLabel.TabIndex = 3;
            this.userNameValueLabel.Text = "DOMAIN\\Username";
            // 
            // passwordExpiresValueLabel
            // 
            this.passwordExpiresValueLabel.AutoSize = true;
            this.passwordExpiresValueLabel.Location = new System.Drawing.Point(213, 71);
            this.passwordExpiresValueLabel.Name = "passwordExpiresValueLabel";
            this.passwordExpiresValueLabel.Size = new System.Drawing.Size(153, 25);
            this.passwordExpiresValueLabel.TabIndex = 4;
            this.passwordExpiresValueLabel.Text = "January 1, 1970";
            // 
            // passwordLastSetValueLabel
            // 
            this.passwordLastChangedValueLabel.AutoSize = true;
            this.passwordLastChangedValueLabel.Location = new System.Drawing.Point(213, 96);
            this.passwordLastChangedValueLabel.Name = "passwordLastSetValueLabel";
            this.passwordLastChangedValueLabel.Size = new System.Drawing.Size(153, 25);
            this.passwordLastChangedValueLabel.TabIndex = 6;
            this.passwordLastChangedValueLabel.Text = "January 1, 1970";
            // 
            // passwordLastSetLabel
            // 
            this.passwordLastSetLabel.AutoSize = true;
            this.passwordLastSetLabel.Location = new System.Drawing.Point(33, 96);
            this.passwordLastSetLabel.Name = "passwordLastSetLabel";
            this.passwordLastSetLabel.Size = new System.Drawing.Size(181, 25);
            this.passwordLastSetLabel.TabIndex = 5;
            this.passwordLastSetLabel.Text = "Password Last Set:";
            // 
            // fullNameValueLabel
            // 
            this.fullNameValueLabel.AutoSize = true;
            this.fullNameValueLabel.Location = new System.Drawing.Point(213, 21);
            this.fullNameValueLabel.Name = "fullNameValueLabel";
            this.fullNameValueLabel.Size = new System.Drawing.Size(135, 25);
            this.fullNameValueLabel.TabIndex = 8;
            this.fullNameValueLabel.Text = "John Q Public";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(33, 21);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(106, 25);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 152);
            this.Controls.Add(this.fullNameValueLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.passwordLastChangedValueLabel);
            this.Controls.Add(this.passwordLastSetLabel);
            this.Controls.Add(this.passwordExpiresValueLabel);
            this.Controls.Add(this.userNameValueLabel);
            this.Controls.Add(this.passwordExpiresLabel);
            this.Controls.Add(this.userNameLabel);
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
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordExpiresLabel;
        private System.Windows.Forms.Label userNameValueLabel;
        private System.Windows.Forms.Label passwordExpiresValueLabel;
        private System.Windows.Forms.Label passwordLastChangedValueLabel;
        private System.Windows.Forms.Label passwordLastSetLabel;
        private System.Windows.Forms.Label fullNameValueLabel;
        private System.Windows.Forms.Label fullNameLabel;
    }
}

