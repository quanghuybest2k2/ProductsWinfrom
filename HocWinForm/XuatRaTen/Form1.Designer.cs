
namespace ChuongTrinhDauTien
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
            this.label_hoten = new System.Windows.Forms.Label();
            this.btn_hoten = new System.Windows.Forms.Button();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lb_tuoi = new System.Windows.Forms.Label();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Location = new System.Drawing.Point(74, 60);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(58, 15);
            this.label_hoten.TabIndex = 0;
            this.label_hoten.Text = "Họ và tên";
            this.label_hoten.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_hoten
            // 
            this.btn_hoten.Location = new System.Drawing.Point(138, 119);
            this.btn_hoten.Name = "btn_hoten";
            this.btn_hoten.Size = new System.Drawing.Size(94, 23);
            this.btn_hoten.TabIndex = 1;
            this.btn_hoten.Text = "Hiện thị";
            this.btn_hoten.UseVisualStyleBackColor = true;
            this.btn_hoten.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(138, 57);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(159, 23);
            this.txt_hoten.TabIndex = 2;
            this.txt_hoten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(270, 119);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lb_tuoi
            // 
            this.lb_tuoi.AutoSize = true;
            this.lb_tuoi.Location = new System.Drawing.Point(74, 93);
            this.lb_tuoi.Name = "lb_tuoi";
            this.lb_tuoi.Size = new System.Drawing.Size(30, 15);
            this.lb_tuoi.TabIndex = 4;
            this.lb_tuoi.Text = "Tuổi";
            this.lb_tuoi.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Location = new System.Drawing.Point(138, 90);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(159, 23);
            this.txt_tuoi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_tuoi);
            this.Controls.Add(this.lb_tuoi);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.btn_hoten);
            this.Controls.Add(this.label_hoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.Button btn_hoten;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lb_tuoi;
        private System.Windows.Forms.TextBox txt_tuoi;
    }
}

