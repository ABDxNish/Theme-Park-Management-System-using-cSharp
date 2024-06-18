namespace WindowsFormsApp1
{
    partial class AdminPanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewCustomerButton = new System.Windows.Forms.Button();
            this.RdOpViewButton = new System.Windows.Forms.Button();
            this.ViewTicketSellerButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.jobseekerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._360_F_105726195_r0MpL0Noxp2NeMh3RsRwCskbeL7ensjV;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(143, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "WellCome Admin";
            // 
            // ViewCustomerButton
            // 
            this.ViewCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCustomerButton.Location = new System.Drawing.Point(112, 85);
            this.ViewCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewCustomerButton.Name = "ViewCustomerButton";
            this.ViewCustomerButton.Size = new System.Drawing.Size(112, 46);
            this.ViewCustomerButton.TabIndex = 1;
            this.ViewCustomerButton.Text = "View Customer";
            this.ViewCustomerButton.UseVisualStyleBackColor = true;
            this.ViewCustomerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RdOpViewButton
            // 
            this.RdOpViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdOpViewButton.Location = new System.Drawing.Point(112, 157);
            this.RdOpViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.RdOpViewButton.Name = "RdOpViewButton";
            this.RdOpViewButton.Size = new System.Drawing.Size(112, 46);
            this.RdOpViewButton.TabIndex = 3;
            this.RdOpViewButton.Text = "View RideOperator";
            this.RdOpViewButton.UseVisualStyleBackColor = true;
            this.RdOpViewButton.Click += new System.EventHandler(this.RdOpViewButton_Click);
            // 
            // ViewTicketSellerButton
            // 
            this.ViewTicketSellerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTicketSellerButton.Location = new System.Drawing.Point(292, 85);
            this.ViewTicketSellerButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewTicketSellerButton.Name = "ViewTicketSellerButton";
            this.ViewTicketSellerButton.Size = new System.Drawing.Size(112, 46);
            this.ViewTicketSellerButton.TabIndex = 2;
            this.ViewTicketSellerButton.Text = "View TicketSeller";
            this.ViewTicketSellerButton.UseVisualStyleBackColor = true;
            this.ViewTicketSellerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(402, 306);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // jobseekerButton
            // 
            this.jobseekerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobseekerButton.Location = new System.Drawing.Point(292, 157);
            this.jobseekerButton.Margin = new System.Windows.Forms.Padding(2);
            this.jobseekerButton.Name = "jobseekerButton";
            this.jobseekerButton.Size = new System.Drawing.Size(112, 46);
            this.jobseekerButton.TabIndex = 4;
            this.jobseekerButton.Text = "Job Seeker";
            this.jobseekerButton.UseVisualStyleBackColor = true;
            this.jobseekerButton.Click += new System.EventHandler(this.jobseekerButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 368);
            this.Controls.Add(this.jobseekerButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ViewTicketSellerButton);
            this.Controls.Add(this.RdOpViewButton);
            this.Controls.Add(this.ViewCustomerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewCustomerButton;
        private System.Windows.Forms.Button RdOpViewButton;
        private System.Windows.Forms.Button ViewTicketSellerButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button jobseekerButton;
    }
}