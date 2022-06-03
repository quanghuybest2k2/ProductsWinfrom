using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Web.Script.Serialization;
using System.Windows.Forms;

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
            string url = "";
            if (cbbChonNgonNgu.SelectedIndex==0)
            {
                url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "vi", "en", Uri.EscapeUriString(input));
            }
            if (cbbChonNgonNgu.SelectedIndex == 1)
            {
                url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "en", "vi", Uri.EscapeUriString(input));

            }
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
            if (rtxtVN.Text != "")
            {
                rtxtEN.Text = TranslateText(rtxtVN.Text);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập chữ bên ô " + lblVN.Text + " nên không thể dịch", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (rtxtVN.Text != "" && cbbGiongDoc.SelectedIndex == 0)
            {
                speech.SelectVoiceByHints(VoiceGender.Male); // giong nam
                speech.SpeakAsync(rtxtEN.Text);
            }
            else if (rtxtVN.Text != "" && cbbGiongDoc.SelectedIndex == 1)
            {
                speech.SelectVoiceByHints(VoiceGender.Female); //giong nu
                speech.SpeakAsync(rtxtEN.Text);
            }
            else if (rtxtVN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chữ bên ô " + lblVN.Text + " nên không thể đọc", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtxtEN.Text == "")
            {
                MessageBox.Show("Không có chữ bên ô " + rtxtEN.Text + " nên không thể đọc", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbGiongDoc.SelectedIndex = 0;//set default value
            cbbChonNgonNgu.SelectedIndex = 0;
            rtxtEN.Enabled = false; // không cho nhập
            tsslSoKyTuNhap.Text = "Số ký tự nhập: " + rtxtVN.Text.Length.ToString();// mặc định text ban đầu
        }

        private void cbbChonNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonNgonNgu.SelectedIndex == 1)
            {
                lblVN.Text = "English";
                lblEN.Text = "Vietnamese";
            }
            else
            {
                lblEN.Text = "English";
                lblVN.Text = "Vietnamese";
            }
        }

        private void rtxtVN_TextChanged(object sender, EventArgs e)
        {
            tsslSoKyTuNhap.Text = "Số ký tự nhập: " + rtxtVN.Text.Length.ToString();
        }
    }
}
