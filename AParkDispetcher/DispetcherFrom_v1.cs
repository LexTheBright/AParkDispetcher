using AParkDispetcher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APark
{
    public partial class DispetcherFrom : Form
    {
        Drivers_list DD;
        Cars_list DC;
        Tasks_list DT;
        DBRedactor DBRed;
        ExportSettingsForm SF;

        private static bool isChangingTasks = false;
        private static bool IsAsideTabSelectingActive = true;

        public Dictionary<int, string> Task_Type = new Dictionary<int, string>();

        public enum Task_Type_Rev
        {
            новая = 0,
            подтверждена = 1,
            исполняется = 2,
            завершена = 3,
            отменена = 4
        }

        public DispetcherFrom()
        {
            Task_Type.Add(0, "новая");
            Task_Type.Add(1, "подтверждена");
            Task_Type.Add(2, "исполняется");
            Task_Type.Add(3, "завершена");
            Task_Type.Add(4, "отменена");

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DU = new Disp_user();
            DD = new Drivers_list();
            DC = new Cars_list();
            DT = new Tasks_list();
            DBRed = new DBRedactor();

            this.Enabled = false;
            LoginForm newLoginForm = new LoginForm();
            if (newLoginForm.ShowDialog(this) == DialogResult.OK)
            {
                User_label.Text = AppUser.name + " " + AppUser.secondName[0] + ". " + AppUser.thirdName[0] + ". (" + AppUser.tabNum + ")";
                this.Enabled = true;

                typeTask_box.Items.Clear();
                DT.FillComboboxWithTypes(typeTask_box);
                if (AppUser.roleTitle == "Администратор" || AppUser.roleTitle == "Оператор")
                {
                    Edit_task_button.Text = "Обработать";
                    MenuAdminUsers.Visible = true;
                    ReportsFormButton.Visible = true;

                    if (Tasks_group.Location.X == 6)
                    {
                        Tasks_group.Location = new Point(219, Tasks_group.Location.Y);
                        Tasks_group.Width -= 210;
                    }

                    DD.fillDispatchersDriverGrid(DriversViewGrid);
                    DC.fillDispatchersCarGrid(carViewGrid);
                    DT.FillDispetcherTasks(MainGrid);
                }

                if (AppUser.roleTitle == "Оператор")
                {
                    AdminFormButton.Visible = false;
                }

                if (AppUser.roleTitle == "Пользователь")
                {
                    Edit_task_button.Text = "Изменить";
                    AdminFormButton.Visible = false;
                    ReportsFormButton.Visible = false;

                    DT.FillUsersTasks(MainGrid, AppUser.tabNum); //fqiugfuiqueohguoiqeguioqehguheqgqe
                    oper_panel.Enabled = false;

                    if (Tasks_group.Location.X != 6)
                    {
                        Tasks_group.Location = new Point(6, Tasks_group.Location.Y);
                        Tasks_group.Width += 210;
                    }
                }
            }
            else { this.Close(); }
            /*StateTask_combobox.Items.Clear();
            if (true)  //todo заполнение от юзера
            {
                StateTask_combobox.Items.Add("подтверждена");
                StateTask_combobox.Items.Add("исполняется");
                StateTask_combobox.Items.Add("завершена");
                StateTask_combobox.Items.Add("отменена");
            } else {
                StateTask_combobox.Items.Add("отменена");
            }
            StateTask_combobox.SelectedIndex = 0;*/
            endingEvent();
            MainGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            carViewGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            //dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold); 
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            state_free.Enabled = false;
            state_busy.Enabled = false;
            state_gone.Enabled = false;

            Dictionary<string, string> driver_state_prop = new Dictionary<string, string>();

            //int selectedIndex = DriversViewGrid.SelectedCells[0].RowIndex;
            //string tab_num_driv = DriversViewGrid.Rows[selectedIndex].Cells[2].Value.ToString();


            if (state_free.Checked) driver_state_prop.Add("driver_state", "0");
            if (state_busy.Checked) driver_state_prop.Add("driver_state", "1");
            if (state_gone.Checked) driver_state_prop.Add("driver_state", "2");

            if (DriversViewGrid.Rows[DriversViewGrid.SelectedCells[0].RowIndex].Cells[1].Value.ToString() == driver_state_prop["driver_state"])
            {
                Cancel_driverstate_button.PerformClick();
                return;
            }
            else
            {
                DBRed.updateByID("drivers", "tab_number", tab_aside.Text, driver_state_prop);
            }

            //сохраняем индакс и обновляем таблицу
            int savedIndex = DriversViewGrid.SelectedCells[0].RowIndex;
            DriversViewGrid.Rows[savedIndex].Cells[1].Value = driver_state_prop["driver_state"];
            //DriversViewGrid.Refresh();
            //dataGridView1_SelectionChanged(sender, e);

            /*DriversViewGrid.Rows.Clear();
            DD.fillDispatchersDriverGrid(DriversViewGrid);
            DriversViewGrid.Rows[savedIndex].Selected = true;*/
            DriversViewGrid.Enabled = true;
            DriversViewGrid.Focus();
            Sort_by_state.PerformClick();

            Cancel_driverstate_button.Visible = false;
            Save_state_button.Enabled = false;
            Save_state_button.BackColor = Color.DarkKhaki;
            IsAsideTabSelectingActive = true;
        }

        private void MenuAdminUsers_Click(object sender, EventArgs e)
        {
            AdminRolesFrom CurAdminForm = new AdminRolesFrom();
            CurAdminForm.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*if (e.Value.ToString().Length > 20) e.Value = e.Value.ToString().Substring(0, 20);*/
            string[] splited_cell = e.Value.ToString().Split(' ');
            if (splited_cell.Count() == 3)
            {
                e.Value = splited_cell[0] + " " + splited_cell[1] + " " + splited_cell[2][0] + ".";

            }

            switch (DriversViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString())
            {
                case "2":
                    DriversViewGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    DriversViewGrid.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Gray;
                    /*e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.SelectionBackColor = Color.Gray;
                    e.Value = "";*/
                    break;
                case "0":
                    DriversViewGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    DriversViewGrid.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Green;
                    //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
                    /*e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.SelectionBackColor = Color.Green;
                    e.Value = "";*/
                    break;
                case "1":
                    DriversViewGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    DriversViewGrid.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkKhaki;
                    /*e.CellStyle.BackColor = Color.LightYellow;
                    e.CellStyle.SelectionBackColor = Color.Orange;
                    e.Value = "";*/
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DriversViewGrid.SelectedCells.Count > 0)
            {
                //DriversViewGrid.SelectedCells[0].Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
                int selectedrowindex = DriversViewGrid.SelectedCells[0].RowIndex;
                string FIO = DriversViewGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
                //DriversViewGrid.Rows[selectedrowindex].Cells[0].Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
                string state = DriversViewGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
                string tab_number = DriversViewGrid.Rows[selectedrowindex].Cells[2].Value.ToString();

                string[] splited_FIO = FIO.Split(' ');

                FIO_aside.Text = splited_FIO[0] + " " + splited_FIO[1][0] + ". " + splited_FIO[2][0] + ".";
                tab_aside.Text = tab_number;

                switch (state)
                {
                    case "0":
                        state_free.Checked = true;
                        break;
                    case "1":
                        state_busy.Checked = true;
                        break;
                    case "2":
                        state_gone.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            carViewGrid.Enabled = false;
            state_notAvailable.Enabled = true;
            state_available.Enabled = true;
            car_cancel_button.Visible = true;
            car_save_button.Enabled = true;
            car_save_button.BackColor = Color.LightGray;
            IsAsideTabSelectingActive = false;
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1) e.Value = e.Value.ToString().Remove(e.Value.ToString().Length - 3);

            string[] splited_cell = carViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString().Split('~');


            switch (splited_cell[0])
            {
                case "1":
                    carViewGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    carViewGrid.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Gray;

                    //e.CellStyle.BackColor = Color.LightGray;
                    //e.CellStyle.SelectionBackColor = Color.Gray;
                    break;
                case "0":
                    carViewGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    carViewGrid.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Green;

                    //e.CellStyle.BackColor = Color.LightGreen;
                    //e.CellStyle.SelectionBackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            state_free_CheckedChanged(sender, e);
            DriversViewGrid.Rows.Clear();
            DD.fillDispatchersDriverGrid(DriversViewGrid);
            //this.ProcessTabKey(true);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DriversViewGrid.Sort(DriversViewGrid.Columns[1], ListSortDirection.Ascending);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            carViewGrid.Sort(carViewGrid.Columns[2], ListSortDirection.Ascending);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            carViewGrid.Rows.Clear();
            DC.fillDispatchersCarGrid(carViewGrid);
            //this.ProcessTabKey(true);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessTabKey(true);
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (carViewGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = carViewGrid.SelectedCells[0].RowIndex;
                string model = carViewGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
                string reg_mark = carViewGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
                string state = carViewGrid.Rows[selectedrowindex].Cells[2].Value.ToString();

                mark_aside.Text = reg_mark;
                model_aside.Text = model;

                switch (state)
                {
                    case "0":
                        state_available.Checked = true;
                        break;
                    case "1":
                        state_notAvailable.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void DispetcherFrom_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width > 1400) MainGrid.Columns[8].Visible = true;
            else MainGrid.Columns[8].Visible = false;

            if (this.Size.Width > 1600)
            {
                MainGrid.Columns[6].Visible = true;
                MainGrid.Columns[12].Width = 100;
            }
            else
            {
                MainGrid.Columns[6].Visible = false;
                MainGrid.Columns[12].Width = 70;
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].MinimumHeight = 35;
            }*/
            if (e.RowIndex % 2 == 1) MainGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            else MainGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue; /*Color.FromArgb(153, 180, 209)*/

            if (e.ColumnIndex == 4) e.Value = Convert.ToDateTime(e.Value).ToString("dd.MM  [HH:mm]");

            if (MainGrid.Rows[e.RowIndex].MinimumHeight != 35) MainGrid.Rows[e.RowIndex].MinimumHeight = 35;


            if (e.ColumnIndex == 11 && e.Value.ToString().Length > 5)
            {
                e.Value = e.Value.ToString().Remove(e.Value.ToString().Length - 3);
            }
            if (e.ColumnIndex == 3)
            {
                switch (e.Value)
                {
                    case "0":
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.SelectionBackColor = Color.DarkOrange;
                        e.Value = "новая";
                        break;
                    case "1":
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.SelectionBackColor = Color.Green;
                        e.Value = "подтверждена";
                        break;
                    case "2":
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.SelectionBackColor = Color.Green;
                        e.Value = "исполняется";
                        break;
                    case "3":
                        e.Value = "завершена";
                        e.CellStyle.BackColor = Color.LightGray;
                        e.CellStyle.SelectionBackColor = Color.Gray;
                        break;
                    case "4":
                        e.Value = "отменена";
                        e.CellStyle.BackColor = Color.LightGray;
                        e.CellStyle.SelectionBackColor = Color.Gray;
                        break;
                    default:
                        break;
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (MainGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = MainGrid.SelectedCells[0].RowIndex;
                string task_numb = MainGrid.Rows[selectedrowindex].Cells[0].Value.ToString();
                string task_datetime = MainGrid.Rows[selectedrowindex].Cells[1].Value.ToString();
                string task_tab_user = MainGrid.Rows[selectedrowindex].Cells[2].Value.ToString();
                string task_state = MainGrid.Rows[selectedrowindex].Cells[3].Value.ToString();

                //string task_dep_time = dataGridView2.Rows[selectedrowindex].Cells[4].Value.ToString();
                DateTime task_dep_time = Convert.ToDateTime(MainGrid.Rows[selectedrowindex].Cells[4].Value);


                string task_dura = MainGrid.Rows[selectedrowindex].Cells[5].Value.ToString();
                string task_dep = MainGrid.Rows[selectedrowindex].Cells[6].Value.ToString();
                string task_dest = MainGrid.Rows[selectedrowindex].Cells[7].Value.ToString();
                string task_user_com = MainGrid.Rows[selectedrowindex].Cells[8].Value.ToString();
                string task_changer_com = MainGrid.Rows[selectedrowindex].Cells[9].Value.ToString();
                string task_tab_driver = MainGrid.Rows[selectedrowindex].Cells[10].Value.ToString();
                string task_reg_mark = MainGrid.Rows[selectedrowindex].Cells[11].Value.ToString();
                string task_ctype = MainGrid.Rows[selectedrowindex].Cells[12].Value.ToString();
                string task_car_color = MainGrid.Rows[selectedrowindex].Cells[13].Value.ToString();
                string task_ordered_type = MainGrid.Rows[selectedrowindex].Cells[14].Value.ToString();
                string task_user_FIO = MainGrid.Rows[selectedrowindex].Cells[15].Value.ToString();
                string task_car_model = MainGrid.Rows[selectedrowindex].Cells[16].Value.ToString();

                numTask_box.Text = task_numb;
                timeTask_box.Text = task_datetime;

                //clientTask_box.Text = task_tab_user;
                clientTask_box.Text = task_user_FIO;

                departTask_box.Text = task_dep;


                OrdtimeTask_box.Format = DateTimePickerFormat.Custom;
                //OrdtimeTask_box.CustomFormat = "      dd.MM.yy  [HH:mm]";
                OrdtimeTask_box.Value = task_dep_time;


                destTask_box.Text = task_dest;
                duraTask_box.Text = task_dura;
                commTask_box.Text = task_user_com;
                driverTask_box.Text = task_tab_driver;
                dispCommTask_box.Text = task_changer_com;
                markTask_box.Text = task_reg_mark;
                modelTask_box.Text = task_car_model;


                if (task_ctype != "")
                {
                    //OrderedTypeTask_box.Visible = false;
                    typeTask_box.SelectedItem = task_ctype;
                    OrderedTypeTask_box.Text = task_ctype;
                    if (task_ctype.Length > 15) OrderedTypeTask_box.Text = task_ctype.Substring(0, 15);
                    //typeTask_box.Visible = true;

                }
                else
                {
                    //typeTask_box.Visible = false;
                    OrderedTypeTask_box.Text = task_ordered_type;
                    typeTask_box.SelectedItem = task_ordered_type;
                    if (task_ordered_type.Length > 15) OrderedTypeTask_box.Text = task_ordered_type.Substring(0, 15);
                    OrderedTypeTask_box.Visible = true;
                }

                colorTask_box.Text = task_car_color;

                //StateTask_combobox.SelectedIndex = Int32.Parse(task_state);
                //admin_car_type_cbox.SelectedItem = DC.types.FirstOrDefault(x => x.Key == type).Key;
                //textStateTask_box.Text = StateTask_combobox.Text;
                textStateTask_box.Text = Task_Type[int.Parse(task_state)];
                try { StateTask_combobox.SelectedItem = textStateTask_box.Text; } catch { StateTask_combobox.SelectedIndex = 0; }

                if (textStateTask_box.Text == "отменена" || textStateTask_box.Text == "завершена")
                {
                    Edit_task_button.Enabled = false;
                    Edit_task_button.BackColor = Color.DarkKhaki;
                }
                else if (!isChangingTasks)
                {
                    Edit_task_button.Text = "Изменить";
                    Edit_task_button.Enabled = true;
                    Edit_task_button.BackColor = SystemColors.ControlLight;
                }
                if (AppUser.roleTitle == "Пользователь" && textStateTask_box.Text == "подтверждена") Edit_task_button.Text = "Отмена заявки";
                if (AppUser.roleTitle == "Пользователь" && textStateTask_box.Text == "исполняется")
                {
                    Edit_task_button.Enabled = false;
                    Edit_task_button.BackColor = Color.DarkKhaki;
                }
                //StateTask_combobox.SelectedItem = textStateTask_box.Text;
            }
            else
            {
                Edit_task_button.Enabled = false;
                Edit_task_button.BackColor = Color.DarkKhaki;
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //MessageBox.Show("The row index = " + e.RowIndex);

            string task_numb = MainGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string task_datetime = MainGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string task_tab_user = MainGrid.Rows[e.RowIndex].Cells[2].Value.ToString();


            TaskHistoryForm CurTHistoryForm = new TaskHistoryForm(task_numb, task_tab_user, task_datetime);
            CurTHistoryForm.Show();
        }

        private void selectCarButton_Click(object sender, EventArgs e)
        {
            DateTime Tright, Tleft;
            if (duraTask_box.Text != "")
            {
                string error_message = ParkDispecter.IsValidValue("Длительность", duraTask_box.Text, false);
                if (error_message != null)
                {
                    MessageBox.Show(error_message);
                    return;
                }
                else
                {
                    if (int.Parse(duraTask_box.Text) < 40)
                    {
                        MessageBox.Show("Неверный формат длительности! Укжите ожидаемую длительность поездки туда-обратно. Не менее 40 минут.");
                        return;
                    }
                    Tright = OrdtimeTask_box.Value.AddMinutes(double.Parse(duraTask_box.Text));
                }
            }
            else Tright = OrdtimeTask_box.Value.AddMinutes(120);
            Tleft = OrdtimeTask_box.Value;
            SelectCarForm CurSelectCarForm = new SelectCarForm(Tleft, Tright);
            if (CurSelectCarForm.ShowDialog(this) == DialogResult.OK)
            {
                int Index = CurSelectCarForm.SelectionCarGrid.SelectedCells[0].RowIndex;
                string car_mark = CurSelectCarForm.SelectionCarGrid.Rows[Index].Cells[0].Value.ToString();
                string car_model = CurSelectCarForm.SelectionCarGrid.Rows[Index].Cells[1].Value.ToString();
                string car_type = CurSelectCarForm.SelectionCarGrid.Rows[Index].Cells[2].Value.ToString();
                string car_color = CurSelectCarForm.SelectionCarGrid.Rows[Index].Cells[3].Value.ToString();

                //MessageBox.Show(car_mark + " " + car_model + " " + car_type + " " + car_color);
                markTask_box.Text = car_mark;
                modelTask_box.Text = car_model;
                OrderedTypeTask_box.Text = car_type;
                colorTask_box.Text = car_color;
            }
        }

        private void state_free_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            if (state_free.Checked) pictureBox1.Visible = true;
            if (state_busy.Checked) pictureBox2.Visible = true;
            if (state_gone.Checked) pictureBox3.Visible = true;

        }

        private void state_busy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            if (state_free.Checked) pictureBox1.Visible = true;
            if (state_busy.Checked) pictureBox2.Visible = true;
            if (state_gone.Checked) pictureBox3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cancel_driverstate_button.Visible = true;
            Save_state_button.Enabled = true;
            Save_state_button.BackColor = Color.LightGray;

            state_free.Enabled = true;
            state_busy.Enabled = true;
            state_gone.Enabled = true;

            DriversViewGrid.Enabled = false;
            //DriversViewGrid.SelectedRows[0].Selected = true;
            IsAsideTabSelectingActive = false;
        }

        private void Cancel_driverstate_button_Click(object sender, EventArgs e)
        {
            IsAsideTabSelectingActive = true;
            dataGridView1_SelectionChanged(sender, e);
            DriversViewGrid.Enabled = true;
            Save_state_button.Enabled = false;
            Save_state_button.BackColor = Color.DarkKhaki;

            Cancel_driverstate_button.Visible = false;

            state_free.Enabled = false;
            state_busy.Enabled = false;
            state_gone.Enabled = false;

            //Change_state_button.Focus();
            //tabControl1.ProcessTabKey(true);
            //DriversViewGrid.SelectedRows[0].Cells[0].Selected = true;
            DriversViewGrid.Focus();
            //DriversViewGrid.SelectedRows[0].Selected = true;
        }

        private void DriversViewGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            Change_state_button.PerformClick();
        }

        private void DriversViewGrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //DriversViewGrid.Rows[e.RowIndex].Cells[0].Style.Font = new Font("Century", 11, FontStyle.Bold);

            //DriversViewGrid.SelectedCells[0].Style.Font = new Font("Century", 11.25);
        }

        private void state_available_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

            if (state_available.Checked) pictureBox4.Visible = true;
            if (state_notAvailable.Checked) pictureBox5.Visible = true;
        }

        private void car_cancel_button_Click(object sender, EventArgs e)
        {
            dataGridView3_SelectionChanged(sender, e);
            IsAsideTabSelectingActive = true;
            carViewGrid.Enabled = true;

            car_cancel_button.Visible = false;

            car_save_button.Enabled = false;
            car_save_button.BackColor = Color.DarkKhaki;

            Cancel_driverstate_button.Visible = false;

            state_available.Enabled = false;
            state_notAvailable.Enabled = false;

            carViewGrid.Focus();
        }

        private void car_save_button_Click(object sender, EventArgs e)
        {
            state_notAvailable.Enabled = false;
            state_available.Enabled = false;

            Dictionary<string, string> car_state_prop = new Dictionary<string, string>();

            if (state_available.Checked) car_state_prop.Add("car_state", "0");
            else car_state_prop.Add("car_state", "1");

            if (carViewGrid.Rows[carViewGrid.SelectedCells[0].RowIndex].Cells[2].Value.ToString() == car_state_prop["car_state"])
            {
                //MessageBox.Show("Jlbyfrjdjt");
                car_cancel_button.PerformClick();
                return;
            }
            else
            {
                DBRed.updateByID("cars", "reg_mark", mark_aside.Text, car_state_prop);
            }
            //сохраняем индакс и обновляем таблицу
            int savedIndex = carViewGrid.SelectedCells[0].RowIndex;
            carViewGrid.Rows[savedIndex].Cells[2].Value = car_state_prop["car_state"];

            carViewGrid.Enabled = true;
            carViewGrid.Focus();
            sort_by_car_state.PerformClick();

            car_cancel_button.Visible = false;
            car_save_button.Enabled = false;
            car_save_button.BackColor = Color.DarkKhaki;
            IsAsideTabSelectingActive = true;
        }

        private void Create_task_button_Click(object sender, EventArgs e)
        {
            OrderedTypeTask_box.Visible = false;
            label14.Visible = false;
            colorTask_box.Visible = false;
            typeTask_box.Visible = true;
            typeTask_box.SelectedIndex = -1;
            typeTask_box.Size = new Size(291, 25);
            typeTask_box.Refresh();

            duraTask_box.ReadOnly = false;
            duraTask_box.Clear();
            departTask_box.ReadOnly = false;
            departTask_box.Clear();
            destTask_box.ReadOnly = false;
            destTask_box.Clear();
            commTask_box.ReadOnly = false;
            commTask_box.Clear();
            driverTask_box.Clear();
            markTask_box.Clear();
            modelTask_box.Clear();
            dispCommTask_box.Clear();
            duraTask_box.BackColor = Color.PaleGreen;
            departTask_box.BackColor = Color.PaleGreen;
            destTask_box.BackColor = Color.PaleGreen;
            commTask_box.BackColor = Color.PaleGreen;

            searchTasks.Enabled = false;
            MainGrid.Enabled = false;
            OrdtimeTask_box.Enabled = true;
            Create_task_button.Enabled = false;
            Create_task_button.BackColor = Color.DarkKhaki;
            Edit_task_button.Enabled = false;
            Edit_task_button.BackColor = Color.DarkKhaki;
            Cancel_task_button.Enabled = true;
            Cancel_task_button.BackColor = SystemColors.ControlLight;
            Save_add_task_button.Enabled = true;
            Save_add_task_button.BackColor = SystemColors.ControlLight;


            numTask_box.Text = (DBRed.getMaxID("tasks", "task_num") + 1).ToString();
            textStateTask_box.Text = "новая";
            OrdtimeTask_box.Value = DBRed.getDateTimeFromServer();
            //timeTask_box.Text = OrdtimeTask_box.Value.ToString("g");
            timeTask_box.Text = OrdtimeTask_box.Value.ToString("dd.MM  [HH:mm]");
            clientTask_box.Text = AppUser.secondName + " " + AppUser.name + " " + AppUser.thirdName;
        }

        private void StateTask_combobox_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sfs = new StringFormat();
            sfs.Alignment = StringAlignment.Center;

            var combo = sender as ComboBox;

            //e.Graphics.FillRectangle(new SoliDBRedush(Color.Navy), e.Bounds);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.PaleGreen), e.Bounds);
            }
            else
            {
                if (StateTask_combobox.DroppedDown) e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }


            if (e.Index >= 0) e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                              new Font("Segoe UI", 11, FontStyle.Bold),
                                              new SolidBrush(Color.Black),
                                              e.Bounds,
                                              sfs);
        }

        private void typeTask_box_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sft = new StringFormat();
            sft.Alignment = StringAlignment.Center;

            var combo = sender as ComboBox;

            //e.Graphics.FillRectangle(new SolidBrush(Color.Navy), e.Bounds);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.PaleGreen), e.Bounds);
            }
            else
            {
                if (typeTask_box.DroppedDown) e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }

            if (e.Index >= 0) e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          new Font("Segoe UI", 11, FontStyle.Bold),
                                          new SolidBrush(Color.Black),
                                          e.Bounds,
                                          sft);
        }

        private void AsideDispTab_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (!IsAsideTabSelectingActive)
            {
                MessageBox.Show("Завершите начатую операцию!", "Ошибка переключения вкладки");
                e.Cancel = true;
            }
        }

        private void endingEvent()
        {
            int start_index_tsk = 0;
            if (MainGrid.Rows.Count != 0) start_index_tsk = MainGrid.SelectedCells[0].RowIndex;
            MainGrid.Rows.Clear();
            if (AppUser.roleTitle == "Пользователь") DT.FillUsersTasks(MainGrid, AppUser.tabNum);
            else DT.FillDispetcherTasks(MainGrid);
            if (start_index_tsk < MainGrid.RowCount) MainGrid.Rows[start_index_tsk].Selected = true;
            dataGridView2_SelectionChanged(Cancel_task_button, new EventArgs());

            OrderedTypeTask_box.Visible = true;
            label14.Visible = true;
            colorTask_box.Visible = true;
            typeTask_box.Visible = false;
            StateTask_combobox.Visible = false;
            textStateTask_box.Visible = true;
            Save_edit_task_button.Visible = false;

            duraTask_box.ReadOnly = true;
            departTask_box.ReadOnly = true;
            destTask_box.ReadOnly = true;
            commTask_box.ReadOnly = true;
            dispCommTask_box.ReadOnly = true;

            duraTask_box.BackColor = Color.PaleGoldenrod;
            departTask_box.BackColor = Color.PaleGoldenrod;
            destTask_box.BackColor = Color.PaleGoldenrod;
            commTask_box.BackColor = Color.PaleGoldenrod;
            dispCommTask_box.BackColor = Color.PaleGoldenrod;
            markTask_box.BackColor = Color.PaleGoldenrod;
            driverTask_box.BackColor = Color.PaleGoldenrod;

            searchTasks.Enabled = true;
            MainGrid.Enabled = true;
            OrdtimeTask_box.Enabled = false;
            selectCarButton.Enabled = false;
            Create_task_button.Enabled = true;
            Create_task_button.BackColor = SystemColors.ControlLight;
            Edit_task_button.Enabled = true;
            Edit_task_button.BackColor = SystemColors.ControlLight;
            Cancel_task_button.Enabled = false;
            Cancel_task_button.BackColor = Color.DarkKhaki;
            Save_add_task_button.Enabled = false;
            Save_add_task_button.BackColor = Color.DarkKhaki;
            selectCarButton.Enabled = false;
            SelectDriverButton.Enabled = false;

            isChangingTasks = false;
        }

        private void Cancel_task_button_Click(object sender, EventArgs e)
        {
            endingEvent();
        }

        private void Save_add_task_button_Click(object sender, EventArgs e)
        {
            isChangingTasks = true;
            Dictionary<string, string> add_task_properties = new Dictionary<string, string>();
            string error_message;

            DateTime current_datetime = DBRed.getDateTimeFromServer();

            add_task_properties.Add("user_tab_number", AppUser.tabNum.ToString());
            add_task_properties.Add("task_num", numTask_box.Text);
            add_task_properties.Add("orderdatetime", current_datetime.ToString("yyyy-MM-dd HH:mm:ss"));
            add_task_properties.Add("order_state", "0");

            if (typeTask_box.SelectedIndex > -1)
            {
                add_task_properties.Add("ordered_ctype", typeTask_box.SelectedItem.ToString());
            }

            if (OrdtimeTask_box.Value > current_datetime.Add(DateTime.Parse("00:30:00").TimeOfDay))
            {
                add_task_properties.Add("ordered_time", OrdtimeTask_box.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            else
            {
                MessageBox.Show("Укажите дату и время поездки.\n\nВыбирайте время начиная с  " + current_datetime.Add(DateTime.Parse("00:30:00").TimeOfDay).ToString("dd.MM.yyyy  [HH:mm]"), "Выезд");
                return;
            }

            if (duraTask_box.Text != "")
            {
                error_message = ParkDispecter.IsValidValue("Длительность", duraTask_box.Text, false);
                if (error_message != null)
                {
                    MessageBox.Show(error_message);
                    return;
                }
                else
                {
                    if (int.Parse(duraTask_box.Text) < 40)
                    {
                        MessageBox.Show("Неверный формат длительности! \n\nУкжите ожидаемую длительность поездки туда-обратно. Не менее 40 минут.", "Длительность");
                        return;
                    }
                    add_task_properties.Add("ordered_duration", duraTask_box.Text);
                }
            }

            error_message = ParkDispecter.IsValidValue("Откуда", departTask_box.Text);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Откуда");
                return;
            }
            else
            {
                add_task_properties.Add("departure", departTask_box.Text);
            }

            error_message = ParkDispecter.IsValidValue("Куда", destTask_box.Text);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Куда");
                return;
            }
            else
            {
                add_task_properties.Add("destination", destTask_box.Text);
            }

            if (commTask_box.Text != "")
            {
                error_message = ParkDispecter.IsValidValue("Описание", commTask_box.Text, false);
                if (error_message != null)
                {
                    MessageBox.Show(error_message, "Комментарий к заявке");
                    return;
                }
                else
                {
                    add_task_properties.Add("user_description", commTask_box.Text);
                }
            }

            if (DBRed.CreateNewKouple("tasks", add_task_properties) == 1) return;
            addTaskToHistory(add_task_properties);
            endingEvent();
        }

        private void addTaskToHistory(Dictionary<string, string> add_task_properties)
        {
            //int max_history_task_number_plus_one = DBRed.getMaxID("thistory", "htask_num") + 1;
            //add_task_properties.Add("htask_num", max_history_task_number_plus_one.ToString());
            if (!add_task_properties.ContainsKey("task_num"))
            {
                add_task_properties.Add("task_num", numTask_box.Text);
            }
            add_task_properties["changer_tab_number"] = AppUser.tabNum;
            add_task_properties.Remove("user_tab_number");
            add_task_properties["chdatetime"] = DBRed.getDateTimeFromServer().ToString("yyyy-MM-dd HH:mm:ss");
            add_task_properties.Remove("orderdatetime");
            if (!add_task_properties.ContainsKey("chdescription"))
            {
                try { add_task_properties["chdescription"] = add_task_properties["user_description"]; } catch { }
                //add_task_properties.Remove("user_description");
            }
            if (!add_task_properties.ContainsKey("user_description")) add_task_properties.Add("user_description", commTask_box.Text);
            if (!add_task_properties.ContainsKey("ordered_ctype")) add_task_properties.Add("ordered_ctype", typeTask_box.SelectedItem.ToString());
            if (!add_task_properties.ContainsKey("ordered_time")) add_task_properties.Add("ordered_time", OrdtimeTask_box.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (DBRed.CreateNewKouple("thistory", add_task_properties) == 1) return;
        }
        private void addToTaskHistoryByNumber()
        {

        }

        private void Edit_task_button_Click(object sender, EventArgs e)
        {
            if (MainGrid.Rows.Count == 0) return;
            if (MainGrid.SelectedRows.Count == 0) MainGrid.Rows[0].Selected = true;

            isChangingTasks = true;
            searchTasks.Enabled = false;
            MainGrid.Enabled = false;

            Save_edit_task_button.Visible = true;
            textStateTask_box.Visible = false;
            StateTask_combobox.Visible = true;

            if (textStateTask_box.Text == "новая")
            {
                StateTask_combobox.Items.Clear();
                StateTask_combobox.Items.Add("новая");
                if (AppUser.roleTitle != "Пользователь") StateTask_combobox.Items.Add("подтверждена"); //не обязательно оставлять условие
                StateTask_combobox.Items.Add("отменена");
                StateTask_combobox.SelectedIndex = 0;
            }
            if (textStateTask_box.Text == "подтверждена")
            {
                StateTask_combobox.Items.Clear();
                StateTask_combobox.Items.Add("подтверждена");
                if (AppUser.roleTitle != "Пользователь") StateTask_combobox.Items.Add("исполняется"); //не обязательно оставлять условие
                StateTask_combobox.Items.Add("отменена");
                StateTask_combobox.SelectedIndex = 0;
            }
            if (textStateTask_box.Text == "исполняется")
            {
                StateTask_combobox.Items.Clear();
                StateTask_combobox.Items.Add("завершена");
                StateTask_combobox.Items.Add("отменена");
                StateTask_combobox.SelectedIndex = 0;
            }

            Create_task_button.Enabled = false;
            Create_task_button.BackColor = Color.DarkKhaki;
            Edit_task_button.Enabled = false;
            Edit_task_button.BackColor = Color.DarkKhaki;
            Cancel_task_button.Enabled = true;
            Cancel_task_button.BackColor = SystemColors.ControlLight;
            Save_edit_task_button.Enabled = true;
            Save_edit_task_button.BackColor = SystemColors.ControlLight;
        }

        private void SelectDriverButton_Click(object sender, EventArgs e)
        {
            SelectDriverForm CurSelectDriverForm = new SelectDriverForm();
            if (CurSelectDriverForm.ShowDialog(this) == DialogResult.OK)
            {
                int Index = CurSelectDriverForm.SelectionDriverGrid.SelectedCells[0].RowIndex;
                string driver_FIO = CurSelectDriverForm.SelectionDriverGrid.Rows[Index].Cells[0].Value.ToString();
                string driver_tab_num = CurSelectDriverForm.SelectionDriverGrid.Rows[Index].Cells[1].Value.ToString();

                driverTask_box.Text = driver_tab_num;
                //driverTask_box.Text = driver_tab_num + " " + driver_FIO.Split(' ')[0] + " " + driver_FIO.Split(' ')[1][0] + ". " + driver_FIO.Split(' ')[2][0] + ".";
            }
        }

        private void Save_edit_task_button_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> add_task_properties = new Dictionary<string, string>();
            string error_message;

            //Статус заявки StateTask_combobox.SelectedItem.ToString()
            add_task_properties.Add("order_state", Task_Type.FirstOrDefault(x => x.Value == StateTask_combobox.SelectedItem.ToString()).Key.ToString());


            //назначение номера и водителя !!!
            if (StateTask_combobox.SelectedItem.ToString() == "подтверждена" || markTask_box.Text != "")
            {
                if (markTask_box.Text != "") add_task_properties.Add("car_reg_mark", markTask_box.Text);
                else
                {
                    MessageBox.Show("Вы не выбрали автомобиль!", "Гос. номер");
                    return;
                }

                if (driverTask_box.Text != "") add_task_properties.Add("driver_tab_number", driverTask_box.Text);
                else
                {
                    MessageBox.Show("Вы не выбрали водителя!", "Водитель");
                    return;
                }
            }


            //коммент об изменении
            error_message = ParkDispecter.IsValidValue("Описание", dispCommTask_box.Text, false);
            if (StateTask_combobox.SelectedItem.ToString() == "отменена" && dispCommTask_box.Text == "") error_message = "Дайте комментарий об изменении!";
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Последний комментарий");
                return;
            }
            else
            {
                add_task_properties.Add("chdescription", dispCommTask_box.Text);
            }


            if (StateTask_combobox.SelectedItem.ToString() == "новая")
            {
                //запрашиваемое авто
                add_task_properties.Add("ordered_ctype", typeTask_box.SelectedItem.ToString());
            }

            /*if (StateTask_combobox.SelectedItem.ToString() != "отменена" &&
                StateTask_combobox.SelectedItem.ToString() != "завершена")
            {*/
            //время
            DateTime current_datetime = DBRed.getDateTimeFromServer();
            if (OrdtimeTask_box.Value > current_datetime.Add(DateTime.Parse("00:30:00").TimeOfDay))
            {
                add_task_properties.Add("ordered_time", OrdtimeTask_box.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            else
            {
                MessageBox.Show("Укажите дату и время поездки.\n\nВыбирайте время начиная с  " + current_datetime.Add(DateTime.Parse("00:30:00").TimeOfDay).ToString("dd.MM.yyyy  [HH:mm]"), "Выезд");
                return;
            }

            //длительность 
            if (duraTask_box.Text != "")
            {
                error_message = ParkDispecter.IsValidValue("Длительность", duraTask_box.Text, false);
                if (error_message != null)
                {
                    MessageBox.Show(error_message, "Длительность в минутах");
                    return;
                }
                else
                {
                    add_task_properties.Add("ordered_duration", duraTask_box.Text);
                }
            }

            //Откуда
            error_message = ParkDispecter.IsValidValue("Откуда", departTask_box.Text, false);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Откуда");
                return;
            }
            else
            {
                add_task_properties.Add("departure", departTask_box.Text);
            }

            //куда
            error_message = ParkDispecter.IsValidValue("Куда", destTask_box.Text, false);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Куда");
                return;
            }
            else
            {
                add_task_properties.Add("destination", destTask_box.Text);
            }
            /*}*/

            if (DBRed.updateByID("tasks", "task_num", numTask_box.Text, add_task_properties) == 1) return;
            addTaskToHistory(add_task_properties);
            endingEvent();
        }

        private void StateTask_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (AppUser.roleTitle == "Пользователь" && Edit_task_button.Text == "Отмена заявки");
             {
                string[] tasks_args = new string[3];
                tasks_args[0] = "№ " + numTask_box.Text;
                tasks_args[1] = "Выезд " + OrdtimeTask_box.Value.ToString();
                tasks_args[2] = "Тип авто " + OrderedTypeTask_box.Text;

                DeleteDialog newDialog = new DeleteDialog("tasks", tasks_args);

                if (newDialog.ShowDialog() == DialogResult.OK)
                {

                }
                сделать функционал отмена заявки
                return;
            }*/
            if (!isChangingTasks) return;
            ResetAllBoxes();
            if (StateTask_combobox.SelectedItem.ToString() == "подтверждена")
            {
                selectCarButton.Enabled = true;
                SelectDriverButton.Enabled = true;

                OrderedTypeTask_box.Visible = true;
                label14.Visible = true;
                colorTask_box.Visible = true;
                typeTask_box.Visible = false;
                typeTask_box.Refresh();

                OrdtimeTask_box.Enabled = true;
                departTask_box.ReadOnly = false;
                departTask_box.BackColor = Color.PaleGreen;

                dispCommTask_box.Enabled = true;
                dispCommTask_box.ReadOnly = false;
                dispCommTask_box.Clear();
                dispCommTask_box.BackColor = Color.PaleGreen;

                markTask_box.BackColor = Color.PaleGreen;
                driverTask_box.BackColor = Color.PaleGreen;
            }
            if (StateTask_combobox.SelectedItem.ToString() == "новая")
            {
                OrderedTypeTask_box.Visible = false;
                label14.Visible = false;
                colorTask_box.Visible = false;
                typeTask_box.Visible = true;
                //typeTask_box.SelectedIndex = -1;
                typeTask_box.Size = new Size(291, 25);
                typeTask_box.Refresh();
                int selectedrowindex = MainGrid.SelectedCells[0].RowIndex;
                string task_ordered_type = MainGrid.Rows[selectedrowindex].Cells[14].Value.ToString();
                typeTask_box.SelectedItem = task_ordered_type;


                OrdtimeTask_box.Enabled = true;
                departTask_box.ReadOnly = false;
                departTask_box.BackColor = Color.PaleGreen;

                if (AppUser.roleTitle == "Пользователь")
                {
                    destTask_box.ReadOnly = false;
                    destTask_box.BackColor = Color.PaleGreen;

                    duraTask_box.ReadOnly = false;
                    duraTask_box.BackColor = Color.PaleGreen;
                }
            }
            if (StateTask_combobox.SelectedItem.ToString() == "исполняется" ||
                StateTask_combobox.SelectedItem.ToString() == "завершена" ||
                StateTask_combobox.SelectedItem.ToString() == "отменена")
            {
                oper_panel.Enabled = true;
                dispCommTask_box.Enabled = true;
                dispCommTask_box.ReadOnly = false;
                dispCommTask_box.Clear();
                dispCommTask_box.BackColor = Color.PaleGreen;
            }
        }

        private void ResetAllBoxes()
        {
            int selectedrowindex = MainGrid.SelectedCells[0].RowIndex;
            OrdtimeTask_box.Value = Convert.ToDateTime(MainGrid.Rows[selectedrowindex].Cells[4].Value);
            OrdtimeTask_box.Enabled = false;

            duraTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[5].Value.ToString();
            duraTask_box.BackColor = Color.PaleGoldenrod;
            duraTask_box.ReadOnly = true;

            departTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[6].Value.ToString();
            departTask_box.BackColor = Color.PaleGoldenrod;
            departTask_box.ReadOnly = true;

            destTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[7].Value.ToString();
            destTask_box.BackColor = Color.PaleGoldenrod;
            destTask_box.ReadOnly = true;

            commTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[8].Value.ToString();
            commTask_box.BackColor = Color.PaleGoldenrod;
            commTask_box.ReadOnly = true;

            dispCommTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[9].Value.ToString();
            dispCommTask_box.BackColor = Color.PaleGoldenrod;
            dispCommTask_box.ReadOnly = true;

            driverTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[10].Value.ToString();
            driverTask_box.BackColor = Color.PaleGoldenrod;

            markTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[11].Value.ToString();
            markTask_box.BackColor = Color.PaleGoldenrod;

            modelTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[16].Value.ToString();

            OrderedTypeTask_box.Visible = true;
            label14.Visible = true;
            colorTask_box.Visible = true;
            typeTask_box.Visible = false;

            selectCarButton.Enabled = false;
            SelectDriverButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!AppUser.iSsignedIn)
            {
                AppUser.getConnInstance().tryToLogin(Login_textbox.Text, Pass_textbox.Text);
            }
            //Login_textbox.Text = AppUser.getConnInstance().tabNum;
        }

        private void searchTasks_Enter(object sender, EventArgs e)
        {
            searchTasks.Clear();
        }

        private void searchTasks_Leave(object sender, EventArgs e)
        {
            if (searchTasks.Text == "") searchTasks.Text = "Поиск";
        }

        private void searchTasks_TextChanged(object sender, EventArgs e)
        {
            MainGrid.ClearSelection();

            if (string.IsNullOrWhiteSpace(searchTasks.Text))
                return;

            var values = searchTasks.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < MainGrid.RowCount; i++)
            {
                var row = MainGrid.Rows[i];
                foreach (string value in values)
                {
                    if (row.Cells["FIO_col"].Value.ToString().Contains(value) ||
                        row.Cells["UTub_col"].Value.ToString().Contains(value) ||
                        row.Cells["TNum_col"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        MainGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
                if (row.Cells["TNum_col"].Value.ToString() == values[0])
                {
                    row.Selected = true;
                    MainGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void SearchPic1_Click(object sender, EventArgs e)
        {
            searchAsideDrive.Visible = true;
            searchAsideDrive.Focus();
        }

        private void searchAsideDrive_Leave(object sender, EventArgs e)
        {
            searchAsideDrive.Visible = false;
            searchAsideDrive.Clear();
        }

        private void searchAsideDrive_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchAsideDrive.Text))
                return;

            var values = searchAsideDrive.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < DriversViewGrid.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = DriversViewGrid.Rows[i];

                    if (row.Cells["Tab_a_col"].Value.ToString().Contains(value) ||
                        row.Cells["FIO_a_col"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        DriversViewGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        private void searchPic2_Click(object sender, EventArgs e)
        {
            searchAsideAuto.Visible = true;
            searchAsideAuto.Focus();
        }

        private void searchAsideAuto_Leave(object sender, EventArgs e)
        {
            searchAsideAuto.Visible = false;
            searchAsideAuto.Clear();
        }

        private void searchAsideAuto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchAsideAuto.Text))
                return;

            var values = searchAsideAuto.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < carViewGrid.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = carViewGrid.Rows[i];

                    if (row.Cells["Num_a_col"].Value.ToString().Contains(value) ||
                        row.Cells["Model_a_col"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        carViewGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            AppUser.LogOut();
            MainGrid.Rows.Clear();
            carViewGrid.Rows.Clear();
            DriversViewGrid.Rows.Clear();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is Label == false)
                    item.ResetText();
            }

            this.Form1_Load(sender, e);
        }

        private void carViewGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            car_edit_button.PerformClick();
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF = new ExportSettingsForm();
            SF.Show();
        }

        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainGrid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }

        private void OrdtimeTask_box_ValueChanged(object sender, EventArgs e)
        {
            if (!isChangingTasks) return;
            if (MainGrid.Rows.Count == 0) return;
            int selectedrowindex = MainGrid.SelectedCells[0].RowIndex;
            driverTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[10].Value.ToString();
            driverTask_box.BackColor = Color.PaleGoldenrod;

            markTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[11].Value.ToString();
            markTask_box.BackColor = Color.PaleGoldenrod;

            modelTask_box.Text = MainGrid.Rows[selectedrowindex].Cells[16].Value.ToString();
        }
    }
}
