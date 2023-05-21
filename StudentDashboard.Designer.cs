namespace DB_Lab_Project
{
    partial class StudentDashboard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClassBtn = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.ClassCodeLabel = new System.Windows.Forms.Label();
            this.ClassCodeTextBox = new System.Windows.Forms.TextBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.Classes = new System.Windows.Forms.Label();
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Class);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 743);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ClassCodeLabel);
            this.panel3.Controls.Add(this.ClassCodeTextBox);
            this.panel3.Controls.Add(this.ViewBtn);
            this.panel3.Controls.Add(this.Classes);
            this.panel3.Controls.Add(this.ClassesCB);
            this.panel3.Controls.Add(this.ClassBtn);
            this.panel3.Location = new System.Drawing.Point(80, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 471);
            this.panel3.TabIndex = 7;
            // 
            // ClassBtn
            // 
            this.ClassBtn.BackColor = System.Drawing.Color.Black;
            this.ClassBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassBtn.Location = new System.Drawing.Point(682, 20);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.Size = new System.Drawing.Size(190, 49);
            this.ClassBtn.TabIndex = 0;
            this.ClassBtn.Text = "+ Join a new class";
            this.ClassBtn.UseVisualStyleBackColor = false;
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(74, 120);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(111, 36);
            this.Class.TabIndex = 6;
            this.Class.Text = "Classes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 2);
            this.panel2.TabIndex = 4;
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(74, 35);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(215, 31);
            this.GoogleClassroom.TabIndex = 3;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // ClassCodeLabel
            // 
            this.ClassCodeLabel.AutoSize = true;
            this.ClassCodeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCodeLabel.Location = new System.Drawing.Point(297, 32);
            this.ClassCodeLabel.Name = "ClassCodeLabel";
            this.ClassCodeLabel.Size = new System.Drawing.Size(138, 31);
            this.ClassCodeLabel.TabIndex = 34;
            this.ClassCodeLabel.Text = "Class Code";
            // 
            // ClassCodeTextBox
            // 
            this.ClassCodeTextBox.Location = new System.Drawing.Point(450, 32);
            this.ClassCodeTextBox.Multiline = true;
            this.ClassCodeTextBox.Name = "ClassCodeTextBox";
            this.ClassCodeTextBox.Size = new System.Drawing.Size(205, 32);
            this.ClassCodeTextBox.TabIndex = 33;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.Black;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBtn.Location = new System.Drawing.Point(644, 146);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(104, 39);
            this.ViewBtn.TabIndex = 32;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // Classes
            // 
            this.Classes.AutoSize = true;
            this.Classes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classes.Location = new System.Drawing.Point(52, 146);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(156, 31);
            this.Classes.TabIndex = 31;
            this.Classes.Text = "Your Classes";
            // 
            // ClassesCB
            // 
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Location = new System.Drawing.Point(232, 152);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(370, 28);
            this.ClassesCB.TabIndex = 30;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 740);
            this.Controls.Add(this.panel1);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ClassBtn;
        private System.Windows.Forms.Label ClassCodeLabel;
        private System.Windows.Forms.TextBox ClassCodeTextBox;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Label Classes;
        private System.Windows.Forms.ComboBox ClassesCB;
    }
}