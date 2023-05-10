namespace DB_Lab_Project
{
    partial class SignUp
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
            this.Sign_Up = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Teacher = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.Sign_Up);
            this.panel1.Controls.Add(this.Student);
            this.panel1.Controls.Add(this.Teacher);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.LName);
            this.panel1.Controls.Add(this.FName);
            this.panel1.Controls.Add(this.ConfirmPassword);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 796);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Sign_Up
            // 
            this.Sign_Up.BackColor = System.Drawing.Color.Black;
            this.Sign_Up.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sign_Up.Location = new System.Drawing.Point(433, 640);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(192, 57);
            this.Sign_Up.TabIndex = 15;
            this.Sign_Up.Text = "Sign Up";
            this.Sign_Up.UseVisualStyleBackColor = false;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Location = new System.Drawing.Point(408, 587);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(95, 25);
            this.Student.TabIndex = 14;
            this.Student.TabStop = true;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // Teacher
            // 
            this.Teacher.AutoSize = true;
            this.Teacher.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher.Location = new System.Drawing.Point(289, 587);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(95, 25);
            this.Teacher.TabIndex = 13;
            this.Teacher.TabStop = true;
            this.Teacher.Text = "Teacher";
            this.Teacher.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(289, 519);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(480, 44);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(289, 434);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(480, 44);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(289, 345);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(480, 44);
            this.textBox3.TabIndex = 10;
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(555, 246);
            this.LName.Multiline = true;
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(214, 44);
            this.LName.TabIndex = 9;
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(289, 246);
            this.FName.Multiline = true;
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(214, 44);
            this.FName.TabIndex = 8;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(283, 483);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(220, 31);
            this.ConfirmPassword.TabIndex = 7;
            this.ConfirmPassword.Text = "Confirm Password";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(283, 400);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(122, 31);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sign Up";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(283, 311);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(74, 31);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(549, 197);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(135, 31);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(283, 197);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(138, 31);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.label1.Location = new System.Drawing.Point(74, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Google Classroom";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(196, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 612);
            this.panel2.TabIndex = 16;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 792);
            this.Controls.Add(this.panel1);
            this.Name = "SignUp";
            this.Text = "TeacherSignup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button Sign_Up;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.RadioButton Teacher;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Panel panel2;
    }
}