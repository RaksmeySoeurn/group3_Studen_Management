using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_Management
{
    public abstract class SQL_Connection
    {
        private string cs;

        public SQL_Connection()
        {
            cs = "Data Source = KCS-PC\\SQLEXPRESS; Initial Catalog = Student_Management; Integrated Security = True";
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(cs);
        }
    }
  
}
