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
    public partial class Tim_kiem : Form
    {
        public Tim_kiem()
        {
            InitializeComponent();
        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txt_tim_kiem.Text;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable results = SearchBookBUS.searchBooks(searchTerm);
                dgv_ds_tim_kiem.DataSource = results;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
            }
        }

        private void btn_dang_xuat_Click(object sender, EventArgs e)
        {
            if(true)
            {
                MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                form_dang_nhap lform = new form_dang_nhap();
                this.Hide();
                lform.ShowDialog();
            } 
        }
    }
}
