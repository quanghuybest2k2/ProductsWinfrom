
namespace TongCuaHaiSo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_tong = new System.Windows.Forms.Button();
            this.lb_SoDauTien = new System.Windows.Forms.Label();
            this.lb_ChuongTrinh = new System.Windows.Forms.Label();
            this.lb_SoThuHai = new System.Windows.Forms.Label();
            this.txt_SoDauTien = new System.Windows.Forms.TextBox();
            this.txt_SoThuHai = new System.Windows.Forms.TextBox();
            this.btn_hieu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tich = new System.Windows.Forms.Button();
            this.btn_thuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tong
            // 
            this.btn_tong.Location = new System.Drawing.Point(150, 143);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(75, 23);
            this.btn_tong.TabIndex = 0;
            this.btn_tong.Text = "Tổng";
            this.btn_tong.UseVisualStyleBackColor = true;
            this.btn_tong.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_SoDauTien
            // 
            this.lb_SoDauTien.AutoSize = true;
            this.lb_SoDauTien.Location = new System.Drawing.Point(150, 68);
            this.lb_SoDauTien.Name = "lb_SoDauTien";
            this.lb_SoDauTien.Size = new System.Drawing.Size(97, 15);
            this.lb_SoDauTien.TabIndex = 1;
            this.lb_SoDauTien.Text = "Nhập số đầu tiên";
            this.lb_SoDauTien.Click += new System.EventHandler(this.lb_SoDauTien_Click);
            // 
            // lb_ChuongTrinh
            // 
            this.lb_ChuongTrinh.AutoSize = true;
            this.lb_ChuongTrinh.Location = new System.Drawing.Point(223, 22);
            this.lb_ChuongTrinh.Name = "lb_ChuongTrinh";
            this.lb_ChuongTrinh.Size = new System.Drawing.Size(129, 15);
            this.lb_ChuongTrinh.TabIndex = 2;
            this.lb_ChuongTrinh.Text = "Chương trình tính toán";
            this.lb_ChuongTrinh.Click += new System.EventHandler(this.lb_ChuongTrinh_Click);
            // 
            // lb_SoThuHai
            // 
            this.lb_SoThuHai.AutoSize = true;
            this.lb_SoThuHai.Location = new System.Drawing.Point(150, 100);
            this.lb_SoThuHai.Name = "lb_SoThuHai";
            this.lb_SoThuHai.Size = new System.Drawing.Size(91, 15);
            this.lb_SoThuHai.TabIndex = 3;
            this.lb_SoThuHai.Text = "Nhập số thứ hai";
            this.lb_SoThuHai.Click += new System.EventHandler(this.lb_SoThuHai_Click);
            // 
            // txt_SoDauTien
            // 
            this.txt_SoDauTien.Location = new System.Drawing.Point(273, 65);
            this.txt_SoDauTien.Name = "txt_SoDauTien";
            this.txt_SoDauTien.Size = new System.Drawing.Size(133, 23);
            this.txt_SoDauTien.TabIndex = 4;
            this.txt_SoDauTien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_SoThuHai
            // 
            this.txt_SoThuHai.Location = new System.Drawing.Point(273, 97);
            this.txt_SoThuHai.Name = "txt_SoThuHai";
            this.txt_SoThuHai.Size = new System.Drawing.Size(133, 23);
            this.txt_SoThuHai.TabIndex = 5;
            // 
            // btn_hieu
            // 
            this.btn_hieu.Location = new System.Drawing.Point(241, 143);
            this.btn_hieu.Name = "btn_hieu";
            this.btn_hieu.Size = new System.Drawing.Size(75, 23);
            this.btn_hieu.TabIndex = 6;
            this.btn_hieu.Text = "Hiệu";
            this.btn_hieu.UseVisualStyleBackColor = true;
            this.btn_hieu.Click += new System.EventHandler(this.btn_hieu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(241, 186);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_tich
            // 
            this.btn_tich.Location = new System.Drawing.Point(340, 143);
            this.btn_tich.Name = "btn_tich";
            this.btn_tich.Size = new System.Drawing.Size(75, 23);
            this.btn_tich.TabIndex = 8;
            this.btn_tich.Text = "Tích";
            this.btn_tich.UseVisualStyleBackColor = true;
            this.btn_tich.Click += new System.EventHandler(this.btn_tich_Click);
            // 
            // btn_thuong
            // 
            this.btn_thuong.Location = new System.Drawing.Point(442, 143);
            this.btn_thuong.Name = "btn_thuong";
            this.btn_thuong.Size = new System.Drawing.Size(75, 23);
            this.btn_thuong.TabIndex = 9;
            this.btn_thuong.Text = "Thương";
            this.btn_thuong.UseVisualStyleBackColor = true;
            this.btn_thuong.Click += new System.EventHandler(this.btn_thuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thuong);
            this.Controls.Add(this.btn_tich);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_hieu);
            this.Controls.Add(this.txt_SoThuHai);
            this.Controls.Add(this.txt_SoDauTien);
            this.Controls.Add(this.lb_SoThuHai);
            this.Controls.Add(this.lb_ChuongTrinh);
            this.Controls.Add(this.lb_SoDauTien);
            this.Controls.Add(this.btn_tong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.Label lb_SoDauTien;
        private System.Windows.Forms.Label lb_ChuongTrinh;
        private System.Windows.Forms.Label lb_SoThuHai;
        private System.Windows.Forms.TextBox txt_SoDauTien;
        private System.Windows.Forms.TextBox txt_SoThuHai;
        private System.Windows.Forms.Button btn_hieu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tich;
        private System.Windows.Forms.Button btn_thuong;
    }
}

