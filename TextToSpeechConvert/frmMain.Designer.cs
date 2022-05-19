
namespace TextToSpeechConvert
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnSpeak = new XanderUI.XUIButton();
            this.btnPause = new XanderUI.XUIButton();
            this.btnTiepTuc = new XanderUI.XUIButton();
            this.lblGiongDoc = new System.Windows.Forms.Label();
            this.cbbGiongDoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 301);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbbGioiTinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(620, 55);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(86, 26);
            this.cbbGioiTinh.TabIndex = 2;
            this.cbbGioiTinh.Text = "Nam";
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackgroundColor = System.Drawing.Color.White;
            this.btnSpeak.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSpeak.ButtonImage")));
            this.btnSpeak.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSpeak.ButtonText = "Phát âm";
            this.btnSpeak.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSpeak.ClickTextColor = System.Drawing.Color.Navy;
            this.btnSpeak.CornerRadius = 5;
            this.btnSpeak.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSpeak.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSpeak.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSpeak.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSpeak.Location = new System.Drawing.Point(12, 40);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(131, 50);
            this.btnSpeak.TabIndex = 3;
            this.btnSpeak.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSpeak.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click_1);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPause.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPause.ButtonImage")));
            this.btnPause.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPause.ButtonText = "Tạm ngưng";
            this.btnPause.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnPause.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPause.CornerRadius = 5;
            this.btnPause.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPause.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPause.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPause.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPause.Location = new System.Drawing.Point(171, 40);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(131, 50);
            this.btnPause.TabIndex = 4;
            this.btnPause.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnPause.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click_1);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTiepTuc.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnTiepTuc.ButtonImage")));
            this.btnTiepTuc.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTiepTuc.ButtonText = "Tiếp tục";
            this.btnTiepTuc.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnTiepTuc.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTiepTuc.CornerRadius = 5;
            this.btnTiepTuc.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTiepTuc.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnTiepTuc.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTiepTuc.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTiepTuc.Location = new System.Drawing.Point(332, 40);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(131, 50);
            this.btnTiepTuc.TabIndex = 5;
            this.btnTiepTuc.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnTiepTuc.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click_1);
            // 
            // lblGiongDoc
            // 
            this.lblGiongDoc.AutoSize = true;
            this.lblGiongDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblGiongDoc.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiongDoc.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblGiongDoc.Location = new System.Drawing.Point(513, 58);
            this.lblGiongDoc.Name = "lblGiongDoc";
            this.lblGiongDoc.Size = new System.Drawing.Size(89, 23);
            this.lblGiongDoc.TabIndex = 6;
            this.lblGiongDoc.Text = "Giọng đọc";
            // 
            // cbbGiongDoc
            // 
            this.cbbGiongDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiongDoc.FormattingEnabled = true;
            this.cbbGiongDoc.Location = new System.Drawing.Point(546, 12);
            this.cbbGiongDoc.Name = "cbbGiongDoc";
            this.cbbGiongDoc.Size = new System.Drawing.Size(242, 28);
            this.cbbGiongDoc.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbGiongDoc);
            this.Controls.Add(this.lblGiongDoc);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển văn bản thành giọng nói";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private XanderUI.XUIButton btnSpeak;
        private XanderUI.XUIButton btnPause;
        private XanderUI.XUIButton btnTiepTuc;
        private System.Windows.Forms.Label lblGiongDoc;
        private System.Windows.Forms.ComboBox cbbGiongDoc;
    }
}

