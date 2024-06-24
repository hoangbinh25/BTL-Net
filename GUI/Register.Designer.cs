namespace GUI
{
    partial class form_dang_ki
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            lb_dang_nhap = new Label();
            panel3 = new Panel();
            btn_dang_ki = new Button();
            txt_mat_khau = new TextBox();
            label2 = new Label();
            txt_ten_nguoi_dung = new TextBox();
            label1 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.xanhtim2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 557);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(253, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 417);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng Kí Tài Khoản";
            // 
            // lb_dang_nhap
            // 
            lb_dang_nhap.AutoSize = true;
            lb_dang_nhap.Font = new Font("Segoe UI Semilight", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_dang_nhap.ForeColor = SystemColors.Highlight;
            lb_dang_nhap.Location = new Point(416, 423);
            lb_dang_nhap.Name = "lb_dang_nhap";
            lb_dang_nhap.Size = new Size(165, 25);
            lb_dang_nhap.TabIndex = 6;
            lb_dang_nhap.Text = "Đăng Nhập Tại Đây";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lb_dang_nhap);
            panel3.Controls.Add(btn_dang_ki);
            panel3.Controls.Add(txt_mat_khau);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txt_ten_nguoi_dung);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(253, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(601, 477);
            panel3.TabIndex = 2;
            // 
            // btn_dang_ki
            // 
            btn_dang_ki.BackColor = Color.Transparent;
            btn_dang_ki.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dang_ki.ForeColor = SystemColors.Window;
            btn_dang_ki.Image = Properties.Resources.xanhtim2;
            btn_dang_ki.Location = new Point(211, 329);
            btn_dang_ki.Margin = new Padding(0);
            btn_dang_ki.Name = "btn_dang_ki";
            btn_dang_ki.Padding = new Padding(10, 5, 10, 5);
            btn_dang_ki.Size = new Size(176, 53);
            btn_dang_ki.TabIndex = 0;
            btn_dang_ki.Text = "Đăng Kí";
            btn_dang_ki.UseVisualStyleBackColor = false;
            // 
            // txt_mat_khau
            // 
            txt_mat_khau.BackColor = SystemColors.Control;
            txt_mat_khau.Location = new Point(18, 144);
            txt_mat_khau.Multiline = true;
            txt_mat_khau.Name = "txt_mat_khau";
            txt_mat_khau.Size = new Size(564, 53);
            txt_mat_khau.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(18, 109);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // txt_ten_nguoi_dung
            // 
            txt_ten_nguoi_dung.BackColor = SystemColors.Control;
            txt_ten_nguoi_dung.Location = new Point(17, 42);
            txt_ten_nguoi_dung.Multiline = true;
            txt_ten_nguoi_dung.Name = "txt_ten_nguoi_dung";
            txt_ten_nguoi_dung.Size = new Size(564, 53);
            txt_ten_nguoi_dung.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(17, 7);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Người Dùng";
            // 
            // form_dang_ki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 538);
            Controls.Add(panel3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "form_dang_ki";
            Text = "Register";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel3;
        private TextBox txt_ten_nguoi_dung;
        private Label label1;
        private TextBox txt_mat_khau;
        private Label label2;
        private Button btn_dang_ki;
        private Label lb_dang_nhap;
    }
}