﻿namespace GUI
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
            btn_ngon_ngu = new Button();
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
<<<<<<< HEAD
            btn_tim_kiem.Location = new Point(786, 165);
=======
            btn_tim_kiem.Location = new Point(678, 224);
            btn_tim_kiem.Margin = new Padding(3, 2, 3, 2);
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            btn_tim_kiem.Name = "btn_tim_kiem";
            btn_tim_kiem.Padding = new Padding(9, 4, 4, 4);
            btn_tim_kiem.Size = new Size(110, 31);
            btn_tim_kiem.TabIndex = 29;
            btn_tim_kiem.Text = "Tìm Kiếm";
            btn_tim_kiem.TextAlign = ContentAlignment.MiddleRight;
            btn_tim_kiem.UseVisualStyleBackColor = true;
            btn_tim_kiem.Click += btn_tim_kiem_Click;
            // 
            // dgv_ds_muon_tra
            // 
<<<<<<< HEAD
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
=======
            txt_han_the.BackColor = SystemColors.Control;
            txt_han_the.Font = new Font("Segoe UI", 12F);
            txt_han_the.Location = new Point(493, 133);
            txt_han_the.Margin = new Padding(3, 2, 3, 2);
            txt_han_the.Multiline = true;
            txt_han_the.Name = "txt_han_the";
            txt_han_the.Size = new Size(414, 26);
            txt_han_the.TabIndex = 28;
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // 
            // panel2
            // 
<<<<<<< HEAD
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
=======
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(472, 110);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 27;
            label1.Text = "Hạn Thẻ";
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // 
            // label7
            // 
<<<<<<< HEAD
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(780, 141);
            label7.Name = "label7";
            label7.Size = new Size(132, 17);
            label7.TabIndex = 41;
            label7.Text = "Tìm Kiếm Phiếu Mượn\r\n";
=======
            txt_nam_sinh.BackColor = SystemColors.Control;
            txt_nam_sinh.Font = new Font("Segoe UI", 12F);
            txt_nam_sinh.Location = new Point(23, 133);
            txt_nam_sinh.Margin = new Padding(3, 2, 3, 2);
            txt_nam_sinh.Multiline = true;
            txt_nam_sinh.Name = "txt_nam_sinh";
            txt_nam_sinh.Size = new Size(414, 26);
            txt_nam_sinh.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 110);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 25;
            label3.Text = "Năm Sinh";
            // 
            // txt_dia_chi
            // 
            txt_dia_chi.BackColor = SystemColors.Control;
            txt_dia_chi.Font = new Font("Segoe UI", 12F);
            txt_dia_chi.Location = new Point(23, 184);
            txt_dia_chi.Margin = new Padding(3, 2, 3, 2);
            txt_dia_chi.Multiline = true;
            txt_dia_chi.Name = "txt_dia_chi";
            txt_dia_chi.Size = new Size(883, 26);
            txt_dia_chi.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 160);
            label8.Name = "label8";
            label8.Size = new Size(60, 21);
            label8.TabIndex = 23;
            label8.Text = "Địa Chỉ";
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // 
            // txt_ngay_tra
            // 
            txt_ngay_tra.BackColor = SystemColors.Control;
            txt_ngay_tra.Font = new Font("Segoe UI", 12F);
            txt_ngay_tra.Location = new Point(493, 78);
            txt_ngay_tra.Margin = new Padding(3, 2, 3, 2);
            txt_ngay_tra.Multiline = true;
            txt_ngay_tra.Name = "txt_ngay_tra";
            txt_ngay_tra.Size = new Size(414, 26);
            txt_ngay_tra.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(472, 55);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 17;
            label4.Text = "Ngày Trả";
            // 
<<<<<<< HEAD
=======
            // dgv_ds_muon_tra
            // 
            dgv_ds_muon_tra.AllowUserToAddRows = false;
            dgv_ds_muon_tra.AllowUserToDeleteRows = false;
            dgv_ds_muon_tra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ds_muon_tra.Location = new Point(0, 25);
            dgv_ds_muon_tra.Margin = new Padding(3, 2, 3, 2);
            dgv_ds_muon_tra.Name = "dgv_ds_muon_tra";
            dgv_ds_muon_tra.ReadOnly = true;
            dgv_ds_muon_tra.RowHeadersWidth = 51;
            dgv_ds_muon_tra.Size = new Size(944, 252);
            dgv_ds_muon_tra.TabIndex = 0;
            // 
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // txt_ngay_muon
            // 
            txt_ngay_muon.BackColor = SystemColors.Control;
            txt_ngay_muon.Font = new Font("Segoe UI", 12F);
            txt_ngay_muon.Location = new Point(493, 25);
            txt_ngay_muon.Margin = new Padding(3, 2, 3, 2);
            txt_ngay_muon.Multiline = true;
            txt_ngay_muon.Name = "txt_ngay_muon";
            txt_ngay_muon.Size = new Size(414, 26);
            txt_ngay_muon.TabIndex = 16;
            // 
