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
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();

        public string CheckLogic(TaiKhoan taikhoan)
        {
            if (taikhoan.ten_nguoi_dung == "")
            {
                return "requeid_taikhoan";
            }

            if (taikhoan.mat_khau == "")
            {
                return "requeid_taikhoan";
            }

            string info = tkAccess.CheckLogic(taikhoan);

            return info;
        }
    }
}
