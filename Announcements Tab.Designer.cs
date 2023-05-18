namespace DB_Lab_Project
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
            this.SuspendLayout();
            // 
            // Announcements
            // 
            this.Announcements.AutoSize = true;
            this.Announcements.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Announcements.Location = new System.Drawing.Point(34, 36);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(203, 31);
            this.Announcements.TabIndex = 0;
            this.Announcements.Text = "Announcements";
            // 
            // AnnouncementCB
            // 
            this.AnnouncementCB.FormattingEnabled = true;
            this.AnnouncementCB.Location = new System.Drawing.Point(255, 37);
            this.AnnouncementCB.Name = "AnnouncementCB";
            this.AnnouncementCB.Size = new System.Drawing.Size(374, 28);
            this.AnnouncementCB.TabIndex = 1;
            // 
            // Announcements_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnnouncementCB);
            this.Controls.Add(this.Announcements);
            this.Name = "Announcements_Tab";
            this.Size = new System.Drawing.Size(675, 111);
            this.Load += new System.EventHandler(this.Announcement_Tab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Announcements;
        private System.Windows.Forms.ComboBox AnnouncementCB;
    }
}
