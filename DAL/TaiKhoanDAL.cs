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
    public class TaiKhoanDAL:ConnectionDAL
    {
        public string CheckLogic(TaiKhoanDTO taikhoan)
        {
            string info = CheckLogic_DTO(taikhoan);
            return info;
        }
    }
}
