namespace DB_Lab_Project
{
    partial class CreateAssignment
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MarksTxtBox = new System.Windows.Forms.TextBox();
            this.Marks = new System.Windows.Forms.Label();
            this.PostBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SetDeadline = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SetDeadline);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.TitleTextBox);
            this.panel1.Controls.Add(this.MarksTxtBox);
            this.panel1.Controls.Add(this.Marks);
            this.panel1.Controls.Add(this.PostBtn);
            this.panel1.Controls.Add(this.uploadBtn);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 740);
            this.panel1.TabIndex = 0;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(164, 119);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(315, 35);
            this.TitleTextBox.TabIndex = 20;
            // 
            // MarksTxtBox
            // 
            this.MarksTxtBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarksTxtBox.Location = new System.Drawing.Point(932, 516);
            this.MarksTxtBox.Multiline = true;
            this.MarksTxtBox.Name = "MarksTxtBox";
            this.MarksTxtBox.Size = new System.Drawing.Size(53, 34);
            this.MarksTxtBox.TabIndex = 19;
            // 
            // Marks
            // 
            this.Marks.AutoSize = true;
            this.Marks.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Marks.Location = new System.Drawing.Point(855, 521);
            this.Marks.Name = "Marks";
            this.Marks.Size = new System.Drawing.Size(71, 27);
            this.Marks.TabIndex = 18;
            this.Marks.Text = "Marks";
            // 
            // PostBtn
            // 
            this.PostBtn.BackColor = System.Drawing.Color.Black;
            this.PostBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostBtn.ForeColor = System.Drawing.Color.White;
            this.PostBtn.Location = new System.Drawing.Point(882, 618);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(103, 40);
            this.PostBtn.TabIndex = 17;
            this.PostBtn.Text = "Post";
            this.PostBtn.UseVisualStyleBackColor = false;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.Black;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(80, 516);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(124, 44);
            this.uploadBtn.TabIndex = 16;
            this.uploadBtn.Text = "Upload File";
            this.uploadBtn.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox1.Location = new System.Drawing.Point(88, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(897, 297);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "Enter Instructions...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 2);
            this.panel2.TabIndex = 13;
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(74, 36);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(215, 31);
            this.GoogleClassroom.TabIndex = 11;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(74, 120);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(71, 36);
            this.Title.TabIndex = 14;
            this.Title.Text = "Title";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(785, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // SetDeadline
            // 
            this.SetDeadline.AutoSize = true;
            this.SetDeadline.BackColor = System.Drawing.Color.White;
            this.SetDeadline.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDeadline.Location = new System.Drawing.Point(586, 145);
            this.SetDeadline.Name = "SetDeadline";
            this.SetDeadline.Size = new System.Drawing.Size(182, 36);
            this.SetDeadline.TabIndex = 22;
            this.SetDeadline.Text = "Set Deadline";
            // 
            // CreateAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 740);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.Name = "CreateAssignment";
            this.Text = "AssignmentPortal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button PostBtn;
        private System.Windows.Forms.TextBox MarksTxtBox;
        private System.Windows.Forms.Label Marks;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label SetDeadline;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}