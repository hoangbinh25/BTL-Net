﻿namespace GUI
{
    partial class form_dang_nhap
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
            txt_ten_nguoi_dung = new TextBox();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            lb_dang_ki = new Label();
            btn_dang_nhap = new Button();
            txt_mat_khau = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txt_ten_nguoi_dung
            // 
            txt_ten_nguoi_dung.BackColor = SystemColors.Control;
            txt_ten_nguoi_dung.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ten_nguoi_dung.Location = new Point(18, 77);
            txt_ten_nguoi_dung.Margin = new Padding(3, 2, 3, 2);
            txt_ten_nguoi_dung.Multiline = true;
            txt_ten_nguoi_dung.Name = "txt_ten_nguoi_dung";
            txt_ten_nguoi_dung.Size = new Size(494, 41);
            txt_ten_nguoi_dung.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(panel3);
            groupBox1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(228, 8);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(526, 398);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng Nhập";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lb_dang_ki);
            panel3.Controls.Add(btn_dang_nhap);
            panel3.Controls.Add(txt_mat_khau);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txt_ten_nguoi_dung);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 39);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(526, 358);
            panel3.TabIndex = 5;
            // 
            // lb_dang_ki
            // 
            lb_dang_ki.AutoSize = true;
            lb_dang_ki.Font = new Font("Segoe UI Semilight", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_dang_ki.ForeColor = SystemColors.Highlight;
            lb_dang_ki.Location = new Point(435, 435);
            lb_dang_ki.Name = "lb_dang_ki";
            lb_dang_ki.Size = new Size(110, 20);
            lb_dang_ki.TabIndex = 6;
            lb_dang_ki.Text = "Đăng Kí Tại Đây";
            // 
            // btn_dang_nhap
            // 
            btn_dang_nhap.BackColor = Color.Transparent;
            btn_dang_nhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dang_nhap.ForeColor = SystemColors.Window;
            btn_dang_nhap.Image = Properties.Resources.xanhtim2;
            btn_dang_nhap.Location = new Point(182, 270);
            btn_dang_nhap.Margin = new Padding(0);
            btn_dang_nhap.Name = "btn_dang_nhap";
            btn_dang_nhap.Padding = new Padding(9, 4, 9, 4);
            btn_dang_nhap.Size = new Size(154, 40);
            btn_dang_nhap.TabIndex = 0;
            btn_dang_nhap.Text = "Đăng Nhập";
            btn_dang_nhap.UseVisualStyleBackColor = false;
            btn_dang_nhap.Click += btn_dang_nhap_Click;
            // 
            // txt_mat_khau
            // 
            txt_mat_khau.BackColor = SystemColors.Control;
            txt_mat_khau.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_mat_khau.Location = new Point(18, 194);
            txt_mat_khau.Margin = new Padding(3, 2, 3, 2);
            txt_mat_khau.Multiline = true;
            txt_mat_khau.Name = "txt_mat_khau";
            txt_mat_khau.PasswordChar = '*';
            txt_mat_khau.Size = new Size(494, 41);
            txt_mat_khau.TabIndex = 2;
            txt_mat_khau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(15, 154);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên Người Dùng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.xanhtim2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 557);
            panel1.TabIndex = 3;
            // 
            // form_dang_nhap
            // 
            AcceptButton = btn_dang_nhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 415);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "form_dang_nhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_ten_nguoi_dung;
        private GroupBox groupBox1;
        private Panel panel3;
        private Label lb_dang_ki;
        private Button btn_dang_nhap;
        private TextBox txt_mat_khau;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}