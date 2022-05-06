using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fTableManager frm = new fTableManager();
            this.Hide();
            frm.ShowDialog(); // ShowDialog(): Phải thực hiện, tắt đi thì Show() hiện lên
            this.Show();
        }
        //21:50
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
