namespace DB_Lab_Project
{
    partial class AssignmentPortal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Marks = new System.Windows.Forms.Label();
            this.PostBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.GradedAssignment = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(932, 516);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 34);
            this.textBox1.TabIndex = 19;
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
            this.richTextBox1.Text = "Enter announcement...";
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
            // GradedAssignment
            // 
            this.GradedAssignment.AutoSize = true;
            this.GradedAssignment.BackColor = System.Drawing.Color.White;
            this.GradedAssignment.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradedAssignment.Location = new System.Drawing.Point(74, 120);
            this.GradedAssignment.Name = "GradedAssignment";
            this.GradedAssignment.Size = new System.Drawing.Size(172, 36);
            this.GradedAssignment.TabIndex = 14;
            this.GradedAssignment.Text = "Assignment";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AssignmentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 740);
            this.Controls.Add(this.GradedAssignment);
            this.Controls.Add(this.panel1);
            this.Name = "AssignmentPortal";
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
        private System.Windows.Forms.Label GradedAssignment;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button PostBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Marks;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}