using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HienThiThoiGian
{
    public partial class Form1 : Form
    {
        //lb_thoigian.Text = DateTime.Now.ToLongTimeString();
        string _gio;
        string _phut;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerThoiGian.Start();
            timerNhacNho.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyThongBao.Dispose();
        }

        private void timerNhacNho_Tick(object sender, EventArgs e)
        {
            switch (_gio)
            {
                case "11" when (_phut == "31"):
                    notifyThongBao.ShowBalloonTip(1000, "Nhắc nhở học bài", "Bạn ơi! mới đó mà đã nản rồi ư? Sắp thành công rồi mà", ToolTipIcon.None);
                    timerNhacNho.Stop();// hiển thị 1 lần rồi dừng, tránh lặp
                    break;
                case "21" when (_phut == "00"):
                    notifyThongBao.ShowBalloonTip(1000, "Nhắc nhở đi ngủ", "Hi hi bạn nên đi ngủ đi", ToolTipIcon.None);
                    timerNhacNho.Stop();// hiển thị 1 lần rồi dừng, tránh lặp
                    break;
            }
        }

        private void timerThoiGian_Tick(object sender, EventArgs e)
        {
            lb_ThoiGian.Text = DateTime.Now.ToString("HH:mm:s");
            _gio = DateTime.Now.Hour.ToString();
            _phut = DateTime.Now.Minute.ToString();
        }
    }
}
