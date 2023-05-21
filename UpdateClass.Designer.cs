namespace DB_Lab_Project
{
    partial class UpdateClass
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CName = new System.Windows.Forms.TextBox();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.CName);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Controls.Add(this.ClassName);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 366);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 2);
            this.panel2.TabIndex = 8;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Black;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(479, 280);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 38);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update Class";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CName
            // 
            this.CName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.CName.ForeColor = System.Drawing.Color.DimGray;
            this.CName.Location = new System.Drawing.Point(383, 131);
            this.CName.Multiline = true;
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(226, 38);
            this.CName.TabIndex = 4;
            this.CName.Text = "Enter Class Name";
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(74, 36);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(215, 31);
            this.GoogleClassroom.TabIndex = 3;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.ClassName.Location = new System.Drawing.Point(202, 131);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(147, 31);
            this.ClassName.TabIndex = 0;
            this.ClassName.Text = "Class Name";
            // 
            // UpdateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(828, 364);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateClass";
            this.Text = "CreateClass";
            this.Load += new System.EventHandler(this.UpdateClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.Panel panel2;
    }
}