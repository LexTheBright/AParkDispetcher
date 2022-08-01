using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AParkDispetcher
{
    public partial class AdminRolesFrom : Form
    {
        Users_list DU;
        Drivers_list DD;
        Cars_list DC;
        DBRedactor ADBR;

        public Dictionary<string, string> tempArgs = new Dictionary<string, string>();

        private static bool IsTabSelectingActive = true;

        public AdminRolesFrom()
        {
            InitializeComponent();
        }

        private void EndingEvent(string tab)
        {
            IsTabSelectingActive = true;
            switch (tab)
            {
                case "user":
                    AdminUsersGrid.Enabled = true;

                    int savedIndex = AdminUsersGrid.SelectedCells[0].RowIndex;

                    AdminUsersGrid.Rows.Clear();
                    DU.FillAdminsUserGrid(AdminUsersGrid);
                    if (savedIndex < AdminUsersGrid.RowCount) AdminUsersGrid.Rows[savedIndex].Selected = true;

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
                    user_tab_textbox.ReadOnly = true;

                    admin_users_role.Visible = false;
                    user_role_textbox.Visible = true;

                    AdminUsersGrid_SelectionChanged(User_button_cancel, new EventArgs());
                    break;

                case "driver":
                    AdminDriversGrid.Enabled = true;

                    int start_index_dr = AdminDriversGrid.SelectedCells[0].RowIndex;
                    AdminDriversGrid.Rows.Clear();
                    DD.FillAdminsDriverGrid(AdminDriversGrid);
                    if (start_index_dr < AdminDriversGrid.RowCount) AdminDriversGrid.Rows[start_index_dr].Selected = true;

                    Driver_button_delete.Enabled = true;
                    Driver_button_add.Enabled = true;
                    Driver_button_cancel.Enabled = false;
                    Driver_button_save.Enabled = false;

                    Driver_button_delete.BackColor = Color.White;
                    Driver_button_add.BackColor = Color.White;
                    Driver_button_cancel.BackColor = Color.Tan;
                    Driver_button_save.BackColor = Color.Tan;
                    driver_FIO_textbox.BackColor = Color.Linen;
                    driver_tab_textbox.BackColor = Color.Linen;

                    driver_FIO_textbox.ReadOnly = true;
                    driver_tab_textbox.ReadOnly = true;

                    AdminDriversGrid_SelectionChanged(Driver_button_cancel, new EventArgs());
                    break;

                case "car":
                    AdminCarsGrid.Enabled = true;

                    int start_index_cr = AdminCarsGrid.SelectedCells[0].RowIndex;
                    AdminCarsGrid.Rows.Clear();
                    DC.FillAdminsCarGrid(AdminCarsGrid);
                    if (start_index_cr < AdminCarsGrid.RowCount) AdminCarsGrid.Rows[start_index_cr].Selected = true;

                    admin_car_type_label.Visible = true;
                    admin_car_type_cbox.Visible = false;

                    //красим области обратно
                    admin_car_mark_label.ReadOnly = true;
                    admin_car_mark_label.BackColor = Color.Linen;
                    admin_car_model_label.ReadOnly = true;
                    admin_car_model_label.BackColor = Color.Linen;
                    admin_car_color_label.ReadOnly = true;
                    admin_car_color_label.BackColor = Color.Linen;
                    admin_car_descr_label.ReadOnly = true;
                    admin_car_descr_label.BackColor = Color.Linen;

                    //красим кнопочки
                    admin_car_add_button.Enabled = true;
                    admin_car_add_button.BackColor = Color.White;
                    admin_car_edit_button.Enabled = true;
                    admin_car_edit_button.BackColor = Color.White;
                    admin_car_delete_button.Enabled = true;
                    admin_car_delete_button.BackColor = Color.White;

                    admin_car_cancel_button.Enabled = false;
                    admin_car_add_save_button.Enabled = false;
                    admin_car_add_save_button.Visible = true;
                    admin_car_edit_save_button.Visible = false;
                    admin_car_cancel_button.BackColor = Color.Tan;
                    admin_car_add_save_button.BackColor = Color.Tan;

                    AdminCarsGrid_SelectionChanged(Driver_button_cancel, new EventArgs());
                    break;
                default:
                    break;
            }

        }

        private void AdminRolesFrom_Load(object sender, EventArgs e)
        {
            DU = new Users_list();
            DD = new Drivers_list();
            DC = new Cars_list();
            ADBR = new DBRedactor();

            DU.FillAdminsUserGrid(AdminUsersGrid);
            DD.FillAdminsDriverGrid(AdminDriversGrid);
            DC.FillAdminsCarGrid(AdminCarsGrid);
            DC.FillTypes(admin_car_type_cbox);
        }


        private void SearchUsers_TextChanged(object sender, EventArgs e)
        {
            AdminUsersGrid.ClearSelection();

            if (string.IsNullOrWhiteSpace(searchUsers.Text))
                return;

            var values = searchUsers.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < AdminUsersGrid.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = AdminUsersGrid.Rows[i];

                    if (row.Cells["SNM_field"].Value.ToString().Contains(value) ||
                        row.Cells["tab__field"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        AdminUsersGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        private void AdminUsersGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (AdminUsersGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = AdminUsersGrid.SelectedCells[0].RowIndex;
                string FIO = AdminUsersGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
                string Tab_num = AdminUsersGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
                string Role = AdminUsersGrid.Rows[selectedrowindex].Cells[2].Value.ToString();
                string Login = AdminUsersGrid.Rows[selectedrowindex].Cells[3].Value.ToString();

                user_FIO_textbox.Text = FIO;
                user_tab_textbox.Text = Tab_num;
                if (Role == "Пользователь") admin_users_role.SelectedIndex = 0;
                if (Role == "Оператор") admin_users_role.SelectedIndex = 1;
                if (Role == "Администратор") admin_users_role.SelectedIndex = 2;
                login_place.Text = Login;
                password_place.Text = "********";
                user_role_textbox.Text = Role;
            }
        }

        private void AdminDriversGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (AdminDriversGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = AdminDriversGrid.SelectedCells[0].RowIndex;
                string FIO = AdminDriversGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
                string Tab_num = AdminDriversGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
                string State = AdminDriversGrid.Rows[selectedrowindex].Cells[2].ToString();

                driver_FIO_textbox.Text = FIO;
                driver_tab_textbox.Text = Tab_num;
            }
        }

        private void AdminDriversGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void UsersPage_Enter(object sender, EventArgs e)
        {
            AdminUsersGrid.Rows.Clear();
            DU.FillAdminsUserGrid(AdminUsersGrid);
        }

        private void DriversPage_Enter(object sender, EventArgs e)
        {
            AdminDriversGrid.Rows.Clear();
            DD.FillAdminsDriverGrid(AdminDriversGrid);
        }

        private void AutosPage_Enter(object sender, EventArgs e)
        {
            AdminCarsGrid.Rows.Clear();
            DC.FillAdminsCarGrid(AdminCarsGrid);
        }

        private void AutosPage_Leave(object sender, EventArgs e)
        {
            admin_car_type_cbox.Items.Clear();
            DC.FillTypes(admin_car_type_cbox);
        }

        private void AdminCarsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
        private void AdminCarsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (AdminCarsGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = AdminCarsGrid.SelectedCells[0].RowIndex;
                string reg_mark = AdminCarsGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
                string model = AdminCarsGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
                string type = AdminCarsGrid.Rows[selectedrowindex].Cells[2].Value.ToString();
                string color = AdminCarsGrid.Rows[selectedrowindex].Cells[3].Value.ToString();

                string temp_check = DC.usr.FirstOrDefault(x => x.reg_mark == reg_mark).reg_mark;
                string description = "";
                if (reg_mark == temp_check)
                {
                    description = DC.usr.FirstOrDefault(x => x.reg_mark == reg_mark).description;
                }

                admin_car_mark_label.Text = reg_mark;
                admin_car_model_label.Text = model;
                admin_car_type_label.Text = type;
                admin_car_color_label.Text = color;
                admin_car_descr_label.Text = description;

                admin_car_type_cbox.SelectedItem = DC.types.FirstOrDefault(x => x.Key == type).Key;
            }
        }

        private void AdminTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessTabKey(true);
        }

        private void AdminUsersGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (AdminUsersGrid.Rows[e.RowIndex].MinimumHeight != 35) AdminUsersGrid.Rows[e.RowIndex].MinimumHeight = 35;
        }

        private void User_button_delete_Click(object sender, EventArgs e)
        {
            if (AdminUsersGrid.SelectedRows.Count == 0) AdminUsersGrid.Rows[0].Selected = true;
            int selectedrowindex = AdminUsersGrid.SelectedCells[0].RowIndex;
            string[] user_args = new string[2];
            user_args[0] = AdminUsersGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
            string tab_n = AdminUsersGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
            user_args[1] = "(" + tab_n + ")";

            DeleteDialog newDialog = new DeleteDialog("users", user_args);

            if (newDialog.ShowDialog() == DialogResult.OK)
            {
                ADBR.DeleteByID("users", "tab_number", tab_n);
                EndingEvent("user");
                if (this.Height > this.MinimumSize.Height + 50) this.Height -= 35;
            }
        }

        private void User_button_edit_Click(object sender, EventArgs e)
        {
            if (AdminUsersGrid.SelectedRows.Count == 0) AdminUsersGrid.Rows[0].Selected = true;
            password_place.Focus();
            IsTabSelectingActive = false;

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
            EndingEvent("user");
            tempArgs.Clear();
        }

        private void User_button_save_Click(object sender, EventArgs e)
        {
            password_place.Focus();

            Dictionary<string, string> properties = new Dictionary<string, string>();

            //табель
            if (!user_tab_textbox.ReadOnly)
            {
                string error_message = ParkDispecter.IsValidValue("Табельный №", user_tab_textbox.Text.ToString());
                if (error_message != null)
                {
                    MessageBox.Show(error_message);
                    return;
                }
                else
                {
                    properties.Add("tab_number", user_tab_textbox.Text);
                }
            }

            //роль
            if (admin_users_role.SelectedItem.ToString() != user_role_textbox.Text)
            {
                properties.Add("user_role_id", admin_users_role.SelectedIndex.ToString());
            }

            //логин
            if (!user_tab_textbox.ReadOnly || login_place.Text != tempArgs["login"])
            {
                string error_message = ParkDispecter.IsValidValue("Логин", login_place.Text.ToString());
                if (error_message != null)
                {
                    MessageBox.Show(error_message);
                    return;
                }
                else
                {
                    properties.Add("login", login_place.Text);
                }
            }

            //пароль
            if (!user_tab_textbox.ReadOnly || password_place.Text.Length > 0)
            {
                string hash = "";
                string error_message = ParkDispecter.IsValidValue("Пароль", password_place.Text.ToString());
                if (error_message != null)
                {
                    MessageBox.Show(error_message);
                    return;
                }
                else
                {
                    using (SHA256 mySHA256 = SHA256.Create())
                    {
                        try
                        {
                            hash = BitConverter.ToString(mySHA256.ComputeHash(Encoding.UTF8.GetBytes(password_place.Text))).Replace("-", "").Substring(0, 32);
                        }
                        catch
                        {
                            MessageBox.Show("Хэширование пароля не удалось. Попробуйте другой пароль.");
                            return;
                        }
                    }
                    properties.Add("password", hash);
                }
            }

            //ФИО
            if (!user_tab_textbox.ReadOnly || user_FIO_textbox.Text != tempArgs["FIO"])
            {
                string error_message = ParkDispecter.IsValidValue("ФИО", user_FIO_textbox.Text.ToString());
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
                    properties.Add("user_surname", splited_FIO[0]);
                    properties.Add("user_name", splited_FIO[1]);
                    properties.Add("user_midname", splited_FIO[2]);
                }
            }

            if (user_tab_textbox.ReadOnly)
            {
                if (properties.Count > 0) ADBR.UpdateByID("users", "tab_number", user_tab_textbox.Text, properties);
            }
            else
            {
                if (properties.ContainsKey("tab_number") && properties.ContainsKey("user_surname") && properties.ContainsKey("login") && properties.ContainsKey("password"))
                {
                    if (!properties.ContainsKey("user_role_id")) properties.Add("user_role_id", admin_users_role.SelectedIndex.ToString());
                    ADBR.CreateNewKouple("users", properties);
                    if (this.Height < Screen.GetWorkingArea(this).Height) this.Height += 35;
                }
            }
            EndingEvent("user");
            tempArgs.Clear();
        }


        private void User_button_add_Click(object sender, EventArgs e)
        {
            user_FIO_textbox.Focus();
            admin_users_role.SelectedIndex = 0;
            AdminUsersGrid.Enabled = false;
            IsTabSelectingActive = false;

            user_tab_textbox.ReadOnly = false;
            user_tab_textbox.BackColor = Color.PaleGreen;
            user_tab_textbox.Clear();
            login_place.ReadOnly = false;
            login_place.Clear();
            login_place.BackColor = Color.PaleGreen;
            password_place.ReadOnly = false;
            password_place.BackColor = Color.PaleGreen;
            password_place.Clear();
            user_FIO_textbox.ReadOnly = false;
            user_FIO_textbox.BackColor = Color.PaleGreen;
            user_FIO_textbox.Clear();
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
        }

        private void Driver_button_add_Click(object sender, EventArgs e)
        {
            driver_FIO_textbox.Focus();
            AdminDriversGrid.Enabled = false;
            IsTabSelectingActive = false;

            driver_FIO_textbox.ReadOnly = false;
            driver_FIO_textbox.BackColor = Color.PaleGreen;
            driver_FIO_textbox.Clear();
            driver_tab_textbox.ReadOnly = false;
            driver_tab_textbox.BackColor = Color.PaleGreen;
            driver_tab_textbox.Clear();

            Driver_button_add.Enabled = false;
            Driver_button_add.BackColor = Color.Tan;
            Driver_button_delete.Enabled = false;
            Driver_button_delete.BackColor = Color.Tan;

            Driver_button_cancel.Enabled = true;
            Driver_button_save.Enabled = true;
            Driver_button_cancel.BackColor = Color.White;
            Driver_button_save.BackColor = Color.White;
        }

        private void Driver_button_delete_Click(object sender, EventArgs e)
        {
            if (AdminDriversGrid.SelectedRows.Count == 0) AdminDriversGrid.Rows[0].Selected = true;
            int selectedrowindex = AdminDriversGrid.SelectedCells[0].RowIndex;
            string[] driver_args = new string[2];
            driver_args[0] = AdminDriversGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
            string tab_n = AdminDriversGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
            driver_args[1] = "(" + tab_n + ")";

            DeleteDialog newDialog = new DeleteDialog("drivers", driver_args);

            if (newDialog.ShowDialog() == DialogResult.OK)
            {
                ADBR.DeleteByID("drivers", "tab_number", tab_n);
                EndingEvent("driver");
                if (this.Height > this.MinimumSize.Height + 50) this.Height -= 35;
            }
        }

        private void Driver_button_cancel_Click(object sender, EventArgs e)
        {
            EndingEvent("driver");
        }

        private void Driver_button_save_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> properties_driver = new Dictionary<string, string>();

            //табель
            string error_message = ParkDispecter.IsValidValue("Табельный №", driver_tab_textbox.Text.ToString());
            if (error_message != null)
            {
                MessageBox.Show(error_message);
                return;
            }
            else
            {
                properties_driver.Add("tab_number", driver_tab_textbox.Text);
            }

            //ФИО
            error_message = ParkDispecter.IsValidValue("ФИО", driver_FIO_textbox.Text.ToString());
            if (error_message != null)
            {
                MessageBox.Show(error_message);
                return;
            }
            else
            {
                string[] splited_FIO = driver_FIO_textbox.Text.Split(' ');
                if (splited_FIO.Length > 3)
                {
                    for (int i = 3; i < splited_FIO.Length; i++) splited_FIO[2] += splited_FIO[i];
                }
                properties_driver.Add("driver_surname", splited_FIO[0]);
                properties_driver.Add("driver_name", splited_FIO[1]);
                properties_driver.Add("driver_midname", splited_FIO[2]);
            }

            if (properties_driver.ContainsKey("tab_number") && properties_driver.ContainsKey("driver_surname"))
            {
                properties_driver.Add("driver_state", "2");
                if (ADBR.CreateNewKouple("drivers", properties_driver) == 1) return;
                if (this.Height < Screen.GetWorkingArea(this).Height - this.Location.Y) this.Height += 35;
            }
            EndingEvent("driver");
        }

        private void Admin_car_add_button_Click(object sender, EventArgs e)
        {
            admin_car_mark_label.Focus();
            AdminCarsGrid.Enabled = false;
            IsTabSelectingActive = false;
            admin_car_type_cbox.SelectedIndex = 0;

            //заменяем лейбл комбобоксом
            admin_car_type_label.Visible = false;
            admin_car_type_cbox.Visible = true;

            //красим области в зеленый
            admin_car_mark_label.ReadOnly = false;
            admin_car_mark_label.BackColor = Color.PaleGreen;
            admin_car_mark_label.Clear();
            admin_car_model_label.ReadOnly = false;
            admin_car_model_label.BackColor = Color.PaleGreen;
            admin_car_model_label.Clear();
            admin_car_color_label.ReadOnly = false;
            admin_car_color_label.BackColor = Color.PaleGreen;
            admin_car_color_label.Clear();
            admin_car_descr_label.ReadOnly = false;
            admin_car_descr_label.BackColor = Color.PaleGreen;
            admin_car_descr_label.Clear();

            //красим кнопочки
            admin_car_add_button.Enabled = false;
            admin_car_add_button.BackColor = Color.Tan;
            admin_car_edit_button.Enabled = false;
            admin_car_edit_button.BackColor = Color.Tan;
            admin_car_delete_button.Enabled = false;
            admin_car_delete_button.BackColor = Color.Tan;

            admin_car_cancel_button.Enabled = true;
            admin_car_add_save_button.Enabled = true;
            admin_car_cancel_button.BackColor = Color.White;
            admin_car_add_save_button.BackColor = Color.White;
        }

        private void Admin_car_edit_button_Click(object sender, EventArgs e)
        {
            if (AdminCarsGrid.SelectedRows.Count == 0) AdminCarsGrid.Rows[0].Selected = true;
            admin_car_descr_label.Focus();
            AdminCarsGrid.Enabled = false;
            IsTabSelectingActive = false;

            //красим области в зеленый
            admin_car_descr_label.ReadOnly = false;
            admin_car_descr_label.BackColor = Color.PaleGreen;

            //красим кнопочки
            admin_car_add_button.Enabled = false;
            admin_car_add_button.BackColor = Color.Tan;
            admin_car_edit_button.Enabled = false;
            admin_car_edit_button.BackColor = Color.Tan;
            admin_car_delete_button.Enabled = false;
            admin_car_delete_button.BackColor = Color.Tan;

            admin_car_cancel_button.Enabled = true;
            admin_car_add_save_button.Visible = false;
            admin_car_edit_save_button.Enabled = true;
            admin_car_edit_save_button.Visible = true;
            admin_car_cancel_button.BackColor = Color.White;
        }

        private void Admin_car_delete_button_Click(object sender, EventArgs e)
        {
            if (AdminCarsGrid.SelectedRows.Count == 0) AdminCarsGrid.Rows[0].Selected = true;
            int selectedrowindex = AdminCarsGrid.SelectedCells[0].RowIndex;
            string[] car_args = new string[2];
            car_args[0] = AdminCarsGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
            string mark_n = AdminCarsGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
            car_args[1] = "(" + mark_n + ")";

            DeleteDialog newDialog = new DeleteDialog("cars", car_args);

            if (newDialog.ShowDialog() == DialogResult.OK)
            {
                ADBR.DeleteByID("cars", "reg_mark", mark_n);
                EndingEvent("car");
                if (this.Height > this.MinimumSize.Height + 50) this.Height -= 35;
            }
        }

        private void Admin_car_cancel_button_Click(object sender, EventArgs e)
        {
            EndingEvent("car");
        }

        private void Admin_car_edit_save_button_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> car_properties = new Dictionary<string, string>();

            {
                string error_mese = ParkDispecter.IsValidValue("Описание", admin_car_descr_label.Text, false);
                if (error_mese != null)
                {
                    MessageBox.Show(error_mese);
                    return;
                }
                else
                {
                    car_properties.Add("description", admin_car_descr_label.Text);
                    ADBR.UpdateByID("cars", "reg_mark", admin_car_mark_label.Text, car_properties);
                    EndingEvent("car");
                }
            }

        }

        private void Admin_car_add_save_button_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> add_car_properties = new Dictionary<string, string>();
            string error_message;

            //Проверка номера авто
            error_message = ParkDispecter.IsValidValue("Номер", admin_car_mark_label.Text.ToString());
            if (error_message != null)
            {
                MessageBox.Show(error_message);
                return;
            }
            else
            {
                add_car_properties.Add("reg_mark", admin_car_mark_label.Text);
            }
            //Проверка модели
            error_message = ParkDispecter.IsValidValue("Модель", admin_car_model_label.Text.ToString());
            if (error_message != null)
            {
                MessageBox.Show(error_message);
                return;
            }
            else
            {
                add_car_properties.Add("model", admin_car_model_label.Text);
            }
            //Проверка Цвета
            error_message = ParkDispecter.IsValidValue("Цвет", admin_car_color_label.Text.ToString());
            if (error_message != null)
            {
                MessageBox.Show(error_message);
                return;
            }
            else
            {
                add_car_properties.Add("color", admin_car_color_label.Text);
            }
            //Проверка Описания
            if (admin_car_descr_label.Text != "")
            {
                error_message = ParkDispecter.IsValidValue("Описание", admin_car_descr_label.Text.ToString(), false);
                if (error_message != null)
                {
                    MessageBox.Show(error_message);
                    return;
                }
                else
                {
                    add_car_properties.Add("description", admin_car_descr_label.Text);
                }
            }
            //Добавляем тип
            add_car_properties.Add("car_type_id", admin_car_type_cbox.SelectedIndex.ToString());
            //Добавляем состояние
            add_car_properties.Add("car_state", "1");

            if (ADBR.CreateNewKouple("cars", add_car_properties) == 1) return;
            if (this.Height < Screen.GetWorkingArea(this).Height - this.Location.Y) this.Height += 35;
            EndingEvent("car");
        }

        private void Admin_car_type_cbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center
            };

            var combo = sender as ComboBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.PaleGreen), e.Bounds);
            }
            else
            {
                if (admin_car_type_cbox.DroppedDown) e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }

            if (e.Index > -1) e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                           new Font("Segoe UI", 11, FontStyle.Bold),
                                           new SolidBrush(Color.Black),
                                           e.Bounds,
                                           sf);
        }

        private void AdminTab_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (!IsTabSelectingActive)
            {
                MessageBox.Show("Завершите начатую операцию!");
                e.Cancel = true;
            }
        }

        private void Admin_users_role_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center
            };

            var combo = sender as ComboBox;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.PaleGreen), e.Bounds);
            }
            else
            {
                if (admin_users_role.DroppedDown) e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }

            if (e.Index > -1) e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                           new Font("Segoe UI", 11, FontStyle.Bold),
                                           new SolidBrush(Color.Black),
                                           e.Bounds,
                                           sf);
        }

        private void SearchTasks_Enter(object sender, EventArgs e)
        {
            searchUsers.Clear();
        }

        private void SearchTasks_Leave(object sender, EventArgs e)
        {
            if (searchUsers.Text == "") searchUsers.Text = "Поиск";
        }

        private void searchDrivers_Enter(object sender, EventArgs e)
        {
            searchDrivers.Clear();
        }

        private void searchDrivers_Leave(object sender, EventArgs e)
        {
            if (searchDrivers.Text == "") searchDrivers.Text = "Поиск";
        }

        private void SearchAuto_Enter(object sender, EventArgs e)
        {
            searchAutos.Clear();
        }

        private void SearchAuto_Leave(object sender, EventArgs e)
        {
            if (searchAutos.Text == "") searchAutos.Text = "Поиск";
        }

        private void SearchAuto_TextChanged(object sender, EventArgs e)
        {
            AdminCarsGrid.ClearSelection();

            if (string.IsNullOrWhiteSpace(searchAutos.Text))
                return;

            var values = searchAutos.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < AdminCarsGrid.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = AdminCarsGrid.Rows[i];

                    if (row.Cells["Gov_num_col"].Value.ToString().Contains(value) ||
                        row.Cells["Model_col"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        AdminCarsGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        private void SearchDrivers_TextChanged(object sender, EventArgs e)
        {
            AdminDriversGrid.ClearSelection();

            if (string.IsNullOrWhiteSpace(searchDrivers.Text))
                return;

            var values = searchDrivers.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < AdminDriversGrid.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = AdminDriversGrid.Rows[i];

                    if (row.Cells["Tab_col"].Value.ToString().Contains(value) ||
                        row.Cells["FIO_col"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        AdminDriversGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }
    }
}
