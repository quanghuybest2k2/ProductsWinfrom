using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TextToSpeechConvert
{
    public partial class frmMain : Form
    {
        SpeechSynthesizer speech;
        public frmMain()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }
        // nut noi
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
                speech.SpeakAsync(richTextBox1.Text);
            else
                MessageBox.Show("Bạn phải điền thông tin vào!!!");
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Speaking)
                speech.Pause();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Paused)
                speech.Resume();
        }
    }
}
