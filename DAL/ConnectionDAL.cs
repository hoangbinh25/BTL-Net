using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
<<<<<<< HEAD
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-R4OFTQE1;Initial Catalog=QL_THUVIEN;Integrated Security=True;");
=======
            SqlConnection Conn = new SqlConnection(@"Data Source=THANHTUNG\THANHTUNG;Initial Catalog=QL_THUVIEN;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
>>>>>>> 6d7d2d6857f909fa2c92cb972bfcba67ef64b9e9
            return Conn;
        }
    }
}