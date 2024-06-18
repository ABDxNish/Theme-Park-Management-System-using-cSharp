namespace WindowsFormsApp1
{
    partial class ViewTicketSeller
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
            this.TSellerDataView = new System.Windows.Forms.DataGridView();
            this.TserchBox = new System.Windows.Forms.TextBox();
            this.UpdateB = new System.Windows.Forms.Button();
            this.RefreshB = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.SearchB = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TSellerDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // TSellerDataView
            // 
            this.TSellerDataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TSellerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TSellerDataView.Location = new System.Drawing.Point(131, 51);
            this.TSellerDataView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TSellerDataView.Name = "TSellerDataView";
            this.TSellerDataView.RowHeadersWidth = 51;
            this.TSellerDataView.RowTemplate.Height = 24;
            this.TSellerDataView.Size = new System.Drawing.Size(358, 303);
            this.TSellerDataView.TabIndex = 1;
            // 
            // TserchBox
            // 
            this.TserchBox.Location = new System.Drawing.Point(250, 16);
            this.TserchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TserchBox.Name = "TserchBox";
            this.TserchBox.Size = new System.Drawing.Size(113, 20);
            this.TserchBox.TabIndex = 2;
            // 
            // UpdateB
            // 
            this.UpdateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateB.Location = new System.Drawing.Point(16, 289);
            this.UpdateB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(101, 34);
            this.UpdateB.TabIndex = 10;
            this.UpdateB.Text = "Update";
            this.UpdateB.UseVisualStyleBackColor = true;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // RefreshB
            // 
            this.RefreshB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RefreshB.Location = new System.Drawing.Point(9, 76);
            this.RefreshB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RefreshB.Name = "RefreshB";
            this.RefreshB.Size = new System.Drawing.Size(108, 36);
            this.RefreshB.TabIndex = 4;
            this.RefreshB.Text = "Refresh";
            this.RefreshB.UseVisualStyleBackColor = true;
            this.RefreshB.Click += new System.EventHandler(this.RefreshB_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(9, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 37);
            this.button4.TabIndex = 1;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteB.ForeColor = System.Drawing.Color.Black;
            this.DeleteB.Location = new System.Drawing.Point(131, 10);
            this.DeleteB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(89, 29);
            this.DeleteB.TabIndex = 5;
            this.DeleteB.Text = "Delete";
            this.DeleteB.UseVisualStyleBackColor = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.Transparent;
            this.SearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchB.ForeColor = System.Drawing.Color.Black;
            this.SearchB.Location = new System.Drawing.Point(367, 12);
            this.SearchB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(73, 27);
            this.SearchB.TabIndex = 3;
            this.SearchB.Text = "Search";
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(16, 160);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(96, 20);
            this.NameBox.TabIndex = 7;
            // 
            // SexBox
            // 
            this.SexBox.Location = new System.Drawing.Point(16, 227);
            this.SexBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(96, 20);
            this.SexBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sex:";
            // 
            // ViewTicketSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RefreshB);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.TserchBox);
            this.Controls.Add(this.TSellerDataView);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewTicketSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTicketSeller";
            ((System.ComponentModel.ISupportInitialize)(this.TSellerDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TSellerDataView;
        private System.Windows.Forms.TextBox TserchBox;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.Button RefreshB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}