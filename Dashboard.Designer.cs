namespace DB_Lab_Project
{
    partial class Dashboard
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
            this.Class = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.ClassBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.ClassNameTextBox = new System.Windows.Forms.TextBox();
            this.ClassCodeTextBox = new System.Windows.Forms.TextBox();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.ClassCodeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Class);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 742);
            this.panel1.TabIndex = 0;
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(74, 120);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(111, 36);
            this.Class.TabIndex = 5;
            this.Class.Text = "Classes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ClassCodeLabel);
            this.panel3.Controls.Add(this.ClassNameLabel);
            this.panel3.Controls.Add(this.ClassCodeTextBox);
            this.panel3.Controls.Add(this.ClassNameTextBox);
            this.panel3.Controls.Add(this.DeleteBtn);
            this.panel3.Controls.Add(this.UpdateBtn);
            this.panel3.Controls.Add(this.ViewBtn);
            this.panel3.Controls.Add(this.Classes);
            this.panel3.Controls.Add(this.ClassesCB);
            this.panel3.Controls.Add(this.ClassBtn);
            this.panel3.Location = new System.Drawing.Point(80, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 471);
            this.panel3.TabIndex = 4;
            // 
            // ClassesCB
            // 
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Location = new System.Drawing.Point(241, 139);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(370, 28);
            this.ClassesCB.TabIndex = 2;
            // 
            // ClassBtn
            // 
            this.ClassBtn.BackColor = System.Drawing.Color.Black;
            this.ClassBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassBtn.Location = new System.Drawing.Point(596, 389);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.Size = new System.Drawing.Size(190, 49);
            this.ClassBtn.TabIndex = 0;
            this.ClassBtn.Text = "+ Create a new class";
            this.ClassBtn.UseVisualStyleBackColor = false;
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 2);
            this.panel2.TabIndex = 3;
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(74, 35);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(215, 31);
            this.GoogleClassroom.TabIndex = 2;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // Classes
            // 
            this.Classes.AutoSize = true;
            this.Classes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classes.Location = new System.Drawing.Point(61, 133);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(156, 31);
            this.Classes.TabIndex = 3;
            this.Classes.Text = "Your Classes";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Black;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(682, 185);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 39);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Black;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(682, 139);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(104, 39);
            this.UpdateBtn.TabIndex = 23;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.Black;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBtn.Location = new System.Drawing.Point(682, 94);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(104, 39);
            this.ViewBtn.TabIndex = 22;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.Location = new System.Drawing.Point(170, 328);
            this.ClassNameTextBox.Multiline = true;
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.Size = new System.Drawing.Size(200, 33);
            this.ClassNameTextBox.TabIndex = 25;
            // 
            // ClassCodeTextBox
            // 
            this.ClassCodeTextBox.Location = new System.Drawing.Point(581, 330);
            this.ClassCodeTextBox.Multiline = true;
            this.ClassCodeTextBox.Name = "ClassCodeTextBox";
            this.ClassCodeTextBox.Size = new System.Drawing.Size(205, 32);
            this.ClassCodeTextBox.TabIndex = 26;
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameLabel.Location = new System.Drawing.Point(17, 330);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(147, 31);
            this.ClassNameLabel.TabIndex = 27;
            this.ClassNameLabel.Text = "Class Name";
            // 
            // ClassCodeLabel
            // 
            this.ClassCodeLabel.AutoSize = true;
            this.ClassCodeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCodeLabel.Location = new System.Drawing.Point(428, 330);
            this.ClassCodeLabel.Name = "ClassCodeLabel";
            this.ClassCodeLabel.Size = new System.Drawing.Size(138, 31);
            this.ClassCodeLabel.TabIndex = 28;
            this.ClassCodeLabel.Text = "Class Code";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 740);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ClassBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Class;
        private DashboardClasses dashboardClasses1;
        private System.Windows.Forms.ComboBox ClassesCB;
        private System.Windows.Forms.Label Classes;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Label ClassCodeLabel;
        private System.Windows.Forms.Label ClassNameLabel;
        private System.Windows.Forms.TextBox ClassCodeTextBox;
        private System.Windows.Forms.TextBox ClassNameTextBox;
    }
}