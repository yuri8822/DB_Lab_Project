namespace DB_Lab_Project
{
    partial class DashboardClasses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassName = new System.Windows.Forms.Label();
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassName.Location = new System.Drawing.Point(3, 35);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(147, 31);
            this.ClassName.TabIndex = 0;
            this.ClassName.Text = "Class Name";
            // 
            // ClassesCB
            // 
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Location = new System.Drawing.Point(157, 37);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(319, 28);
            this.ClassesCB.TabIndex = 1;
            // 
            // DashboardClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClassesCB);
            this.Controls.Add(this.ClassName);
            this.Name = "DashboardClasses";
            this.Size = new System.Drawing.Size(499, 81);
            this.Load += new System.EventHandler(this.DashboardClasses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.ComboBox ClassesCB;
    }
}
