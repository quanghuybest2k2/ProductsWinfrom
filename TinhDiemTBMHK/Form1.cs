using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhDiemTBMHK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_tong_hk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tinhtoan_Click(object sender, EventArgs e)
        {
            float diem_mieng = float.Parse(txt_mieng.Text) * 1;
            float diem_15p_1 = float.Parse(txt_15p.Text) * 1;
            float diem_15p_2 = float.Parse(txt_15p_2.Text) * 1;
            float diem_15p_3 = float.Parse(txt_15p_3.Text) * 1;
            float diem_ktra1_tiet_1 = float.Parse(txt_1tiet.Text) * 2;
            float diem_ktra1_tiet_2 = float.Parse(txt_1tiet_2.Text) * 2;
            float diem_ktra1_tiet_3 = float.Parse(txt_1tiet_3.Text) * 2;
            float diem_thi = float.Parse(txt_hk.Text) * 3;

            float tong = (diem_mieng + diem_15p_1 + diem_15p_2 + diem_15p_3 + diem_ktra1_tiet_1 + diem_ktra1_tiet_2 + diem_ktra1_tiet_3 + diem_thi) / 13;

            //float diem_tong_TBM = float.Parse(txt_tong_hk.Text);
            txt_tong_hk.Text = tong.ToString();
        }
    }
}
