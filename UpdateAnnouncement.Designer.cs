namespace DB_Lab_Project
{
    partial class UpdateAnnouncement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.TitleTextBox);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 740);
            this.panel1.TabIndex = 0;
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(74, 36);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(215, 31);
            this.GoogleClassroom.TabIndex = 10;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 2);
            this.panel2.TabIndex = 12;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(74, 120);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(71, 36);
            this.Title.TabIndex = 15;
            this.Title.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(164, 120);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(315, 35);
            this.TitleTextBox.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox1.Location = new System.Drawing.Point(88, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(897, 297);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "Enter Instructions...";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Black;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(864, 618);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(121, 40);
            this.UpdateBtn.TabIndex = 23;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // UpdateAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 740);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateAnnouncement";
            this.Text = "UpdateAnnouncement";
            this.Load += new System.EventHandler(this.UpdateAnnouncement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button UpdateBtn;
    }
}