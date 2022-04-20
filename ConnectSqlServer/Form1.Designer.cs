
namespace FormLogin
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
            this.btn_MoKN = new System.Windows.Forms.Button();
            this.btn_DongKN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MoKN
            // 
            this.btn_MoKN.AutoSize = true;
            this.btn_MoKN.Location = new System.Drawing.Point(102, 187);
            this.btn_MoKN.Name = "btn_MoKN";
            this.btn_MoKN.Size = new System.Drawing.Size(151, 56);
            this.btn_MoKN.TabIndex = 0;
            this.btn_MoKN.Text = "Mở kết nối";
            this.btn_MoKN.UseVisualStyleBackColor = true;
            this.btn_MoKN.Click += new System.EventHandler(this.btn_MoKN_Click);
            // 
            // btn_DongKN
            // 
            this.btn_DongKN.AutoSize = true;
            this.btn_DongKN.Location = new System.Drawing.Point(461, 187);
            this.btn_DongKN.Name = "btn_DongKN";
            this.btn_DongKN.Size = new System.Drawing.Size(155, 56);
            this.btn_DongKN.TabIndex = 1;
            this.btn_DongKN.Text = "Đóng kết nối";
            this.btn_DongKN.UseVisualStyleBackColor = true;
            this.btn_DongKN.Click += new System.EventHandler(this.btn_DongKN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DongKN);
            this.Controls.Add(this.btn_MoKN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MoKN;
        private System.Windows.Forms.Button btn_DongKN;
    }
}

