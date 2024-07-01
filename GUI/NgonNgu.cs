using BUS;
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
    public partial class NgonNgu : Form
    {
        public NgonNgu()
        {
            InitializeComponent();
        }

        public void loads_dgv()
        {
            dgv_ds_ngon_ngu.DataSource = NgonNguBUS.getAllNgonNgu();
        }

        private void ClearForm()
        {
            txt_ma_ngon_ngu.Clear();
            txt_ngon_ngu.Clear();
        }


        private void btn_ngonNgu_Click(object sender, EventArgs e)
        {

        }
        private void NgonNgu_Load(object sender, EventArgs e)
        {
            loads_dgv();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                int maNgonNgu = int.Parse(txt_ma_ngon_ngu.Text);
                String tenNN = txt_ngon_ngu.Text;
                tbNgonNgu ngonNgu = new tbNgonNgu(maNgonNgu, tenNN);
                NgonNguBUS.Them_NgonNgu(ngonNgu);
                MessageBox.Show("Bạn đã thêm " + tenNN + " thành công");
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
                int maNgonNgu = int.Parse(txt_ma_ngon_ngu.Text);
                String tenNN = txt_ngon_ngu.Text;
                tbNgonNgu ngonNgu = new tbNgonNgu(maNgonNgu, tenNN);
                NgonNguBUS.Sua_NgonNgu(ngonNgu);
                MessageBox.Show("Bạn đã cập nhật " + tenNN + " thành công");
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
                int maNgonNgu = int.Parse(txt_ma_ngon_ngu.Text);
                String tenNN = txt_ngon_ngu.Text;
                tbNgonNgu ngonNgu = new tbNgonNgu(maNgonNgu, tenNN);
                NgonNguBUS.Xoa_NgonNgu(ngonNgu);
                MessageBox.Show("Bạn đã xóa " + tenNN + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_muon_tra_Click(object sender, EventArgs e)
        {
            QL_TraMuon_Sach qlmt = new QL_TraMuon_Sach();
            this.Hide();
            qlmt.ShowDialog();
        }

        private void btn_doc_gia_Click(object sender, EventArgs e)
        {
            QL_Tai_Khoan_Doc_Gia qldg = new QL_Tai_Khoan_Doc_Gia();
            this.Hide();
            qldg.ShowDialog();
        }

        private void btn_kho_sach_Click(object sender, EventArgs e)
        {
            QL_Kho_Sach qlks = new QL_Kho_Sach();
            this.Hide();
            qlks.ShowDialog();
        }

        private void btn_nhan_vien_Click(object sender, EventArgs e)
        {
            QL_Nhan_Vien qlnv = new QL_Nhan_Vien();
            this.Hide();
            qlnv.ShowDialog();
        }
    }
}
