
namespace HienThiThoiGian
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
            this.components = new System.ComponentModel.Container();
            this.lb_thoigian = new System.Windows.Forms.Label();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.AutoSize = true;
            this.lb_thoigian.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_thoigian.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thoigian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_thoigian.Location = new System.Drawing.Point(71, 68);
            this.lb_thoigian.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(169, 19);
            this.lb_thoigian.TabIndex = 0;
            this.lb_thoigian.Text = "Thời gian hiện tại";
            // 
            // lb_ngay
            // 
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_ngay.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngay.Location = new System.Drawing.Point(71, 182);
            this.lb_ngay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(147, 19);
            this.lb_ngay.TabIndex = 1;
            this.lb_ngay.Text = "Ngày hôm nay";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 337);
            this.Controls.Add(this.lb_ngay);
            this.Controls.Add(this.lb_thoigian);
            this.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Hệ thống ngày giờ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thoigian;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.Timer timer1;
    }
}

