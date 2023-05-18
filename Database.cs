using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_Lab_Project
{
    public class Database
    {
        private string UmarString;
        private string ARString;

        public Database()
        {
            UmarString = @"Data Source = UMARFAROOQ\SQLEXPRESS; Initial Catalog = DB_L_Project; Integrated Security = True";
            //ARString = 
        }

        public string getUmarString()
        {            
            return UmarString;
        }
        public string getARString()
        {
            return ARString;
        }
    }
}
