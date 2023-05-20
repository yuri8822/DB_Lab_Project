namespace DB_Lab_Project
{
    partial class ViewAnnouncement
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Announcement = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.Announcement);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 739);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(80, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(897, 367);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Announcement
            // 
            this.Announcement.AutoSize = true;
            this.Announcement.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Announcement.Location = new System.Drawing.Point(74, 120);
            this.Announcement.Name = "Announcement";
            this.Announcement.Size = new System.Drawing.Size(315, 36);
            this.Announcement.TabIndex = 12;
            this.Announcement.Text = "Create Announcement";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 2);
            this.panel2.TabIndex = 11;
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(74, 36);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(215, 31);
            this.GoogleClassroom.TabIndex = 9;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // ViewAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 740);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAnnouncement";
            this.Text = "CreateAnnouncement";
            this.Load += new System.EventHandler(this.ViewAnnouncement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Announcement;
    }
}