﻿using System;
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
    public partial class TaskHistoryForm : Form
    {
        public string task_number;
        public string tub_from_click;
        public string task_date_time;

        SingleTaskHistory ST;

        public TaskHistoryForm()
        {
            InitializeComponent();
        }

        public TaskHistoryForm(string num, string tab, string dt)
        {
            task_number = num;
            tub_from_click = tab;
            task_date_time = dt;
            InitializeComponent();
        }

        private void TaskHistoryGrid_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void TaskHistoryForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskHistoryForm_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "История заявки #" + task_number + "            Подана: " + task_date_time + "            Табельный заказчика: " + tub_from_click;
            ST = new SingleTaskHistory();
            ST.fillHistoryTaskForm(TaskHistoryGrid, task_number);
            TaskHistoryGrid.ClearSelection();
            THF_size();
        }

        private void THF_size()
        {
            TaskHistoryGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewElementStates states = DataGridViewElementStates.None;
            TaskHistoryGrid.ScrollBars = ScrollBars.Horizontal;
            var totalHeight = TaskHistoryGrid.Rows.GetRowsHeight(states) + TaskHistoryGrid.ColumnHeadersHeight;
            //totalHeight += TaskHistoryGrid.Rows.Count * 4;

            this.ClientSize = new Size(this.Width, totalHeight + 28 + 20);

            if (TaskHistoryGrid.Controls.OfType<HScrollBar>().First().Visible)
            {
                totalHeight += 35;
                this.ClientSize = new Size(this.Width, totalHeight + 28 + 20);
            }

            TaskHistoryGrid.ClientSize = new Size(TaskHistoryGrid.Width, totalHeight);
        }

        private void expand_button_Click(object sender, EventArgs e)
        {
            //if (Screen.PrimaryScreen.Bounds.Size.Width >= 1800) {
            expand_button.Visible = false;
            minimize_button.Visible = true;
            this.Width = Screen.GetWorkingArea(this.Location).Width;

            this.TopMost = true;

            //this.Width = 1240;

            // убрать - 10 на продакшене
            this.Location = new Point(Screen.GetWorkingArea(this.Location).Left - 8, this.Location.Y);


            //this.Location = new Point(0, this.Location.Y);

            /*model_col.Width = 100;
            model_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.None;

            dest_col.Width = 100;
            dest_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.None;

            dep_col.Width = 100;
            dep_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.None;*/

            /*change_com_col.Width = 150;
            //change_com_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.None;

            user_com_col.Width = 150;
            user_com_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.None;*/

            //dura_col.Visible = true;
            ord_type_col.Visible = true;
            type_col.Visible = true;
            user_com_col.Visible = true;
            color_col.Visible = true;
            THF_size();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            expand_button.Visible = true;
            minimize_button.Visible = false;
            this.Width = 1240;
            this.Location = new Point(Screen.GetWorkingArea(this.Location).Left, this.Location.Y);

            //this.Location = new Point(200, this.Location.Y);

            /*model_col.FillWeight = 100;
            model_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.Fill;

            dest_col.FillWeight = 100;
            dest_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.Fill;

            dep_col.FillWeight = 100;
            dep_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.Fill;*/

            /*change_com_col.FillWeight = 150;
            change_com_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.Fill;

            /*user_com_col.FillWeight = 150;
            user_com_col.AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.Fill;*/

            //dura_col.Visible = false;
            ord_type_col.Visible = false;
            type_col.Visible = false;
            user_com_col.Visible = false;
            color_col.Visible = false;
            THF_size();
        }

        private void TaskHistoryGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (TaskHistoryGrid.Rows[e.RowIndex].MinimumHeight != 35) TaskHistoryGrid.Rows[e.RowIndex].MinimumHeight = 35;

            if (e.ColumnIndex == 11 && e.Value.ToString().Length > 5) e.Value = e.Value.ToString().Remove(e.Value.ToString().Length - 3);

            if (e.ColumnIndex == 0)
            {
                switch (e.Value)
                {
                    case "0":
                        //e.CellStyle.BackColor = Color.Orange;
                        //e.CellStyle.SelectionBackColor = Color.DarkOrange;
                        e.Value = "новая";
                        break;
                    case "1":
                        //e.CellStyle.BackColor = Color.LightGreen;
                        //e.CellStyle.SelectionBackColor = Color.Green;
                        e.Value = "подтверждена";
                        break;
                    case "2":
                        //e.CellStyle.BackColor = Color.LightGreen;
                        //e.CellStyle.SelectionBackColor = Color.Green;
                        e.Value = "исполняется";
                        break;
                    case "3":
                        //e.CellStyle.BackColor = Color.LightGray;
                        //e.CellStyle.SelectionBackColor = Color.Gray;
                        e.Value = "завершена";
                        break;
                    case "4":
                        e.Value = "отменена";
                        //e.CellStyle.BackColor = Color.LightGray;
                        //e.CellStyle.SelectionBackColor = Color.Gray;
                        break;
                    default:
                        break;
                }
            }
            //&& TaskHistoryGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Displayed && TaskHistoryGrid.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Displayed
            if (e.RowIndex > 0 && e.ColumnIndex > 1)
            {
                if (TaskHistoryGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != TaskHistoryGrid.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.ToString())
                {
                    if (TaskHistoryGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                    {
                        e.CellStyle.BackColor = Color.Khaki;
                    }
                }
            }
        }
    }
}