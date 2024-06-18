namespace WindowsFormsApp1
{
    partial class Login
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
            this.LGPassBox = new System.Windows.Forms.TextBox();
            this.LgUserName = new System.Windows.Forms.TextBox();
            this.RoleBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eye_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LGPassBox
            // 
            this.LGPassBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LGPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGPassBox.ForeColor = System.Drawing.Color.Black;
            this.LGPassBox.Location = new System.Drawing.Point(64, 167);
            this.LGPassBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LGPassBox.Multiline = true;
            this.LGPassBox.Name = "LGPassBox";
            this.LGPassBox.PasswordChar = '*';
            this.LGPassBox.Size = new System.Drawing.Size(264, 35);
            this.LGPassBox.TabIndex = 2;
            this.LGPassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LGPassBox_KeyDown);
            // 
            // LgUserName
            // 
            this.LgUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LgUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgUserName.ForeColor = System.Drawing.Color.Black;
            this.LgUserName.Location = new System.Drawing.Point(64, 97);
            this.LgUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LgUserName.Multiline = true;
            this.LgUserName.Name = "LgUserName";
            this.LgUserName.Size = new System.Drawing.Size(264, 35);
            this.LgUserName.TabIndex = 1;
            this.LgUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LgUserName_KeyDown);
            // 
            // RoleBox
            // 
            this.RoleBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoleBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Location = new System.Drawing.Point(64, 218);
            this.RoleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(264, 27);
            this.RoleBox.TabIndex = 4;
            this.RoleBox.Text = "Select A Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(60, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(27, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Here? Didn\'t SignUp? SignUp Right Now!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(125, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "LOG IN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.eye_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LGPassBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LgUserName);
            this.panel1.Controls.Add(this.RoleBox);
            this.panel1.Location = new System.Drawing.Point(127, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 314);
            this.panel1.TabIndex = 8;
            // 
            // eye_btn
            // 
            this.eye_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.eye_512x512;
            this.eye_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eye_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_btn.Location = new System.Drawing.Point(339, 167);
            this.eye_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eye_btn.Name = "eye_btn";
            this.eye_btn.Size = new System.Drawing.Size(43, 36);
            this.eye_btn.TabIndex = 3;
            this.eye_btn.UseVisualStyleBackColor = true;
            this.eye_btn.Click += new System.EventHandler(this.eye_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_login_button_64;
            this.pictureBox1.Location = new System.Drawing.Point(100, 257);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.Location = new System.Drawing.Point(152, 257);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(116, 46);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LogIn";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(460, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Signup Now!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.geometric_gradient_futuristic_background_23_2149116406;
            this.ClientSize = new System.Drawing.Size(665, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LGPassBox;
        private System.Windows.Forms.TextBox LgUserName;
        private System.Windows.Forms.ComboBox RoleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eye_btn;
    }
}