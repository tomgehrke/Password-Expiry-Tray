using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveDirectoryUtilityLibrary;

namespace Pet
{
    public partial class MainForm : Form
    {
        private ActiveDirectoryUser currentActiveDirectoryUser = new ActiveDirectoryUser();
        private WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
        private Priority currentPriority = Priority.None;
        private Settings settings = new Settings();

        private enum Priority
        {
            Unknown, None, Low, Medium, High
        }

        public MainForm()
        {
            InitializeComponent();
            string[] userNameParts = currentIdentity.Name.Split('\\');
            currentActiveDirectoryUser.Domain = userNameParts[0];
            currentActiveDirectoryUser.UserName = userNameParts[1];
            RefreshForm();
            //MessageBox.Show(activeDirectoryUser.ToString());
        }

        private void RefreshForm()
        {
            // Get current user info
            currentActiveDirectoryUser.Update();

            // Update user info components
            UserNameValueLabel.Text = String.Format("{0}", currentIdentity.Name);
            FullNameValueLabel.Text = currentActiveDirectoryUser.FullName;
            PasswordExpiresValueLabel.Text = String.Format("{0:dddd, MMMM dd, yyyy}", currentActiveDirectoryUser.PasswordExpirationDate);

            StringBuilder messageStringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(currentActiveDirectoryUser.FirstName))
            {
                messageStringBuilder.AppendFormat("{0}, y", currentActiveDirectoryUser.FirstName);
            }
            else
            {
                messageStringBuilder.Append("Y");
            }

            messageStringBuilder.AppendFormat("ou are logged in with a {0} account. ", currentActiveDirectoryUser.Context);

            if (currentActiveDirectoryUser.PasswordRequired)
            {
                currentPriority = Priority.Low;
                messageStringBuilder.AppendFormat("Your password was last changed on {0:d} at {0:t}. You have {1} days until you will need to change it. ", currentActiveDirectoryUser.PasswordLastChangedDate, (currentActiveDirectoryUser.PasswordExpirationDate - DateTime.Now).Days);
            }
            else
            {
                currentPriority = Priority.None;
                messageStringBuilder.Append("You do not required a password.");
            }

            messageLabel.Text = messageStringBuilder.ToString();

            switch (currentPriority)
            {
                case Priority.Low:
                    alertPanel.BackColor = Color.Green;
                    break;
                case Priority.Medium:
                    alertPanel.BackColor = Color.Yellow;
                    break;
                case Priority.High:
                    alertPanel.BackColor = Color.Red;
                    break;
                default:
                    alertPanel.BackColor = Color.Gray;
                    break;
            }

            // Update settings related components
            ChangePasswordButton.Visible = !(String.IsNullOrEmpty(settings.Action));

            if (ChangePasswordButton.Visible)
            {
                this.Height = 420;
            }
            else
            {
                this.Height = 320;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void MainNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == false)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsForm = new SettingsForm();
            MainContextMenuStrip.Enabled = false;
            settingsForm.ShowDialog();
            settings.Load();
            MainContextMenuStrip.Enabled = true;
        }

        private void CheckExpirationTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}