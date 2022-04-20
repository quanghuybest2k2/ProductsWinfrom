
namespace TinhDiemTBMHK
{
    partial class Form1
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
            this.diem_mieng = new System.Windows.Forms.Label();
            this.diem_15p = new System.Windows.Forms.Label();
            this.diem_ktr1tiet = new System.Windows.Forms.Label();
            this.diem_thi = new System.Windows.Forms.Label();
            this.tong_hk = new System.Windows.Forms.Label();
            this.txt_mieng = new System.Windows.Forms.TextBox();
            this.txt_15p = new System.Windows.Forms.TextBox();
            this.txt_1tiet = new System.Windows.Forms.TextBox();
            this.txt_hk = new System.Windows.Forms.TextBox();
            this.txt_tong_hk = new System.Windows.Forms.TextBox();
            this.btn_tinhtoan = new System.Windows.Forms.Button();
            this.txt_15p_2 = new System.Windows.Forms.TextBox();
            this.txt_15p_3 = new System.Windows.Forms.TextBox();
            this.txt_1tiet_2 = new System.Windows.Forms.TextBox();
            this.txt_1tiet_3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // diem_mieng
            // 
            this.diem_mieng.AutoSize = true;
            this.diem_mieng.Location = new System.Drawing.Point(37, 27);
            this.diem_mieng.Name = "diem_mieng";
            this.diem_mieng.Size = new System.Drawing.Size(62, 13);
            this.diem_mieng.TabIndex = 0;
            this.diem_mieng.Text = "Điểm miệng";
            // 
            // diem_15p
            // 
            this.diem_15p.AutoSize = true;
            this.diem_15p.Location = new System.Drawing.Point(152, 27);
            this.diem_15p.Name = "diem_15p";
            this.diem_15p.Size = new System.Drawing.Size(70, 13);
            this.diem_15p.TabIndex = 1;
            this.diem_15p.Text = "Điểm 15 phút";
            // 
            // diem_ktr1tiet
            // 
            this.diem_ktr1tiet.AutoSize = true;
            this.diem_ktr1tiet.Location = new System.Drawing.Point(277, 27);
            this.diem_ktr1tiet.Name = "diem_ktr1tiet";
            this.diem_ktr1tiet.Size = new System.Drawing.Size(71, 13);
            this.diem_ktr1tiet.TabIndex = 2;
            this.diem_ktr1tiet.Text = "Kiểm tra 1 tiết";
            // 
            // diem_thi
            // 
            this.diem_thi.AutoSize = true;
            this.diem_thi.Location = new System.Drawing.Point(383, 27);
            this.diem_thi.Name = "diem_thi";
            this.diem_thi.Size = new System.Drawing.Size(57, 13);
            this.diem_thi.TabIndex = 3;
            this.diem_thi.Text = "Thi học kỳ";
            // 
            // tong_hk
            // 
            this.tong_hk.AutoSize = true;
            this.tong_hk.Location = new System.Drawing.Point(471, 27);
            this.tong_hk.Name = "tong_hk";
            this.tong_hk.Size = new System.Drawing.Size(106, 13);
            this.tong_hk.TabIndex = 4;
            this.tong_hk.Text = "Điểm TB môn học kỳ";
            // 
            // txt_mieng
            // 
            this.txt_mieng.Location = new System.Drawing.Point(40, 52);
            this.txt_mieng.Name = "txt_mieng";
            this.txt_mieng.Size = new System.Drawing.Size(59, 20);
            this.txt_mieng.TabIndex = 1;
            // 
            // txt_15p
            // 
            this.txt_15p.Location = new System.Drawing.Point(155, 52);
            this.txt_15p.Name = "txt_15p";
            this.txt_15p.Size = new System.Drawing.Size(59, 20);
            this.txt_15p.TabIndex = 2;
            // 
            // txt_1tiet
            // 
            this.txt_1tiet.Location = new System.Drawing.Point(280, 52);
            this.txt_1tiet.Name = "txt_1tiet";
            this.txt_1tiet.Size = new System.Drawing.Size(59, 20);
            this.txt_1tiet.TabIndex = 5;
            // 
            // txt_hk
            // 
            this.txt_hk.Location = new System.Drawing.Point(386, 52);
            this.txt_hk.Name = "txt_hk";
            this.txt_hk.Size = new System.Drawing.Size(59, 20);
            this.txt_hk.TabIndex = 8;
            // 
            // txt_tong_hk
            // 
            this.txt_tong_hk.Location = new System.Drawing.Point(498, 52);
            this.txt_tong_hk.Name = "txt_tong_hk";
            this.txt_tong_hk.Size = new System.Drawing.Size(59, 20);
            this.txt_tong_hk.TabIndex = 9;
            this.txt_tong_hk.TextChanged += new System.EventHandler(this.txt_tong_hk_TextChanged);
            // 
            // btn_tinhtoan
            // 
            this.btn_tinhtoan.Location = new System.Drawing.Point(280, 244);
            this.btn_tinhtoan.Name = "btn_tinhtoan";
            this.btn_tinhtoan.Size = new System.Drawing.Size(75, 23);
            this.btn_tinhtoan.TabIndex = 10;
            this.btn_tinhtoan.Text = "Tính điểm";
            this.btn_tinhtoan.UseVisualStyleBackColor = true;
            this.btn_tinhtoan.Click += new System.EventHandler(this.btn_tinhtoan_Click);
            // 
            // txt_15p_2
            // 
            this.txt_15p_2.Location = new System.Drawing.Point(155, 101);
            this.txt_15p_2.Name = "txt_15p_2";
            this.txt_15p_2.Size = new System.Drawing.Size(59, 20);
            this.txt_15p_2.TabIndex = 3;
            // 
            // txt_15p_3
            // 
            this.txt_15p_3.Location = new System.Drawing.Point(155, 146);
            this.txt_15p_3.Name = "txt_15p_3";
            this.txt_15p_3.Size = new System.Drawing.Size(59, 20);
            this.txt_15p_3.TabIndex = 4;
            // 
            // txt_1tiet_2
            // 
            this.txt_1tiet_2.Location = new System.Drawing.Point(280, 101);
            this.txt_1tiet_2.Name = "txt_1tiet_2";
            this.txt_1tiet_2.Size = new System.Drawing.Size(59, 20);
            this.txt_1tiet_2.TabIndex = 6;
            // 
            // txt_1tiet_3
            // 
            this.txt_1tiet_3.Location = new System.Drawing.Point(280, 146);
            this.txt_1tiet_3.Name = "txt_1tiet_3";
            this.txt_1tiet_3.Size = new System.Drawing.Size(59, 20);
            this.txt_1tiet_3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_1tiet_3);
            this.Controls.Add(this.txt_1tiet_2);
            this.Controls.Add(this.txt_15p_3);
            this.Controls.Add(this.txt_15p_2);
            this.Controls.Add(this.btn_tinhtoan);
            this.Controls.Add(this.txt_tong_hk);
            this.Controls.Add(this.txt_hk);
            this.Controls.Add(this.txt_1tiet);
            this.Controls.Add(this.txt_15p);
            this.Controls.Add(this.txt_mieng);
            this.Controls.Add(this.tong_hk);
            this.Controls.Add(this.diem_thi);
            this.Controls.Add(this.diem_ktr1tiet);
            this.Controls.Add(this.diem_15p);
            this.Controls.Add(this.diem_mieng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diem_mieng;
        private System.Windows.Forms.Label diem_15p;
        private System.Windows.Forms.Label diem_ktr1tiet;
        private System.Windows.Forms.Label diem_thi;
        private System.Windows.Forms.Label tong_hk;
        private System.Windows.Forms.TextBox txt_mieng;
        private System.Windows.Forms.TextBox txt_15p;
        private System.Windows.Forms.TextBox txt_1tiet;
        private System.Windows.Forms.TextBox txt_hk;
        private System.Windows.Forms.TextBox txt_tong_hk;
        private System.Windows.Forms.Button btn_tinhtoan;
        private System.Windows.Forms.TextBox txt_15p_2;
        private System.Windows.Forms.TextBox txt_15p_3;
        private System.Windows.Forms.TextBox txt_1tiet_2;
        private System.Windows.Forms.TextBox txt_1tiet_3;
    }
}

