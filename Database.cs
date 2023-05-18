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
        private string connString;

        public Database()
        {
            connString = @"Data Source = UMARFAROOQ\SQLEXPRESS; Initial Catalog = DB_L_Project; Integrated Security = True";
        }

        public string ConnectionString()
        {            
            return connString;
        }
    }
}
