using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lab_Project
{
    public class Announcement
    {
        public int announcementID;
        public string announcementTitle;
        public string announcementDescription;
        public string announcementDate;
        public string announcementClassCode;

        public Announcement(int announcementID, string announcementTitle, string announcementDescription, string announcementDate, string announcementClassCode)
        {
            this.announcementID = announcementID;
            this.announcementTitle = announcementTitle;
            this.announcementDescription = announcementDescription;
            this.announcementDate = announcementDate;
            this.announcementClassCode = announcementClassCode;
        }
        
        public Announcement(String Title, String Desciption)
        {
            this.announcementTitle = Title;
            this.announcementDescription = Desciption;
        }

        public int AnnouncementID
        {
            get { return announcementID; }
            set { announcementID = value; }
        }

        public string AnnouncementTitle
        {
            get { return announcementTitle; }
            set { announcementTitle = value; }
        }

        public string AnnouncementDescription
        {
            get { return announcementDescription; }
            set { announcementDescription = value; }
        }

        public string AnnouncementDate
        {
            get { return announcementDate; }
            set { announcementDate = value; }
        }

        public string AnnouncementClassCode
        {
            get { return announcementClassCode; }
            set { announcementClassCode = value; }
        }

        
    }
}
