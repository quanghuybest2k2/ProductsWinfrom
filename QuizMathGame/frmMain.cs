using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMathGame
{
    public partial class frmMain : Form
    {
        int var1;
        int var2;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            var1 = rand.Next(0, 1000);
            var2 = rand.Next(0, 1000);
            nrudNum1.Value = var1;
            nrudNum2.Value = var2;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputUser.Text))
            {
                MessageBox.Show("Nhập thông tin vào bạn ơi!");
            }
            else
            {
                txtInputUser.Focus();
                int result = var1 * var2;
                lblInfo.Visible = true;
                if (txtInputUser.Text != result.ToString())
                {
                    lblInfo.Text = $"Sai rồi\nKết quả đúng là: {result}";
                }
                else
                {
                    lblInfo.Text = "Chính xác!";
                }
            }
        }
    }
}
