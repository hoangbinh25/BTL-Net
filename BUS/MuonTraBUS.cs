using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MuonTraBUS
    {
        public static DataTable ds_sachBUS()
        {
            return MuonTraDAL.select_all_sach();
        }
        public static DataTable ds_phieu_muonBUS()
        {
            return MuonTraDAL.select_all_phieu_muon();
        }
        public static DataTable ds_chi_tiet_phieu_muonBUS(int phieu_muon_id)
        {
            return MuonTraDAL.select_all_chi_tiet_phieu_muon(phieu_muon_id);
        }
    }
}
