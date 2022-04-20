using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPhuongTrinhBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x;
        double x1, x2, delta;
        double d;
        private void lb_c_Click(object sender, EventArgs e)
        {

        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_a_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_b_Click(object sender, EventArgs e)
        {

        }

        private void lb_giaiPT_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(txt_a.Text);
            double b = Convert.ToInt32(txt_b.Text);
            double c = Convert.ToInt32(txt_c.Text);

            if (a == 0)
            {
                lb_ketqua.Text = "Phuong trinh vo nghiem";
            }
            else
            {
                delta = (b * b - 4 * a * c);
                d = System.Math.Sqrt(delta);
                if (d == 0)
                {
                    x = -c / a;
                    lb_ketqua.Text = "Phuong trinh co 1 nghiem -c/a: " + x;
                }
                else if (d > 0)
                {
                    x1 = (-b + d) / (2 * a);
                    x2 = (-b - d) / (2 * a);
                    lb_ketqua.Text = $"Phuong trinh co 2 nghiem x1 = {x1} va x2 = {x2}";
                }
                else
                {
                    lb_ketqua.Text = "Phuong trinh co vo so nghiem!";
                }
            }
        }

        private void lb_kq_nghiem_Click(object sender, EventArgs e)
        {

        }

        private void lb_ketqua_Click(object sender, EventArgs e)
        {

        }
    }
}
