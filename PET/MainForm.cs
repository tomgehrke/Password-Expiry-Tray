using ActiveDirectoryUtilityLibrary;

using System;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

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
        private DateTime LastNotified;
        private Priority CurrentPriority = Priority.Unknown;

        // Alert priorities
        private enum Priority
        {
            Unknown, None, Warn, Alert
        }

        public MainForm()
        {
            InitializeComponent();
            Font = SystemFonts.DefaultFont;

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
            DateTime currentTime = DateTime.Now;
            DateTime lastChecked = currentTime;
            bool priorityChanged = false;

            // Get current user info
            currentActiveDirectoryUser.Update();

            // Create "report"
            PasswordExpiresValueLabel.Text = String.Format("{0:dddd, MMMM dd, yyyy}", currentActiveDirectoryUser.PasswordExpirationDate);

            StringBuilder messageStringBuilder = new StringBuilder("<html><head></head><body>");

            messageStringBuilder.AppendFormat("<p><b>{0}</b> ({1}), you are logged in with a <i>{2}</i> account.</p>", currentIdentity.Name, currentActiveDirectoryUser.FullName, currentActiveDirectoryUser.Context);

            if (currentActiveDirectoryUser.PasswordRequired)
            {
                if (currentActiveDirectoryUser.PasswordNeverExpires)
                {
                    CurrentPriority = Priority.Unknown;
                    messageStringBuilder.Append("<p>Your password never expires.</p>");
                }
                else
                {
                    Priority originalPriority = CurrentPriority;
                    CurrentPriority = GetCurrentPriority(currentTime);
                    priorityChanged = !(originalPriority == CurrentPriority);
                    messageStringBuilder.AppendFormat("<p>Your password was last changed on {0:d} at {0:t}. You have <b>{1}</b> days until it will need to be changed.</p>", currentActiveDirectoryUser.PasswordLastChangedDate, (currentActiveDirectoryUser.PasswordExpirationDate - currentTime).Days);
                }
            }
            else
            {
                CurrentPriority = Priority.Unknown;
                messageStringBuilder.Append("<p>You do not required a password.</p>");
            }

            messageStringBuilder.AppendFormat("<p>Password last checked on {0:d} at {0:t}</p>", lastChecked);
            messageStringBuilder.Append("</body></html>");

            // Update status area (web browser)
            messageWebBrowser.Navigate("about:blank");
            messageWebBrowser.Document.OpenNew(false);
            messageWebBrowser.Document.Write(messageStringBuilder.ToString());
            messageWebBrowser.Refresh();

            switch (CurrentPriority)
            {
                case Priority.None:
                    alertPanel.BackColor = Color.Green;
                    passwordExpiresLabel.ForeColor = Color.LightGray;
                    PasswordExpiresValueLabel.ForeColor = Color.White;
                    MainNotifyIcon.Icon = Properties.Resources.pWhite;
                    break;
                case Priority.Warn:
                    alertPanel.BackColor = Color.Yellow;
                    passwordExpiresLabel.ForeColor = Color.DimGray;
                    PasswordExpiresValueLabel.ForeColor = Color.Black;
                    MainNotifyIcon.Icon = Properties.Resources.pYellow;
                    break;
                case Priority.Alert:
                    alertPanel.BackColor = Color.Red;
                    passwordExpiresLabel.ForeColor = Color.LightGray;
                    PasswordExpiresValueLabel.ForeColor = Color.LightYellow;
                    MainNotifyIcon.Icon = Properties.Resources.pRed;
                    break;
                default:
                    alertPanel.BackColor = Color.Gray;
                    passwordExpiresLabel.ForeColor = Color.LightGray;
                    PasswordExpiresValueLabel.ForeColor = Color.White;
                    MainNotifyIcon.Icon = Properties.Resources.pBlack;
                    break;
            }

            // Update settings related components
            ChangePasswordButton.Visible = !String.IsNullOrEmpty(settings.Action);

            // Check notification status
            if (priorityChanged || NotificationRequired(currentTime))
            {
                ShowNotification();
                LastNotified = currentTime;
            }
        }

        private void ShowNotification()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void HideNotification()
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private Priority GetCurrentPriority(DateTime currentTime)
        {
            Priority priority = Priority.None;

            if ((currentActiveDirectoryUser.PasswordExpirationDate - currentTime).Days <= settings.WarnThreshold)
            {
                priority = Priority.Warn;
                if ((currentActiveDirectoryUser.PasswordExpirationDate - currentTime).Days <= settings.AlertThreshold)
                {
                    priority = Priority.Alert;
                }
            }

            return priority;
        }

        private bool NotificationRequired(DateTime currentTime)
        {
            bool notificationRequired = false;

            switch (CurrentPriority)
            {
                case Priority.Unknown:
                    notificationRequired = false;
                    break;
                case Priority.None:
                    notificationRequired = false;
                    break;
                case Priority.Warn:
                    if ((LastNotified - currentTime).Hours >= settings.WarnThreshold) { notificationRequired = true; }
                    break;
                case Priority.Alert:
                    if ((LastNotified - currentTime).Hours >= settings.AlertInterval) { notificationRequired = true; }
                    break;
                default:
                    break;
            }

            return notificationRequired;
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
                ShowNotification();
            }
            else
            {
                HideNotification();
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
                HideNotification();
            }
        }

        private void updateNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}