using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_Lab_Project
{
    public static class Database
    {
        public static bool choose = true;

        public static string getConnection()
        {
            if (choose)
            {
                return @"Data Source = UMARFAROOQ\SQLEXPRESS; Initial Catalog = DB_L_Project; Integrated Security = True";

            }
            else
            {
                return @"Data Source = DESKTOP-L3PILNC\SQLEXPRESS; Initial Catalog = DB_L_Project; Integrated Security = True";
            }

        }
    }
}
