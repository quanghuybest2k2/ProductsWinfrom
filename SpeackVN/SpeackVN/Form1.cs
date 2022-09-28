using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SpeackVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pbuilder = new PromptBuilder();
            var speaker2 = new SpeechSynthesizer();
            speaker2.Rate = -2;

            var culture = CultureInfo.GetCultureInfo("en-us");
            var voices = speaker2.GetInstalledVoices(culture);
            if (voices.Count > 0) //Chinese voices found
            {
                speaker2.SelectVoice(voices[0].VoiceInfo.Name); //you need to call this API
                pbuilder.AppendText("hello");
                speaker2.SpeakAsync(pbuilder);
            }
        }
    }
}
