using AParkDispetcher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APark
{
    public partial class DispetcherFrom : Form
    {
        //Disp_user DU;
        Disp_drivers DD;
        Disp_cars DC;
        Disp_tasks DT;
        DBRedactor DBRed;

        private static bool IsAsideTabSelectingActive = true;

        public DispetcherFrom()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DU = new Disp_user();
            DD = new Disp_drivers();
            DC = new Disp_cars();
            DT = new Disp_tasks();
            DBRed = new DBRedactor();

            DD.fillDispatchersDriverGrid(DriversViewGrid);
            DC.fillDispatchersCarGrid(carViewGrid);
            DT.fillDispetcherTasks(MainGrid);
            typeTask_box.Items.Clear();
            DT.fillComboboxWithTypes(typeTask_box);

            MainGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
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
                    //DriversViewGrid.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkKhaki;
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
            if (e.ColumnIndex == 1)  e.Value = e.Value.ToString().Remove(e.Value.ToString().Length - 3); 

            string[] splited_cell = carViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString().Split('~');


            /*foreach (DataGridViewRow Myrow in dataGridView3.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToInt32(Myrow.Cells[2].Value) < Convert.ToInt32(Myrow.Cells[1].Value))// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Green;
                }
            }*/

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
            OrdtimeTask_box.CustomFormat = "      dd.MM  [HH:mm]";
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
                //typeTask_box.Visible = true;

            }
            else
            {
                //typeTask_box.Visible = false;
                OrderedTypeTask_box.Text = task_ordered_type;
                OrderedTypeTask_box.Visible = true;
            }


            
            colorTask_box.Text = task_car_color;


              /*switch (task_state)
              {
                  case "0":
                      textStateTask_box.Text = task_state;
                      break;
                  case "1":
                      state_notAvailable.Checked = true;
                      break;
                  default:
                      break;
              }*/

            StateTask_combobox.SelectedIndex = Int32.Parse(task_state);
            textStateTask_box.Text = StateTask_combobox.Text;

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
            SelectCarForm CurSelectCarForm = new SelectCarForm();
            if (CurSelectCarForm.ShowDialog(this) == DialogResult.OK)
            {
                int Index = CurSelectCarForm.SelectionCarGrid.SelectedCells[0].RowIndex;
                string car_mark = CurSelectCarForm.SelectionCarGrid.Rows[Index].Cells[0].Value.ToString();
                string car_model = CurSelectCarForm.SelectionCarGrid.Rows[Index].Cells[1].Value.ToString();
                string car_type = CurSelectCarForm.SelectionCarGrid.Rows[Index].Cells[2].Value.ToString();
                string car_color = CurSelectCarForm.SelectionCarGrid.Rows[Index].Cells[3].Value.ToString();

                MessageBox.Show(car_mark + " " + car_model + " " + car_type + " " + car_color);

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
            typeTask_box.Size = new Size(291, 25);
            typeTask_box.Refresh();

            duraTask_box.ReadOnly = false;
            departTask_box.ReadOnly = false;
            destTask_box.ReadOnly = false;
            commTask_box.ReadOnly = false;
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
            OrdtimeTask_box.Value = DBRed.getDateTimeFromServer();
            //timeTask_box.Text = OrdtimeTask_box.Value.ToString("g");
            timeTask_box.Text = OrdtimeTask_box.Value.ToString("dd.MM  [HH:mm]");

        }

        private void StateTask_combobox_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

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

            

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          new Font("Segoe UI", 11, FontStyle.Bold),
                                          new SolidBrush(Color.Black),
                                          e.Bounds,
                                          sf);
        }

        private void typeTask_box_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

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
                                          sf);
        }

        private void AsideDispTab_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (!IsAsideTabSelectingActive)
            {
                MessageBox.Show("Завершите начатую операцию!");
                e.Cancel = true;
            }
        }

        private void endingEvent()
        {
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
        } 

        private void Cancel_task_button_Click(object sender, EventArgs e)
        {
            endingEvent();
        }
    }
}
