using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace GoogleTranslate
{
    public partial class Form1 : Form
    {
    SpeechSynthesizer speech;
        public Form1()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }

        public string TranslateText(string input)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "vi", "en", Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }
        // Chọn ngôn ngữ
        private void btnDichVanBan_Click(object sender, EventArgs e)
        {
          rtxtEN.Text = TranslateText(rtxtVN.Text);
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (rtxtVN.Text != "" && cbbGioiTinh.SelectedIndex == 0)
            {
                speech.SelectVoiceByHints(VoiceGender.Male); // giong nam
                speech.SpeakAsync(rtxtEN.Text);
            }
            else if (rtxtVN.Text != "" && cbbGioiTinh.SelectedIndex == 1)
            {
                speech.SelectVoiceByHints(VoiceGender.Female); //giong nu
                speech.SpeakAsync(rtxtEN.Text);
            }
            else if (rtxtVN.Text == "")
            {
                MessageBox.Show("Bạn phải nhập thông tin bên ô tiếng Việt!!! Sau đó nhấn dịch văn bản", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtxtEN.Text == "")
            {
                MessageBox.Show("Không có chữ Tiếng Anh nên không thể đọc!!!", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn giọng đọc!!!", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbGioiTinh.SelectedIndex = 0;
        }
    }
}
