﻿namespace DB_Lab_Project
{
    partial class Announcements_Tab
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
            this.Announcements = new System.Windows.Forms.Label();
            this.AnnouncementCB = new System.Windows.Forms.ComboBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Announcements
            // 
            this.Announcements.AutoSize = true;
            this.Announcements.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Announcements.Location = new System.Drawing.Point(34, 58);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(203, 31);
            this.Announcements.TabIndex = 0;
            this.Announcements.Text = "Announcements";
            // 
            // AnnouncementCB
            // 
            this.AnnouncementCB.FormattingEnabled = true;
            this.AnnouncementCB.Location = new System.Drawing.Point(255, 61);
            this.AnnouncementCB.Name = "AnnouncementCB";
            this.AnnouncementCB.Size = new System.Drawing.Size(374, 28);
            this.AnnouncementCB.TabIndex = 1;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.Black;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBtn.Location = new System.Drawing.Point(675, 12);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(104, 39);
            this.ViewBtn.TabIndex = 16;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Black;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(675, 60);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(104, 39);
            this.UpdateBtn.TabIndex = 17;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Black;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(675, 106);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 39);
            this.DeleteBtn.TabIndex = 18;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Announcements_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.AnnouncementCB);
            this.Controls.Add(this.Announcements);
            this.Name = "Announcements_Tab";
            this.Size = new System.Drawing.Size(848, 166);
            this.Load += new System.EventHandler(this.Announcement_Tab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Announcements;
        private System.Windows.Forms.ComboBox AnnouncementCB;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
