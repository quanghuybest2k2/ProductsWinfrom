
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
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
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(79, 48);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(124, 58);
            this.btnSpeak.TabIndex = 1;
            this.btnSpeak.Text = "Nói";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(290, 48);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(124, 58);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Ngưng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(522, 48);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(124, 58);
            this.btnTiepTuc.TabIndex = 1;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển văn bản thành giọng nói";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnTiepTuc;
    }
}

