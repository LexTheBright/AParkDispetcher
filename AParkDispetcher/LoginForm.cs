using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AParkDispetcher
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if (!AppUser.iSsignedIn)
            {
                AppUser.getConnInstance().tryToLogin(Login_textbox.Text, Pass_textbox.Text);
            } 
            if (AppUser.iSsignedIn)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void sloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Pass_textbox.Focus();
            }
        }

        private void Pass_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                logButton_Click(sender, e);
            }
        }
    }
}
