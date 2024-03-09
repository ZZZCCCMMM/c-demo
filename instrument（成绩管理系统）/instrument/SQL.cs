using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrument
{
    internal class SQL
    {
        public static DataTable GetTable(string sqltext)
        {
            SqlConnection connection = new SqlConnection(Config.ConnecctionString);
            SqlDataAdapter adapter = new SqlDataAdapter(sqltext, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            connection.Dispose();
            return dt;
        }
    }
}
