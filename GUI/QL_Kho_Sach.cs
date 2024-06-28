using DAL;
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
    public partial class QL_Kho_Sach : Form
    {
        DataTable dt = new DataTable();
        public QL_Kho_Sach()
        {
            InitializeComponent();
        }

        private void btn_nhan_vien_Click(object sender, EventArgs e)
        {
            QL_Nhan_Vien qlnv = new QL_Nhan_Vien();
            this.Hide();
            qlnv.ShowDialog();
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
    }
}
