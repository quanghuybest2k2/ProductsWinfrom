
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.poisonStyleManager1 = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            this.lblTittle = new ReaLTaiizor.Controls.LabelEdit();
            this.rtxtVN = new System.Windows.Forms.RichTextBox();
            this.rtxtEN = new System.Windows.Forms.RichTextBox();
            this.btnDichVanBan = new System.Windows.Forms.Button();
            this.lblEN = new System.Windows.Forms.Label();
            this.lblVN = new System.Windows.Forms.Label();
            this.ptpHinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptpHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonStyleManager1
            // 
            this.poisonStyleManager1.Owner = null;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblTittle.Location = new System.Drawing.Point(278, 21);
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
            this.rtxtEN.Text = "Kết quả dịch";
            // 
            // btnDichVanBan
            // 
            this.btnDichVanBan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDichVanBan.Location = new System.Drawing.Point(331, 200);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptpHinh);
            this.Controls.Add(this.lblVN);
            this.Controls.Add(this.lblEN);
            this.Controls.Add(this.btnDichVanBan);
            this.Controls.Add(this.rtxtEN);
            this.Controls.Add(this.rtxtVN);
            this.Controls.Add(this.lblTittle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Translate";
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptpHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager1;
        private ReaLTaiizor.Controls.LabelEdit lblTittle;
        private System.Windows.Forms.RichTextBox rtxtVN;
        private System.Windows.Forms.RichTextBox rtxtEN;
        private System.Windows.Forms.Button btnDichVanBan;
        private System.Windows.Forms.Label lblEN;
        private System.Windows.Forms.Label lblVN;
        private System.Windows.Forms.PictureBox ptpHinh;
    }
}

