
namespace AParkDispetcher
{
    partial class SelectCarForm
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
            this.searchAutos2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SelectionCarGrid = new System.Windows.Forms.DataGridView();
            this.Gov_num_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionCarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.searchAutos2);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.SelectionCarGrid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 620);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите автомобиль";
            // 
            // searchAutos2
            // 
            this.searchAutos2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchAutos2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchAutos2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchAutos2.Font = new System.Drawing.Font("Cambria", 11.75F);
            this.searchAutos2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchAutos2.Location = new System.Drawing.Point(650, -3);
            this.searchAutos2.Multiline = true;
            this.searchAutos2.Name = "searchAutos2";
            this.searchAutos2.Size = new System.Drawing.Size(320, 23);
            this.searchAutos2.TabIndex = 2;
            this.searchAutos2.TabStop = false;
            this.searchAutos2.Text = "Поиск";
            this.searchAutos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchAutos2.TextChanged += new System.EventHandler(this.SearchAutos2_TextChanged);
            this.searchAutos2.Enter += new System.EventHandler(this.SearchAutos2_Enter);
            this.searchAutos2.Leave += new System.EventHandler(this.SearchAutos2_Leave);
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
            this.panel6.Size = new System.Drawing.Size(967, 46);
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
            this.ok_button.Location = new System.Drawing.Point(810, 4);
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
            this.cancel_button.Location = new System.Drawing.Point(654, 4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(150, 39);
            this.cancel_button.TabIndex = 51;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // SelectionCarGrid
            // 
            this.SelectionCarGrid.AllowUserToAddRows = false;
            this.SelectionCarGrid.AllowUserToDeleteRows = false;
            this.SelectionCarGrid.AllowUserToResizeColumns = false;
            this.SelectionCarGrid.AllowUserToResizeRows = false;
            this.SelectionCarGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionCarGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SelectionCarGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.SelectionCarGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectionCarGrid.CausesValidation = false;
            this.SelectionCarGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectionCarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SelectionCarGrid.ColumnHeadersHeight = 40;
            this.SelectionCarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SelectionCarGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gov_num_col,
            this.model_col,
            this.dataGridViewTextBoxColumn6,
            this.Column2,
            this.dataGridViewTextBoxColumn7,
            this.Column1});
            this.SelectionCarGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectionCarGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SelectionCarGrid.GridColor = System.Drawing.Color.Black;
            this.SelectionCarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectionCarGrid.Location = new System.Drawing.Point(3, 23);
            this.SelectionCarGrid.Margin = new System.Windows.Forms.Padding(0);
            this.SelectionCarGrid.MultiSelect = false;
            this.SelectionCarGrid.Name = "SelectionCarGrid";
            this.SelectionCarGrid.ReadOnly = true;
            this.SelectionCarGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectionCarGrid.RowHeadersVisible = false;
            this.SelectionCarGrid.RowHeadersWidth = 90;
            this.SelectionCarGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.SelectionCarGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SelectionCarGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SelectionCarGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Azure;
            this.SelectionCarGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.SelectionCarGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.SelectionCarGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.SelectionCarGrid.RowTemplate.Height = 30;
            this.SelectionCarGrid.RowTemplate.ReadOnly = true;
            this.SelectionCarGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectionCarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectionCarGrid.Size = new System.Drawing.Size(967, 546);
            this.SelectionCarGrid.StandardTab = true;
            this.SelectionCarGrid.TabIndex = 1;
            this.SelectionCarGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.SelectionCarGrid_CellFormatting);
            this.SelectionCarGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectionCarGrid_CellMouseDoubleClick);
            // 
            // Gov_num_col
            // 
            this.Gov_num_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gov_num_col.HeaderText = "Гос. номер";
            this.Gov_num_col.Name = "Gov_num_col";
            this.Gov_num_col.ReadOnly = true;
            this.Gov_num_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gov_num_col.Width = 120;
            // 
            // model_col
            // 
            this.model_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.model_col.HeaderText = "Модель ";
            this.model_col.MinimumWidth = 150;
            this.model_col.Name = "model_col";
            this.model_col.ReadOnly = true;
            this.model_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.model_col.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Тип авто";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Цвет";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Текущая занятость";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 175;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Описание";
            this.Column1.MinimumWidth = 150;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // SelectCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(985, 631);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectCarForm";
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.SelectCarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectionCarGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        public System.Windows.Forms.DataGridView SelectionCarGrid;
        private System.Windows.Forms.TextBox searchAutos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gov_num_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}