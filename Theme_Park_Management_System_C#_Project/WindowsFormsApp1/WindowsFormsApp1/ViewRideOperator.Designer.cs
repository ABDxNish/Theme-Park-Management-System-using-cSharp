namespace WindowsFormsApp1
{
    partial class ViewRideOperator
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
            this.viewRideop = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.serachb = new System.Windows.Forms.Button();
            this.BackB = new System.Windows.Forms.Button();
            this.refreshb = new System.Windows.Forms.Button();
            this.Updateb = new System.Windows.Forms.Button();
            this.SexBox = new System.Windows.Forms.TextBox();
            this.serachBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewRideop)).BeginInit();
            this.SuspendLayout();
            // 
            // viewRideop
            // 
            this.viewRideop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewRideop.Location = new System.Drawing.Point(139, 63);
            this.viewRideop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewRideop.Name = "viewRideop";
            this.viewRideop.RowHeadersWidth = 51;
            this.viewRideop.RowTemplate.Height = 24;
            this.viewRideop.Size = new System.Drawing.Size(351, 296);
            this.viewRideop.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(118, 21);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(79, 25);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // serachb
            // 
            this.serachb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serachb.Location = new System.Drawing.Point(369, 22);
            this.serachb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serachb.Name = "serachb";
            this.serachb.Size = new System.Drawing.Size(73, 24);
            this.serachb.TabIndex = 2;
            this.serachb.Text = "Search";
            this.serachb.UseVisualStyleBackColor = true;
            this.serachb.Click += new System.EventHandler(this.serachb_Click);
            // 
            // BackB
            // 
            this.BackB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackB.Location = new System.Drawing.Point(11, 17);
            this.BackB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(70, 35);
            this.BackB.TabIndex = 3;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // refreshb
            // 
            this.refreshb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshb.Location = new System.Drawing.Point(11, 73);
            this.refreshb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshb.Name = "refreshb";
            this.refreshb.Size = new System.Drawing.Size(70, 29);
            this.refreshb.TabIndex = 4;
            this.refreshb.Text = "Refresh";
            this.refreshb.UseVisualStyleBackColor = true;
            // 
            // Updateb
            // 
            this.Updateb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updateb.Location = new System.Drawing.Point(27, 279);
            this.Updateb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Updateb.Name = "Updateb";
            this.Updateb.Size = new System.Drawing.Size(70, 30);
            this.Updateb.TabIndex = 5;
            this.Updateb.Text = "Update";
            this.Updateb.UseVisualStyleBackColor = true;
            this.Updateb.Click += new System.EventHandler(this.Updateb_Click);
            // 
            // SexBox
            // 
            this.SexBox.Location = new System.Drawing.Point(27, 229);
            this.SexBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(84, 20);
            this.SexBox.TabIndex = 6;
            // 
            // serachBox
            // 
            this.serachBox.Location = new System.Drawing.Point(248, 26);
            this.serachBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serachBox.Name = "serachBox";
            this.serachBox.Size = new System.Drawing.Size(117, 20);
            this.serachBox.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(27, 157);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(80, 20);
            this.NameBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sex:";
            // 
            // ViewRideOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(499, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.serachBox);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.Updateb);
            this.Controls.Add(this.refreshb);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.serachb);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.viewRideop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewRideOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewRideOperator";
            ((System.ComponentModel.ISupportInitialize)(this.viewRideop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewRideop;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button serachb;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.Button refreshb;
        private System.Windows.Forms.Button Updateb;
        private System.Windows.Forms.TextBox SexBox;
        private System.Windows.Forms.TextBox serachBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}