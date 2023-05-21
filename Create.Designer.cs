namespace DB_Lab_Project
{
    partial class Create
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Select = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Code);
            this.panel1.Controls.Add(this.CreateBtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Select);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 366);
            this.panel1.TabIndex = 0;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.Black;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.Location = new System.Drawing.Point(480, 280);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(130, 38);
            this.CreateBtn.TabIndex = 12;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Assignment",
            "Material",
            "Announcement"});
            this.comboBox1.Location = new System.Drawing.Point(324, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // Select
            // 
            this.Select.AutoSize = true;
            this.Select.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Select.Location = new System.Drawing.Point(206, 129);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(83, 31);
            this.Select.TabIndex = 10;
            this.Select.Text = "Select";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 2);
            this.panel2.TabIndex = 9;
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(74, 36);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(215, 31);
            this.GoogleClassroom.TabIndex = 4;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Code.Location = new System.Drawing.Point(74, 212);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(131, 31);
            this.Code.TabIndex = 13;
            this.Code.Text = "ClassCode";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(828, 364);
            this.Controls.Add(this.panel1);
            this.Name = "Create";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Select;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label Code;
    }
}