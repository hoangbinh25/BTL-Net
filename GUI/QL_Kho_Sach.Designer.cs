namespace GUI
{
    partial class QL_Kho_Sach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            txt_ten_sach = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label2222 = new Label();
            groupBox2 = new GroupBox();
            dgv_kho_sach = new DataGridView();
            panel2 = new Panel();
            txt_tac_gia = new TextBox();
            label8 = new Label();
            txt_so_luong = new TextBox();
            label6 = new Label();
            txt_nha_xuat_ban = new TextBox();
            label7 = new Label();
            txt_gia_bia = new TextBox();
            label4 = new Label();
            txt_ngay_nhap = new TextBox();
            label5 = new Label();
            cbb_ngon_ngu = new ComboBox();
            label1 = new Label();
            btn_boqua = new Button();
            cbb_the_loai = new ComboBox();
            txt_ma_sach = new TextBox();
            groupBox1 = new GroupBox();
            btn_dang_xuat = new Button();
            btn_muon_tra = new Button();
            btn_doc_gia = new Button();
            btn_kho_sach = new Button();
            panel1 = new Panel();
            btn_nhan_vien = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_kho_sach).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_xoa
            // 
            btn_xoa.Cursor = Cursors.Hand;
            btn_xoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoa.ForeColor = Color.Black;
            btn_xoa.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            btn_xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoa.Location = new Point(321, 412);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Padding = new Padding(10, 5, 5, 5);
            btn_xoa.Size = new Size(101, 41);
            btn_xoa.TabIndex = 11;
            btn_xoa.Text = "Xóa";
            btn_xoa.TextAlign = ContentAlignment.MiddleRight;
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Cursor = Cursors.Hand;
            btn_sua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua.ForeColor = Color.Black;
            btn_sua.Image = Properties.Resources.z5560539359740_9337aa11269aeccd6e939ece18cfa20e;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(171, 412);
            btn_sua.Name = "btn_sua";
            btn_sua.Padding = new Padding(10, 5, 5, 5);
            btn_sua.Size = new Size(101, 41);
            btn_sua.TabIndex = 10;
            btn_sua.Text = "Sửa";
            btn_sua.TextAlign = ContentAlignment.MiddleRight;
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Cursor = Cursors.Hand;
            btn_them.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_them.ForeColor = Color.Black;
            btn_them.Image = Properties.Resources.z5560539359591_8726bde7817e7680733c216c1b763b9d;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(27, 412);
            btn_them.Name = "btn_them";
            btn_them.Padding = new Padding(10, 5, 5, 5);
            btn_them.Size = new Size(101, 41);
            btn_them.TabIndex = 9;
            btn_them.Text = "Thêm ";
            btn_them.TextAlign = ContentAlignment.MiddleRight;
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // txt_ten_sach
            // 
            txt_ten_sach.BackColor = SystemColors.Control;
            txt_ten_sach.Font = new Font("Segoe UI", 12F);
            txt_ten_sach.Location = new Point(26, 104);
            txt_ten_sach.Multiline = true;
            txt_ten_sach.Name = "txt_ten_sach";
            txt_ten_sach.Size = new Size(473, 33);
            txt_ten_sach.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 229);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 6;
            label3.Text = "Thể Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 4;
            label2.Text = "Tên Sách";
            // 
            // label2222
            // 
            label2222.AutoSize = true;
            label2222.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2222.ForeColor = Color.White;
            label2222.Location = new Point(26, 3);
            label2222.Name = "label2222";
            label2222.Size = new Size(86, 28);
            label2222.TabIndex = 2;
            label2222.Text = "Mã Sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_kho_sach);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(32, 500);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(1079, 273);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // dgv_kho_sach
            // 
            dgv_kho_sach.AllowUserToAddRows = false;
            dgv_kho_sach.AllowUserToDeleteRows = false;
            dgv_kho_sach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_kho_sach.Location = new Point(0, 27);
            dgv_kho_sach.Name = "dgv_kho_sach";
            dgv_kho_sach.ReadOnly = true;
            dgv_kho_sach.RowHeadersWidth = 51;
            dgv_kho_sach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_kho_sach.Size = new Size(1079, 247);
            dgv_kho_sach.TabIndex = 0;
            dgv_kho_sach.RowEnter += dgv_kho_sach_RowEnter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_tac_gia);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_so_luong);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_nha_xuat_ban);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_gia_bia);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_ngay_nhap);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cbb_ngon_ngu);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_boqua);
            panel2.Controls.Add(btn_xoa);
            panel2.Controls.Add(btn_sua);
            panel2.Controls.Add(btn_them);
            panel2.Controls.Add(txt_ten_sach);
            panel2.Controls.Add(cbb_the_loai);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_ma_sach);
            panel2.Controls.Add(label2222);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(27, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 462);
            panel2.TabIndex = 0;
            // 
            // txt_tac_gia
            // 
            txt_tac_gia.BackColor = SystemColors.Control;
            txt_tac_gia.Font = new Font("Segoe UI", 12F);
            txt_tac_gia.Location = new Point(26, 181);
            txt_tac_gia.Multiline = true;
            txt_tac_gia.Name = "txt_tac_gia";
            txt_tac_gia.Size = new Size(473, 33);
            txt_tac_gia.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(26, 151);
            label8.Name = "label8";
            label8.Size = new Size(73, 28);
            label8.TabIndex = 23;
            label8.Text = "Tác Giả";
            // 
            // txt_so_luong
            // 
            txt_so_luong.BackColor = SystemColors.Control;
            txt_so_luong.Font = new Font("Segoe UI", 12F);
            txt_so_luong.Location = new Point(563, 276);
            txt_so_luong.Multiline = true;
            txt_so_luong.Name = "txt_so_luong";
            txt_so_luong.Size = new Size(473, 33);
            txt_so_luong.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(563, 233);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 21;
            label6.Text = "Số Lượng";
            // 
            // txt_nha_xuat_ban
            // 
            txt_nha_xuat_ban.BackColor = SystemColors.Control;
            txt_nha_xuat_ban.Font = new Font("Segoe UI", 12F);
            txt_nha_xuat_ban.Location = new Point(563, 181);
            txt_nha_xuat_ban.Multiline = true;
            txt_nha_xuat_ban.Name = "txt_nha_xuat_ban";
            txt_nha_xuat_ban.Size = new Size(473, 33);
            txt_nha_xuat_ban.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(563, 149);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 19;
            label7.Text = "Nhà Xuất Bản";
            // 
            // txt_gia_bia
            // 
            txt_gia_bia.BackColor = SystemColors.Control;
            txt_gia_bia.Font = new Font("Segoe UI", 12F);
            txt_gia_bia.Location = new Point(563, 104);
            txt_gia_bia.Multiline = true;
            txt_gia_bia.Name = "txt_gia_bia";
            txt_gia_bia.Size = new Size(473, 33);
            txt_gia_bia.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(563, 73);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 17;
            label4.Text = "Giá Bìa";
            // 
            // txt_ngay_nhap
            // 
            txt_ngay_nhap.BackColor = SystemColors.Control;
            txt_ngay_nhap.Font = new Font("Segoe UI", 12F);
            txt_ngay_nhap.Location = new Point(563, 33);
            txt_ngay_nhap.Multiline = true;
            txt_ngay_nhap.Name = "txt_ngay_nhap";
            txt_ngay_nhap.Size = new Size(473, 33);
            txt_ngay_nhap.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(563, 1);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 15;
            label5.Text = "Ngày Nhập";
            // 
            // cbb_ngon_ngu
            // 
            cbb_ngon_ngu.BackColor = SystemColors.Control;
            cbb_ngon_ngu.Font = new Font("Segoe UI", 12F);
            cbb_ngon_ngu.FormattingEnabled = true;
            cbb_ngon_ngu.Location = new Point(26, 343);
            cbb_ngon_ngu.Name = "cbb_ngon_ngu";
            cbb_ngon_ngu.Size = new Size(473, 36);
            cbb_ngon_ngu.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 313);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 13;
            label1.Text = "Ngôn Ngữ";
            // 
            // btn_boqua
            // 
            btn_boqua.Cursor = Cursors.Hand;
            btn_boqua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_boqua.ForeColor = Color.Black;
            btn_boqua.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            btn_boqua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_boqua.Location = new Point(901, 416);
            btn_boqua.Name = "btn_boqua";
            btn_boqua.Padding = new Padding(10, 5, 5, 5);
            btn_boqua.Size = new Size(101, 41);
            btn_boqua.TabIndex = 12;
            btn_boqua.Text = "Bỏ Qua";
            btn_boqua.TextAlign = ContentAlignment.MiddleRight;
            btn_boqua.UseVisualStyleBackColor = true;
            btn_boqua.Click += btn_boqua_Click;
            // 
            // cbb_the_loai
            // 
            cbb_the_loai.BackColor = SystemColors.Control;
            cbb_the_loai.Font = new Font("Segoe UI", 12F);
            cbb_the_loai.FormattingEnabled = true;
            cbb_the_loai.Location = new Point(26, 260);
            cbb_the_loai.Name = "cbb_the_loai";
            cbb_the_loai.Size = new Size(473, 36);
            cbb_the_loai.TabIndex = 7;
            // 
            // txt_ma_sach
            // 
            txt_ma_sach.BackColor = SystemColors.Control;
            txt_ma_sach.Font = new Font("Segoe UI", 12F);
            txt_ma_sach.Location = new Point(26, 33);
            txt_ma_sach.Multiline = true;
            txt_ma_sach.Name = "txt_ma_sach";
            txt_ma_sach.Size = new Size(473, 33);
            txt_ma_sach.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel2);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(235, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1141, 792);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý Kho Sách";
            // 
            // btn_dang_xuat
            // 
            btn_dang_xuat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dang_xuat.Location = new Point(14, 737);
            btn_dang_xuat.Name = "btn_dang_xuat";
            btn_dang_xuat.Size = new Size(190, 33);
            btn_dang_xuat.TabIndex = 4;
            btn_dang_xuat.Text = "Đăng Xuất";
            btn_dang_xuat.UseVisualStyleBackColor = true;
            // 
            // btn_muon_tra
            // 
            btn_muon_tra.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_muon_tra.Location = new Point(14, 181);
            btn_muon_tra.Name = "btn_muon_tra";
            btn_muon_tra.Size = new Size(190, 35);
            btn_muon_tra.TabIndex = 3;
            btn_muon_tra.Text = "Mượn Trả";
            btn_muon_tra.UseVisualStyleBackColor = true;
            btn_muon_tra.Click += btn_muon_tra_Click;
            // 
            // btn_doc_gia
            // 
            btn_doc_gia.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_doc_gia.Location = new Point(14, 127);
            btn_doc_gia.Name = "btn_doc_gia";
            btn_doc_gia.Size = new Size(190, 35);
            btn_doc_gia.TabIndex = 2;
            btn_doc_gia.Text = "Độc Giả";
            btn_doc_gia.UseVisualStyleBackColor = true;
            btn_doc_gia.Click += btn_doc_gia_Click;
            // 
            // btn_kho_sach
            // 
            btn_kho_sach.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_kho_sach.Location = new Point(14, 67);
            btn_kho_sach.Name = "btn_kho_sach";
            btn_kho_sach.Size = new Size(190, 33);
            btn_kho_sach.TabIndex = 1;
            btn_kho_sach.Text = "Kho Sách";
            btn_kho_sach.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.xanhtimdocmmm;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_dang_xuat);
            panel1.Controls.Add(btn_muon_tra);
            panel1.Controls.Add(btn_doc_gia);
            panel1.Controls.Add(btn_kho_sach);
            panel1.Controls.Add(btn_nhan_vien);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 792);
            panel1.TabIndex = 6;
            // 
            // btn_nhan_vien
            // 
            btn_nhan_vien.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nhan_vien.Location = new Point(14, 15);
            btn_nhan_vien.Name = "btn_nhan_vien";
            btn_nhan_vien.Size = new Size(190, 33);
            btn_nhan_vien.TabIndex = 0;
            btn_nhan_vien.Text = "Nhân Viên";
            btn_nhan_vien.UseVisualStyleBackColor = true;
            btn_nhan_vien.Click += btn_nhan_vien_Click;
            // 
            // QL_Kho_Sach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.xanhtim2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1374, 788);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "QL_Kho_Sach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QL_Kho_Sach";
            Load += QL_Kho_Sach_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_kho_sach).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private TextBox txt_ten_sach;
        private Label label3;
        private Label label2;
        private Label label2222;
        private GroupBox groupBox2;
        private DataGridView dgv_kho_sach;
        private Panel panel2;
        private TextBox txt_ma_sach;
        private GroupBox groupBox1;
        private Button btn_dang_xuat;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private Button btn_kho_sach;
        private Panel panel1;
        private Button btn_nhan_vien;
        private Button btn_boqua;
        private ComboBox cbb_the_loai;
        private TextBox txt_tac_gia;
        private Label label8;
        private TextBox txt_so_luong;
        private Label label6;
        private TextBox txt_nha_xuat_ban;
        private Label label7;
        private TextBox txt_gia_bia;
        private Label label4;
        private TextBox txt_ngay_nhap;
        private Label label5;
        private ComboBox cbb_ngon_ngu;
        private Label label1;
    }
}