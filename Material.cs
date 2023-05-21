using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lab_Project
{
    public class Material
    {
        public int materialID;
        public string materialTitle;
        public string materialDescription;
        public string materialTime;
        public int classCode;

        public Material(int materialID, string materialTitle, string materialDescription, string materialTime, int classCode)
        {
            this.materialID = materialID;
            this.materialTitle = materialTitle;
            this.materialDescription = materialDescription;
            this.materialTime = materialTime;
            this.classCode = classCode;
        }
        
        public Material(string materialTitle, string materialDescription)
        {
            this.materialTitle = materialTitle;
            this.materialDescription = materialDescription;
        }

        public int MaterialID
        {
            get { return materialID; }
            set { materialID = value; }
        }


        public string MaterialTitle
        {
            get { return materialTitle; }
            set { materialTitle = value; }
        }


        public string MaterialDescription
        {
            get { return materialDescription; }
            set { materialDescription = value; }
        }


        public string MaterialTime
        {
            get { return materialTime; }
            set { materialTime = value; }
        }


        public override string ToString()
        {
            return materialTitle;
        }

    }
}
