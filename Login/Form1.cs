using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace Login
{
    public partial class form_dangnhap : Form
    {
        public bool IsLogin { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public form_dangnhap()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            IsLogin = false;
        }
        //------------set color for background gradient-----------------
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196,232,250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string StrUserName = txt_taikhoan.Text.Trim();
            string StrPassWord = txt_matkhau.Text.Trim();
            string strErr = string.Empty;
            if (StrUserName == string.Empty)
                strErr = "Bạn vui lòng nhập tên đăng nhập!!!";
            if (StrPassWord == string.Empty)
                strErr += "\n Bạn chưa nhập mật khẩu!!!";
            if(strErr != string.Empty)
            {
                MessageBox.Show("Error: " + strErr);
                return;
            }
            try
            {
                string strCon = @"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";
                SqlParameter[] arrParam = new SqlParameter[2];
                arrParam[0] = new SqlParameter("@username", StrUserName);
                arrParam[1] = new SqlParameter("@pass", StrPassWord);
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "UserSystem_CheckLogin", arrParam);
                if (reader.Read() == true)
                {
                    //MessageBox.Show("Thanh cong!!!");
                    //this.Hide();
                    //form_dangnhap formLogin = new form_dangnhap();
                    //formLogin.ShowDialog();
                    IsLogin = true;
                    //lay thong tin dang nhap
                    FullName = reader["fullname"].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tai khoan hoac mat khau!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
