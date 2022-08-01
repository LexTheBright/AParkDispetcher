
namespace AParkDispetcher
{
    partial class ApprovalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tasks_group = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Approve_button = new System.Windows.Forms.Button();
            this.Disapprove_button = new System.Windows.Forms.Button();
            this.unselect_all = new System.Windows.Forms.Button();
            this.select_all = new System.Windows.Forms.Button();
            this.approvalGrid = new System.Windows.Forms.DataGridView();
            this.searchTasks = new System.Windows.Forms.TextBox();
            this.approveCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TNum_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTub_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_state_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordered_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordered_duration_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_description_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chdescription_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_tab_number_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_reg_mark_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordered_ctype_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasks_group.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approvalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Tasks_group
            // 
            this.Tasks_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tasks_group.BackColor = System.Drawing.Color.Transparent;
            this.Tasks_group.Controls.Add(this.panel3);
            this.Tasks_group.Controls.Add(this.approvalGrid);
            this.Tasks_group.Controls.Add(this.searchTasks);
            this.Tasks_group.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Tasks_group.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tasks_group.Location = new System.Drawing.Point(3, 3);
            this.Tasks_group.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Tasks_group.Name = "Tasks_group";
            this.Tasks_group.Size = new System.Drawing.Size(1303, 623);
            this.Tasks_group.TabIndex = 9;
            this.Tasks_group.TabStop = false;
            this.Tasks_group.Text = "Заявки";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Controls.Add(this.Approve_button);
            this.panel3.Controls.Add(this.Disapprove_button);
            this.panel3.Controls.Add(this.unselect_all);
            this.panel3.Controls.Add(this.select_all);
            this.panel3.Location = new System.Drawing.Point(6, 573);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1291, 46);
            this.panel3.TabIndex = 60;
            // 
            // Approve_button
            // 
            this.Approve_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Approve_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Approve_button.BackColor = System.Drawing.SystemColors.Window;
            this.Approve_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Approve_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Approve_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Approve_button.ForeColor = System.Drawing.Color.Black;
            this.Approve_button.Location = new System.Drawing.Point(1125, 4);
            this.Approve_button.Name = "Approve_button";
            this.Approve_button.Size = new System.Drawing.Size(159, 39);
            this.Approve_button.TabIndex = 9;
            this.Approve_button.Text = "Утвердить заявки";
            this.Approve_button.UseVisualStyleBackColor = false;
            this.Approve_button.Click += new System.EventHandler(this.Approve_button_Click);
            // 
            // Disapprove_button
            // 
            this.Disapprove_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Disapprove_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Disapprove_button.BackColor = System.Drawing.SystemColors.Window;
            this.Disapprove_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Disapprove_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Disapprove_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disapprove_button.ForeColor = System.Drawing.Color.Black;
            this.Disapprove_button.Location = new System.Drawing.Point(960, 4);
            this.Disapprove_button.Name = "Disapprove_button";
            this.Disapprove_button.Size = new System.Drawing.Size(159, 39);
            this.Disapprove_button.TabIndex = 43;
            this.Disapprove_button.TabStop = false;
            this.Disapprove_button.Text = "Отменить заявки";
            this.Disapprove_button.UseVisualStyleBackColor = false;
            this.Disapprove_button.Click += new System.EventHandler(this.Disapprove_button_Click);
            // 
            // unselect_all
            // 
            this.unselect_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unselect_all.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unselect_all.BackColor = System.Drawing.SystemColors.Window;
            this.unselect_all.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.unselect_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unselect_all.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unselect_all.ForeColor = System.Drawing.Color.Black;
            this.unselect_all.Location = new System.Drawing.Point(163, 4);
            this.unselect_all.Name = "unselect_all";
            this.unselect_all.Size = new System.Drawing.Size(150, 39);
            this.unselect_all.TabIndex = 92;
            this.unselect_all.TabStop = false;
            this.unselect_all.Text = "Снять все";
            this.unselect_all.UseVisualStyleBackColor = false;
            this.unselect_all.Click += new System.EventHandler(this.User_button_edit_Click);
            // 
            // select_all
            // 
            this.select_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.select_all.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.select_all.BackColor = System.Drawing.SystemColors.Window;
            this.select_all.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.select_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select_all.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_all.ForeColor = System.Drawing.Color.Black;
            this.select_all.Location = new System.Drawing.Point(7, 4);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(150, 39);
            this.select_all.TabIndex = 8;
            this.select_all.Text = "Выделить все";
            this.select_all.UseVisualStyleBackColor = false;
            this.select_all.Click += new System.EventHandler(this.User_button_add_Click);
            // 
            // approvalGrid
            // 
            this.approvalGrid.AllowUserToAddRows = false;
            this.approvalGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.approvalGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.approvalGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approvalGrid.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.approvalGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.approvalGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.approvalGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.approvalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approvalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.approveCol,
            this.TNum_col,
            this.Column2,
            this.UTub_col,
            this.order_state_col,
            this.ordered_time_col,
            this.ordered_duration_col,
            this.departure_col,
            this.destination_col,
            this.user_description_col,
            this.chdescription_col,
            this.driver_tab_number_col,
            this.car_reg_mark_col,
            this.Column10,
            this.Column20,
            this.ordered_ctype_col,
            this.FIO_col,
            this.Column23});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.approvalGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.approvalGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.approvalGrid.Location = new System.Drawing.Point(6, 25);
            this.approvalGrid.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.approvalGrid.MultiSelect = false;
            this.approvalGrid.Name = "approvalGrid";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.approvalGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.approvalGrid.RowHeadersVisible = false;
            this.approvalGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.approvalGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.approvalGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.approvalGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.approvalGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvalGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.approvalGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.approvalGrid.RowTemplate.Height = 25;
            this.approvalGrid.RowTemplate.ReadOnly = true;
            this.approvalGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.approvalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.approvalGrid.Size = new System.Drawing.Size(1291, 546);
            this.approvalGrid.StandardTab = true;
            this.approvalGrid.TabIndex = 4;
            this.approvalGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApprovalGrid_CellContentClick);
            this.approvalGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ApprovalGrid_CellFormatting);
            this.approvalGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ApprovalGrid_CellMouseDoubleClick);
            this.approvalGrid.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.ApprovalGrid_SortCompare);
            // 
            // searchTasks
            // 
            this.searchTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTasks.Font = new System.Drawing.Font("Cambria", 11.75F);
            this.searchTasks.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchTasks.Location = new System.Drawing.Point(947, -1);
            this.searchTasks.Multiline = true;
            this.searchTasks.Name = "searchTasks";
            this.searchTasks.Size = new System.Drawing.Size(350, 23);
            this.searchTasks.TabIndex = 5;
            this.searchTasks.Text = "Поиск";
            this.searchTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchTasks.TextChanged += new System.EventHandler(this.SearchTasks_TextChanged);
            this.searchTasks.Enter += new System.EventHandler(this.SearchTasks_Enter);
            this.searchTasks.Leave += new System.EventHandler(this.SearchTasks_Leave);
            // 
            // approveCol
            // 
            this.approveCol.FalseValue = "";
            this.approveCol.HeaderText = "Утвердить?";
            this.approveCol.Name = "approveCol";
            this.approveCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.approveCol.ToolTipText = "Для утверждения поставьте галочку напротив заявки и нажмите Утвердить заявки";
            this.approveCol.TrueValue = "true";
            // 
            // TNum_col
            // 
            this.TNum_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TNum_col.HeaderText = "№";
            this.TNum_col.Name = "TNum_col";
            this.TNum_col.Width = 54;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата заявки";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // UTub_col
            // 
            this.UTub_col.HeaderText = "Табельный заказчика";
            this.UTub_col.Name = "UTub_col";
            // 
            // order_state_col
            // 
            this.order_state_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.order_state_col.HeaderText = "Статус";
            this.order_state_col.Name = "order_state_col";
            this.order_state_col.Visible = false;
            this.order_state_col.Width = 83;
            // 
            // ordered_time_col
            // 
            this.ordered_time_col.HeaderText = "Выезд";
            this.ordered_time_col.Name = "ordered_time_col";
            this.ordered_time_col.Width = 130;
            // 
            // ordered_duration_col
            // 
            this.ordered_duration_col.HeaderText = "Длительность";
            this.ordered_duration_col.Name = "ordered_duration_col";
            this.ordered_duration_col.Visible = false;
            // 
            // departure_col
            // 
            this.departure_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departure_col.HeaderText = "Место выезда";
            this.departure_col.Name = "departure_col";
            // 
            // destination_col
            // 
            this.destination_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destination_col.HeaderText = "Место назначения";
            this.destination_col.MinimumWidth = 95;
            this.destination_col.Name = "destination_col";
            // 
            // user_description_col
            // 
            this.user_description_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_description_col.FillWeight = 150F;
            this.user_description_col.HeaderText = "Комментарий к заявке";
            this.user_description_col.Name = "user_description_col";
            // 
            // chdescription_col
            // 
            this.chdescription_col.HeaderText = "Последний комментарий";
            this.chdescription_col.Name = "chdescription_col";
            this.chdescription_col.Visible = false;
            // 
            // driver_tab_number_col
            // 
            this.driver_tab_number_col.HeaderText = "Табельный водителя";
            this.driver_tab_number_col.Name = "driver_tab_number_col";
            // 
            // car_reg_mark_col
            // 
            this.car_reg_mark_col.HeaderText = "Номер авто";
            this.car_reg_mark_col.Name = "car_reg_mark_col";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Тип авто";
            this.Column10.Name = "Column10";
            this.Column10.Width = 70;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Цвет";
            this.Column20.Name = "Column20";
            this.Column20.Visible = false;
            // 
            // ordered_ctype_col
            // 
            this.ordered_ctype_col.HeaderText = "Запрашиваемый тип авто";
            this.ordered_ctype_col.Name = "ordered_ctype_col";
            this.ordered_ctype_col.Visible = false;
            // 
            // FIO_col
            // 
            this.FIO_col.HeaderText = "User_FIO";
            this.FIO_col.Name = "FIO_col";
            this.FIO_col.Visible = false;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Модель авто";
            this.Column23.Name = "Column23";
            this.Column23.Visible = false;
            // 
            // ApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1309, 628);
            this.Controls.Add(this.Tasks_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "ApprovalForm";
            this.Text = "Панель согласования";
            this.Deactivate += new System.EventHandler(this.ApprovalForm_Deactivate);
            this.Load += new System.EventHandler(this.ApprovalForm_Load);
            this.Tasks_group.ResumeLayout(false);
            this.Tasks_group.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.approvalGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Tasks_group;
        private System.Windows.Forms.TextBox searchTasks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Approve_button;
        private System.Windows.Forms.Button Disapprove_button;
        private System.Windows.Forms.Button unselect_all;
        private System.Windows.Forms.Button select_all;
        private System.Windows.Forms.DataGridView approvalGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approveCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNum_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTub_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_state_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordered_time_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordered_duration_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_description_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn chdescription_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_tab_number_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_reg_mark_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordered_ctype_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
    }
}