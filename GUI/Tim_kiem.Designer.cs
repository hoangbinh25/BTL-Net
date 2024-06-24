namespace GUI
{
    partial class Tim_kiem
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
            label1 = new Label();
            dgv_ds_nhan_vien = new DataGridView();
            txt_ten_nguoi_dung = new TextBox();
            groupBox2 = new GroupBox();
            btn_dang_xuat = new Button();
            btn_muon_tra = new Button();
            btn_doc_gia = new Button();
            btn_kho_sach = new Button();
            panel1 = new Panel();
            btn_nhan_vien = new Button();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            btn_tim_kiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ds_nhan_vien).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 2;
            label1.Text = "Cụm Từ Tìm Kiếm";
            // 
            // dgv_ds_nhan_vien
            // 
            dgv_ds_nhan_vien.AllowUserToAddRows = false;
            dgv_ds_nhan_vien.AllowUserToDeleteRows = false;
            dgv_ds_nhan_vien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ds_nhan_vien.Location = new Point(0, 33);
            dgv_ds_nhan_vien.Name = "dgv_ds_nhan_vien";
            dgv_ds_nhan_vien.ReadOnly = true;
            dgv_ds_nhan_vien.RowHeadersWidth = 51;
            dgv_ds_nhan_vien.Size = new Size(775, 358);
            dgv_ds_nhan_vien.TabIndex = 0;
            // 
            // txt_ten_nguoi_dung
            // 
            txt_ten_nguoi_dung.BackColor = SystemColors.Control;
            txt_ten_nguoi_dung.Font = new Font("Segoe UI", 12F);
            txt_ten_nguoi_dung.Location = new Point(26, 33);
            txt_ten_nguoi_dung.Multiline = true;
            txt_ten_nguoi_dung.Name = "txt_ten_nguoi_dung";
            txt_ten_nguoi_dung.Size = new Size(592, 34);
            txt_ten_nguoi_dung.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_ds_nhan_vien);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(33, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(775, 389);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
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
            panel1.Size = new Size(227, 581);
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
            groupBox1.Size = new Size(838, 581);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Nhanh";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_tim_kiem);
            panel2.Controls.Add(txt_ten_nguoi_dung);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(28, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 100);
            panel2.TabIndex = 0;
            // 
            // btn_tim_kiem
            // 
            btn_tim_kiem.Cursor = Cursors.Hand;
            btn_tim_kiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tim_kiem.ForeColor = Color.Black;
            btn_tim_kiem.Image = Properties.Resources.favicon_16x16;
            btn_tim_kiem.ImageAlign = ContentAlignment.MiddleLeft;
            btn_tim_kiem.Location = new Point(636, 28);
            btn_tim_kiem.Name = "btn_tim_kiem";
            btn_tim_kiem.Padding = new Padding(10, 5, 5, 5);
            btn_tim_kiem.Size = new Size(126, 41);
            btn_tim_kiem.TabIndex = 30;
            btn_tim_kiem.Text = "Tìm Kiếm";
            btn_tim_kiem.TextAlign = ContentAlignment.MiddleRight;
            btn_tim_kiem.UseVisualStyleBackColor = true;
            // 
            // Tim_kiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.xanhtim2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1074, 582);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Tim_kiem";
            Text = "Tim_kiem";
            ((System.ComponentModel.ISupportInitialize)dgv_ds_nhan_vien).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DataGridView dgv_ds_nhan_vien;
        private TextBox txt_ten_nguoi_dung;
        private GroupBox groupBox2;
        private Button btn_dang_xuat;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private Button btn_kho_sach;
        private Panel panel1;
        private Button btn_nhan_vien;
        private GroupBox groupBox1;
        private Panel panel2;
        private Button btn_tim_kiem;
    }
}