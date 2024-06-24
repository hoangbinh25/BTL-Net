namespace GUI
{
    partial class QL_Nhan_Vien
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
            btn_nhan_vien = new Button();
            panel1 = new Panel();
            btn_dang_xuat = new Button();
            btn_muon_tra = new Button();
            btn_doc_gia = new Button();
            btn_kho_sach = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgv_ds_nhan_vien = new DataGridView();
            panel2 = new Panel();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            txt_mat_khau = new TextBox();
            cbb_vai_tro = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txt_ten_nguoi_dung = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ds_nhan_vien).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.Location = new Point(2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 581);
            panel1.TabIndex = 4;
            // 
            // btn_dang_xuat
            // 
            btn_dang_xuat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dang_xuat.Location = new Point(14, 531);
            btn_dang_xuat.Name = "btn_dang_xuat";
            btn_dang_xuat.Size = new Size(190, 33);
            btn_dang_xuat.TabIndex = 4;
            btn_dang_xuat.Text = "Đăng Xuất";
            btn_dang_xuat.UseVisualStyleBackColor = true;
            btn_dang_xuat.Click += btn_dang_xuat_Click;
            // 
            // btn_muon_tra
            // 
            btn_muon_tra.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_muon_tra.Location = new Point(14, 173);
            btn_muon_tra.Name = "btn_muon_tra";
            btn_muon_tra.Size = new Size(190, 33);
            btn_muon_tra.TabIndex = 3;
            btn_muon_tra.Text = "Mượn Trả";
            btn_muon_tra.UseVisualStyleBackColor = true;
            btn_muon_tra.Click += btn_muon_tra_Click;
            // 
            // btn_doc_gia
            // 
            btn_doc_gia.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_doc_gia.Location = new Point(14, 119);
            btn_doc_gia.Name = "btn_doc_gia";
            btn_doc_gia.Size = new Size(190, 33);
            btn_doc_gia.TabIndex = 2;
            btn_doc_gia.Text = "Độc Giả";
            btn_doc_gia.UseVisualStyleBackColor = true;
            btn_doc_gia.Click += btn_doc_gia_Click;
            // 
            // btn_kho_sach
            // 
            btn_kho_sach.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_kho_sach.Location = new Point(14, 66);
            btn_kho_sach.Name = "btn_kho_sach";
            btn_kho_sach.Size = new Size(190, 33);
            btn_kho_sach.TabIndex = 1;
            btn_kho_sach.Text = "Kho Sách";
            btn_kho_sach.UseVisualStyleBackColor = true;
            btn_kho_sach.Click += btn_kho_sach_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel2);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(235, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(838, 581);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý Nhân Viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_ds_nhan_vien);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(33, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(775, 273);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // dgv_ds_nhan_vien
            // 
            dgv_ds_nhan_vien.AllowUserToAddRows = false;
            dgv_ds_nhan_vien.AllowUserToDeleteRows = false;
            dgv_ds_nhan_vien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ds_nhan_vien.Location = new Point(0, 37);
            dgv_ds_nhan_vien.Name = "dgv_ds_nhan_vien";
            dgv_ds_nhan_vien.ReadOnly = true;
            dgv_ds_nhan_vien.RowHeadersWidth = 51;
            dgv_ds_nhan_vien.Size = new Size(775, 236);
            dgv_ds_nhan_vien.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_xoa);
            panel2.Controls.Add(btn_sua);
            panel2.Controls.Add(btn_them);
            panel2.Controls.Add(txt_mat_khau);
            panel2.Controls.Add(cbb_vai_tro);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_ten_nguoi_dung);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(28, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 216);
            panel2.TabIndex = 0;
            // 
            // btn_xoa
            // 
            btn_xoa.Cursor = Cursors.Hand;
            btn_xoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoa.ForeColor = Color.Black;
            btn_xoa.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            btn_xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoa.Location = new Point(669, 158);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Padding = new Padding(10, 5, 5, 5);
            btn_xoa.Size = new Size(100, 41);
            btn_xoa.TabIndex = 11;
            btn_xoa.Text = "Xóa";
            btn_xoa.TextAlign = ContentAlignment.MiddleRight;
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Cursor = Cursors.Hand;
            btn_sua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua.ForeColor = Color.Black;
            btn_sua.Image = Properties.Resources.z5560539359740_9337aa11269aeccd6e939ece18cfa20e;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(669, 99);
            btn_sua.Name = "btn_sua";
            btn_sua.Padding = new Padding(10, 5, 5, 5);
            btn_sua.Size = new Size(100, 41);
            btn_sua.TabIndex = 10;
            btn_sua.Text = "Sửa";
            btn_sua.TextAlign = ContentAlignment.MiddleRight;
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Cursor = Cursors.Hand;
            btn_them.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_them.ForeColor = Color.Black;
            btn_them.Image = Properties.Resources.z5560539359591_8726bde7817e7680733c216c1b763b9d;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(669, 44);
            btn_them.Name = "btn_them";
            btn_them.Padding = new Padding(10, 5, 5, 5);
            btn_them.Size = new Size(100, 41);
            btn_them.TabIndex = 9;
            btn_them.Text = "Thêm ";
            btn_them.TextAlign = ContentAlignment.MiddleRight;
            btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_mat_khau
            // 
            txt_mat_khau.BackColor = SystemColors.Control;
            txt_mat_khau.Location = new Point(26, 104);
            txt_mat_khau.Multiline = true;
            txt_mat_khau.Name = "txt_mat_khau";
            txt_mat_khau.Size = new Size(606, 34);
            txt_mat_khau.TabIndex = 8;
            // 
            // cbb_vai_tro
            // 
            cbb_vai_tro.BackColor = SystemColors.Control;
            cbb_vai_tro.FormattingEnabled = true;
            cbb_vai_tro.Location = new Point(26, 180);
            cbb_vai_tro.Name = "cbb_vai_tro";
            cbb_vai_tro.Size = new Size(606, 45);
            cbb_vai_tro.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 144);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 6;
            label3.Text = "Vai Trò";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 4;
            label2.Text = "Mật Khẩu";
            // 
            // txt_ten_nguoi_dung
            // 
            txt_ten_nguoi_dung.BackColor = SystemColors.Control;
            txt_ten_nguoi_dung.Location = new Point(26, 33);
            txt_ten_nguoi_dung.Multiline = true;
            txt_ten_nguoi_dung.Name = "txt_ten_nguoi_dung";
            txt_ten_nguoi_dung.Size = new Size(606, 34);
            txt_ten_nguoi_dung.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 2;
            label1.Text = "Tên Người Dùng";
            // 
            // QL_Nhan_Vien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.xanhtim2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1074, 582);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "QL_Nhan_Vien";
            Text = "QL_Nhan_Vien";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ds_nhan_vien).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_nhan_vien;
        private Panel panel1;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private Button btn_kho_sach;
        private Button btn_dang_xuat;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label2;
        private TextBox txt_ten_nguoi_dung;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txt_mat_khau;
        private ComboBox cbb_vai_tro;
        private Label label3;
        private DataGridView dgv_ds_nhan_vien;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
    }
}