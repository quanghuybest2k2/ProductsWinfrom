﻿using System;
using System.IO;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Media;

namespace Assistant
{
    public partial class frmForm : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speech = new SpeechSynthesizer();
        SoundPlayer music = new SoundPlayer();
        public frmForm()
        {
            InitializeComponent();
            Choices choices = new Choices();
            string[] text = File.ReadAllLines(Environment.CurrentDirectory + "//grammer.txt");
            choices.Add(text);
            Grammar grammer = new Grammar(new GrammarBuilder(choices));
            recEngine.LoadGrammar(grammer);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            recEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recEngine_SpeechRecognized);

            speech.SelectVoiceByHints(VoiceGender.Female);

        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string result = e.Result.Text;
            //if (result == "Hello")
            //{
            //    result = "Hello, Can I help you?";
            //}
            string open = "Ok, I open ";
            switch (result)
            {
                case "Hello":
                    {
                        result = "Hello, Can I help you?";
                        break;
                    }
                case "What time is it":
                    {
                        result = "It's currently " + DateTime.Now.ToLongTimeString();
                        break;
                    }
                case "Open Google Chrome":
                    {
                        System.Diagnostics.Process.Start("https://www.google.com/");
                        result = open + "Google Chrome";
                        break;
                    }
                case "Close Google Chrome":
                    {
                        System.Diagnostics.Process[] close = System.Diagnostics.Process.GetProcessesByName("chrome");
                        foreach (System.Diagnostics.Process p in close)
                        {
                            p.Kill();
                        }
                        result = "Closing Google Chrome";
                        break;
                    }
                case "Open Visual Studio Code":
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\quang\AppData\Local\Programs\Microsoft VS Code\Code.exe");
                        result = open + "Visual Studio Code";
                        break;
                    }
                case "Close Visual Studio Code":
                    {
                        System.Diagnostics.Process[] close = System.Diagnostics.Process.GetProcessesByName("Code");
                        foreach (System.Diagnostics.Process p in close)
                        {
                            p.Kill();
                        }
                        result = "Closing Visual Studio Code";
                        break;
                    }
                case "Today I'm sad":
                    {
                        result = "When you’re sad, try not to get upset with yourself. There's a reason you feel the way you do. “We lost — and I really wanted us to win. Now we can’t go to playoffs.” It’s natural to feel sad when something doesn’t work out as you hoped. “I guess other kids feel sad when they lose a big game. My teammates probably feel sad too.” Be kind and patient with yourself. Your sadness will pass, and you'll feel better.";
                        break;
                    }
                case "There’s No One At All":
                    {
                        music.SoundLocation = "There’s No One At All.wav";//file wav
                        result = "There’s No One At All by Sơn Tùng MTP";//There’s No One At All by Sơn Tùng MTP
                        music.Play();
                        
                        break;
                    }
                case "Stop":
                    {
                        speech.SpeakAsyncCancelAll();
                        music.Stop();
                        result = "";//There’s No One At All by Sơn Tùng MTP
                        break;
                    }
                case "Goodbye":
                    {
                        Application.Exit();
                        break;
                    }
            }
            speech.SpeakAsync(result);
            //lblKetQua.Text = result;
            rtbKetQua.Text = result;
        }
    }
}
