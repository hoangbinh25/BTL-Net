using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QL_chi_tiet_muon : Form
    {
        private int phieu_muon_id;

        public QL_chi_tiet_muon()
        {
            InitializeComponent();
        }

        public QL_chi_tiet_muon(int phieu_muon_id)
        {
            this.phieu_muon_id = phieu_muon_id;
        }

        public void Loads_chi_tiet_phieu_muon(int phieu_muon_id)
        {
            dgv_ds_cuon_sach.DataSource = MuonTraBUS.ds_chi_tiet_phieu_muonBUS(phieu_muon_id);
        }
        public void Load_sach()
        {
            cbb_cuon_sach.DataSource = MuonTraBUS.ds_sachBUS();
            cbb_cuon_sach.DisplayMember = "ten_sach";
            cbb_cuon_sach.ValueMember = "sach_id";
        }
        public void clearForm_chiTiet_phieuMuon()
        {
            // Reset combo box
            cbb_cuon_sach.SelectedIndex = -1;
            txt_so_luong.Text = string.Empty;
        }
        private void btn_nhan_vien_Click(object sender, EventArgs e)
        {

        }

        private void btn_kho_sach_Click(object sender, EventArgs e)
        {
            QL_Kho_Sach qlks = new QL_Kho_Sach();
            this.Hide();
            qlks.ShowDialog();
        }

        private void btn_doc_gia_Click(object sender, EventArgs e)
        {
            QL_Tai_Khoan_Doc_Gia qldg = new QL_Tai_Khoan_Doc_Gia();
            this.Hide();
            qldg.ShowDialog();
        }

        private void btn_muon_tra_Click(object sender, EventArgs e)
        {
            QL_TraMuon_Sach qlmt = new QL_TraMuon_Sach();
            this.Hide();
            qlmt.ShowDialog();
        }

        private void btn_dang_xuat_Click(object sender, EventArgs e)
        {

        }

        private void QL_chi_tiet_muon_Load(object sender, EventArgs e)
        {
            Loads_chi_tiet_phieu_muon(phieu_muon_id);
        }

        private void btn_them_chi_tiet_phieu_muon_Click(object sender, EventArgs e)
        {

        }
    }
}
