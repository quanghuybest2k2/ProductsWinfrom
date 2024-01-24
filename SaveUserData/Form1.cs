using System.Windows.Forms;

namespace SaveUserData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
            !string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                frmMain mainForm = new frmMain();
                mainForm.ShowDialog();
                this.Hide();
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            // Lưu username và password vào settings
            Properties.Settings.Default.Username = txtUsername.Text;
            Properties.Settings.Default.Password = txtPass.Text;
            Properties.Settings.Default.Save();
            if (!string.IsNullOrEmpty(txtUsername.Text.Trim()) && !string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                // Hiển thị frmMain
                frmMain mainForm = new frmMain();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được trống!");
            }
        }
    }
}
