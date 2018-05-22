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

namespace PET
{
    public partial class MainForm : Form
    {
        private ActiveDirectoryUser activeDirectoryUser = new ActiveDirectoryUser();
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
            activeDirectoryUser.Domain = userNameParts[0];
            activeDirectoryUser.UserName = userNameParts[1];
            RefreshForm();
            MessageBox.Show(activeDirectoryUser.ToString());
        }

        private void RefreshForm()
        {
            activeDirectoryUser.Update();

            userNameValueLabel.Text = String.Format("{0}", currentIdentity.Name);
            fullNameValueLabel.Text = activeDirectoryUser.FullName;
            passwordExpiresValueLabel.Text = String.Format("{0}", activeDirectoryUser.PasswordExpirationDate);

            StringBuilder messageStringBuilder = new StringBuilder();

            if (activeDirectoryUser.FirstName != "")
            {
                messageStringBuilder.AppendFormat("{0}, y", activeDirectoryUser.FirstName);
            }
            else
            {
                messageStringBuilder.Append("Y");
            }

            messageStringBuilder.AppendFormat("ou are logged in with a {0} account. ", activeDirectoryUser.Context);

            if (activeDirectoryUser.PasswordRequired)
            {
                currentPriority = Priority.Low;
                messageStringBuilder.AppendFormat("Your password was last changed on {0:d} at {0:t}. You have {1} days until you will need to change it. ", activeDirectoryUser.PasswordLastChangedDate, (activeDirectoryUser.PasswordExpirationDate - DateTime.Now).Days);
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
            }
        }
    }
}
