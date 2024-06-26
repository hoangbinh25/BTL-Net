using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAL tkAccess = new TaiKhoanDAL();

        public string CheckLogic(TaiKhoanDTO taikhoan)
        {
            if (taikhoan.ten_nguoi_dung == "")
            {
                return "requeid_taikhoan";
            }

            if (taikhoan.mat_khau == "")
            {
                return "requeid_matkhau";
            }

            string info = tkAccess.CheckLogic(taikhoan);

            return info;
        }
    }
}
