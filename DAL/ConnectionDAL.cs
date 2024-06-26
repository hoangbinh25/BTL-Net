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
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-R4OFTQE1;Initial Catalog=QL_THUVIEN;Integrated Security=True;Encrypt=True;");
            return Conn;
        }
    }
    public class ConnectionDAL
    {
        public static string CheckLogic_DTO(TaiKhoanDTO taikhoan)
        {
            string user = null;
            // connect tới CSDL
            SqlConnection Conn = SqlConnectionData.Connect();
            Conn.Open();
            SqlCommand command = new SqlCommand("proc_login", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.ten_nguoi_dung);
            command.Parameters.AddWithValue("@pass", taikhoan.mat_khau);
            command.Parameters.AddWithValue("@role", taikhoan.vai_tro);
            command.Connection = Conn;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                Conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;
        }
    }
}
