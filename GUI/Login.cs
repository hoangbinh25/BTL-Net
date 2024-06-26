using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class form_dang_nhap : Form
    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        TaiKhoanBUS TKBUS = new TaiKhoanBUS();
        public form_dang_nhap()
        {
            InitializeComponent();
        }

        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            taikhoan.ten_nguoi_dung = txt_ten_nguoi_dung.Text;
            taikhoan.mat_khau = txt_mat_khau.Text;
            string getuser = TKBUS.CheckLogic(taikhoan);

            // Trả lại kết quả nếu nhập tài khoản không đúng
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "requeid_matkhau":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }
            MessageBox.Show("Đăng nhập thành công");
            QL_Kho_Sach qlksForm = new QL_Kho_Sach();
            qlksForm.ShowDialog();
        }
    }
}
