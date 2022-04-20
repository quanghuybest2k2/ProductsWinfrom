
namespace GiaiPhuongTrinhBac2
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
            this.lb_a = new System.Windows.Forms.Label();
            this.lb_b = new System.Windows.Forms.Label();
            this.lb_c = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lb_giaiPT = new System.Windows.Forms.Label();
            this.lb_kq_nghiem = new System.Windows.Forms.Label();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_a
            // 
            this.lb_a.AutoSize = true;
            this.lb_a.Location = new System.Drawing.Point(109, 86);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(47, 15);
            this.lb_a.TabIndex = 0;
            this.lb_a.Text = "Nhập A";
            this.lb_a.Click += new System.EventHandler(this.lb_a_Click);
            // 
            // lb_b
            // 
            this.lb_b.AutoSize = true;
            this.lb_b.Location = new System.Drawing.Point(109, 131);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(46, 15);
            this.lb_b.TabIndex = 1;
            this.lb_b.Text = "Nhập B";
            this.lb_b.Click += new System.EventHandler(this.lb_b_Click);
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Location = new System.Drawing.Point(109, 182);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(47, 15);
            this.lb_c.TabIndex = 2;
            this.lb_c.Text = "Nhập C";
            this.lb_c.Click += new System.EventHandler(this.lb_c_Click);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(191, 83);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(150, 23);
            this.txt_a.TabIndex = 3;
            this.txt_a.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(191, 179);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(150, 23);
            this.txt_c.TabIndex = 5;
            this.txt_c.TextChanged += new System.EventHandler(this.txt_c_TextChanged);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(191, 128);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(150, 23);
            this.txt_b.TabIndex = 4;
            // 
            // lb_giaiPT
            // 
            this.lb_giaiPT.BackColor = System.Drawing.SystemColors.Info;
            this.lb_giaiPT.CausesValidation = false;
            this.lb_giaiPT.Location = new System.Drawing.Point(507, 73);
            this.lb_giaiPT.Name = "lb_giaiPT";
            this.lb_giaiPT.Size = new System.Drawing.Size(87, 40);
            this.lb_giaiPT.TabIndex = 6;
            this.lb_giaiPT.Text = "Kết quả";
            this.lb_giaiPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_giaiPT.UseMnemonic = false;
            this.lb_giaiPT.Click += new System.EventHandler(this.lb_giaiPT_Click);
            // 
            // lb_kq_nghiem
            // 
            this.lb_kq_nghiem.AutoSize = true;
            this.lb_kq_nghiem.Location = new System.Drawing.Point(475, 116);
            this.lb_kq_nghiem.Name = "lb_kq_nghiem";
            this.lb_kq_nghiem.Size = new System.Drawing.Size(145, 15);
            this.lb_kq_nghiem.TabIndex = 7;
            this.lb_kq_nghiem.Text = "Nghiệm của phương trình";
            this.lb_kq_nghiem.Click += new System.EventHandler(this.lb_kq_nghiem_Click);
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_ketqua.Location = new System.Drawing.Point(475, 156);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(213, 92);
            this.lb_ketqua.TabIndex = 8;
            this.lb_ketqua.Click += new System.EventHandler(this.lb_ketqua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_ketqua);
            this.Controls.Add(this.lb_kq_nghiem);
            this.Controls.Add(this.lb_giaiPT);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.lb_c);
            this.Controls.Add(this.lb_b);
            this.Controls.Add(this.lb_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_a;
        private System.Windows.Forms.Label lb_b;
        private System.Windows.Forms.Label lb_c;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label lb_giaiPT;
        private System.Windows.Forms.Label lb_kq_nghiem;
        private System.Windows.Forms.Label lb_ketqua;
    }
}

