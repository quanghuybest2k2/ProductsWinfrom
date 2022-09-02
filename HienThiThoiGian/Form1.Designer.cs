
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblGio = new System.Windows.Forms.Label();
            this.lb_ThoiGian = new System.Windows.Forms.Label();
            this.notifyThongBao = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxmNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPhut = new System.Windows.Forms.Label();
            this.timerNhacNho = new System.Windows.Forms.Timer(this.components);
            this.timerThoiGian = new System.Windows.Forms.Timer(this.components);
            this.ctxmNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGio
            // 
            this.lblGio.AutoSize = true;
            this.lblGio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGio.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGio.Location = new System.Drawing.Point(60, 68);
            this.lblGio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(31, 19);
            this.lblGio.TabIndex = 0;
            this.lblGio.Text = "00";
            // 
            // lb_ThoiGian
            // 
            this.lb_ThoiGian.AutoSize = true;
            this.lb_ThoiGian.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_ThoiGian.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThoiGian.Location = new System.Drawing.Point(71, 182);
            this.lb_ThoiGian.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_ThoiGian.Name = "lb_ThoiGian";
            this.lb_ThoiGian.Size = new System.Drawing.Size(57, 19);
            this.lb_ThoiGian.TabIndex = 1;
            this.lb_ThoiGian.Text = "Hour";
            // 
            // notifyThongBao
            // 
            this.notifyThongBao.ContextMenuStrip = this.ctxmNotify;
            this.notifyThongBao.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyThongBao.Icon")));
            this.notifyThongBao.Text = "notifyThongBao";
            this.notifyThongBao.Visible = true;
            // 
            // ctxmNotify
            // 
            this.ctxmNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.ctxmNotify.Name = "ctxmNotify";
            this.ctxmNotify.Size = new System.Drawing.Size(105, 26);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thông báo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPhut
            // 
            this.lblPhut.AutoSize = true;
            this.lblPhut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhut.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhut.Location = new System.Drawing.Point(103, 68);
            this.lblPhut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhut.Name = "lblPhut";
            this.lblPhut.Size = new System.Drawing.Size(31, 19);
            this.lblPhut.TabIndex = 0;
            this.lblPhut.Text = "00";
            // 
            // timerNhacNho
            // 
            this.timerNhacNho.Interval = 1000;
            this.timerNhacNho.Tick += new System.EventHandler(this.timerNhacNho_Tick);
            // 
            // timerThoiGian
            // 
            this.timerThoiGian.Tick += new System.EventHandler(this.timerThoiGian_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_ThoiGian);
            this.Controls.Add(this.lblPhut);
            this.Controls.Add(this.lblGio);
            this.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Hệ thống ngày giờ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ctxmNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.Label lb_ThoiGian;
        private System.Windows.Forms.NotifyIcon notifyThongBao;
        private System.Windows.Forms.ContextMenuStrip ctxmNotify;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPhut;
        private System.Windows.Forms.Timer timerNhacNho;
        private System.Windows.Forms.Timer timerThoiGian;
    }
}

