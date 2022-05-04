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
    public partial class SelectDriverForm : Form
    {
        public SelectDriverForm()
        {
            InitializeComponent();
            Drivers_list DD = new Drivers_list();
            DD.fillSelectDriverForm(SelectionDriverGrid);
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SelectionDriverGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (SelectionDriverGrid.Rows[e.RowIndex].MinimumHeight != 35) SelectionDriverGrid.Rows[e.RowIndex].MinimumHeight = 40;

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

        private void SelectDriverForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.GetWorkingArea(this.Location).Right - this.Width, Screen.GetWorkingArea(this.Location).Bottom - this.Height);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectionDriverGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1) this.DialogResult = DialogResult.OK;
        }

        private void searchDrivers2_Enter(object sender, EventArgs e)
        {
            searchDrivers2.Clear();
        }

        private void searchDrivers2_Leave(object sender, EventArgs e)
        {
            if (searchDrivers2.Text == "") searchDrivers2.Text = "Поиск";
        }

        private void searchDrivers2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchDrivers2.Text))
                return;

            var values = searchDrivers2.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < SelectionDriverGrid.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = SelectionDriverGrid.Rows[i];

                    if (row.Cells["FIO_col"].Value.ToString().Contains(value) ||
                        row.Cells["Tab_col"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        SelectionDriverGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }
    }
}
