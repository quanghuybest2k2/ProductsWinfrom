using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongCuaHaiSo
{
    public partial class Form1 : Form
    {
        int SoDauTien, SoThuHai, sum, hieu, tich, thuong;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoDauTien = Convert.ToInt32(txt_SoDauTien.Text);
            SoThuHai = Convert.ToInt32(txt_SoThuHai.Text);
            sum = SoDauTien + SoThuHai;
            MessageBox.Show($"Tổng của hai số là: {sum}");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_tich_Click(object sender, EventArgs e)
        {
            SoDauTien = Convert.ToInt32(txt_SoDauTien.Text);
            SoThuHai = Convert.ToInt32(txt_SoThuHai.Text);
            tich = SoDauTien * SoThuHai;
            MessageBox.Show($"Tích của hai số là: {tich}");
        }

        private void btn_thuong_Click(object sender, EventArgs e)
        {
            SoDauTien = Convert.ToInt32(txt_SoDauTien.Text);
            SoThuHai = Convert.ToInt32(txt_SoThuHai.Text);
            thuong = SoDauTien / SoThuHai;
            MessageBox.Show($"Thương của hai số là: {thuong}");
        }

        private void lb_SoDauTien_Click(object sender, EventArgs e)
        {

        }

        private void lb_ChuongTrinh_Click(object sender, EventArgs e)
        {

        }

        private void btn_hieu_Click(object sender, EventArgs e)
        {
            SoDauTien = Convert.ToInt32(txt_SoDauTien.Text);
            SoThuHai = Convert.ToInt32(txt_SoThuHai.Text);
            hieu = SoDauTien - SoThuHai;
            MessageBox.Show($"Hiệu của hai số là: {hieu}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_SoThuHai_Click(object sender, EventArgs e)
        {

        }
    }
}
