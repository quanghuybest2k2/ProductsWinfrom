
namespace GoogleTranslate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTittle = new ReaLTaiizor.Controls.LabelEdit();
            this.rtxtVN = new System.Windows.Forms.RichTextBox();
            this.rtxtEN = new System.Windows.Forms.RichTextBox();
            this.btnDichVanBan = new System.Windows.Forms.Button();
            this.lblEN = new System.Windows.Forms.Label();
            this.lblVN = new System.Windows.Forms.Label();
            this.ptpHinh = new System.Windows.Forms.PictureBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.cbbChonNgonNgu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptpHinh)).BeginInit();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblTittle.Location = new System.Drawing.Point(267, 24);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(242, 26);
            this.lblTittle.TabIndex = 10;
            this.lblTittle.Text = "Google Translate";
            // 
            // rtxtVN
            // 
            this.rtxtVN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtVN.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtxtVN.Location = new System.Drawing.Point(12, 103);
            this.rtxtVN.Name = "rtxtVN";
            this.rtxtVN.Size = new System.Drawing.Size(313, 335);
            this.rtxtVN.TabIndex = 12;
            this.rtxtVN.Text = "Nhập nội dung văn bản....";
            // 
            // rtxtEN
            // 
            this.rtxtEN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtEN.Location = new System.Drawing.Point(475, 103);
            this.rtxtEN.Name = "rtxtEN";
            this.rtxtEN.Size = new System.Drawing.Size(313, 335);
            this.rtxtEN.TabIndex = 12;
            this.rtxtEN.Text = "Kết quả hiển thị";
            // 
            // btnDichVanBan
            // 
            this.btnDichVanBan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDichVanBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVanBan.Location = new System.Drawing.Point(331, 178);
            this.btnDichVanBan.Name = "btnDichVanBan";
            this.btnDichVanBan.Size = new System.Drawing.Size(138, 54);
            this.btnDichVanBan.TabIndex = 14;
            this.btnDichVanBan.Text = "Dịch văn bản";
            this.btnDichVanBan.UseVisualStyleBackColor = false;
            this.btnDichVanBan.Click += new System.EventHandler(this.btnDichVanBan_Click);
            // 
            // lblEN
            // 
            this.lblEN.AutoSize = true;
            this.lblEN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEN.Location = new System.Drawing.Point(614, 70);
            this.lblEN.Name = "lblEN";
            this.lblEN.Size = new System.Drawing.Size(57, 20);
            this.lblEN.TabIndex = 15;
            this.lblEN.Text = "English";
            // 
            // lblVN
            // 
            this.lblVN.AutoSize = true;
            this.lblVN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVN.Location = new System.Drawing.Point(91, 70);
            this.lblVN.Name = "lblVN";
            this.lblVN.Size = new System.Drawing.Size(81, 20);
            this.lblVN.TabIndex = 15;
            this.lblVN.Text = "Vietnamese";
            // 
            // ptpHinh
            // 
            this.ptpHinh.Image = ((System.Drawing.Image)(resources.GetObject("ptpHinh.Image")));
            this.ptpHinh.InitialImage = null;
            this.ptpHinh.Location = new System.Drawing.Point(329, 298);
            this.ptpHinh.Name = "ptpHinh";
            this.ptpHinh.Size = new System.Drawing.Size(140, 140);
            this.ptpHinh.TabIndex = 16;
            this.ptpHinh.TabStop = false;
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSpeak.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpeak.Location = new System.Drawing.Point(331, 238);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(138, 54);
            this.btnSpeak.TabIndex = 17;
            this.btnSpeak.Text = "Đọc văn bản";
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Giọng Nam",
            "Giọng Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(331, 146);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(138, 26);
            this.cbbGioiTinh.TabIndex = 18;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lblTittle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(800, 67);
            this.pnTop.TabIndex = 19;
            // 
            // cbbChonNgonNgu
            // 
            this.cbbChonNgonNgu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonNgonNgu.FormattingEnabled = true;
            this.cbbChonNgonNgu.Items.AddRange(new object[] {
            "Dịch Tiếng Anh",
            "Dịch Tiếng Việt"});
            this.cbbChonNgonNgu.Location = new System.Drawing.Point(331, 104);
            this.cbbChonNgonNgu.Name = "cbbChonNgonNgu";
            this.cbbChonNgonNgu.Size = new System.Drawing.Size(138, 26);
            this.cbbChonNgonNgu.TabIndex = 20;
            this.cbbChonNgonNgu.SelectedIndexChanged += new System.EventHandler(this.cbbChonNgonNgu_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbChonNgonNgu);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.ptpHinh);
            this.Controls.Add(this.lblVN);
            this.Controls.Add(this.lblEN);
            this.Controls.Add(this.btnDichVanBan);
            this.Controls.Add(this.rtxtEN);
            this.Controls.Add(this.rtxtVN);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Translate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptpHinh)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.LabelEdit lblTittle;
        private System.Windows.Forms.RichTextBox rtxtVN;
        private System.Windows.Forms.RichTextBox rtxtEN;
        private System.Windows.Forms.Button btnDichVanBan;
        private System.Windows.Forms.Label lblEN;
        private System.Windows.Forms.Label lblVN;
        private System.Windows.Forms.PictureBox ptpHinh;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.ComboBox cbbChonNgonNgu;
    }
}

