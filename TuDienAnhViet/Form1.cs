using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace TuDienAnhViet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_TraTu_Click(object sender, EventArgs e)
        {
            //Khi cần hiện từ thì hiện thẳng chương trình
            FormMainApp formMain = new FormMainApp();
            formMain.Show();
            this.Hide();
        }

        private void btn_QL_Click(object sender, EventArgs e)
        {
            // khi cần thêm từ thì hiện form đăng nhập để quản lý từ
            groupBox1.Show();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            // xử lý đăng nhập
            // nếu đúng username và password thì mở form
            try
            {
                // Khai báo 2 biến chuỗi sẽ chứa giá trị được nhập từ textbox
                string user = txtUser.Text.Trim();//Xóa khoảng trắng đầu và cuối
                string pass = txtPass.Text.Trim();
                // tạo một bảng trắng chứa table mình sẽ get về (nếu có)
                // cấu trúc SQLHelper (chuỗi kết nối, tên Proceduce, biến truyền vào nếu có)
                DataTable dt = SqlHelper.ExecuteDataset(SQLstring.strcnn, "Login_Select", user, pass).Tables[0];
                // xử lý khi người dùng nhập đúng
                if(dt.Rows.Count > 0) // nếu Row lớn hơn 0 nếu trùng user và pass.
                {
                    FormQuanLyTu form = new FormQuanLyTu();
                    form.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
