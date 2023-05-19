namespace DB_Lab_Project
{
    partial class TeacherClass
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
            this.ClassLabel = new System.Windows.Forms.Label();
            this.CreateClassBtn = new System.Windows.Forms.Button();
            this.assignmentsTab1 = new DB_Lab_Project.AssignmentsTab();
            this.announcements_Tab1 = new DB_Lab_Project.Announcements_Tab();
            this.materialTab1 = new DB_Lab_Project.MaterialTab();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialTab1);
            this.panel1.Controls.Add(this.assignmentsTab1);
            this.panel1.Controls.Add(this.announcements_Tab1);
            this.panel1.Controls.Add(this.CreateClassBtn);
            this.panel1.Controls.Add(this.ClassLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 742);
            this.panel1.TabIndex = 0;
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(74, 36);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(215, 31);
            this.GoogleClassroom.TabIndex = 12;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 2);
            this.panel2.TabIndex = 14;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.BackColor = System.Drawing.Color.White;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.Location = new System.Drawing.Point(74, 120);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(111, 36);
            this.ClassLabel.TabIndex = 15;
            this.ClassLabel.Text = "Classes";
            // 
            // CreateClassBtn
            // 
            this.CreateClassBtn.BackColor = System.Drawing.Color.Black;
            this.CreateClassBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateClassBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateClassBtn.Location = new System.Drawing.Point(787, 120);
            this.CreateClassBtn.Name = "CreateClassBtn";
            this.CreateClassBtn.Size = new System.Drawing.Size(190, 49);
            this.CreateClassBtn.TabIndex = 0;
            this.CreateClassBtn.Text = "+ Create a new class";
            this.CreateClassBtn.UseVisualStyleBackColor = false;
            // 
            // assignmentsTab1
            // 
            this.assignmentsTab1.Location = new System.Drawing.Point(80, 350);
            this.assignmentsTab1.Name = "assignmentsTab1";
            this.assignmentsTab1.Size = new System.Drawing.Size(897, 166);
            this.assignmentsTab1.TabIndex = 17;
            // 
            // announcements_Tab1
            // 
            this.announcements_Tab1.Location = new System.Drawing.Point(80, 187);
            this.announcements_Tab1.Name = "announcements_Tab1";
            this.announcements_Tab1.Size = new System.Drawing.Size(897, 166);
            this.announcements_Tab1.TabIndex = 16;
            // 
            // materialTab1
            // 
            this.materialTab1.Location = new System.Drawing.Point(80, 522);
            this.materialTab1.Name = "materialTab1";
            this.materialTab1.Size = new System.Drawing.Size(897, 166);
            this.materialTab1.TabIndex = 18;
            // 
            // TeacherClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1070, 740);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherClass";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.TeacherClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Button CreateClassBtn;
        private AssignmentsTab assignmentsTab1;
        private Announcements_Tab announcements_Tab1;
        private MaterialTab materialTab1;
    }
}