using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SachBUS
    {
        public static DataTable ds_theloai()
        {
            return QuerySQL.select_all_theLoai();
        }

        public static DataTable ds_ngon_ngu()
        {
            return QuerySQL.select_all_ngon_ngu();
        }
        public static DataTable ds_sach()
        {
            return QuerySQL.select_all_sach();
        }
        public static void them_sach(tblSach sach)
        {
            QuerySQL.insert_sach(sach);
        }
        public static void sua_sach(tblSach sach)
        {
            QuerySQL.edit_sach(sach);
        }
        public static void xoa_sach(tblSach sach)
        {
            QuerySQL.delete_sach(sach);
        }
    }
}
