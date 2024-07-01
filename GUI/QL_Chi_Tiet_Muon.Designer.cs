namespace GUI
{
    partial class QL_chi_tiet_muon
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
            dgv_ds_cuon_sach = new DataGridView();
            panel2 = new Panel();
            btn_tro_lai = new Button();
            btn_bo_qua_chi_tiet_phieu_muon = new Button();
            txt_so_luong = new TextBox();
            label1 = new Label();
            cbb_cuon_sach = new ComboBox();
            btn_xoa_chi_tiet_phieu_muon = new Button();
            btn_sua_chi_tiet_phieu_muon = new Button();
            btn_them_chi_tiet_phieu_muon = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ds_cuon_sach).BeginInit();
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
            btn_kho_sach.Location = new Point(14, 67);
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
            groupBox1.Text = "Quản Lý Chi Tiết Mượn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_ds_cuon_sach);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(33, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(775, 273);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // dgv_ds_cuon_sach
            // 
            dgv_ds_cuon_sach.AllowUserToAddRows = false;
            dgv_ds_cuon_sach.AllowUserToDeleteRows = false;
            dgv_ds_cuon_sach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ds_cuon_sach.Location = new Point(0, 37);
            dgv_ds_cuon_sach.Name = "dgv_ds_cuon_sach";
            dgv_ds_cuon_sach.ReadOnly = true;
            dgv_ds_cuon_sach.RowHeadersWidth = 51;
            dgv_ds_cuon_sach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ds_cuon_sach.Size = new Size(775, 236);
            dgv_ds_cuon_sach.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_tro_lai);
            panel2.Controls.Add(btn_bo_qua_chi_tiet_phieu_muon);
            panel2.Controls.Add(txt_so_luong);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cbb_cuon_sach);
            panel2.Controls.Add(btn_xoa_chi_tiet_phieu_muon);
            panel2.Controls.Add(btn_sua_chi_tiet_phieu_muon);
            panel2.Controls.Add(btn_them_chi_tiet_phieu_muon);
            panel2.Controls.Add(label3);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(27, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 231);
            panel2.TabIndex = 0;
            // 
            // btn_tro_lai
            // 
            btn_tro_lai.Cursor = Cursors.Hand;
            btn_tro_lai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tro_lai.ForeColor = Color.Black;
            btn_tro_lai.Image = Properties.Resources.favicon_16x161;
            btn_tro_lai.ImageAlign = ContentAlignment.MiddleLeft;
            btn_tro_lai.Location = new Point(515, 175);
            btn_tro_lai.Name = "btn_tro_lai";
            btn_tro_lai.Padding = new Padding(10, 5, 5, 5);
            btn_tro_lai.Size = new Size(105, 41);
            btn_tro_lai.TabIndex = 63;
            btn_tro_lai.Text = "Trở Lại";
            btn_tro_lai.TextAlign = ContentAlignment.MiddleRight;
            btn_tro_lai.UseVisualStyleBackColor = true;
            // 
            // btn_bo_qua_chi_tiet_phieu_muon
            // 
            btn_bo_qua_chi_tiet_phieu_muon.Cursor = Cursors.Hand;
            btn_bo_qua_chi_tiet_phieu_muon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_bo_qua_chi_tiet_phieu_muon.ForeColor = Color.Black;
            btn_bo_qua_chi_tiet_phieu_muon.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            btn_bo_qua_chi_tiet_phieu_muon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bo_qua_chi_tiet_phieu_muon.Location = new Point(661, 175);
            btn_bo_qua_chi_tiet_phieu_muon.Name = "btn_bo_qua_chi_tiet_phieu_muon";
            btn_bo_qua_chi_tiet_phieu_muon.Padding = new Padding(10, 5, 5, 5);
            btn_bo_qua_chi_tiet_phieu_muon.Size = new Size(101, 41);
            btn_bo_qua_chi_tiet_phieu_muon.TabIndex = 62;
            btn_bo_qua_chi_tiet_phieu_muon.Text = "Bỏ Qua";
            btn_bo_qua_chi_tiet_phieu_muon.TextAlign = ContentAlignment.MiddleRight;
            btn_bo_qua_chi_tiet_phieu_muon.UseVisualStyleBackColor = true;
            // 
            // txt_so_luong
            // 
            txt_so_luong.BackColor = SystemColors.Control;
            txt_so_luong.Font = new Font("Segoe UI", 12F);
            txt_so_luong.Location = new Point(36, 121);
            txt_so_luong.Multiline = true;
            txt_so_luong.Name = "txt_so_luong";
            txt_so_luong.Size = new Size(726, 33);
            txt_so_luong.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 58;
            label1.Text = "Số Lượng";
            // 
            // cbb_cuon_sach
            // 
            cbb_cuon_sach.BackColor = SystemColors.Control;
            cbb_cuon_sach.Font = new Font("Segoe UI", 12F);
            cbb_cuon_sach.FormattingEnabled = true;
            cbb_cuon_sach.Location = new Point(36, 46);
            cbb_cuon_sach.Name = "cbb_cuon_sach";
            cbb_cuon_sach.Size = new Size(724, 36);
            cbb_cuon_sach.TabIndex = 57;
            // 
            // btn_xoa_chi_tiet_phieu_muon
            // 
            btn_xoa_chi_tiet_phieu_muon.Cursor = Cursors.Hand;
            btn_xoa_chi_tiet_phieu_muon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoa_chi_tiet_phieu_muon.ForeColor = Color.Black;
            btn_xoa_chi_tiet_phieu_muon.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            btn_xoa_chi_tiet_phieu_muon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoa_chi_tiet_phieu_muon.Location = new Point(333, 175);
            btn_xoa_chi_tiet_phieu_muon.Name = "btn_xoa_chi_tiet_phieu_muon";
            btn_xoa_chi_tiet_phieu_muon.Padding = new Padding(10, 5, 5, 5);
            btn_xoa_chi_tiet_phieu_muon.Size = new Size(101, 41);
            btn_xoa_chi_tiet_phieu_muon.TabIndex = 56;
            btn_xoa_chi_tiet_phieu_muon.Text = "Xóa";
            btn_xoa_chi_tiet_phieu_muon.TextAlign = ContentAlignment.MiddleRight;
            btn_xoa_chi_tiet_phieu_muon.UseVisualStyleBackColor = true;
            // 
            // btn_sua_chi_tiet_phieu_muon
            // 
            btn_sua_chi_tiet_phieu_muon.Cursor = Cursors.Hand;
            btn_sua_chi_tiet_phieu_muon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua_chi_tiet_phieu_muon.ForeColor = Color.Black;
            btn_sua_chi_tiet_phieu_muon.Image = Properties.Resources.z5560539359740_9337aa11269aeccd6e939ece18cfa20e;
            btn_sua_chi_tiet_phieu_muon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua_chi_tiet_phieu_muon.Location = new Point(183, 175);
            btn_sua_chi_tiet_phieu_muon.Name = "btn_sua_chi_tiet_phieu_muon";
            btn_sua_chi_tiet_phieu_muon.Padding = new Padding(10, 5, 5, 5);
            btn_sua_chi_tiet_phieu_muon.Size = new Size(101, 41);
            btn_sua_chi_tiet_phieu_muon.TabIndex = 55;
            btn_sua_chi_tiet_phieu_muon.Text = "Sửa";
            btn_sua_chi_tiet_phieu_muon.TextAlign = ContentAlignment.MiddleRight;
            btn_sua_chi_tiet_phieu_muon.UseVisualStyleBackColor = true;
            // 
            // btn_them_chi_tiet_phieu_muon
            // 
            btn_them_chi_tiet_phieu_muon.Cursor = Cursors.Hand;
            btn_them_chi_tiet_phieu_muon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_them_chi_tiet_phieu_muon.ForeColor = Color.Black;
            btn_them_chi_tiet_phieu_muon.Image = Properties.Resources.z5560539359591_8726bde7817e7680733c216c1b763b9d;
            btn_them_chi_tiet_phieu_muon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them_chi_tiet_phieu_muon.Location = new Point(34, 175);
            btn_them_chi_tiet_phieu_muon.Name = "btn_them_chi_tiet_phieu_muon";
            btn_them_chi_tiet_phieu_muon.Padding = new Padding(10, 5, 5, 5);
            btn_them_chi_tiet_phieu_muon.Size = new Size(101, 41);
            btn_them_chi_tiet_phieu_muon.TabIndex = 54;
            btn_them_chi_tiet_phieu_muon.Text = "Thêm ";
            btn_them_chi_tiet_phieu_muon.TextAlign = ContentAlignment.MiddleRight;
            btn_them_chi_tiet_phieu_muon.UseVisualStyleBackColor = true;
            btn_them_chi_tiet_phieu_muon.Click += btn_them_chi_tiet_phieu_muon_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 14);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 53;
            label3.Text = "Cuốn Sách";
            // 
            // QL_chi_tiet_muon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.xanhtim2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1074, 581);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "QL_chi_tiet_muon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QL_Chi_tiet_muon";
            Load += QL_chi_tiet_muon_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ds_cuon_sach).EndInit();
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
        private GroupBox groupBox2;
        private DataGridView dgv_ds_cuon_sach;
        private ComboBox cbb_cuon_sach;
        private Button btn_xoa_chi_tiet_phieu_muon;
        private Button btn_sua_chi_tiet_phieu_muon;
        private Button btn_them_chi_tiet_phieu_muon;
        private Label label3;
        private TextBox txt_so_luong;
        private Label label1;
        private Button btn_tro_lai;
        private Button btn_bo_qua_chi_tiet_phieu_muon;
    }
}