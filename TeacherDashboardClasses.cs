using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_Project
{
    public class TeacherDashboardClasses
    {
        public string className;
        public string classCode;

        public TeacherDashboardClasses(string className, string classCode)
        {
            this.className = className;
            this.classCode = classCode;
        }

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        public string ClassCode
        {
            get { return classCode; }
            set { classCode = value; }
        }
        
    }
}
