
namespace Assistant
{
    partial class frmForm
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
            this.lblLiveSpeech = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLiveSpeech
            // 
            this.lblLiveSpeech.AutoSize = true;
            this.lblLiveSpeech.Location = new System.Drawing.Point(91, 62);
            this.lblLiveSpeech.Name = "lblLiveSpeech";
            this.lblLiveSpeech.Size = new System.Drawing.Size(52, 13);
            this.lblLiveSpeech.TabIndex = 0;
            this.lblLiveSpeech.Text = "Trợ Lý ảo";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(94, 108);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 13);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "Kết quả";
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblLiveSpeech);
            this.Name = "frmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trợ lý ảo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLiveSpeech;
        private System.Windows.Forms.Label lblKetQua;
    }
}

