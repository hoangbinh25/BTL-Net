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
            dgv_ds_nhan_vien = new DataGridView();
            panel2 = new Panel();
            txt_ma_sach = new TextBox();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button6 = new Button();
            cbb_vai_tro = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            txt_tac_gia = new TextBox();
            label8 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ds_nhan_vien).BeginInit();
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
            btn_xoa.Location = new Point(320, 400);
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
            btn_sua.Location = new Point(170, 400);
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
            btn_them.Location = new Point(26, 400);
            btn_them.Name = "btn_them";
            btn_them.Padding = new Padding(10, 5, 5, 5);
            btn_them.Size = new Size(100, 41);
            btn_them.TabIndex = 9;
            btn_them.Text = "Thêm ";
            btn_them.TextAlign = ContentAlignment.MiddleRight;
            btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_ten_sach
            // 
            txt_ten_sach.BackColor = SystemColors.Control;
            txt_ten_sach.Location = new Point(26, 104);
            txt_ten_sach.Multiline = true;
            txt_ten_sach.Name = "txt_ten_sach";
            txt_ten_sach.Size = new Size(472, 34);
            txt_ten_sach.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 218);
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
            label2.Size = new Size(87, 28);
            label2.TabIndex = 4;
            label2.Text = "Tên Sách";
            // 
            // label2222
            // 
            label2222.AutoSize = true;
            label2222.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2222.ForeColor = Color.White;
            label2222.Location = new Point(3, 1);
            label2222.Name = "label2222";
            label2222.Size = new Size(86, 28);
            label2222.TabIndex = 2;
            label2222.Text = "Mã Sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_ds_nhan_vien);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(28, 506);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(1079, 273);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // dgv_ds_nhan_vien
            // 
            dgv_ds_nhan_vien.AllowUserToAddRows = false;
            dgv_ds_nhan_vien.AllowUserToDeleteRows = false;
            dgv_ds_nhan_vien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ds_nhan_vien.Location = new Point(0, 27);
            dgv_ds_nhan_vien.Name = "dgv_ds_nhan_vien";
            dgv_ds_nhan_vien.ReadOnly = true;
            dgv_ds_nhan_vien.RowHeadersWidth = 51;
            dgv_ds_nhan_vien.Size = new Size(1079, 236);
            dgv_ds_nhan_vien.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_tac_gia);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(btn_xoa);
            panel2.Controls.Add(btn_sua);
            panel2.Controls.Add(btn_them);
            panel2.Controls.Add(txt_ten_sach);
            panel2.Controls.Add(cbb_vai_tro);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_ma_sach);
            panel2.Controls.Add(label2222);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(28, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 460);
            panel2.TabIndex = 0;
            // 
            // txt_ma_sach
            // 
            txt_ma_sach.BackColor = SystemColors.Control;
            txt_ma_sach.Location = new Point(26, 33);
            txt_ma_sach.Multiline = true;
            txt_ma_sach.Name = "txt_ma_sach";
            txt_ma_sach.Size = new Size(472, 34);
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
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(14, 737);
            button5.Name = "button5";
            button5.Size = new Size(190, 33);
            button5.TabIndex = 4;
            button5.Text = "Đăng Xuất";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(14, 173);
            button4.Name = "button4";
            button4.Size = new Size(190, 33);
            button4.TabIndex = 3;
            button4.Text = "Mượn Trả";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(14, 119);
            button3.Name = "button3";
            button3.Size = new Size(190, 33);
            button3.TabIndex = 2;
            button3.Text = "Độc Giả";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(14, 66);
            button2.Name = "button2";
            button2.Size = new Size(190, 33);
            button2.TabIndex = 1;
            button2.Text = "Kho Sách";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.xanhtimdocmmm;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 792);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(14, 15);
            button1.Name = "button1";
            button1.Size = new Size(190, 33);
            button1.TabIndex = 0;
            button1.Text = "Nhân Viên";
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Image = Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(974, 400);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 5, 5, 5);
            button6.Size = new Size(100, 41);
            button6.TabIndex = 12;
            button6.Text = "Bỏ Qua";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            // 
            // cbb_vai_tro
            // 
            cbb_vai_tro.BackColor = SystemColors.Control;
            cbb_vai_tro.FormattingEnabled = true;
            cbb_vai_tro.Location = new Point(26, 247);
            cbb_vai_tro.Name = "cbb_vai_tro";
            cbb_vai_tro.Size = new Size(472, 45);
            cbb_vai_tro.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(563, 104);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(472, 34);
            textBox1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(540, 73);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 17;
            label4.Text = "Tên Sách";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(563, 33);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(472, 34);
            textBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(540, 1);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 15;
            label5.Text = "Mã Sách";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Location = new Point(563, 252);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(472, 34);
            textBox3.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(540, 221);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 21;
            label6.Text = "Tên Sách";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Location = new Point(563, 181);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(472, 34);
            textBox4.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(540, 149);
            label7.Name = "label7";
            label7.Size = new Size(86, 28);
            label7.TabIndex = 19;
            label7.Text = "Mã Sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 294);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 13;
            label1.Text = "Vai Trò";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 325);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(472, 45);
            comboBox1.TabIndex = 14;
            // 
            // txt_tac_gia
            // 
            txt_tac_gia.BackColor = SystemColors.Control;
            txt_tac_gia.Location = new Point(26, 181);
            txt_tac_gia.Multiline = true;
            txt_tac_gia.Name = "txt_tac_gia";
            txt_tac_gia.Size = new Size(472, 34);
            txt_tac_gia.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 150);
            label8.Name = "label8";
            label8.Size = new Size(73, 28);
            label8.TabIndex = 23;
            label8.Text = "Tác Giả";
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
            Text = "QL_Kho_Sach";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ds_nhan_vien).EndInit();
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
        private DataGridView dgv_ds_nhan_vien;
        private Panel panel2;
        private TextBox txt_ma_sach;
        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Button button1;
        private Button button6;
        private ComboBox cbb_vai_tro;
        private TextBox txt_tac_gia;
        private Label label8;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label1;
    }
}