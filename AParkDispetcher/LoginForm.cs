using System;
using System.Windows.Forms;

namespace AParkDispetcher
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            if (!AppUser.ISsignedIn)
            {
                AppUser.getConnInstance().TryToLogin(Login_textbox.Text, Pass_textbox.Text);
            }
            if (AppUser.ISsignedIn)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void SloseButton_Click(object sender, EventArgs e)
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
                LogButton_Click(sender, e);
            }
        }
    }
}
