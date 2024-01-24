using System.Windows.Forms;

namespace SaveUserData
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // Hiển thị thông tin username và password từ settings
            lblUsername.Text = Properties.Settings.Default.Username;
            lblPass.Text = Properties.Settings.Default.Password;
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            // Xóa thông tin username và password từ settings khi đăng xuất
            Properties.Settings.Default.Username = string.Empty;
            Properties.Settings.Default.Password = string.Empty;
            Properties.Settings.Default.Save();
            // Reset toàn bộ settings về giá trị mặc định
            Properties.Settings.Default.Reset();

            // Hiển thị Form1 khi đăng xuất
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
