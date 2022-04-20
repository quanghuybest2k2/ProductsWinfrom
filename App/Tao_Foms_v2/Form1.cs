using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tao_Foms_v2
{
    public partial class btnCancel : Form
    {
        public btnCancel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string tk = "quanghuybest";
        string mk = "123456";
        private void button1_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();

        }

        private void KiemTraDangNhap()
        {
            // lấy dữ liệu người dùng nhập vào
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus(); // Đưa con trỏ chuột về lại tài khoản
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus(); // Đưa con trỏ chuột về lại mật khẩu
            }
            else
            {
                NguoiDung nd = new NguoiDung(txtTaiKhoan.Text, txtMatKhau.Text);

                if (nd.KiemTraDangNhap(tk, mk) == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Focus();
                    txtMatKhau.SelectAll();
                }
            }
        }
        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                KiemTraDangNhap();

            }
        }
        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                KiemTraDangNhap();

            }
        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);

            if (Result == DialogResult.No)
            {
                return;
            }
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
                //this.Close();
                return;
            }
        }
    }
}