using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WatingForm
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {           
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            for (int i = 1; i <= 100; i++)
            {
                SplashScreenManager.Default.SetWaitFormDescription(i.ToString() + "%");
                Thread.Sleep(25);
            }
            SplashScreenManager.CloseForm(false);
         
        }

    }
}
