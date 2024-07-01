using BUS;
using DAL;
using DTO;
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
    public partial class QL_Tai_Khoan_Doc_Gia : Form
    {
        public QL_Tai_Khoan_Doc_Gia()
        {
            InitializeComponent();
        }

        private void btn_nhan_vien_Click(object sender, EventArgs e)
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

        private void btn_muon_tra_Click_1(object sender, EventArgs e)
        {
            QL_TraMuon_Sach qlmt = new QL_TraMuon_Sach();
            this.Hide();
            qlmt.ShowDialog();
        }

        public void loads_dgv()
        {
            dgv_ds_doc_gia.DataSource = DocGiaBUS.ds_docgia();
        }

        private void QL_Tai_Khoan_Doc_Gia_Load(object sender, EventArgs e)
        {
            loads_dgv();
            ClearForm();
        }

        private void ClearForm()
        {
            txt_ma_doc_gia.Clear();
            txt_ten_doc_gia.Clear();
            txt_nam_sinh.Clear();
            txt_dia_chi.Clear();
            txt_so_dien_thoai.Clear();
            txt_cmt.Clear();
            txt_han_the.Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                int maDocGia = int.Parse(txt_ma_doc_gia.Text);
                String tenDG = txt_ten_doc_gia.Text;
                DateTime ngaySinh = DateTime.Parse(txt_nam_sinh.Text);
                String DiaChi = txt_dia_chi.Text;
                int Sdt = int.Parse(txt_so_dien_thoai.Text);
                string CMT = txt_cmt.Text;
                String HanThe = txt_han_the.Text;
                tbDocGia dg = new tbDocGia(maDocGia, tenDG, ngaySinh, DiaChi, Sdt, CMT, HanThe);
                DocGiaBUS.InsertDocGia(dg);
                MessageBox.Show("Bạn đã thêm " + tenDG + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                int maDocGia = int.Parse(txt_ma_doc_gia.Text);
                String tenDG = txt_ten_doc_gia.Text;
                DateTime ngaySinh = DateTime.Parse(txt_nam_sinh.Text);
                String DiaChi = txt_dia_chi.Text;
                int Sdt = int.Parse(txt_so_dien_thoai.Text);
                string CMT = txt_cmt.Text;
                String HanThe = txt_han_the.Text;
                tbDocGia dg = new tbDocGia(maDocGia, tenDG, ngaySinh, DiaChi, Sdt, CMT, HanThe);
                DocGiaBUS.UpdateDocGia(dg);
                MessageBox.Show("Bạn đã cập nhật " + tenDG + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maDocGia = int.Parse(txt_ma_doc_gia.Text);
                String tenDG = txt_ten_doc_gia.Text;
                DateTime ngaySinh = DateTime.Parse(txt_nam_sinh.Text);
                String DiaChi = txt_dia_chi.Text;
                int Sdt = int.Parse(txt_so_dien_thoai.Text);
                string CMT = txt_cmt.Text;
                String HanThe = txt_han_the.Text;
                tbDocGia dg = new tbDocGia(maDocGia, tenDG, ngaySinh, DiaChi, Sdt, CMT, HanThe);
                DocGiaBUS.DeleteDocGia(dg);
                MessageBox.Show("Bạn đã xóa " + tenDG + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
