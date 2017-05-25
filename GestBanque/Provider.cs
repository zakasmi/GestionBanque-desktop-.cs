using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBanque
{
    class Provider
    {
        public static SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestBanque;Integrated Security=True");
        public static DataSet ds = new DataSet();




    }

  
}
