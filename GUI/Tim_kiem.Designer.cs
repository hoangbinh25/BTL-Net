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
            dgv_ds_tim_kiem = new DataGridView();
            groupBox2 = new GroupBox();
            btn_dang_xuat = new Button();
            btn_muon_tra = new Button();
            btn_doc_gia = new Button();
            btn_kho_sach = new Button();
            panel1 = new Panel();
            btn_nhan_vien = new Button();
            groupBox1 = new GroupBox();
            btn_ngon_ngu = new Button();
            label1 = new Label();
            txt_tim_kiem = new TextBox();
            btn_tim_kiem = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_ds_tim_kiem).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_ds_tim_kiem
            // 
            dgv_ds_tim_kiem.AllowUserToAddRows = false;
            dgv_ds_tim_kiem.AllowUserToDeleteRows = false;
            dgv_ds_tim_kiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ds_tim_kiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ds_tim_kiem.Location = new Point(-12, 26);
            dgv_ds_tim_kiem.Margin = new Padding(3, 2, 3, 2);
            dgv_ds_tim_kiem.Name = "dgv_ds_tim_kiem";
            dgv_ds_tim_kiem.ReadOnly = true;
            dgv_ds_tim_kiem.RightToLeft = RightToLeft.No;
            dgv_ds_tim_kiem.RowHeadersWidth = 51;
            dgv_ds_tim_kiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ds_tim_kiem.Size = new Size(981, 428);
            dgv_ds_tim_kiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_ds_tim_kiem);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(29, 131);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(969, 443);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // btn_dang_xuat
            // 
            btn_dang_xuat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dang_xuat.Location = new Point(12, 558);
            btn_dang_xuat.Margin = new Padding(3, 2, 3, 2);
            btn_dang_xuat.Name = "btn_dang_xuat";
            btn_dang_xuat.Size = new Size(166, 25);
            btn_dang_xuat.TabIndex = 4;
            btn_dang_xuat.Text = "Đăng Xuất";
            btn_dang_xuat.UseVisualStyleBackColor = true;
            btn_dang_xuat.Click += btn_dang_xuat_Click;
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
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 594);
            panel1.TabIndex = 6;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel2);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(206, 1);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1016, 594);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Nhanh";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 2;
            label1.Text = "Cụm Từ Tìm Kiếm";
            // 
            // txt_tim_kiem
            // 
            txt_tim_kiem.BackColor = SystemColors.Control;
            txt_tim_kiem.Font = new Font("Segoe UI", 12F);
            txt_tim_kiem.Location = new Point(16, 34);
            txt_tim_kiem.Margin = new Padding(3, 2, 3, 2);
            txt_tim_kiem.Multiline = true;
            txt_tim_kiem.Name = "txt_tim_kiem";
            txt_tim_kiem.Size = new Size(743, 30);
            txt_tim_kiem.TabIndex = 3;
            // 
            // btn_tim_kiem
            // 
            btn_tim_kiem.Cursor = Cursors.Hand;
            btn_tim_kiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tim_kiem.ForeColor = Color.Black;
            btn_tim_kiem.Image = Properties.Resources.favicon_16x16;
            btn_tim_kiem.ImageAlign = ContentAlignment.MiddleLeft;
            btn_tim_kiem.Location = new Point(792, 34);
            btn_tim_kiem.Margin = new Padding(3, 2, 3, 2);
            btn_tim_kiem.Name = "btn_tim_kiem";
            btn_tim_kiem.Padding = new Padding(9, 4, 4, 4);
            btn_tim_kiem.Size = new Size(110, 30);
            btn_tim_kiem.TabIndex = 30;
            btn_tim_kiem.Text = "Tìm Kiếm";
            btn_tim_kiem.TextAlign = ContentAlignment.MiddleRight;
            btn_tim_kiem.UseVisualStyleBackColor = true;
            btn_tim_kiem.Click += btn_tim_kiem_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_tim_kiem);
            panel2.Controls.Add(txt_tim_kiem);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(29, 40);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(969, 87);
            panel2.TabIndex = 0;
            // 
            // Tim_kiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.xanhtim2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1216, 597);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Tim_kiem";
            Text = "Tim_kiem";
            ((System.ComponentModel.ISupportInitialize)dgv_ds_tim_kiem).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_ds_tim_kiem;
        private GroupBox groupBox2;
        private Button btn_dang_xuat;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private Button btn_kho_sach;
        private Panel panel1;
        private Button btn_nhan_vien;
        private GroupBox groupBox1;
        private Button btn_ngon_ngu;
        private Panel panel2;
        private Button btn_tim_kiem;
        private TextBox txt_tim_kiem;
        private Label label1;
    }
}