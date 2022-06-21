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
    public partial class ApprovalForm : Form
    {
        Tasks_list DT;
        DBRedactor DBR;
        public ApprovalForm()
        {
            InitializeComponent();
        }

        private void ApprovalForm_Load(object sender, EventArgs e)
        {
            DT = new Tasks_list();
            DT.FillMasterTasks(approvalGrid);
        }

        private void User_button_add_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in approvalGrid.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void approvalGrid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }

        private void approvalGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 1) approvalGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            else approvalGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;

            if (e.ColumnIndex == 5) e.Value = Convert.ToDateTime(e.Value).ToString("dd.MM  [HH:mm]");

            if (approvalGrid.Rows[e.RowIndex].MinimumHeight != 35) approvalGrid.Rows[e.RowIndex].MinimumHeight = 35;


            if (e.ColumnIndex == 12 && e.Value.ToString().Length > 5)
            {
                e.Value = e.Value.ToString().Remove(e.Value.ToString().Length - 3);
            }
        }

        private void approvalGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void approvalGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                if ((bool)approvalGrid.Rows[e.RowIndex].Cells[0].Value) approvalGrid.Rows[e.RowIndex].Cells[0].Value = false;
                else approvalGrid.Rows[e.RowIndex].Cells[0].Value = true;
            }
        }

        private void User_button_edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in approvalGrid.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void Approve_button_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsList = new List<DataGridViewRow>();
            Dictionary<string, string> props = new Dictionary<string, string>();
            foreach (DataGridViewRow row in approvalGrid.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    rowsList.Add(row);
                }
            }
            if (rowsList.Count > 0)
            {
                foreach (DataGridViewRow row in rowsList)
                {
                    DBR = new DBRedactor();
                    props.Add("order_state", "2");
                    DBR.updateByID("tasks", "task_num", row.Cells["TNum_col"].Value.ToString(), props);
                    props.Add("task_num", row.Cells["TNum_col"].Value.ToString());
                    props.Add("ordered_ctype", row.Cells["ordered_ctype_col"].Value.ToString());
                    props.Add("ordered_time", DateTime.Parse(row.Cells["ordered_time_col"].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss"));
                    props.Add("ordered_duration", row.Cells["ordered_duration_col"].Value.ToString());
                    props.Add("departure", row.Cells["departure_col"].Value.ToString());
                    props.Add("destination", row.Cells["destination_col"].Value.ToString());
                    props.Add("user_description", row.Cells["user_description_col"].Value.ToString());
                    props.Add("car_reg_mark", row.Cells["car_reg_mark_col"].Value.ToString());
                    props.Add("changer_tab_number", AppUser.tabNum);
                    props.Add("driver_tab_number", row.Cells["driver_tab_number_col"].Value.ToString());
                    props.Add("chdatetime", DBR.getDateTimeFromServer().ToString("yyyy-MM-dd HH:mm:ss"));
                    props.Add("chdescription", "Утверждено начальником АХЧ");
                    DBR.CreateNewKouple("thistory", props);
                    MessageBox.Show("Заявки утверждены!", "Завершение операции");
                    approvalGrid.Rows.Clear();
                    DT.FillMasterTasks(approvalGrid);
                }
            }
        }

        private void Disapprove_button_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsList = new List<DataGridViewRow>();
            Dictionary<string, string> props = new Dictionary<string, string>();
            foreach (DataGridViewRow row in approvalGrid.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    rowsList.Add(row);
                }
            }
            if (rowsList.Count > 0)
            {
                foreach (DataGridViewRow row in rowsList)
                {
                    DBR = new DBRedactor();
                    props.Add("order_state", "5");
                    DBR.updateByID("tasks", "task_num", row.Cells["TNum_col"].Value.ToString(), props);
                    props.Add("task_num", row.Cells["TNum_col"].Value.ToString());
                    props.Add("ordered_ctype", row.Cells["ordered_ctype_col"].Value.ToString());
                    props.Add("ordered_time", DateTime.Parse(row.Cells["ordered_time_col"].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss"));
                    props.Add("ordered_duration", row.Cells["ordered_duration_col"].Value.ToString());
                    props.Add("departure", row.Cells["departure_col"].Value.ToString());
                    props.Add("destination", row.Cells["destination_col"].Value.ToString());
                    props.Add("user_description", row.Cells["user_description_col"].Value.ToString());
                    props.Add("car_reg_mark", row.Cells["car_reg_mark_col"].Value.ToString());
                    props.Add("changer_tab_number", AppUser.tabNum);
                    props.Add("driver_tab_number", row.Cells["driver_tab_number_col"].Value.ToString());
                    props.Add("chdatetime", DBR.getDateTimeFromServer().ToString("yyyy-MM-dd HH:mm:ss"));
                    props.Add("chdescription", "Отменена начальником АХЧ");
                    DBR.CreateNewKouple("thistory", props);
                    MessageBox.Show("Заявки отмнены!", "Завершение операции");
                    approvalGrid.Rows.Clear();
                    DT.FillMasterTasks(approvalGrid);
                }
            }
        }

        private void searchTasks_TextChanged(object sender, EventArgs e)
        {
            approvalGrid.ClearSelection();

            if (string.IsNullOrWhiteSpace(searchTasks.Text))
                return;

            var values = searchTasks.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < approvalGrid.RowCount; i++)
            {
                var row = approvalGrid.Rows[i];
                foreach (string value in values)
                {
                    if (row.Cells["FIO_col"].Value.ToString().Contains(value) ||
                        row.Cells["UTub_col"].Value.ToString().Contains(value) ||
                        row.Cells["TNum_col"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        approvalGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
                if (row.Cells["TNum_col"].Value.ToString() == values[0])
                {
                    row.Selected = true;
                    approvalGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void searchTasks_Enter(object sender, EventArgs e)
        {
            searchTasks.Clear();
        }

        private void searchTasks_Leave(object sender, EventArgs e)
        {
            if (searchTasks.Text == "") searchTasks.Text = "Поиск";
        }

        private void approvalGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //MessageBox.Show("The row index = " + e.RowIndex);

            string task_numb = approvalGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string task_datetime = approvalGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            string task_tab_user = approvalGrid.Rows[e.RowIndex].Cells[3].Value.ToString();


            TaskHistoryForm CurTHistoryForm = new TaskHistoryForm(task_numb, task_tab_user, task_datetime);
            CurTHistoryForm.Show();
        }

        private void ApprovalForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
