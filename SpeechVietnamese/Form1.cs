using System;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace SpeechVietnamese
{
    public partial class Form1 : Form
    {
        static SpeechSynthesizer SS = new SpeechSynthesizer();
        private SpeechRecognitionEngine SRE = new SpeechRecognitionEngine();
        private bool SRE_listening = false;
        private int wordid;
        private string shibie;
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initvoice();
        }
        public void initvoice() // speech recognition initialization
        {
            //SS.SelectVoice("lily");
            SRE.SetInputToDefaultAudioDevice();  //  The default voice input device can also be set to recognize a wav text

            GrammarBuilder GB = new GrammarBuilder();

            GB.Append(new Choices(new string[] { "China", "USA", "UK" }));

            DictationGrammar DG = new DictationGrammar();

            Grammar G = new Grammar(GB);

            G.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(G_SpeechRecognized);  // Register speech recognition events

            SRE.EndSilenceTimeout = TimeSpan.FromSeconds(2);

            SRE.LoadGrammar(G);

        }

        void G_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Beep(500, 500);// Recognized tone

            string result = e.Result.Text;
            switch (result)
            {
                case "China":
                    shibie = "China: five star red flag";
                    choice(0);
                    break;
                case "USA":
                    shibie = "United States: Star Spangled Banner";
                    choice(1);
                    break;
                case "UK":
                    shibie = "United Kingdom: meter flag";
                    choice(2);
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SRE_listening == false)
            {
                button1.Text = "stop";
                SRE.RecognizeAsync(RecognizeMode.Multiple);
            }
            else
            {
                button1.Text = "start";
                SRE.RecognizeAsyncStop();
            }
            lblanswer.Text = "";
            SRE_listening = !SRE_listening;
        }
        private void choice(int id)
        {
            wordid = id;

            Thread t1;
            Thread t2;

            t1 = new Thread(new ThreadStart(speekanswer));
            t1.Start();
            t1.Join();
            t2 = new Thread(new ThreadStart(speekanswer));
            t2.Start();
        }
        void showanswer() // thread
        {
            MethodInvoker mi = new MethodInvoker(this.dosomething);
            this.BeginInvoke(mi);

        }
        void dosomething()
        {
            lblanswer.Text = shibie;
        }
        void speekanswer() // thread
        {
            switch (wordid)
            {
                case 0:
                    SS.Speak("five star red flag");

                    break;
                case 1:
                    SS.Speak("Star Spangled Banner");

                    break;
                case 2:
                    SS.Speak("meter flag");

                    break;
            }
        }
    }
}
