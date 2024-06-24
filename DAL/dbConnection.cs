using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class dbConnection
    {
        public static SqlConnection Connect()
        {
            SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-R4OFTQE1;Initial Catalog=QL_THUVIEN;Integrated Security=True;Encrypt=True;");
            return Conn;
        }
    }
}
