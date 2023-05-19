using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lab_Project
{
    
    public class Assignment
    {
        public int assignmentID;
        public string assignmentTitle;
        public string assignmentDescription;
        public string assignmentDate;
        public int assignmentMarks;
        public string assignmentClassCode;

        public Assignment()
        {

        }

        public Assignment(int assignmentID, string assignmentTitle, string assignmentDescription, string assignmentDate, int assignmentMarks)
        {
            this.assignmentID = assignmentID;
            this.assignmentTitle = assignmentTitle;
            this.assignmentDescription = assignmentDescription;
            this.assignmentDate = assignmentDate;
            this.assignmentMarks = assignmentMarks;
        }

        public Assignment(String Title, String Desciption)
        {
            this.assignmentTitle = Title;
            this.assignmentDescription = Desciption;
        }
        
        public Assignment(String Title)
        {
            this.assignmentTitle = Title; 
        }

        public int AssignmentID
        {
            get { return assignmentID; }
            set { assignmentID = value; }
        }

        public string AssignmentTitle
        {
            get { return assignmentTitle; }
            set { assignmentTitle = value; }
        }

        public string AssignmentDescription
        {
            get { return assignmentDescription; }
            set { assignmentDescription = value; }
        }

        public string AssignmentDate
        {
            get { return assignmentDate; }
            set { assignmentDate = value; }
        }

        public int AssignmentMarks
        {
            get { return assignmentMarks; }
            set { assignmentMarks = value; }
        }

        public string AssignmentClassCode
        {
            get { return assignmentClassCode; }
            set { assignmentClassCode = value; }
        }

        public override string ToString()
        {
            return assignmentTitle;
        }

    }
}
