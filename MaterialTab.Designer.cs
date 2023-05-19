namespace DB_Lab_Project
{
    partial class MaterialTab
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
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.MaterialCB = new System.Windows.Forms.ComboBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Material
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(34, 58);
            this.MaterialLabel.Name = "Material";
            this.MaterialLabel.Size = new System.Drawing.Size(107, 31);
            this.MaterialLabel.TabIndex = 2;
            this.MaterialLabel.Text = "Material";
            // 
            // MaterialCB
            // 
            this.MaterialCB.FormattingEnabled = true;
            this.MaterialCB.Location = new System.Drawing.Point(239, 61);
            this.MaterialCB.Name = "MaterialCB";
            this.MaterialCB.Size = new System.Drawing.Size(374, 28);
            this.MaterialCB.TabIndex = 3;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Black;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(678, 104);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 39);
            this.DeleteBtn.TabIndex = 22;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Black;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(678, 59);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(104, 39);
            this.UpdateBtn.TabIndex = 21;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.Black;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBtn.Location = new System.Drawing.Point(678, 14);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(104, 39);
            this.ViewBtn.TabIndex = 20;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            // 
            // MaterialTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.MaterialCB);
            this.Controls.Add(this.MaterialLabel);
            this.Name = "MaterialTab";
            this.Size = new System.Drawing.Size(848, 166);
            this.Load += new System.EventHandler(this.MaterialLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.ComboBox MaterialCB;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ViewBtn;
    }
}
