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

        private void cbb_the_loai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void HienThiComboBox()
        {
            
        }

        private void QL_Kho_Sach_Load(object sender, EventArgs e)
        {

            String strQuery = "select * from loai_sach";
            try
            {
                dt = QuerySQL.getData(strQuery);
                cbb_the_loai.DisplayMember = "ten_loai_sach";
                cbb_the_loai.ValueMember = "loai_sach_id";
                cbb_the_loai.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
