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
    public partial class QL_TraMuon_Sach : Form
    {
        public QL_TraMuon_Sach()
        {
            InitializeComponent();
        }
        private bool check = false; // biến check
        //phương thức xử lý 
        public void Loads_phieu_muon()
        {
            dgv_ds_muon_tra.DataSource = MuonTraBUS.ds_phieu_muonBUS();
        }
        
        
        public void clearForm_phieuMuon()
        {
            // Clear text boxes
            txt_ma_phieu_muon.Text = string.Empty;
            txt_ma_doc_gia.Text = string.Empty;
            txt_ngay_muon.Text = string.Empty;
            txt_ngay_tra.Text = string.Empty;
        }
        
        private void btn_nhan_vien_Click_1(object sender, EventArgs e)
        {
            QL_chi_tiet_muon qlnv = new QL_chi_tiet_muon();
            this.Hide();
            qlnv.ShowDialog();
        }

        private void btn_kho_sach_Click_1(object sender, EventArgs e)
        {
            QL_Kho_Sach qlks = new QL_Kho_Sach();
            this.Hide();
            qlks.ShowDialog();
        }

        private void btn_doc_gia_Click_1(object sender, EventArgs e)
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
        //phiếu mượn
        private void btn_them_phieu_muon_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_phieu_muon_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_phieu_muon_Click(object sender, EventArgs e)
        {

        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_bo_qua_phieu_muon_Click(object sender, EventArgs e)
        {
            clearForm_phieuMuon();
        }
       

        //Loads datagirdview
        private void QL_TraMuon_Sach_Load(object sender, EventArgs e)
        {
            Loads_phieu_muon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loads_phieu_muon();
            txt_ma_phieu_muon.Enabled = true;
            txt_ma_doc_gia.Enabled = true;
            txt_ngay_muon.Enabled = true;
            txt_ngay_tra.Enabled = true;
            check = false;
        }

        private void dgv_ds_muon_tra_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            // Kiểm tra xem chỉ số có hợp lệ không
            if (rowIndex >= 0 && rowIndex < dgv_ds_muon_tra.Rows.Count)
            {
                DataGridViewRow row = dgv_ds_muon_tra.Rows[rowIndex];
                txt_ma_phieu_muon.Text = row.Cells["phieu_muon_id"].Value.ToString();
                txt_ma_doc_gia.Text = row.Cells["doc_gia_id"].Value.ToString();
                txt_ngay_muon.Text = DateTime.Parse(row.Cells["ngay_muon"].Value.ToString()).ToString("yyyy-MM-dd");
                txt_ngay_tra.Text = DateTime.Parse(row.Cells["ngay_hen_tra"].Value.ToString()).ToString("yyyy-MM-dd");
            }
        }

        private void btn_xem_chi_tiet_phieu_muon_Click_1(object sender, EventArgs e)
        {
            int phieu_muon_id = int.Parse(txt_ma_phieu_muon.Text);
            QL_chi_tiet_muon qlChiTietMuon = new QL_chi_tiet_muon(phieu_muon_id);
            qlChiTietMuon.ShowDialog();
        }
    }
}
