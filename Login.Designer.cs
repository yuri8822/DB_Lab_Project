namespace DB_Lab_Project
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TeacherEmail = new System.Windows.Forms.TextBox();
            this.TeacherPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TeacherLogin = new System.Windows.Forms.Button();
            this.Teacher = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentPassword = new System.Windows.Forms.TextBox();
            this.StudentLogin = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Label();
            this.StudentEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(713, 481);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 481);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Google Classroom";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TeacherEmail);
            this.panel3.Controls.Add(this.TeacherPassword);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TeacherLogin);
            this.panel3.Controls.Add(this.Teacher);
            this.panel3.Location = new System.Drawing.Point(27, 110);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 299);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // TeacherEmail
            // 
            this.TeacherEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TeacherEmail.Location = new System.Drawing.Point(42, 123);
            this.TeacherEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherEmail.Multiline = true;
            this.TeacherEmail.Name = "TeacherEmail";
            this.TeacherEmail.Size = new System.Drawing.Size(205, 24);
            this.TeacherEmail.TabIndex = 4;
            this.TeacherEmail.Text = "Enter Email";
            // 
            // TeacherPassword
            // 
            this.TeacherPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TeacherPassword.Location = new System.Drawing.Point(42, 176);
            this.TeacherPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherPassword.Multiline = true;
            this.TeacherPassword.Name = "TeacherPassword";
            this.TeacherPassword.Size = new System.Drawing.Size(206, 25);
            this.TeacherPassword.TabIndex = 5;
            this.TeacherPassword.Text = "Enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // TeacherLogin
            // 
            this.TeacherLogin.BackColor = System.Drawing.Color.Black;
            this.TeacherLogin.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TeacherLogin.Location = new System.Drawing.Point(120, 227);
            this.TeacherLogin.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherLogin.Name = "TeacherLogin";
            this.TeacherLogin.Size = new System.Drawing.Size(71, 27);
            this.TeacherLogin.TabIndex = 6;
            this.TeacherLogin.Text = "Login";
            this.TeacherLogin.UseVisualStyleBackColor = false;
            this.TeacherLogin.Click += new System.EventHandler(this.TeacherLogin_Click);
            // 
            // Teacher
            // 
            this.Teacher.AutoSize = true;
            this.Teacher.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher.Location = new System.Drawing.Point(94, 12);
            this.Teacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(116, 35);
            this.Teacher.TabIndex = 0;
            this.Teacher.Text = "Teacher";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 477);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.StudentPassword);
            this.panel4.Controls.Add(this.StudentLogin);
            this.panel4.Controls.Add(this.Student);
            this.panel4.Controls.Add(this.StudentEmail);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(24, 108);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 299);
            this.panel4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // StudentPassword
            // 
            this.StudentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StudentPassword.Location = new System.Drawing.Point(42, 176);
            this.StudentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.StudentPassword.Multiline = true;
            this.StudentPassword.Name = "StudentPassword";
            this.StudentPassword.Size = new System.Drawing.Size(223, 25);
            this.StudentPassword.TabIndex = 11;
            this.StudentPassword.Text = "Enter Password";
            // 
            // StudentLogin
            // 
            this.StudentLogin.BackColor = System.Drawing.Color.Black;
            this.StudentLogin.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentLogin.Location = new System.Drawing.Point(120, 227);
            this.StudentLogin.Margin = new System.Windows.Forms.Padding(2);
            this.StudentLogin.Name = "StudentLogin";
            this.StudentLogin.Size = new System.Drawing.Size(71, 27);
            this.StudentLogin.TabIndex = 12;
            this.StudentLogin.Text = "Login";
            this.StudentLogin.UseVisualStyleBackColor = false;
            this.StudentLogin.Click += new System.EventHandler(this.StudentLogin_Click);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Location = new System.Drawing.Point(94, 12);
            this.Student.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(117, 35);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            // 
            // StudentEmail
            // 
            this.StudentEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StudentEmail.Location = new System.Drawing.Point(42, 123);
            this.StudentEmail.Margin = new System.Windows.Forms.Padding(2);
            this.StudentEmail.Multiline = true;
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.Size = new System.Drawing.Size(223, 24);
            this.StudentEmail.TabIndex = 10;
            this.StudentEmail.Text = "Enter Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(713, 481);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TeacherLogin;
        private System.Windows.Forms.TextBox TeacherPassword;
        private System.Windows.Forms.TextBox TeacherEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Teacher;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StudentPassword;
        private System.Windows.Forms.Button StudentLogin;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.TextBox StudentEmail;
        private System.Windows.Forms.Label label4;
    }
}
