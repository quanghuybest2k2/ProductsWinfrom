using System;
using System.Windows.Forms;

namespace DocSoThanhChu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] Tens = { "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };

            int no = int.Parse(textBox1.Text);
            string strWords = "";

            if (no > 999 && no < 10000)
            {
                int i = no / 1000;
                strWords = strWords + Ones[i - 1] + " Ngàn ";
                no = no % 1000;
            }


            if (no > 99 && no < 1000)
            {
                int i = no / 100;
                strWords = strWords + Ones[i - 1] + " Trăm ";
                no = no % 100;
            }

            if (no > 19 && no < 100)
            {
                int i = no / 10;
                strWords = strWords + Tens[i - 1] + " ";
                no = no % 10;
            }

            if (no > 0 && no < 20)
            {
                strWords = strWords + Ones[no - 1];
            }

            label2.Text = strWords;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/quanghuybest2k2/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
