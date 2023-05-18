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
            this.dashboardClasses1 = new DB_Lab_Project.DashboardClasses();
            this.ClassBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.dB_L_ProjectDataSet1 = new DB_Lab_Project.DB_L_ProjectDataSet();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_L_ProjectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Class);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 482);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(49, 78);
            this.Class.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(79, 25);
            this.Class.TabIndex = 5;
            this.Class.Text = "Classes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dashboardClasses1);
            this.panel3.Controls.Add(this.ClassBtn);
            this.panel3.Location = new System.Drawing.Point(53, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 307);
            this.panel3.TabIndex = 4;
            // 
            // dashboardClasses1
            // 
            this.dashboardClasses1.Location = new System.Drawing.Point(125, 77);
            this.dashboardClasses1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dashboardClasses1.Name = "dashboardClasses1";
            this.dashboardClasses1.Size = new System.Drawing.Size(333, 53);
            this.dashboardClasses1.TabIndex = 1;
            this.dashboardClasses1.Load += new System.EventHandler(this.dashboardClasses1_Load);
            // 
            // ClassBtn
            // 
            this.ClassBtn.BackColor = System.Drawing.Color.Black;
            this.ClassBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassBtn.Location = new System.Drawing.Point(455, 13);
            this.ClassBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.Size = new System.Drawing.Size(127, 32);
            this.ClassBtn.TabIndex = 0;
            this.ClassBtn.Text = "+ Create a new class";
            this.ClassBtn.UseVisualStyleBackColor = false;
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(53, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 1);
            this.panel2.TabIndex = 3;
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(49, 23);
            this.GoogleClassroom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(148, 21);
            this.GoogleClassroom.TabIndex = 2;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // dB_L_ProjectDataSet1
            // 
            this.dB_L_ProjectDataSet1.DataSetName = "DB_L_ProjectDataSet";
            this.dB_L_ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 481);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dB_L_ProjectDataSet1)).EndInit();
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
        private DB_L_ProjectDataSet dB_L_ProjectDataSet1;
    }
}