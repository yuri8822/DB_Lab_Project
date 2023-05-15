namespace DB_Lab_Project
{
    partial class CreateMaterial
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
            this.PostBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoogleClassroom = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PostBtn);
            this.panel1.Controls.Add(this.uploadBtn);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GoogleClassroom);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 738);
            this.panel1.TabIndex = 0;
            // 
            // PostBtn
            // 
            this.PostBtn.BackColor = System.Drawing.Color.Black;
            this.PostBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostBtn.ForeColor = System.Drawing.Color.White;
            this.PostBtn.Location = new System.Drawing.Point(874, 618);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(103, 40);
            this.PostBtn.TabIndex = 16;
            this.PostBtn.Text = "Post";
            this.PostBtn.UseVisualStyleBackColor = false;
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.Black;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(80, 516);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(124, 44);
            this.uploadBtn.TabIndex = 15;
            this.uploadBtn.Text = "Upload File";
            this.uploadBtn.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox1.Location = new System.Drawing.Point(80, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(897, 297);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "Enter announcement...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(80, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 2);
            this.panel2.TabIndex = 12;
            // 
            // GoogleClassroom
            // 
            this.GoogleClassroom.AutoSize = true;
            this.GoogleClassroom.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.GoogleClassroom.Location = new System.Drawing.Point(74, 36);
            this.GoogleClassroom.Name = "GoogleClassroom";
            this.GoogleClassroom.Size = new System.Drawing.Size(215, 31);
            this.GoogleClassroom.TabIndex = 10;
            this.GoogleClassroom.Text = "Google Classroom";
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.BackColor = System.Drawing.Color.White;
            this.Material.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material.Location = new System.Drawing.Point(74, 120);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(293, 36);
            this.Material.TabIndex = 13;
            this.Material.Text = "Create Class Material";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 740);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.panel1);
            this.Name = "CreateMaterial";
            this.Text = "CreateMaterial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GoogleClassroom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button PostBtn;
    }
}