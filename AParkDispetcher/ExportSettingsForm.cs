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
    public partial class ExportSettingsForm : Form
    {
        public ExportSettingsForm()
        {
            InitializeComponent();
            //exLeftPicker.Format = DateTimePickerFormat.Custom;
            //exRightPicker.Format = DateTimePickerFormat.Custom;
            exLeftPicker.Value = DateTime.Now.AddMonths(-1);
            exRightPicker.Value = DateTime.Now;
        }

        private void exModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            exDoExportButton.Focus();
            if (exModeBox.SelectedItem.ToString() == "Все заявки")
            {
                exDriverButton.Enabled = false;
                exAutoButton.Enabled = false;
                exDriverText.BackColor = Color.PaleGoldenrod;
                exDriverText.Clear();
                exAutoText.BackColor = Color.PaleGoldenrod;
                exAutoText.Clear();
            }
            if (exModeBox.SelectedItem.ToString() == "По водителю")
            {
                exDriverButton.Enabled = true;
                exAutoButton.Enabled = false;
                exDriverText.BackColor = Color.MintCream;
                exAutoText.BackColor = Color.PaleGoldenrod;
                exAutoText.Clear();

            }
            if (exModeBox.SelectedItem.ToString() == "По автомобилю")
            {
                exDriverButton.Enabled = false;
                exAutoButton.Enabled = true;
                exDriverText.BackColor = Color.PaleGoldenrod;
                exDriverText.Clear();
                exAutoText.BackColor = Color.MintCream;
            }
        }

        private void Cancel_driverstate_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_state_button_Click(object sender, EventArgs e)
        {
            if (exModeBox.SelectedIndex == -1) exModeBox.SelectedIndex = 0;
            if (exModeBox.SelectedItem.ToString() == "Все заявки")
            {
                DateExporter.ReportAllForPeriod(exLeftPicker.Value, exRightPicker.Value);
            }
            if (exModeBox.SelectedItem.ToString() == "По водителю")
            {
                DateExporter.ReportWhereForPeriod("driver_tab_number", exDriverText.Text.Split(' ')[0], exLeftPicker.Value, exRightPicker.Value);
            }
            if (exModeBox.SelectedItem.ToString() == "По автомобилю")
            {
                DateExporter.ReportWhereForPeriod("car_reg_mark", exAutoText.Text, exLeftPicker.Value, exRightPicker.Value);
            }
        }

        private void exAutoButton_Click(object sender, EventArgs e)
        {
            SelectCarForm CurSelectCarForm = new SelectCarForm();
            if (CurSelectCarForm.ShowDialog(this) == DialogResult.OK)
            {
                int Index = CurSelectCarForm.SelectionCarGrid.SelectedCells[0].RowIndex;
                string car_mark = CurSelectCarForm.SelectionCarGrid.Rows[Index].Cells[0].Value.ToString();

                exAutoText.Text = car_mark;
            }
        }

        private void exDriverButton_Click(object sender, EventArgs e)
        {
            SelectDriverForm CurSelectDriverForm = new SelectDriverForm();
            if (CurSelectDriverForm.ShowDialog(this) == DialogResult.OK)
            {
                int Index = CurSelectDriverForm.SelectionDriverGrid.SelectedCells[0].RowIndex;
                string FIO = CurSelectDriverForm.SelectionDriverGrid.Rows[Index].Cells[0].Value.ToString();
                string Dr_tab_num = CurSelectDriverForm.SelectionDriverGrid.Rows[Index].Cells[1].Value.ToString();
                exDriverText.Text = Dr_tab_num + " (" + FIO.Split(' ')[0] + ")";
            }
        }

        private void exLeftPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Excel_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
