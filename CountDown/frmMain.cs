using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class frmMain : Form
    {
        private int toTalSecond;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                this.cbbPhut.Items.Add(i.ToString());
                this.cbbGiay.Items.Add(i.ToString());
            }
            this.cbbPhut.SelectedIndex = 30;
            this.cbbGiay.SelectedIndex = 59;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;

            int m = int.Parse(this.cbbPhut.SelectedItem.ToString());
            int s = int.Parse(this.cbbGiay.SelectedItem.ToString());

            toTalSecond = (m * 60) + s;
            this.timerCountDown.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            if (toTalSecond>0)
            {
                toTalSecond--;
                int m = toTalSecond / 60;
                int s = toTalSecond - (m * 60);
                this.label3.Text = m.ToString() + ":" + s.ToString();
            }
            else
            {
                this.timerCountDown.Stop();
                MessageBox.Show("Hết giờ làm rồi!");
            }
        }
    }
}
