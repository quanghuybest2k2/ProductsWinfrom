using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ScreenShotAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string createImageFileName()
        {
            DateTime dt = new DateTime();
            return dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image myImage = Clipboard.GetImage();
            pictureBox1.Image = myImage;
            string s = createImageFileName();
            myImage.Save("D:\\pictures\\Hinh\\" + s + ".png");
            this.Show();
        }

        private void btnGoToSrc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\pictures\\Hinh");
        }
    }
}
