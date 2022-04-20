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
        // Tạo biến cục bộ
        string strCon = @"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";
        // Tạo đối tượng kết nối
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_MoKN_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);//NULL is create new DB
                }
                // Mở kết nối
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open(); // CLOSED is Open
                    MessageBox.Show("Kết nối thành công cơ sở dữ liệu!");
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DongKN_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đã đóng kết nối!");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối cơ sở dữ liệu!");
            }
        }
    }
}
