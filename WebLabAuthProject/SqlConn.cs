using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WebLabAuthProject
{
    internal class SqlConn
    {
        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BOV3B8B\SQLEXPRESS;Initial Catalog=WebLabAuthDb;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}

