
namespace AParkDispetcher
{
    partial class TaskHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minimize_button = new System.Windows.Forms.Button();
            this.expand_button = new System.Windows.Forms.Button();
            this.TaskHistoryGrid = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change_com_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dura_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dest_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ord_type_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_com_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskHistoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.minimize_button);
            this.groupBox1.Controls.Add(this.expand_button);
            this.groupBox1.Controls.Add(this.TaskHistoryGrid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "История заявки № 1";
            // 
            // minimize_button
            // 
            this.minimize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_button.BackColor = System.Drawing.Color.White;
            this.minimize_button.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimize_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minimize_button.Location = new System.Drawing.Point(1106, -2);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(115, 25);
            this.minimize_button.TabIndex = 6;
            this.minimize_button.Text = "← Свернуть";
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Visible = false;
            this.minimize_button.Click += new System.EventHandler(this.Minimize_button_Click);
            // 
            // expand_button
            // 
            this.expand_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expand_button.BackColor = System.Drawing.Color.White;
            this.expand_button.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.expand_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.expand_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expand_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.expand_button.Location = new System.Drawing.Point(1106, -1);
            this.expand_button.Name = "expand_button";
            this.expand_button.Size = new System.Drawing.Size(115, 25);
            this.expand_button.TabIndex = 1;
            this.expand_button.Text = "Раскрыть →";
            this.expand_button.UseVisualStyleBackColor = false;
            this.expand_button.Click += new System.EventHandler(this.Expand_button_Click);
            // 
            // TaskHistoryGrid
            // 
            this.TaskHistoryGrid.AllowUserToAddRows = false;
            this.TaskHistoryGrid.AllowUserToDeleteRows = false;
            this.TaskHistoryGrid.AllowUserToResizeColumns = false;
            this.TaskHistoryGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskHistoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TaskHistoryGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskHistoryGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TaskHistoryGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TaskHistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskHistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TaskHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column5,
            this.change_com_col,
            this.Column11,
            this.dura_col,
            this.dep_col,
            this.dest_col,
            this.ord_type_col,
            this.user_com_col,
            this.type_col,
            this.Column18,
            this.model_col,
            this.color_col,
            this.Column17,
            this.Column22,
            this.Column1,
            this.Column4,
            this.Column19});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskHistoryGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.TaskHistoryGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TaskHistoryGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.TaskHistoryGrid.Location = new System.Drawing.Point(3, 25);
            this.TaskHistoryGrid.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TaskHistoryGrid.MultiSelect = false;
            this.TaskHistoryGrid.Name = "TaskHistoryGrid";
            this.TaskHistoryGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskHistoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TaskHistoryGrid.RowHeadersVisible = false;
            this.TaskHistoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskHistoryGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TaskHistoryGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TaskHistoryGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Azure;
            this.TaskHistoryGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskHistoryGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.TaskHistoryGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskHistoryGrid.RowTemplate.Height = 35;
            this.TaskHistoryGrid.RowTemplate.ReadOnly = true;
            this.TaskHistoryGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskHistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TaskHistoryGrid.ShowEditingIcon = false;
            this.TaskHistoryGrid.Size = new System.Drawing.Size(1218, 413);
            this.TaskHistoryGrid.StandardTab = true;
            this.TaskHistoryGrid.TabIndex = 5;
            this.TaskHistoryGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TaskHistoryGrid_CellFormatting);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Статус";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 83;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Дата изменения";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 144;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Табельный изменившего";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // change_com_col
            // 
            this.change_com_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.change_com_col.FillWeight = 150F;
            this.change_com_col.HeaderText = "Комментарий об изменении";
            this.change_com_col.MinimumWidth = 150;
            this.change_com_col.Name = "change_com_col";
            this.change_com_col.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column11.HeaderText = "Время выезда";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 131;
            // 
            // dura_col
            // 
            this.dura_col.HeaderText = "Длительность (ч)";
            this.dura_col.Name = "dura_col";
            this.dura_col.ReadOnly = true;
            this.dura_col.Visible = false;
            this.dura_col.Width = 120;
            // 
            // dep_col
            // 
            this.dep_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dep_col.HeaderText = "Место выезда";
            this.dep_col.MinimumWidth = 120;
            this.dep_col.Name = "dep_col";
            this.dep_col.ReadOnly = true;
            // 
            // dest_col
            // 
            this.dest_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dest_col.HeaderText = "Место назначения";
            this.dest_col.MinimumWidth = 120;
            this.dest_col.Name = "dest_col";
            this.dest_col.ReadOnly = true;
            // 
            // ord_type_col
            // 
            this.ord_type_col.HeaderText = "Запрашиваемый тип авто";
            this.ord_type_col.Name = "ord_type_col";
            this.ord_type_col.ReadOnly = true;
            this.ord_type_col.Visible = false;
            this.ord_type_col.Width = 140;
            // 
            // user_com_col
            // 
            this.user_com_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_com_col.FillWeight = 150F;
            this.user_com_col.HeaderText = "Сообщение заказчика";
            this.user_com_col.MinimumWidth = 120;
            this.user_com_col.Name = "user_com_col";
            this.user_com_col.ReadOnly = true;
            this.user_com_col.Visible = false;
            // 
            // type_col
            // 
            this.type_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.type_col.HeaderText = "Тип авто";
            this.type_col.Name = "type_col";
            this.type_col.ReadOnly = true;
            this.type_col.Visible = false;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Номер авто";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // model_col
            // 
            this.model_col.HeaderText = "Модель авто";
            this.model_col.Name = "model_col";
            this.model_col.ReadOnly = true;
            // 
            // color_col
            // 
            this.color_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.color_col.HeaderText = "Цвет авто";
            this.color_col.Name = "color_col";
            this.color_col.ReadOnly = true;
            this.color_col.Visible = false;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Табельный водителя";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "User_FIO";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "№ заявки";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата подачи";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 130;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Табельный заказчика";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            // 
            // TaskHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1224, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaskHistoryForm";
            this.Text = "История заявки";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.TaskHistoryForm_Deactivate);
            this.Load += new System.EventHandler(this.TaskHistoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskHistoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TaskHistoryGrid;
        private System.Windows.Forms.Button expand_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn change_com_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dura_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dest_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ord_type_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_com_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn color_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
    }
}