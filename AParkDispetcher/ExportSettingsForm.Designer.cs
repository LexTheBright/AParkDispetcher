
namespace AParkDispetcher
{
    partial class ExportSettingsForm
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
            this.exLeftPicker = new System.Windows.Forms.DateTimePicker();
            this.exRightPicker = new System.Windows.Forms.DateTimePicker();
            this.exModeBox = new System.Windows.Forms.ComboBox();
            this.ex_mode_label = new System.Windows.Forms.Label();
            this.ex_left_label = new System.Windows.Forms.Label();
            this.ex_right_label = new System.Windows.Forms.Label();
            this.ex_driver_label = new System.Windows.Forms.Label();
            this.exDriverText = new System.Windows.Forms.TextBox();
            this.exAutoText = new System.Windows.Forms.TextBox();
            this.ex_auto_label = new System.Windows.Forms.Label();
            this.exAutoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exCancelButton = new System.Windows.Forms.Button();
            this.exDoExportButton = new System.Windows.Forms.Button();
            this.exDriverButton = new System.Windows.Forms.Button();
            this.Excel_panel = new System.Windows.Forms.Panel();
            this.Excel_group = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.Excel_panel.SuspendLayout();
            this.Excel_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // exLeftPicker
            // 
            this.exLeftPicker.CustomFormat = "";
            this.exLeftPicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.exLeftPicker.Location = new System.Drawing.Point(89, 37);
            this.exLeftPicker.Margin = new System.Windows.Forms.Padding(4);
            this.exLeftPicker.Name = "exLeftPicker";
            this.exLeftPicker.Size = new System.Drawing.Size(172, 27);
            this.exLeftPicker.TabIndex = 0;
            this.exLeftPicker.ValueChanged += new System.EventHandler(this.exLeftPicker_ValueChanged);
            // 
            // exRightPicker
            // 
            this.exRightPicker.CustomFormat = "dd.MM.yy  [HH:mm]";
            this.exRightPicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.exRightPicker.Location = new System.Drawing.Point(89, 72);
            this.exRightPicker.Margin = new System.Windows.Forms.Padding(4);
            this.exRightPicker.Name = "exRightPicker";
            this.exRightPicker.Size = new System.Drawing.Size(172, 27);
            this.exRightPicker.TabIndex = 1;
            this.exRightPicker.Value = new System.DateTime(2022, 5, 16, 18, 55, 5, 0);
            // 
            // exModeBox
            // 
            this.exModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exModeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exModeBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.exModeBox.FormattingEnabled = true;
            this.exModeBox.Items.AddRange(new object[] {
            "Все заявки",
            "По водителю",
            "По автомобилю"});
            this.exModeBox.Location = new System.Drawing.Point(49, 143);
            this.exModeBox.Margin = new System.Windows.Forms.Padding(4);
            this.exModeBox.Name = "exModeBox";
            this.exModeBox.Size = new System.Drawing.Size(212, 28);
            this.exModeBox.TabIndex = 2;
            this.exModeBox.SelectedIndexChanged += new System.EventHandler(this.exModeBox_SelectedIndexChanged);
            // 
            // ex_mode_label
            // 
            this.ex_mode_label.AutoSize = true;
            this.ex_mode_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic);
            this.ex_mode_label.ForeColor = System.Drawing.Color.Black;
            this.ex_mode_label.Location = new System.Drawing.Point(45, 120);
            this.ex_mode_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ex_mode_label.Name = "ex_mode_label";
            this.ex_mode_label.Size = new System.Drawing.Size(116, 19);
            this.ex_mode_label.TabIndex = 3;
            this.ex_mode_label.Text = "Режим отчета";
            // 
            // ex_left_label
            // 
            this.ex_left_label.AutoSize = true;
            this.ex_left_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic);
            this.ex_left_label.ForeColor = System.Drawing.Color.Black;
            this.ex_left_label.Location = new System.Drawing.Point(47, 41);
            this.ex_left_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ex_left_label.Name = "ex_left_label";
            this.ex_left_label.Size = new System.Drawing.Size(17, 19);
            this.ex_left_label.TabIndex = 4;
            this.ex_left_label.Text = "C";
            // 
            // ex_right_label
            // 
            this.ex_right_label.AutoSize = true;
            this.ex_right_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic);
            this.ex_right_label.ForeColor = System.Drawing.Color.Black;
            this.ex_right_label.Location = new System.Drawing.Point(45, 76);
            this.ex_right_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ex_right_label.Name = "ex_right_label";
            this.ex_right_label.Size = new System.Drawing.Size(28, 19);
            this.ex_right_label.TabIndex = 5;
            this.ex_right_label.Text = "ПО";
            // 
            // ex_driver_label
            // 
            this.ex_driver_label.AutoSize = true;
            this.ex_driver_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic);
            this.ex_driver_label.ForeColor = System.Drawing.Color.Black;
            this.ex_driver_label.Location = new System.Drawing.Point(45, 201);
            this.ex_driver_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ex_driver_label.Name = "ex_driver_label";
            this.ex_driver_label.Size = new System.Drawing.Size(78, 19);
            this.ex_driver_label.TabIndex = 6;
            this.ex_driver_label.Text = "Водитель";
            // 
            // exDriverText
            // 
            this.exDriverText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.exDriverText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.exDriverText.Location = new System.Drawing.Point(49, 223);
            this.exDriverText.Name = "exDriverText";
            this.exDriverText.ReadOnly = true;
            this.exDriverText.Size = new System.Drawing.Size(166, 27);
            this.exDriverText.TabIndex = 7;
            this.exDriverText.TabStop = false;
            this.exDriverText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exAutoText
            // 
            this.exAutoText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.exAutoText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.exAutoText.Location = new System.Drawing.Point(49, 310);
            this.exAutoText.Name = "exAutoText";
            this.exAutoText.ReadOnly = true;
            this.exAutoText.Size = new System.Drawing.Size(166, 27);
            this.exAutoText.TabIndex = 9;
            this.exAutoText.TabStop = false;
            this.exAutoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ex_auto_label
            // 
            this.ex_auto_label.AutoSize = true;
            this.ex_auto_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic);
            this.ex_auto_label.ForeColor = System.Drawing.Color.Black;
            this.ex_auto_label.Location = new System.Drawing.Point(45, 288);
            this.ex_auto_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ex_auto_label.Name = "ex_auto_label";
            this.ex_auto_label.Size = new System.Drawing.Size(98, 19);
            this.ex_auto_label.TabIndex = 8;
            this.ex_auto_label.Text = "Автомобиль";
            // 
            // exAutoButton
            // 
            this.exAutoButton.Enabled = false;
            this.exAutoButton.ForeColor = System.Drawing.Color.Black;
            this.exAutoButton.Location = new System.Drawing.Point(231, 310);
            this.exAutoButton.Name = "exAutoButton";
            this.exAutoButton.Size = new System.Drawing.Size(30, 27);
            this.exAutoButton.TabIndex = 4;
            this.exAutoButton.Text = "...";
            this.exAutoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exAutoButton.UseVisualStyleBackColor = true;
            this.exAutoButton.Click += new System.EventHandler(this.exAutoButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(49, 278);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 1);
            this.panel2.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel4.Controls.Add(this.exCancelButton);
            this.panel4.Controls.Add(this.exDoExportButton);
            this.panel4.Location = new System.Drawing.Point(0, 383);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 43);
            this.panel4.TabIndex = 61;
            // 
            // exCancelButton
            // 
            this.exCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exCancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exCancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exCancelButton.ForeColor = System.Drawing.Color.Black;
            this.exCancelButton.Location = new System.Drawing.Point(14, 8);
            this.exCancelButton.Name = "exCancelButton";
            this.exCancelButton.Size = new System.Drawing.Size(146, 29);
            this.exCancelButton.TabIndex = 14;
            this.exCancelButton.TabStop = false;
            this.exCancelButton.Text = "Отмена";
            this.exCancelButton.UseVisualStyleBackColor = false;
            this.exCancelButton.Click += new System.EventHandler(this.Cancel_driverstate_button_Click);
            // 
            // exDoExportButton
            // 
            this.exDoExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exDoExportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exDoExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exDoExportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exDoExportButton.ForeColor = System.Drawing.Color.Black;
            this.exDoExportButton.Location = new System.Drawing.Point(172, 8);
            this.exDoExportButton.Name = "exDoExportButton";
            this.exDoExportButton.Size = new System.Drawing.Size(146, 29);
            this.exDoExportButton.TabIndex = 5;
            this.exDoExportButton.Text = "Экспорт";
            this.exDoExportButton.UseVisualStyleBackColor = false;
            this.exDoExportButton.Click += new System.EventHandler(this.Save_state_button_Click);
            // 
            // exDriverButton
            // 
            this.exDriverButton.Enabled = false;
            this.exDriverButton.ForeColor = System.Drawing.Color.Black;
            this.exDriverButton.Location = new System.Drawing.Point(231, 223);
            this.exDriverButton.Name = "exDriverButton";
            this.exDriverButton.Size = new System.Drawing.Size(30, 27);
            this.exDriverButton.TabIndex = 62;
            this.exDriverButton.Text = "...";
            this.exDriverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exDriverButton.UseVisualStyleBackColor = true;
            this.exDriverButton.Click += new System.EventHandler(this.exDriverButton_Click);
            // 
            // Excel_panel
            // 
            this.Excel_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Excel_panel.BackColor = System.Drawing.Color.Khaki;
            this.Excel_panel.Controls.Add(this.label1);
            this.Excel_panel.Controls.Add(this.exAutoText);
            this.Excel_panel.Controls.Add(this.exLeftPicker);
            this.Excel_panel.Controls.Add(this.exRightPicker);
            this.Excel_panel.Controls.Add(this.exModeBox);
            this.Excel_panel.Controls.Add(this.exDriverButton);
            this.Excel_panel.Controls.Add(this.ex_mode_label);
            this.Excel_panel.Controls.Add(this.ex_left_label);
            this.Excel_panel.Controls.Add(this.panel2);
            this.Excel_panel.Controls.Add(this.ex_right_label);
            this.Excel_panel.Controls.Add(this.exAutoButton);
            this.Excel_panel.Controls.Add(this.ex_driver_label);
            this.Excel_panel.Controls.Add(this.exDriverText);
            this.Excel_panel.Controls.Add(this.ex_auto_label);
            this.Excel_panel.Location = new System.Drawing.Point(6, 17);
            this.Excel_panel.Name = "Excel_panel";
            this.Excel_panel.Size = new System.Drawing.Size(310, 373);
            this.Excel_panel.TabIndex = 67;
            this.Excel_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Excel_panel_Paint);
            // 
            // Excel_group
            // 
            this.Excel_group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Excel_group.Controls.Add(this.Excel_panel);
            this.Excel_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excel_group.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Excel_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.Excel_group.Location = new System.Drawing.Point(5, -5);
            this.Excel_group.Name = "Excel_group";
            this.Excel_group.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Excel_group.Size = new System.Drawing.Size(322, 390);
            this.Excel_group.TabIndex = 8;
            this.Excel_group.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Excel ";
            // 
            // ExportSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(332, 426);
            this.ControlBox = false;
            this.Controls.Add(this.Excel_group);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExportSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки экспорта";
            this.panel4.ResumeLayout(false);
            this.Excel_panel.ResumeLayout(false);
            this.Excel_panel.PerformLayout();
            this.Excel_group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker exLeftPicker;
        private System.Windows.Forms.DateTimePicker exRightPicker;
        private System.Windows.Forms.ComboBox exModeBox;
        private System.Windows.Forms.Label ex_mode_label;
        private System.Windows.Forms.Label ex_left_label;
        private System.Windows.Forms.Label ex_right_label;
        private System.Windows.Forms.Label ex_driver_label;
        private System.Windows.Forms.TextBox exDriverText;
        private System.Windows.Forms.TextBox exAutoText;
        private System.Windows.Forms.Label ex_auto_label;
        private System.Windows.Forms.Button exAutoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exCancelButton;
        private System.Windows.Forms.Button exDoExportButton;
        private System.Windows.Forms.Button exDriverButton;
        private System.Windows.Forms.Panel Excel_panel;
        private System.Windows.Forms.GroupBox Excel_group;
        private System.Windows.Forms.Label label1;
    }
}