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
    public partial class SelectCarForm : Form
    {
        public SelectCarForm()
        {
            InitializeComponent();
            Cars_list DC = new Cars_list();
            DC.fillSelectCarForm(SelectionCarGrid);
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

        private void SelectionCarGrid_SelectionChanged(object sender, EventArgs e)
        {
            int selectedrowindex = SelectionCarGrid.SelectedCells[0].RowIndex;
            //Car_description_text.Text = SelectionCarGrid.Rows[selectedrowindex].Cells[5].Value.ToString();
        }

        private void SelectCarForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.GetWorkingArea(this.Location).Right-this.Width, Screen.GetWorkingArea(this.Location).Bottom - this.Height);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SelectionCarGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
