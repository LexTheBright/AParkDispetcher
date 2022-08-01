
namespace AParkDispetcher
{
    partial class SelectDriverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchDrivers2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SelectionDriverGrid = new System.Windows.Forms.DataGridView();
            this.FIO_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionDriverGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.searchDrivers2);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.SelectionDriverGrid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 620);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите водителя";
            // 
            // searchDrivers2
            // 
            this.searchDrivers2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDrivers2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchDrivers2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchDrivers2.Font = new System.Drawing.Font("Cambria", 11.75F);
            this.searchDrivers2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchDrivers2.Location = new System.Drawing.Point(311, -3);
            this.searchDrivers2.Multiline = true;
            this.searchDrivers2.Name = "searchDrivers2";
            this.searchDrivers2.Size = new System.Drawing.Size(320, 23);
            this.searchDrivers2.TabIndex = 3;
            this.searchDrivers2.TabStop = false;
            this.searchDrivers2.Text = "Поиск";
            this.searchDrivers2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchDrivers2.TextChanged += new System.EventHandler(this.SearchDrivers2_TextChanged);
            this.searchDrivers2.Enter += new System.EventHandler(this.SearchDrivers2_Enter);
            this.searchDrivers2.Leave += new System.EventHandler(this.SearchDrivers2_Leave);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Controls.Add(this.ok_button);
            this.panel6.Controls.Add(this.cancel_button);
            this.panel6.Location = new System.Drawing.Point(3, 571);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(628, 46);
            this.panel6.TabIndex = 60;
            // 
            // ok_button
            // 
            this.ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ok_button.BackColor = System.Drawing.SystemColors.Window;
            this.ok_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_button.ForeColor = System.Drawing.Color.Black;
            this.ok_button.Location = new System.Drawing.Point(471, 4);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(150, 39);
            this.ok_button.TabIndex = 58;
            this.ok_button.Text = "Ок";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancel_button.BackColor = System.Drawing.SystemColors.Window;
            this.cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.ForeColor = System.Drawing.Color.Black;
            this.cancel_button.Location = new System.Drawing.Point(315, 4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(150, 39);
            this.cancel_button.TabIndex = 51;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // SelectionDriverGrid
            // 
            this.SelectionDriverGrid.AllowUserToAddRows = false;
            this.SelectionDriverGrid.AllowUserToDeleteRows = false;
            this.SelectionDriverGrid.AllowUserToResizeColumns = false;
            this.SelectionDriverGrid.AllowUserToResizeRows = false;
            this.SelectionDriverGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionDriverGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SelectionDriverGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.SelectionDriverGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectionDriverGrid.CausesValidation = false;
            this.SelectionDriverGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectionDriverGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SelectionDriverGrid.ColumnHeadersHeight = 40;
            this.SelectionDriverGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SelectionDriverGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO_col,
            this.Tab_col,
            this.dataGridViewTextBoxColumn7});
            this.SelectionDriverGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectionDriverGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SelectionDriverGrid.GridColor = System.Drawing.Color.Black;
            this.SelectionDriverGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectionDriverGrid.Location = new System.Drawing.Point(3, 23);
            this.SelectionDriverGrid.Margin = new System.Windows.Forms.Padding(0);
            this.SelectionDriverGrid.MultiSelect = false;
            this.SelectionDriverGrid.Name = "SelectionDriverGrid";
            this.SelectionDriverGrid.ReadOnly = true;
            this.SelectionDriverGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectionDriverGrid.RowHeadersVisible = false;
            this.SelectionDriverGrid.RowHeadersWidth = 90;
            this.SelectionDriverGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.SelectionDriverGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SelectionDriverGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SelectionDriverGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Azure;
            this.SelectionDriverGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.SelectionDriverGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.SelectionDriverGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.SelectionDriverGrid.RowTemplate.Height = 30;
            this.SelectionDriverGrid.RowTemplate.ReadOnly = true;
            this.SelectionDriverGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectionDriverGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectionDriverGrid.Size = new System.Drawing.Size(628, 546);
            this.SelectionDriverGrid.StandardTab = true;
            this.SelectionDriverGrid.TabIndex = 1;
            this.SelectionDriverGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.SelectionDriverGrid_CellFormatting);
            this.SelectionDriverGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectionDriverGrid_CellMouseDoubleClick);
            // 
            // FIO_col
            // 
            this.FIO_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIO_col.HeaderText = "Фамилия Имя Отчество";
            this.FIO_col.MinimumWidth = 300;
            this.FIO_col.Name = "FIO_col";
            this.FIO_col.ReadOnly = true;
            this.FIO_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tab_col
            // 
            this.Tab_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tab_col.HeaderText = "Табельный номер";
            this.Tab_col.MinimumWidth = 150;
            this.Tab_col.Name = "Tab_col";
            this.Tab_col.ReadOnly = true;
            this.Tab_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tab_col.Width = 170;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Состояние";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 117;
            // 
            // SelectDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(646, 627);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectDriverForm";
            this.Text = "Водители";
            this.Load += new System.EventHandler(this.SelectDriverForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectionDriverGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        public System.Windows.Forms.DataGridView SelectionDriverGrid;
        private System.Windows.Forms.TextBox searchDrivers2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tab_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}