namespace GUI
{
    partial class QL_TraMuon_Sach
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
            btn_tim_kiem = new Button();
            dgv_ds_muon_tra = new DataGridView();
            panel2 = new Panel();
            label7 = new Label();
            txt_ngay_tra = new TextBox();
            label4 = new Label();
            txt_ngay_muon = new TextBox();
            label5 = new Label();
            btn_bo_qua_phieu_muon = new Button();
            btn_xoa_phieu_muon = new Button();
            btn_sua_phieu_muon = new Button();
            btn_them_phieu_muon = new Button();
            txt_ma_doc_gia = new TextBox();
            label2 = new Label();
            txt_ma_phieu_muon = new TextBox();
            label2222 = new Label();
            btn_dang_xuat = new Button();
            btn_muon_tra = new Button();
            btn_doc_gia = new Button();
            btn_kho_sach = new Button();
            btn_nhan_vien = new Button();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            btn_xem_chi_tiet_phieu_muon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ds_muon_tra).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_tim_kiem
            // 
            btn_tim_kiem.Cursor = Cursors.Hand;
            btn_tim_kiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tim_kiem.ForeColor = Color.Black;
            btn_tim_kiem.Image = Properties.Resources.favicon_16x16;
            btn_tim_kiem.ImageAlign = ContentAlignment.MiddleLeft;
            btn_tim_kiem.Location = new Point(786, 165);
            btn_tim_kiem.Name = "btn_tim_kiem";
            btn_tim_kiem.Padding = new Padding(10, 5, 5, 5);
            btn_tim_kiem.Size = new Size(126, 41);
            btn_tim_kiem.TabIndex = 29;
            btn_tim_kiem.Text = "Tìm Kiếm";
            btn_tim_kiem.TextAlign = ContentAlignment.MiddleRight;
            btn_tim_kiem.UseVisualStyleBackColor = true;
            btn_tim_kiem.Click += btn_tim_kiem_Click;
            // 
            // dgv_ds_muon_tra
            // 
            dgv_ds_muon_tra.AllowUserToAddRows = false;
            dgv_ds_muon_tra.AllowUserToDeleteRows = false;
            dgv_ds_muon_tra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ds_muon_tra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ds_muon_tra.Location = new Point(0, 33);
            dgv_ds_muon_tra.Name = "dgv_ds_muon_tra";
            dgv_ds_muon_tra.ReadOnly = true;
            dgv_ds_muon_tra.RowHeadersWidth = 51;
            dgv_ds_muon_tra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ds_muon_tra.Size = new Size(1079, 336);
            dgv_ds_muon_tra.TabIndex = 0;
            dgv_ds_muon_tra.RowEnter += dgv_ds_muon_tra_RowEnter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btn_xem_chi_tiet_phieu_muon);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btn_tim_kiem);
            panel2.Controls.Add(txt_ngay_tra);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_ngay_muon);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btn_bo_qua_phieu_muon);
            panel2.Controls.Add(btn_xoa_phieu_muon);
            panel2.Controls.Add(btn_sua_phieu_muon);
            panel2.Controls.Add(btn_them_phieu_muon);
            panel2.Controls.Add(txt_ma_doc_gia);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_ma_phieu_muon);
            panel2.Controls.Add(label2222);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(27, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 226);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(780, 141);
            label7.Name = "label7";
            label7.Size = new Size(132, 17);
            label7.TabIndex = 41;
            label7.Text = "Tìm Kiếm Phiếu Mượn\r\n";
            // 
            // txt_ngay_tra
            // 
            txt_ngay_tra.BackColor = SystemColors.Control;
            txt_ngay_tra.Font = new Font("Segoe UI", 12F);
            txt_ngay_tra.Location = new Point(563, 104);
            txt_ngay_tra.Multiline = true;
            txt_ngay_tra.Name = "txt_ngay_tra";
            txt_ngay_tra.Size = new Size(473, 33);
            txt_ngay_tra.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(539, 73);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 17;
            label4.Text = "Ngày Trả";
            // 
            // txt_ngay_muon
            // 
            txt_ngay_muon.BackColor = SystemColors.Control;
            txt_ngay_muon.Font = new Font("Segoe UI", 12F);
            txt_ngay_muon.Location = new Point(563, 33);
            txt_ngay_muon.Multiline = true;
            txt_ngay_muon.Name = "txt_ngay_muon";
            txt_ngay_muon.Size = new Size(473, 33);
            txt_ngay_muon.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(539, 1);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 15;
            label5.Text = "Ngày Mượn ";
            // 
            // btn_bo_qua_phieu_muon
            // 
            btn_bo_qua_phieu_muon.Cursor = Cursors.Hand;
            btn_bo_qua_phieu_muon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_bo_qua_phieu_muon.ForeColor = Color.Black;
            btn_bo_qua_phieu_muon.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            btn_bo_qua_phieu_muon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bo_qua_phieu_muon.Location = new Point(932, 165);
            btn_bo_qua_phieu_muon.Name = "btn_bo_qua_phieu_muon";
            btn_bo_qua_phieu_muon.Padding = new Padding(10, 5, 5, 5);
            btn_bo_qua_phieu_muon.Size = new Size(101, 41);
            btn_bo_qua_phieu_muon.TabIndex = 12;
            btn_bo_qua_phieu_muon.Text = "Bỏ Qua";
            btn_bo_qua_phieu_muon.TextAlign = ContentAlignment.MiddleRight;
            btn_bo_qua_phieu_muon.UseVisualStyleBackColor = true;
            btn_bo_qua_phieu_muon.Click += btn_bo_qua_phieu_muon_Click;
            // 
            // btn_xoa_phieu_muon
            // 
            btn_xoa_phieu_muon.Cursor = Cursors.Hand;
            btn_xoa_phieu_muon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoa_phieu_muon.ForeColor = Color.Black;
            btn_xoa_phieu_muon.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            btn_xoa_phieu_muon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoa_phieu_muon.Location = new Point(327, 165);
            btn_xoa_phieu_muon.Name = "btn_xoa_phieu_muon";
            btn_xoa_phieu_muon.Padding = new Padding(10, 5, 5, 5);
            btn_xoa_phieu_muon.Size = new Size(101, 41);
            btn_xoa_phieu_muon.TabIndex = 11;
            btn_xoa_phieu_muon.Text = "Xóa";
            btn_xoa_phieu_muon.TextAlign = ContentAlignment.MiddleRight;
            btn_xoa_phieu_muon.UseVisualStyleBackColor = true;
            btn_xoa_phieu_muon.Click += btn_xoa_phieu_muon_Click;
            // 
            // btn_sua_phieu_muon
            // 
            btn_sua_phieu_muon.Cursor = Cursors.Hand;
            btn_sua_phieu_muon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua_phieu_muon.ForeColor = Color.Black;
            btn_sua_phieu_muon.Image = Properties.Resources.z5560539359740_9337aa11269aeccd6e939ece18cfa20e;
            btn_sua_phieu_muon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua_phieu_muon.Location = new Point(177, 165);
            btn_sua_phieu_muon.Name = "btn_sua_phieu_muon";
            btn_sua_phieu_muon.Padding = new Padding(10, 5, 5, 5);
            btn_sua_phieu_muon.Size = new Size(101, 41);
            btn_sua_phieu_muon.TabIndex = 10;
            btn_sua_phieu_muon.Text = "Sửa";
            btn_sua_phieu_muon.TextAlign = ContentAlignment.MiddleRight;
            btn_sua_phieu_muon.UseVisualStyleBackColor = true;
            btn_sua_phieu_muon.Click += btn_sua_phieu_muon_Click;
            // 
            // btn_them_phieu_muon
            // 
            btn_them_phieu_muon.Cursor = Cursors.Hand;
            btn_them_phieu_muon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_them_phieu_muon.ForeColor = Color.Black;
            btn_them_phieu_muon.Image = Properties.Resources.z5560539359591_8726bde7817e7680733c216c1b763b9d;
            btn_them_phieu_muon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them_phieu_muon.Location = new Point(28, 165);
            btn_them_phieu_muon.Name = "btn_them_phieu_muon";
            btn_them_phieu_muon.Padding = new Padding(10, 5, 5, 5);
            btn_them_phieu_muon.Size = new Size(101, 41);
            btn_them_phieu_muon.TabIndex = 9;
            btn_them_phieu_muon.Text = "Thêm ";
            btn_them_phieu_muon.TextAlign = ContentAlignment.MiddleRight;
            btn_them_phieu_muon.UseVisualStyleBackColor = true;
            btn_them_phieu_muon.Click += btn_them_phieu_muon_Click;
            // 
            // txt_ma_doc_gia
            // 
            txt_ma_doc_gia.BackColor = SystemColors.Control;
            txt_ma_doc_gia.Font = new Font("Segoe UI", 12F);
            txt_ma_doc_gia.Location = new Point(26, 104);
            txt_ma_doc_gia.Multiline = true;
            txt_ma_doc_gia.Name = "txt_ma_doc_gia";
            txt_ma_doc_gia.Size = new Size(473, 33);
            txt_ma_doc_gia.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 1);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 4;
            label2.Text = "Mã Phiếu Mượn";
            // 
            // txt_ma_phieu_muon
            // 
            txt_ma_phieu_muon.BackColor = SystemColors.Control;
            txt_ma_phieu_muon.Font = new Font("Segoe UI", 12F);
            txt_ma_phieu_muon.Location = new Point(26, 33);
            txt_ma_phieu_muon.Multiline = true;
            txt_ma_phieu_muon.Name = "txt_ma_phieu_muon";
            txt_ma_phieu_muon.Size = new Size(473, 33);
            txt_ma_phieu_muon.TabIndex = 3;
            // 
            // label2222
            // 
            label2222.AutoSize = true;
            label2222.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2222.ForeColor = Color.White;
            label2222.Location = new Point(3, 71);
            label2222.Name = "label2222";
            label2222.Size = new Size(114, 28);
            label2222.TabIndex = 2;
            label2222.Text = "Mã Độc Giả";
            // 
            // btn_dang_xuat
            // 
            btn_dang_xuat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dang_xuat.Location = new Point(14, 541);
            btn_dang_xuat.Name = "btn_dang_xuat";
            btn_dang_xuat.Size = new Size(190, 33);
            btn_dang_xuat.TabIndex = 4;
            btn_dang_xuat.Text = "Đăng Xuất";
            btn_dang_xuat.UseVisualStyleBackColor = true;
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
            btn_doc_gia.Click += btn_doc_gia_Click_1;
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
            btn_kho_sach.Click += btn_kho_sach_Click_1;
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
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 641);
            panel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_ds_muon_tra);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(31, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(1079, 360);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel2);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(233, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1141, 643);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý Mượn - Trả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(551, 143);
            label6.Name = "label6";
            label6.Size = new Size(223, 17);
            label6.TabIndex = 51;
            label6.Text = "Chi Tiết Phiếu Mượn Theo Phiếu Mượn";
            // 
            // btn_xem_chi_tiet_phieu_muon
            // 
            btn_xem_chi_tiet_phieu_muon.Cursor = Cursors.Hand;
            btn_xem_chi_tiet_phieu_muon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xem_chi_tiet_phieu_muon.ForeColor = Color.Black;
            btn_xem_chi_tiet_phieu_muon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xem_chi_tiet_phieu_muon.Location = new Point(679, 165);
            btn_xem_chi_tiet_phieu_muon.Name = "btn_xem_chi_tiet_phieu_muon";
            btn_xem_chi_tiet_phieu_muon.Padding = new Padding(10, 5, 5, 5);
            btn_xem_chi_tiet_phieu_muon.Size = new Size(83, 41);
            btn_xem_chi_tiet_phieu_muon.TabIndex = 50;
            btn_xem_chi_tiet_phieu_muon.Text = "Xem";
            btn_xem_chi_tiet_phieu_muon.UseVisualStyleBackColor = true;
            btn_xem_chi_tiet_phieu_muon.Click += btn_xem_chi_tiet_phieu_muon_Click_1;
            // 
            // QL_TraMuon_Sach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.xanhtim2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1374, 648);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "QL_TraMuon_Sach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QL_TraMuon_Sach";
            Load += QL_TraMuon_Sach_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ds_muon_tra).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_tim_kiem;
        private DataGridView dgv_ds_muon_tra;
        private Panel panel2;
        private Button btn_bo_qua_phieu_muon;
        private Button btn_xoa_phieu_muon;
        private Button btn_sua_phieu_muon;
        private Button btn_them_phieu_muon;
        private Button btn_dang_xuat;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private Button btn_kho_sach;
        private Button btn_nhan_vien;
        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txt_ngay_tra;
        private Label label4;
        private TextBox txt_ngay_muon;
        private Label label5;
        private TextBox txt_ma_doc_gia;
        private Label label2;
        private TextBox txt_ma_phieu_muon;
        private Label label2222;
        private Label label7;
        private Label label6;
        private Button btn_xem_chi_tiet_phieu_muon;
    }
}