<<<<<<< HEAD
=======
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_tim_kiem);
            panel2.Controls.Add(txt_han_the);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_nam_sinh);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_dia_chi);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_ngay_tra);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_ngay_muon);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(btn_xoa);
            panel2.Controls.Add(btn_sua);
            panel2.Controls.Add(btn_them);
            panel2.Controls.Add(txt_ma_the_muon);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_ma_doc_gia);
            panel2.Controls.Add(label2222);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(24, 30);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 264);
            panel2.TabIndex = 0;
            // 
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(472, 1);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 15;
            label5.Text = "Ngày Mượn ";
            // 
            // btn_bo_qua_phieu_muon
            // 
<<<<<<< HEAD
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
=======
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(818, 224);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Padding = new Padding(9, 4, 4, 4);
            button6.Size = new Size(88, 31);
            button6.TabIndex = 12;
            button6.Text = "Bỏ Qua";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // 
            // btn_xoa_phieu_muon
            // 
<<<<<<< HEAD
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
=======
            btn_xoa.Cursor = Cursors.Hand;
            btn_xoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoa.ForeColor = Color.Black;
            btn_xoa.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            btn_xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoa.Location = new Point(284, 224);
            btn_xoa.Margin = new Padding(3, 2, 3, 2);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Padding = new Padding(9, 4, 4, 4);
            btn_xoa.Size = new Size(88, 31);
            btn_xoa.TabIndex = 11;
            btn_xoa.Text = "Xóa";
            btn_xoa.TextAlign = ContentAlignment.MiddleRight;
            btn_xoa.UseVisualStyleBackColor = true;
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // 
            // btn_sua_phieu_muon
            // 
<<<<<<< HEAD
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
=======
            btn_sua.Cursor = Cursors.Hand;
            btn_sua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua.ForeColor = Color.Black;
            btn_sua.Image = Properties.Resources.z5560539359740_9337aa11269aeccd6e939ece18cfa20e;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(153, 224);
            btn_sua.Margin = new Padding(3, 2, 3, 2);
            btn_sua.Name = "btn_sua";
            btn_sua.Padding = new Padding(9, 4, 4, 4);
            btn_sua.Size = new Size(88, 31);
            btn_sua.TabIndex = 10;
            btn_sua.Text = "Sửa";
            btn_sua.TextAlign = ContentAlignment.MiddleRight;
            btn_sua.UseVisualStyleBackColor = true;
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // 
            // btn_them_phieu_muon
            // 
<<<<<<< HEAD
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
=======
            btn_them.Cursor = Cursors.Hand;
            btn_them.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_them.ForeColor = Color.Black;
            btn_them.Image = Properties.Resources.z5560539359591_8726bde7817e7680733c216c1b763b9d;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(23, 224);
            btn_them.Margin = new Padding(3, 2, 3, 2);
            btn_them.Name = "btn_them";
            btn_them.Padding = new Padding(9, 4, 4, 4);
            btn_them.Size = new Size(88, 31);
            btn_them.TabIndex = 9;
            btn_them.Text = "Thêm ";
            btn_them.TextAlign = ContentAlignment.MiddleRight;
            btn_them.UseVisualStyleBackColor = true;
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // 
            // txt_ma_doc_gia
            // 
<<<<<<< HEAD
            txt_ma_doc_gia.BackColor = SystemColors.Control;
            txt_ma_doc_gia.Font = new Font("Segoe UI", 12F);
            txt_ma_doc_gia.Location = new Point(26, 104);
            txt_ma_doc_gia.Multiline = true;
            txt_ma_doc_gia.Name = "txt_ma_doc_gia";
            txt_ma_doc_gia.Size = new Size(473, 33);
            txt_ma_doc_gia.TabIndex = 8;
=======
            txt_ma_the_muon.BackColor = SystemColors.Control;
            txt_ma_the_muon.Font = new Font("Segoe UI", 12F);
            txt_ma_the_muon.Location = new Point(23, 78);
            txt_ma_the_muon.Margin = new Padding(3, 2, 3, 2);
            txt_ma_the_muon.Multiline = true;
            txt_ma_the_muon.Name = "txt_ma_the_muon";
            txt_ma_the_muon.Size = new Size(414, 26);
            txt_ma_the_muon.TabIndex = 8;
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
<<<<<<< HEAD
            label2.Location = new Point(3, 1);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
=======
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            label2.TabIndex = 4;
            label2.Text = "Mã Phiếu Mượn";
            // 
            // txt_ma_phieu_muon
            // 
<<<<<<< HEAD
            txt_ma_phieu_muon.BackColor = SystemColors.Control;
            txt_ma_phieu_muon.Font = new Font("Segoe UI", 12F);
            txt_ma_phieu_muon.Location = new Point(26, 33);
            txt_ma_phieu_muon.Multiline = true;
            txt_ma_phieu_muon.Name = "txt_ma_phieu_muon";
            txt_ma_phieu_muon.Size = new Size(473, 33);
            txt_ma_phieu_muon.TabIndex = 3;
