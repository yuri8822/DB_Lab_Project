namespace DB_Lab_Project
{
    partial class JoinClass
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.CCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Join = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Join);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 367);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.CreateBtn);
            this.panel2.Controls.Add(this.CCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(80, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 2);
            this.panel2.TabIndex = 9;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.Black;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.Location = new System.Drawing.Point(399, 24);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(130, 38);
            this.CreateBtn.TabIndex = 10;
            this.CreateBtn.Text = "Create Class";
            this.CreateBtn.UseVisualStyleBackColor = false;
            // 
            // CCode
            // 
            this.CCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.CCode.ForeColor = System.Drawing.Color.DimGray;
            this.CCode.Location = new System.Drawing.Point(303, -59);
            this.CCode.Multiline = true;
            this.CCode.Name = "CCode";
            this.CCode.Size = new System.Drawing.Size(226, 38);
            this.CCode.TabIndex = 9;
            this.CCode.Text = "Enter Class Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(122, -51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Class Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(202, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Class Code";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(371, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 38);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Enter Class Code";
            // 
            // Join
            // 
            this.Join.BackColor = System.Drawing.Color.Black;
            this.Join.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join.ForeColor = System.Drawing.Color.White;
            this.Join.Location = new System.Drawing.Point(467, 238);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(130, 38);
            this.Join.TabIndex = 10;
            this.Join.Text = "Join Class";
            this.Join.UseVisualStyleBackColor = false;
            // 
            // JoinClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(828, 364);
            this.Controls.Add(this.panel1);
            this.Name = "JoinClass";
            this.Text = "JoinClass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Join;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox CCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}