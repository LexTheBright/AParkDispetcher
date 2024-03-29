﻿
namespace AParkDispetcher
{
    partial class DeleteDialog
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
            this.User_button_save = new System.Windows.Forms.Button();
            this.User_button_cancel = new System.Windows.Forms.Button();
            this.ActionText = new System.Windows.Forms.TextBox();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_button_save
            // 
            this.User_button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.User_button_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.User_button_save.BackColor = System.Drawing.SystemColors.Window;
            this.User_button_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.User_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.User_button_save.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_button_save.ForeColor = System.Drawing.Color.Black;
            this.User_button_save.Location = new System.Drawing.Point(164, 3);
            this.User_button_save.Name = "User_button_save";
            this.User_button_save.Size = new System.Drawing.Size(150, 32);
            this.User_button_save.TabIndex = 60;
            this.User_button_save.Text = "Да";
            this.User_button_save.UseVisualStyleBackColor = false;
            this.User_button_save.Click += new System.EventHandler(this.User_button_save_Click);
            // 
            // User_button_cancel
            // 
            this.User_button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.User_button_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.User_button_cancel.BackColor = System.Drawing.SystemColors.Window;
            this.User_button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.User_button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.User_button_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_button_cancel.ForeColor = System.Drawing.Color.Black;
            this.User_button_cancel.Location = new System.Drawing.Point(8, 3);
            this.User_button_cancel.Name = "User_button_cancel";
            this.User_button_cancel.Size = new System.Drawing.Size(150, 32);
            this.User_button_cancel.TabIndex = 59;
            this.User_button_cancel.Text = "Нет";
            this.User_button_cancel.UseVisualStyleBackColor = false;
            this.User_button_cancel.Click += new System.EventHandler(this.User_button_cancel_Click);
            // 
            // ActionText
            // 
            this.ActionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionText.BackColor = System.Drawing.Color.PapayaWhip;
            this.ActionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActionText.Enabled = false;
            this.ActionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionText.Location = new System.Drawing.Point(12, 3);
            this.ActionText.Name = "ActionText";
            this.ActionText.ReadOnly = true;
            this.ActionText.Size = new System.Drawing.Size(299, 22);
            this.ActionText.TabIndex = 0;
            this.ActionText.Text = "Удалить";
            this.ActionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.BackColor = System.Drawing.Color.PapayaWhip;
            this.MessageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageText.Cursor = System.Windows.Forms.Cursors.Default;
            this.MessageText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MessageText.Location = new System.Drawing.Point(12, 31);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.Size = new System.Drawing.Size(299, 80);
            this.MessageText.TabIndex = 61;
            this.MessageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Controls.Add(this.User_button_cancel);
            this.panel3.Controls.Add(this.User_button_save);
            this.panel3.Location = new System.Drawing.Point(0, 114);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 39);
            this.panel3.TabIndex = 62;
            // 
            // DeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(323, 153);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.ActionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление";
            this.TopMost = true;
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button User_button_save;
        private System.Windows.Forms.Button User_button_cancel;
        private System.Windows.Forms.TextBox ActionText;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Panel panel3;
    }
}