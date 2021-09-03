﻿using AParkDispetcher;
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
        Disp_user DU;
        Disp_driver DD;
        Disp_car DC;
        Disp_task DT;

        public DispetcherFrom()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DU = new Disp_user();
            DD = new Disp_driver();
            DC = new Disp_car();
            DT = new Disp_task();

            DD.fillDispatchersDriverGrid(dataGridView1);
            DC.fillDispatchersCarGrid(dataGridView3);
            DT.fillDispetcherTasks(dataGridView2);
            typeTask_box.Items.Clear();
            DT.fillTypes(typeTask_box);

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
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

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

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

            switch (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString())
            {
                case "2":
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Gray;
                    /*e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.SelectionBackColor = Color.Gray;
                    e.Value = "";*/
                    break;
                case "0":
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Green;
                    //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
                    /*e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.SelectionBackColor = Color.Green;
                    e.Value = "";*/
                    break;
                case "1":
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Orange;
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
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                string FIO = dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString();
                string state = dataGridView1.Rows[selectedrowindex].Cells[1].Value.ToString();
                string tab_number = dataGridView1.Rows[selectedrowindex].Cells[2].Value.ToString();

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

        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)  e.Value = e.Value.ToString().Remove(e.Value.ToString().Length - 3); 

            string[] splited_cell = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString().Split('~');


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
                    dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    dataGridView3.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Gray;

                    //e.CellStyle.BackColor = Color.LightGray;
                    //e.CellStyle.SelectionBackColor = Color.Gray;
                    break;
                case "0":
                    dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridView3.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Green;

                    //e.CellStyle.BackColor = Color.LightGreen;
                    //e.CellStyle.SelectionBackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DD.fillDispatchersDriverGrid(dataGridView1);
            //this.ProcessTabKey(true);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
 
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView3.Sort(dataGridView3.Columns[2], ListSortDirection.Ascending);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            DC.fillDispatchersCarGrid(dataGridView3);
            //this.ProcessTabKey(true);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessTabKey(true);
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView3.SelectedCells[0].RowIndex;
                string model = dataGridView3.Rows[selectedrowindex].Cells[0].Value.ToString();
                string reg_mark = dataGridView3.Rows[selectedrowindex].Cells[1].Value.ToString();
                string state = dataGridView3.Rows[selectedrowindex].Cells[2].Value.ToString();

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
            if (this.Size.Width > 1400) dataGridView2.Columns[8].Visible = true;
            else dataGridView2.Columns[8].Visible = false;

            if (this.Size.Width > 1600)
            {
                dataGridView2.Columns[6].Visible = true;
                dataGridView2.Columns[12].Width = 100;
            }
            else
            {
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[12].Width = 70;
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].MinimumHeight = 35;
            }*/

            if (dataGridView2.Rows[e.RowIndex].MinimumHeight != 35) dataGridView2.Rows[e.RowIndex].MinimumHeight = 35;


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
            int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
            string task_numb = dataGridView2.Rows[selectedrowindex].Cells[0].Value.ToString();
            string task_datetime = dataGridView2.Rows[selectedrowindex].Cells[1].Value.ToString();
            string task_tab_user = dataGridView2.Rows[selectedrowindex].Cells[2].Value.ToString();
            string task_state = dataGridView2.Rows[selectedrowindex].Cells[3].Value.ToString();
            string task_dep_time = dataGridView2.Rows[selectedrowindex].Cells[4].Value.ToString();
            string task_dura = dataGridView2.Rows[selectedrowindex].Cells[5].Value.ToString();
            string task_dep = dataGridView2.Rows[selectedrowindex].Cells[6].Value.ToString();
            string task_dest = dataGridView2.Rows[selectedrowindex].Cells[7].Value.ToString();
            string task_user_com = dataGridView2.Rows[selectedrowindex].Cells[8].Value.ToString();
            string task_changer_com = dataGridView2.Rows[selectedrowindex].Cells[9].Value.ToString();
            string task_tab_driver = dataGridView2.Rows[selectedrowindex].Cells[10].Value.ToString();
            string task_reg_mark = dataGridView2.Rows[selectedrowindex].Cells[11].Value.ToString();
            string task_ctype = dataGridView2.Rows[selectedrowindex].Cells[12].Value.ToString();
            string task_car_color = dataGridView2.Rows[selectedrowindex].Cells[13].Value.ToString();
            string task_ordered_type = dataGridView2.Rows[selectedrowindex].Cells[14].Value.ToString();
            string task_user_FIO = dataGridView2.Rows[selectedrowindex].Cells[15].Value.ToString();
            string task_car_model = dataGridView2.Rows[selectedrowindex].Cells[16].Value.ToString();

            numTask_box.Text = task_numb;
            timeTask_box.Text = task_datetime;

            //clientTask_box.Text = task_tab_user;
            clientTask_box.Text = task_user_FIO;

            departTask_box.Text = task_dep;

            OrdtimeTask_box.Format = DateTimePickerFormat.Custom;
            OrdtimeTask_box.CustomFormat = "        dd/MM  H:mm";
            OrdtimeTask_box.Text = task_dep_time;
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
                typeTask_box.Visible = false;
                OrderedTypeTask_box.Text = task_ordered_type;
                OrderedTypeTask_box.Visible = true;
            }


            
            colorTask_box.Text = task_car_color;


/*            switch (task_state)
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

            string task_numb = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            string task_datetime = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            string task_tab_user = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();


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
    }
}