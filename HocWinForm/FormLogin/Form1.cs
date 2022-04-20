using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SqlConnection("");
        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_taikhoan_Click(object sender, EventArgs e)
        {

        }

        private void lb_matkhau_Click(object sender, EventArgs e)
        {

        }
    }
}
