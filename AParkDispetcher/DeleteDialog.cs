using System;
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
                case "tasks":
                    ActionText.Text = "Отменить заявку?";
                    this.Text = "Отмена заявки";
                    break;
                case "users":
                    ActionText.Text += " пользователя?";
                    this.Text = "Удаление пользователя";
                    break;
                case "drivers":
                    ActionText.Text += " водителя?";
                    this.Text = "Удаление водителя";
                    break;
                case "cars":
                    ActionText.Text += " автомобиль?";
                    this.Text = "Удаление автомобиля";
                    break;
                default:
                    break;
            }
            foreach (var arg in agrs)
            {
                MessageText.Text += arg + "\r\n";
            }
            MessageText.Text = MessageText.Text.Remove(MessageText.Text.Length - 2);
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
