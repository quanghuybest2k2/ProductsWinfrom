
namespace UngDungVoTuongLai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ptrVo = new System.Windows.Forms.PictureBox();
            this.btnTimVo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblthongTin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrVo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrVo
            // 
            this.ptrVo.Location = new System.Drawing.Point(12, 62);
            this.ptrVo.Name = "ptrVo";
            this.ptrVo.Size = new System.Drawing.Size(409, 435);
            this.ptrVo.TabIndex = 0;
            this.ptrVo.TabStop = false;
            // 
            // btnTimVo
            // 
            this.btnTimVo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTimVo.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnTimVo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTimVo.Location = new System.Drawing.Point(130, 514);
            this.btnTimVo.Name = "btnTimVo";
            this.btnTimVo.Size = new System.Drawing.Size(103, 33);
            this.btnTimVo.TabIndex = 1;
            this.btnTimVo.Text = "Tìm Vợ";
            this.btnTimVo.UseVisualStyleBackColor = false;
            this.btnTimVo.Click += new System.EventHandler(this.btnTimVo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // lblthongTin
            // 
            this.lblthongTin.AutoSize = true;
            this.lblthongTin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblthongTin.Location = new System.Drawing.Point(445, 126);
            this.lblthongTin.Name = "lblthongTin";
            this.lblthongTin.Size = new System.Drawing.Size(199, 22);
            this.lblthongTin.TabIndex = 2;
            this.lblthongTin.Text = "====>Thông tin<====";
            this.lblthongTin.Click += new System.EventHandler(this.lblthongTin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Crimson;
            this.label7.Font = new System.Drawing.Font("UTM Nokia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(583, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vợ tương lai của bạn là...";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Salmon;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThoat.Location = new System.Drawing.Point(504, 514);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 30);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(671, 559);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblthongTin);
            this.Controls.Add(this.btnTimVo);
            this.Controls.Add(this.ptrVo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OMG";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrVo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ptrVo;
        private System.Windows.Forms.Button btnTimVo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblthongTin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
    }
}

