
namespace SpeechVietnamese
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
            this.btnspeak = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.cbbChonGiong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnspeak
            // 
            this.btnspeak.Location = new System.Drawing.Point(99, 71);
            this.btnspeak.Name = "btnspeak";
            this.btnspeak.Size = new System.Drawing.Size(75, 23);
            this.btnspeak.TabIndex = 0;
            this.btnspeak.Text = "speak";
            this.btnspeak.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(260, 71);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(391, 71);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 0;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            // 
            // cbbChonGiong
            // 
            this.cbbChonGiong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChonGiong.FormattingEnabled = true;
            this.cbbChonGiong.Location = new System.Drawing.Point(601, 72);
            this.cbbChonGiong.Name = "cbbChonGiong";
            this.cbbChonGiong.Size = new System.Drawing.Size(121, 21);
            this.cbbChonGiong.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbChonGiong);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnspeak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnspeak;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.ComboBox cbbChonGiong;
    }
}

