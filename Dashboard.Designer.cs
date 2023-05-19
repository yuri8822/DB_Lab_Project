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
            this.ClassBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.dashboardClasses1 = new DB_Lab_Project.DashboardClasses();
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel3.Controls.Add(this.dashboardClasses1);
            this.panel3.Controls.Add(this.ClassBtn);
            this.panel3.Location = new System.Drawing.Point(80, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 471);
            this.panel3.TabIndex = 4;
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
            // dashboardClasses1
            // 
            this.dashboardClasses1.Location = new System.Drawing.Point(26, 122);
            this.dashboardClasses1.Name = "dashboardClasses1";
            this.dashboardClasses1.Size = new System.Drawing.Size(846, 166);
            this.dashboardClasses1.TabIndex = 1;
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
    }
}