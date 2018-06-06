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
        // Application settings object
        private Settings settings = new Settings();

        // Identity objects
        private ActiveDirectoryUser currentActiveDirectoryUser = new ActiveDirectoryUser();
        private WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();

        // Current alert states
        private DateTime LastChecked;
        private Priority currentPriority = Priority.Unknown;

        // Alert priorities
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

            // Kick off the timer
            CheckExpirationTimer.Enabled = true;
            CheckExpirationTimer.Start();
        }

        private void RefreshSettings()
        {
            settings.Load();
            CheckExpirationTimer.Interval = settings.TimerInterval * 60000;
        }

        private void RefreshForm()
        {

            // Get current user info
            currentActiveDirectoryUser.Update();
            LastChecked = DateTime.Now;

            // Create "report"
            PasswordExpiresValueLabel.Text = String.Format("{0:dddd, MMMM dd, yyyy}", currentActiveDirectoryUser.PasswordExpirationDate);

            StringBuilder messageStringBuilder = new StringBuilder("<html><head></head><body>");

            messageStringBuilder.AppendFormat("<p><b>{0}</b> ({1}), you are logged in with a <i>{2}</i> account.</p>", currentIdentity.Name, currentActiveDirectoryUser.FullName, currentActiveDirectoryUser.Context);

            if (currentActiveDirectoryUser.PasswordRequired)
            {
                currentPriority = Priority.Low;
                messageStringBuilder.AppendFormat("<p>Your password was last changed on {0:d} at {0:t}. You have <b>{1}</b> days until it will need to be changed.</p>", currentActiveDirectoryUser.PasswordLastChangedDate, (currentActiveDirectoryUser.PasswordExpirationDate - DateTime.Now).Days);
            }
            else
            {
                currentPriority = Priority.None;
                messageStringBuilder.Append("<p>You do not required a password.</p>");
            }

            messageStringBuilder.AppendFormat("<p>Password last checked on {0:d} at {0:t}</p>", LastChecked);
            messageStringBuilder.Append("</body></html>");

            // Update status area (web browser)
            messageWebBrowser.Navigate("about:blank");
            messageWebBrowser.Document.OpenNew(false);
            messageWebBrowser.Document.Write(messageStringBuilder.ToString());
            messageWebBrowser.Refresh();

            switch (currentPriority)
            {
                case Priority.Low:
                    alertPanel.BackColor = Color.Green;
                    alertPanel.ForeColor = Color.White;
                    break;
                case Priority.Medium:
                    alertPanel.BackColor = Color.Yellow;
                    alertPanel.ForeColor = Color.Black;
                    break;
                case Priority.High:
                    alertPanel.BackColor = Color.Red;
                    alertPanel.ForeColor = Color.LightYellow;
                    break;
                default:
                    alertPanel.BackColor = Color.Gray;
                    alertPanel.ForeColor = Color.White;
                    break;
            }

            // Update settings related components
            ChangePasswordButton.Visible = !String.IsNullOrEmpty(settings.Action);

            if (ChangePasswordButton.Visible)
            {
                this.Height = 420;
            }
            else
            {
                this.Height = 360;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshSettings();
            RefreshForm();

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
            MainContextMenuStrip.Enabled = true;
            RefreshSettings();
            RefreshForm();
        }

        private void CheckExpirationTimer_Tick(object sender, EventArgs e)
        {
            RefreshForm();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(settings.Action);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PET Error!");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void updateNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}