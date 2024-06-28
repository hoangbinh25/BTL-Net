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
        public TaiKhoanDAL tkDAL = new TaiKhoanDAL();
        
        public bool ValidateUser(string username, string password)
        {
            return tkDAL.ValidateUser(username, password);
        }
    }
}
