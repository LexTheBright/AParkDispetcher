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
    public partial class DeleteDialog : Form
    {
        public DeleteDialog(string from, string[] agrs)
        {
            InitializeComponent();
            switch (from)
            {
                case "users":
                    textBox1.Text += " пользователя?";
                    break;
                case "drivers":
                    textBox1.Text += " водителя?";
                    break;
                case "cars":
                    textBox1.Text += " автомобиль?";
                    break;
                default:
                    break;
            }
            foreach (var arg in agrs)
            {
                textBox2.Text += arg + " ";
            }
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
        }

        private void User_button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_button_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
