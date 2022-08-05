using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder Restring, int Returnlength, IntPtr callback);
        
        public Form1()
        {
            InitializeComponent();
            mciSendString("open new Type waveaudio alias recsound", null, 0, IntPtr.Zero);
            button1.Click += new EventHandler(this.buttonclick);
        }

        private void buttonclick(object sender, EventArgs e)
        {
            mciSendString("record recsound", null, 0, IntPtr.Zero);
            button2.Click += new EventHandler(this.button2click);
        }

        private void button2click(object sender, EventArgs e)
        {
            mciSendString("save recsound D:\\test.wav", null, 0, IntPtr.Zero);
            mciSendString("close recsound", null, 0, IntPtr.Zero);
        }
    }
}
