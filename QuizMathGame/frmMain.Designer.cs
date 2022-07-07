
namespace QuizMathGame
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.nrudNum1 = new System.Windows.Forms.NumericUpDown();
            this.nrudNum2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtInputUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nrudNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrudNum2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(473, 69);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // nrudNum1
            // 
            this.nrudNum1.Location = new System.Drawing.Point(56, 69);
            this.nrudNum1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nrudNum1.Name = "nrudNum1";
            this.nrudNum1.Size = new System.Drawing.Size(88, 20);
            this.nrudNum1.TabIndex = 1;
            // 
            // nrudNum2
            // 
            this.nrudNum2.Location = new System.Drawing.Point(170, 69);
            this.nrudNum2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nrudNum2.Name = "nrudNum2";
            this.nrudNum2.Size = new System.Drawing.Size(88, 20);
            this.nrudNum2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(170, 142);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "label2";
            this.lblInfo.Visible = false;
            // 
            // txtInputUser
            // 
            this.txtInputUser.Location = new System.Drawing.Point(305, 71);
            this.txtInputUser.Name = "txtInputUser";
            this.txtInputUser.Size = new System.Drawing.Size(125, 20);
            this.txtInputUser.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInputUser);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nrudNum2);
            this.Controls.Add(this.nrudNum1);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrudNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrudNum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown nrudNum1;
        private System.Windows.Forms.NumericUpDown nrudNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtInputUser;
        private System.Windows.Forms.Label label2;
    }
}

