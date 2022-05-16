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
        // nut nói
        private void btnSpeak_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && cbbGioiTinh.Text == "Nam")
            {
                speech.SelectVoiceByHints(VoiceGender.Male); // giong nam
                speech.SpeakAsync(richTextBox1.Text);
            }
            else if (richTextBox1.Text != "" && cbbGioiTinh.Text == "Nữ")
            {
                speech.SelectVoiceByHints(VoiceGender.Female); //giong nu
                speech.SpeakAsync(richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Bạn phải điền thông tin vào!!!", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Speaking)
                speech.Pause();
        }

        private void btnTiepTuc_Click_1(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Paused)
                speech.Resume();
        }
    }
}