=======
            txt_ma_doc_gia.BackColor = SystemColors.Control;
            txt_ma_doc_gia.Font = new Font("Segoe UI", 12F);
            txt_ma_doc_gia.Location = new Point(23, 25);
            txt_ma_doc_gia.Margin = new Padding(3, 2, 3, 2);
            txt_ma_doc_gia.Multiline = true;
            txt_ma_doc_gia.Name = "txt_ma_doc_gia";
            txt_ma_doc_gia.Size = new Size(414, 26);
            txt_ma_doc_gia.TabIndex = 3;
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            // 
            // label2222
            // 
            label2222.AutoSize = true;
            label2222.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2222.ForeColor = Color.White;
            label2222.Location = new Point(3, 71);
            label2222.Name = "label2222";
            label2222.Size = new Size(90, 21);
            label2222.TabIndex = 2;
            label2222.Text = "Mã Độc Giả";
            // 
            // btn_dang_xuat
            // 
            btn_dang_xuat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            btn_dang_xuat.Location = new Point(14, 541);
=======
            btn_dang_xuat.Location = new Point(12, 553);
            btn_dang_xuat.Margin = new Padding(3, 2, 3, 2);
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            btn_dang_xuat.Name = "btn_dang_xuat";
            btn_dang_xuat.Size = new Size(166, 25);
            btn_dang_xuat.TabIndex = 4;
            btn_dang_xuat.Text = "Đăng Xuất";
            btn_dang_xuat.UseVisualStyleBackColor = true;
            // 
            // btn_muon_tra
            // 
            btn_muon_tra.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_muon_tra.Location = new Point(12, 130);
            btn_muon_tra.Margin = new Padding(3, 2, 3, 2);
            btn_muon_tra.Name = "btn_muon_tra";
            btn_muon_tra.Size = new Size(166, 25);
            btn_muon_tra.TabIndex = 3;
            btn_muon_tra.Text = "Mượn Trả";
            btn_muon_tra.UseVisualStyleBackColor = true;
            btn_muon_tra.Click += btn_muon_tra_Click;
            // 
            // btn_doc_gia
            // 
            btn_doc_gia.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_doc_gia.Location = new Point(12, 89);
            btn_doc_gia.Margin = new Padding(3, 2, 3, 2);
            btn_doc_gia.Name = "btn_doc_gia";
            btn_doc_gia.Size = new Size(166, 25);
            btn_doc_gia.TabIndex = 2;
            btn_doc_gia.Text = "Độc Giả";
            btn_doc_gia.UseVisualStyleBackColor = true;
            btn_doc_gia.Click += btn_doc_gia_Click_1;
            // 
            // btn_kho_sach
            // 
            btn_kho_sach.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_kho_sach.Location = new Point(12, 50);
            btn_kho_sach.Margin = new Padding(3, 2, 3, 2);
            btn_kho_sach.Name = "btn_kho_sach";
            btn_kho_sach.Size = new Size(166, 25);
            btn_kho_sach.TabIndex = 1;
            btn_kho_sach.Text = "Kho Sách";
            btn_kho_sach.UseVisualStyleBackColor = true;
            btn_kho_sach.Click += btn_kho_sach_Click_1;
            // 
            // btn_nhan_vien
            // 
            btn_nhan_vien.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nhan_vien.Location = new Point(12, 11);
            btn_nhan_vien.Margin = new Padding(3, 2, 3, 2);
            btn_nhan_vien.Name = "btn_nhan_vien";
            btn_nhan_vien.Size = new Size(166, 25);
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
            panel1.Controls.Add(btn_ngon_ngu);
            panel1.Controls.Add(btn_dang_xuat);
            panel1.Controls.Add(btn_muon_tra);
            panel1.Controls.Add(btn_doc_gia);
            panel1.Controls.Add(btn_kho_sach);
            panel1.Controls.Add(btn_nhan_vien);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
<<<<<<< HEAD
            panel1.Size = new Size(227, 641);
=======
            panel1.Size = new Size(199, 595);
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            panel1.TabIndex = 10;
            // 
            // btn_ngon_ngu
            // 
            btn_ngon_ngu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ngon_ngu.Location = new Point(12, 171);
            btn_ngon_ngu.Margin = new Padding(3, 2, 3, 2);
            btn_ngon_ngu.Name = "btn_ngon_ngu";
            btn_ngon_ngu.Size = new Size(166, 30);
            btn_ngon_ngu.TabIndex = 6;
            btn_ngon_ngu.Text = "Ngôn ngữ";
            btn_ngon_ngu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_ds_muon_tra);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(31, 272);
=======
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(24, 309);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(944, 270);
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
            groupBox1.Location = new Point(204, -2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
<<<<<<< HEAD
            groupBox1.Size = new Size(1141, 643);
=======
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(998, 594);
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.xanhtim2;
            BackgroundImageLayout = ImageLayout.Stretch;
<<<<<<< HEAD
            ClientSize = new Size(1374, 648);
=======
            ClientSize = new Size(1202, 591);
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
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
<<<<<<< HEAD
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
=======
        private Button btn_ngon_ngu;
>>>>>>> 6cc4869ffdc33e3f67bc11fcb421dc57a8132ef4
    }
}