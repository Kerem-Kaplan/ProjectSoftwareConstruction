using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SoftwareConstructorProject
{
    public class Sql_Connection
    {
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP;Initial Catalog=DbSoftConstProject;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
