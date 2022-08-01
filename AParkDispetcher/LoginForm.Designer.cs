
namespace AParkDispetcher
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.sloseButton = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.logButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Pass_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Login_textbox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 195);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Авториация";
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logButton.ForeColor = System.Drawing.Color.Black;
            this.logButton.Location = new System.Drawing.Point(53, 150);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(191, 28);
            this.logButton.TabIndex = 4;
            this.logButton.Text = "Войти";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // Pass_textbox
            // 
            this.Pass_textbox.Location = new System.Drawing.Point(84, 86);
            this.Pass_textbox.Name = "Pass_textbox";
            this.Pass_textbox.PasswordChar = '*';
            this.Pass_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pass_textbox.Size = new System.Drawing.Size(192, 29);
            this.Pass_textbox.TabIndex = 2;
            this.Pass_textbox.Text = "Sinister";
            this.Pass_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pass_textbox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // Login_textbox
            // 
            this.Login_textbox.Location = new System.Drawing.Point(84, 48);
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Login_textbox.Size = new System.Drawing.Size(192, 29);
            this.Login_textbox.TabIndex = 0;
            this.Login_textbox.Text = "Sinister";
            this.Login_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Login_textbox_KeyUp);
            // 
            // sloseButton
            // 
            this.sloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sloseButton.Image = global::AParkDispetcher.Properties.Resources.close_91;
            this.sloseButton.InitialImage = null;
            this.sloseButton.Location = new System.Drawing.Point(288, 5);
            this.sloseButton.Name = "sloseButton";
            this.sloseButton.Size = new System.Drawing.Size(32, 31);
            this.sloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sloseButton.TabIndex = 5;
            this.sloseButton.TabStop = false;
            this.sloseButton.Click += new System.EventHandler(this.SloseButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(324, 207);
            this.Controls.Add(this.sloseButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Авторизация";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pass_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.PictureBox sloseButton;
    }
}