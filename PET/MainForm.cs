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
        private ActiveDirectoryUser user = new ActiveDirectoryUser();

        public MainForm()
        {
            InitializeComponent();
            WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
            string[] userNameParts = currentIdentity.Name.Split('\\');
            user.Domain = userNameParts[0];
            user.UserName = userNameParts[1];
            user.Update();

            userNameValueLabel.Text = String.Format("{0}\\{1}", user.Domain, user.UserName);
            passwordExpiresValueLabel.Text = String.Format("{0:D}", user.PasswordExpirationDate);
            passwordLastChangedValueLabel.Text = String.Format("{0:D}", user.PasswordLastChangedDate);
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
            if (this.WindowState==FormWindowState.Minimized)
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
