namespace DB_Lab_Project
{
    partial class ViewAssignment
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
            this.Marks = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ViewAssignmentLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.SetDeadline = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SetDeadline);
            this.panel1.Controls.Add(this.Marks);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.ViewAssignmentLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 739);
            this.panel1.TabIndex = 0;
            // 
            // Marks
            // 
            this.Marks.AutoSize = true;
            this.Marks.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Marks.Location = new System.Drawing.Point(841, 575);
            this.Marks.Name = "Marks";
            this.Marks.Size = new System.Drawing.Size(71, 27);
            this.Marks.TabIndex = 19;
            this.Marks.Text = "Marks";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(88, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(897, 367);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "Enter Announcement..";
            // 
            // ViewAssignmentLabel
            // 
            this.ViewAssignmentLabel.AutoSize = true;
            this.ViewAssignmentLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAssignmentLabel.Location = new System.Drawing.Point(80, 120);
            this.ViewAssignmentLabel.Name = "ViewAssignmentLabel";
            this.ViewAssignmentLabel.Size = new System.Drawing.Size(244, 36);
            this.ViewAssignmentLabel.TabIndex = 14;
            this.ViewAssignmentLabel.Text = "View Assignment";
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
            // SetDeadline
            // 
            this.SetDeadline.AutoSize = true;
            this.SetDeadline.BackColor = System.Drawing.Color.White;
            this.SetDeadline.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDeadline.Location = new System.Drawing.Point(631, 155);
            this.SetDeadline.Name = "SetDeadline";
            this.SetDeadline.Size = new System.Drawing.Size(100, 27);
            this.SetDeadline.TabIndex = 23;
            this.SetDeadline.Text = "Deadline:";
            // 
            // ViewAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 740);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAssignment";
            this.Text = "ViewAssignment";
            this.Load += new System.EventHandler(this.ViewAssignment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ViewAssignmentLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Marks;
        private System.Windows.Forms.Label SetDeadline;
    }
}