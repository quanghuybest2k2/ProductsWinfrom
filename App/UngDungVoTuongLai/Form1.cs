using System;
using System.Drawing;
using System.Windows.Forms;

namespace UngDungVoTuongLai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] listHotGirl = new string[6];
        string[, ] soThich = {
        {"Bùi Như Ý", "Nụ cười tỏa nắng","Sở thích: Thổi kèn","75","63","85" },//diem manh, so thich, so do 3 vong
        {"Nguyễn Quỳnh Tiên","Nấu ăn ngon","Sở thích: Nghe nhạc","90","60","90" },
        {"Suri Phan", "Học giỏi","Sở thích: Thả thính","80","68","90" },
        {"Phan Thị Ánh Nguyệt", "Miệng móm","Sở thích: Sống ảo","70","80","70" },
        {"Nguyễn THị Mỹ Duyên", "Xinh như thiên thần","Sở thích: Đi bơi","90","56","96" },
        {"Ka-Tơ RY", "Hoa Hậu Châu Phi","Sở thích: Nhảy múa","90","60","80" },
        };

        int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 600);
            for (int i = 1; i <= 6; i++)
            {
                listHotGirl[i - 1] = "VoTuongLai/" + i + ".jpg";
            }

            loadVoTuongLai();
        }

        private void loadVoTuongLai()
        {
            Random rd = new Random();
            index = rd.Next(0, listHotGirl.Length);

            ptrVo.BackgroundImage = Image.FromFile(listHotGirl[index]);
            ptrVo.BackgroundImageLayout = ImageLayout.Stretch;

            lblthongTin.ResetText(); // reset du lieu
            lblthongTin.Text = "====>Thông tin<====";

            for (int i = 0; i < soThich.GetLength(1); i++)
            {
                lblthongTin.Text += "\n" + soThich[index, i];
            }
        }

        private void btnTimVo_Click(object sender, EventArgs e)
        {
            loadVoTuongLai();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbldiemManh_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblVong1_Click(object sender, EventArgs e)
        {

        }

        private void lblthongTin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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