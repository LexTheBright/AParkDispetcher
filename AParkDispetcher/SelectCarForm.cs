using System;
using System.Drawing;
using System.Windows.Forms;

namespace AParkDispetcher
{
    public partial class SelectCarForm : Form
    {
        public SelectCarForm()
        {
            InitializeComponent();
            Cars_list DC = new Cars_list();
            DC.FillSelectCarForm(SelectionCarGrid);
        }
        public SelectCarForm(DateTime Tleft, DateTime Tright)
        {
            InitializeComponent();
            Cars_list DC = new Cars_list();
            DC.FillSelectCarForm(SelectionCarGrid, Tleft, Tright);
        }

        private void SelectionCarGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (SelectionCarGrid.Rows[e.RowIndex].MinimumHeight != 35) SelectionCarGrid.Rows[e.RowIndex].MinimumHeight = 40;

            if (e.ColumnIndex == 0 && e.Value.ToString().Length > 5) e.Value = e.Value.ToString().Remove(e.Value.ToString().Length - 3);

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

        private void SelectCarForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.GetWorkingArea(this.Location).Right - this.Width, Screen.GetWorkingArea(this.Location).Bottom - this.Height);
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SelectionCarGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1) this.DialogResult = DialogResult.OK;
        }

        private void SearchAutos2_Enter(object sender, EventArgs e)
        {
            searchAutos2.Clear();
        }

        private void SearchAutos2_Leave(object sender, EventArgs e)
        {
            if (searchAutos2.Text == "") searchAutos2.Text = "Поиск";
        }

        private void SearchAutos2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchAutos2.Text))
                return;

            var values = searchAutos2.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < SelectionCarGrid.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = SelectionCarGrid.Rows[i];

                    if (row.Cells["Gov_num_col"].Value.ToString().Contains(value) ||
                        row.Cells["model_col"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        SelectionCarGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }
    }
}
