using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AParkDispetcher
{
    public partial class AdminRolesFrom : Form
    {
        Disp_user DU ;
        Disp_driver DD ;
        Disp_car DC;
        AdminDBRedactor ADBR;

        public Dictionary<string, string> tempArgs = new Dictionary<string, string>();

        public AdminRolesFrom()
        {
            InitializeComponent();
        }


        private void endingEvent(string tab)
        {
            switch (tab)
            {
                case "user":
                    AdminUsersGrid.Enabled = true;

                    int start_index = AdminUsersGrid.SelectedCells[0].RowIndex;
                    AdminUsersGrid.Rows.Clear();
                    DU.fillAdminsUserGrid(AdminUsersGrid);
                    AdminUsersGrid.Rows[start_index].Selected = true;

                    User_button_delete.Enabled = true;
                    User_button_edit.Enabled = true;
                    User_button_add.Enabled = true;
                    User_button_cancel.Enabled = false;
                    User_button_save.Enabled = false;

                    User_button_delete.BackColor = Color.White;
                    User_button_edit.BackColor = Color.White;
                    User_button_add.BackColor = Color.White;
                    User_button_cancel.BackColor = Color.Tan;
                    User_button_save.BackColor = Color.Tan;

                    user_FIO_textbox.BackColor = Color.Linen;
                    user_tab_textbox.BackColor = Color.Linen;

                    user_role_textbox.BackColor = Color.Linen;
                    login_place.BackColor = Color.Linen;
                    password_place.BackColor = Color.Linen;

                    user_FIO_textbox.ReadOnly = true;
                    user_role_textbox.ReadOnly = true;
                    login_place.ReadOnly = true;
                    password_place.ReadOnly = true;

                    admin_users_role.Visible = false;
                    user_role_textbox.Visible = true;

                    //AdminUsersGrid.SelectAll();
                    dataGridView1_SelectionChanged(User_button_cancel, new EventArgs());
                    break;
                default:
                    break;
            }
           
        }

        private void AdminRolesFrom_Load(object sender, EventArgs e)
        {
            DU = new Disp_user();
            DD = new Disp_driver();
            DC = new Disp_car();
            ADBR = new AdminDBRedactor();

            DU.fillAdminsUserGrid(AdminUsersGrid);
            DD.fillAdminsDriverGrid(AdminDriversGrid);
            DC.fillAdminsCarGrid(AdminCarsGrid);
            DC.fillTypes(comboBox2);
        }


        private void searchTasks_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (AdminUsersGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = AdminUsersGrid.SelectedCells[0].RowIndex;
                string FIO = AdminUsersGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
                string Tab_num = AdminUsersGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
                string Role = AdminUsersGrid.Rows[selectedrowindex].Cells[2].Value.ToString();
                //int RoleNum = Int32.TryParse(Role);
                string Login = AdminUsersGrid.Rows[selectedrowindex].Cells[3].Value.ToString();
                //string[] splited_FIO = FIO.Split(' ');

                user_FIO_textbox.Text = FIO;
                user_tab_textbox.Text = Tab_num;
                //comboBox1.Text = Role;
                if (Role == "Пользователь") admin_users_role.SelectedIndex = 0;
                if (Role == "Оператор") admin_users_role.SelectedIndex = 1;
                if (Role == "Администратор") admin_users_role.SelectedIndex = 2;
                login_place.Text = Login;
                password_place.Text = "********";
                user_role_textbox.Text = Role;
                //textBox2.Text = Role;
                //textBox3.Text = Login;
            }

            //string nameses = dataGridView1.CurrentRow.cek;
            //textBox1.Text = dataGridView1.CurrentRow.Cells[1].;
            /*int rowNum = 1;
            DataGridViewCell cell = dataGridView1.Rows[rowNum].Cells[0];
            dataGridView1.CurrentCell = cell;
            dataGridView1.CurrentCell.Selected = true;*/
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (AdminDriversGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = AdminDriversGrid.SelectedCells[0].RowIndex;
                string FIO = AdminDriversGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
                string Tab_num = AdminDriversGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
                string State = AdminDriversGrid.Rows[selectedrowindex].Cells[2].ToString();
                //string[] splited_FIO = FIO.Split(' ');

                textBox8.Text = FIO;
                textBox7.Text = Tab_num;
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (AdminDriversGrid.Rows[e.RowIndex].MinimumHeight != 35) AdminDriversGrid.Rows[e.RowIndex].MinimumHeight = 35;

            switch (e.Value)
            {
                case "Отсутствует":
                    e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.SelectionBackColor = Color.Gray;
                    break;
                case "Работает":
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.SelectionBackColor = Color.Green;
                    break;
                case "Занят":
                    e.CellStyle.BackColor = Color.LightYellow;
                    e.CellStyle.SelectionBackColor = Color.Orange;
                    break;
                default:
                    break;
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AdminUsersGrid.Rows.Clear();
            DU.fillAdminsUserGrid(AdminUsersGrid);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            AdminDriversGrid.Rows.Clear();
            DD.fillAdminsDriverGrid(AdminDriversGrid);
        }


        private void tabPage3_Enter(object sender, EventArgs e)
        {
            AdminCarsGrid.Rows.Clear();
            DC.fillAdminsCarGrid(AdminCarsGrid);
        }

        private void tabPage3_Leave(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            DC.fillTypes(comboBox2);
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (AdminCarsGrid.Rows[e.RowIndex].MinimumHeight != 35) AdminCarsGrid.Rows[e.RowIndex].MinimumHeight = 35;

            switch (e.Value)
            {
                case "Не доступна":
                    e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.SelectionBackColor = Color.Gray;
                    break;
                case "Доступна":
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.SelectionBackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (AdminCarsGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = AdminCarsGrid.SelectedCells[0].RowIndex;
                string reg_mark = AdminCarsGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
                string model = AdminCarsGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
                string type = AdminCarsGrid.Rows[selectedrowindex].Cells[2].Value.ToString(); 
                string color = AdminCarsGrid.Rows[selectedrowindex].Cells[3].Value.ToString();


                /*Disp_car DC = new Disp_car();
                DC.fillCar(dataGridView3, 1);
                DC.fillTypes(comboBox2);*/

                string temp_check = DC.usr.FirstOrDefault(x => x.reg_mark == reg_mark).reg_mark;
                string description = "";
                if (reg_mark == temp_check)
                {
                    description = DC.usr.FirstOrDefault(x => x.reg_mark == reg_mark).description;
                }
                //string[] splited_FIO = FIO.Split(' ');

                textBox12.Text = reg_mark;
                textBox13.Text = model;
                textBox3.Text = type;
                textBox6.Text = color;
                textBox11.Text = description;

                comboBox2.SelectedItem = DC.types.FirstOrDefault(x => x.Key == type).Key; //DC.types[type].Key;

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessTabKey(true);
            //SendKeys.Send("{TAB}");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (AdminUsersGrid.Rows[e.RowIndex].MinimumHeight != 35) AdminUsersGrid.Rows[e.RowIndex].MinimumHeight = 35;
        }

        private void User_button_delete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = AdminUsersGrid.SelectedCells[0].RowIndex;
            string[] user_args = new string[2];
            user_args[0] = AdminUsersGrid.Rows[selectedrowindex].Cells[0].Value.ToString() + "\r\n";
            user_args[1] = "(" +AdminUsersGrid.Rows[selectedrowindex].Cells[1].Value.ToString() + ")";

            DeleteDialog newDialog = new DeleteDialog("users", user_args);

            string dqd = " kekw, ";

            if (newDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dqd.Remove(dqd.Length - 2));
            }
        }

        private void User_button_edit_Click(object sender, EventArgs e)
        {
            //tabControl1.TabPages[0].Focus();
            password_place.Focus();

            AdminUsersGrid.Enabled = false;
            login_place.ReadOnly = false;
            login_place.BackColor = Color.PaleGreen;
            password_place.ReadOnly = false;
            password_place.BackColor = Color.PaleGreen;
            user_FIO_textbox.ReadOnly = false;
            user_FIO_textbox.BackColor = Color.PaleGreen;
            admin_users_role.Visible = true;
            user_role_textbox.Visible = false;


            User_button_delete.Enabled = false;
            User_button_edit.Enabled = false;
            User_button_add.Enabled = false;
            User_button_delete.BackColor = Color.Tan;
            User_button_edit.BackColor = Color.Tan;
            User_button_add.BackColor = Color.Tan;

            User_button_cancel.Enabled = true;
            User_button_save.Enabled = true;
            User_button_cancel.BackColor = Color.White;
            User_button_save.BackColor = Color.White;

            tempArgs.Add("login", login_place.Text);
            password_place.Text = "";
            tempArgs.Add("FIO", user_FIO_textbox.Text);
        }

        private void User_button_cancel_Click(object sender, EventArgs e)
        {
            endingEvent("user");
            tempArgs.Clear();
        }

        private void User_button_save_Click(object sender, EventArgs e)
        {
            //tabControl1.TabPages[0].Focus();
            password_place.Focus();

            Dictionary<string, string> properties = new Dictionary<string, string>();

            if (admin_users_role.SelectedItem.ToString() != user_role_textbox.Text) 
            {
                properties.Add("user_role_id", admin_users_role.SelectedIndex.ToString());
            }

            if (login_place.Text != tempArgs["login"])
            {
                string error_message = IsValidFunc("login", login_place.Text.ToString());
                if (error_message != null)
                {
                    MessageBox.Show(error_message);
                    return;
                }
                else
                {
                    //MessageBox.Show("прошло");
                    properties.Add("login", login_place.Text);
                }
            } 


            if (password_place.Text.Length > 0)
            {
                //string dsqdpi = password_place.
                string error_message = IsValidFunc("password", password_place.Text.ToString());
                if (error_message != null)
                {
                    MessageBox.Show(error_message);
                    return;
                }
                else
                {
                    //MessageBox.Show("прошло");
                    properties.Add("password", password_place.Text);
                }
            } 


            if (user_FIO_textbox.Text != tempArgs["FIO"])
            {
                string error_message = IsValidFunc("FIO", user_FIO_textbox.Text.ToString());
                if (error_message != null)
                {
                    MessageBox.Show(error_message);
                    return;
                }
                else
                {
                    string[] splited_FIO = user_FIO_textbox.Text.Split(' '); 
                    if (splited_FIO.Length > 3)
                    {
                        for (int i = 3; i < splited_FIO.Length; i++) splited_FIO[2] += splited_FIO[i];
                    }
                    //MessageBox.Show("прошло");
                    properties.Add("user_surname", splited_FIO[0]);
                    properties.Add("user_name", splited_FIO[1]);
                    properties.Add("user_midname", splited_FIO[2]);
                }
            } 


            if (properties.Count > 0 && user_tab_textbox.ReadOnly)
            {
                ADBR.updateByID("users", "tab_number", user_tab_textbox.Text, properties);
            }
            endingEvent("user");
            tempArgs.Clear();
        }

        private string IsValidFunc(string field_name, string expr)
        {
            string pattern = "";
            string vlid_error = "";
            switch (field_name)
            {
                case "login":
                    pattern = @"^[A-Za-z0-9]{8,15}$";
                    vlid_error = "Неверный логин! Логин должен состоять только из букв латинского алфавита и цифр. А также должен содержать от 8 до 15 символов.";
                    break;
                case "password":
                    pattern = @"^[A-Za-z0-9]{8,20}$";
                    vlid_error = "Неверный пароль! Пароль должен состоять только из букв латинского алфавита и цифр. А также должен содержать от 8 до 20 символов.";
                    break;
                case "FIO":
                    pattern = @"\w*\s\w*\s\w*";
                    vlid_error = "Ошибка! ФИО должно содержать от 10 до 150 символов";
                    break;
                default:
                    break;
            }

            if (Regex.IsMatch(expr, pattern/*, RegexOptions.IgnoreCase*/)) { return null; }
            else
            {
                return vlid_error;
            }
        }
    }
}
