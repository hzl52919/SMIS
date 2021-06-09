using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DBUtils
    {
        public SqlConnection DBConn (){
            string connstr = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(connstr);
            sqlconn.Open();
            return sqlconn;
        }
    }
}
