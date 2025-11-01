using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;  
using System.Speech.Recognition; 
using System.Globalization;    

namespace texttospeech1
{
    public partial class Form1 : Form
    {

        SpeechSynthesizer synth;

        
        SpeechRecognitionEngine recognizer;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // === TTS (Text-to-Speech) Ayarları ===
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice(); // Sesi varsayılan ses cihazına yönlendir

            // Bilgisayarda yüklü olan sesleri ComboBox'a yükle
            foreach (var voice in synth.GetInstalledVoices())
            {
                // Sadece 'TR' veya 'EN' gibi temel dilleri alalım (isteğe bağlı)
                if (voice.VoiceInfo.Culture.Name.StartsWith("tr") || voice.VoiceInfo.Culture.Name.StartsWith("en"))
                {
                    cmbSesler.Items.Add(voice.VoiceInfo.Name);
                }
            }
            // İlk sesi varsayılan olarak seç
            if (cmbSesler.Items.Count > 0)
            {
                cmbSesler.SelectedIndex = 0;
            }

            // === STT (Speech-to-Text) Ayarları ===

            // Türkçe tanıma için kültür ayarı. 
            // Bilgisayarınızda Türkçe Dil Paketi yüklü olmalıdır.
            // Yüklü değilse, 'en-US' gibi bir dil kullanın veya hata alırsınız.
            try
            {
                CultureInfo ci = new CultureInfo("tr-TR");
                recognizer = new SpeechRecognitionEngine(ci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dil paketi bulunamadı. " + ex.Message + "\nVarsayılan dil (İngilizce) kullanılacak.");
                recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));
            }

            recognizer.SetInputToDefaultAudioDevice(); // Mikrofonu varsayılan giriş olarak ayarla

            // Tanıma için dil bilgisi (grammar) yükle
            // DictationGrammar: Serbest konuşmayı tanır.
            recognizer.LoadGrammar(new DictationGrammar());

            // Olay Yöneticileri: Konuşma tanındığında veya tanınmadığında tetiklenirler
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            recognizer.SpeechRecognitionRejected += Recognizer_SpeechRecognitionRejected;

            // Başlangıçta durumu ayarla
            lblDurum.Text = "Durum: Beklemede";
            lblDurum.ForeColor = Color.Gray;
        }

       

        // Konuşma başarılı bir şekilde tanındığında
        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Tanınan metni TextBox'a ekle
            // Bu satırın çalışması için txtAlgilananMetin'in adının doğru olduğundan emin olun.
            txtAlgilananMetin.AppendText(e.Result.Text + " ");

            // Durum etiketini güncelle
            lblDurum.Text = "Durum: Konuşma algılandı.";
            lblDurum.ForeColor = Color.Green;
        }

        // Konuşma algılandı ama anlaşılamadıysa
        private void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            lblDurum.Text = "Durum: Konuşma anlaşılamadı.";
            lblDurum.ForeColor = Color.OrangeRed;
        }

        private void btnSeslendir_Click(object sender, EventArgs e)
        {
            // Zaten konuşuyorsa durdur
            synth.SpeakAsyncCancelAll();

            // Ayarları uygula
            if (cmbSesler.SelectedItem != null)
            {
                synth.SelectVoice(cmbSesler.SelectedItem.ToString());
            }
            synth.Rate = trackBarHiz.Value; // Hızı ayarla

            // Metni seslendir (Async kullanarak arayüzün kilitlenmesini engelle)
            synth.SpeakAsync(txtMetinGirdisi.Text);
        }

        private void btnDinle_Click(object sender, EventArgs e)
        {
            // Butonun mevcut metnine göre Aç/Kapa işlemi yap
            if (btnDinle.Text == "Dinlemeyi Başlat")
            {
                try
                {
                    // Dinlemeyi başlat (Asenkron ve çoklu tanıma modu)
                    recognizer.RecognizeAsync(RecognizeMode.Multiple);

                    btnDinle.Text = "Dinlemeyi Durdur";
                    lblDurum.Text = "Durum: Dinleniyor...";
                    lblDurum.ForeColor = Color.Blue;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dinleme başlatılamadı: " + ex.Message);
                }
            }
            else // btnDinle.Text == "Dinlemeyi Durdur" ise
            {
                // Dinlemeyi durdur
                recognizer.RecognizeAsyncStop();

                btnDinle.Text = "Dinlemeyi Başlat";
                lblDurum.Text = "Durum: Beklemede";
                lblDurum.ForeColor = Color.Gray;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Motorları düzgünce durdur ve kaynakları serbest bırak
            if (synth != null)
            {
                synth.Dispose();
            }
            if (recognizer != null)
            {
                recognizer.Dispose();
            }
        }
    }
}
