namespace DB_Lab_Project
{
    partial class AssignmentsTab
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
            this.Assignments = new System.Windows.Forms.Label();
            this.AssignmentCB = new System.Windows.Forms.ComboBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Assignments
            // 
            this.Assignments.AutoSize = true;
            this.Assignments.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignments.Location = new System.Drawing.Point(34, 58);
            this.Assignments.Name = "Assignments";
            this.Assignments.Size = new System.Drawing.Size(160, 31);
            this.Assignments.TabIndex = 1;
            this.Assignments.Text = "Assignments";
            // 
            // AssignmentCB
            // 
            this.AssignmentCB.FormattingEnabled = true;
            this.AssignmentCB.Location = new System.Drawing.Point(239, 61);
            this.AssignmentCB.Name = "AssignmentCB";
            this.AssignmentCB.Size = new System.Drawing.Size(374, 28);
            this.AssignmentCB.TabIndex = 2;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.Black;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBtn.Location = new System.Drawing.Point(678, 16);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(104, 39);
            this.ViewBtn.TabIndex = 17;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Black;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(678, 61);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(104, 39);
            this.UpdateBtn.TabIndex = 18;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Black;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(678, 106);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 39);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // AssignmentsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.AssignmentCB);
            this.Controls.Add(this.Assignments);
            this.Name = "AssignmentsTab";
            this.Size = new System.Drawing.Size(848, 166);
            this.Load += new System.EventHandler(this.AssignmentLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Assignments;
        private System.Windows.Forms.ComboBox AssignmentCB;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
