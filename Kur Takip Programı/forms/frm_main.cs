using Kur_Takip_Programı.forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Kur_Takip_Programı
{
    public partial class frm_main : Form
    {
        string dolarDegeri, euroDegeri, dolarMinMax;

        // dolar ve euro değerlerini çekmek için değişkenler
        int dollarStartIndex, dollarEndIndex;
        int euroStartIndex, euroEndIndex;

        //dolar ve euronun max-min değerlerini çekmek için değişkenler
        int dollarIndex, dollarIndexEnd;
        int euroIndex, euroIndexEnd;

        // timer'in süresi
        public static float updateTime;

        // uyarılar için belirlenen değişkenler
        double dolar, euro;
        double kullaniciDolar, kullaniciEuro;

        // dolar ve euro kurlarını diziye aktarıp virgül varsa noktaya çevirmek için
        char[] charDolar;
        char[] charEuro;
        char[] charKullaniciDolar;
        char[] charKullaniciEuro;

        // kontroller için tanımlanmış değişkenler
        string dolarkontrol, eurokontrol;
        bool okundumuDolar, okundumuEuro;

        public frm_main()
        {
            okundumuDolar = false;
            okundumuEuro = false;
            dolarDegeri = "0.0000 ₺";
            euroDegeri = "0.0000 ₺";
            InitializeComponent();
            backgroundWorkerDolar.RunWorkerAsync();
            backgroundWorkerEuro.RunWorkerAsync();
            programAyarlariniYukle();
            tmr_cek.Start();
        }

        private void uyarilariKontrolEt()
        {

            if (File.Exists(Application.StartupPath + @"\ayarlar.ini"))
            {
                dosyaislemleri ini = new dosyaislemleri(Application.StartupPath + @"\ayarlar.ini");
                // dolar değeri null mı diye kontrol ediyorum. Null ise hiç işlem yapmayacak
                if (dolarDegeri != null)
                {
                    // dolar değerini char değişkene atıyorum
                    charDolar = lbl_dolar.Text.Substring(0, 6).ToCharArray();
                    // for döngüsü ile . olan kısımları , ile değiştiriyorum.
                    for (int i = 0; i < charDolar.Length; i++)
                    {
                        if (charDolar[i] == '.')
                            charDolar[i] = ',';
                    }
                    // string değişkeninin içini boşalttım.
                    dolarDegeri = string.Empty;
                    // char değişkeni içerisindeki verileri stringe aktardım.
                    for (int i = 0; i < charDolar.Length; i++)
                    {
                        dolarDegeri += charDolar[i];
                    }
                    // double olan dolar değişkenine sonucu ilettim.
                    dolar = Convert.ToDouble(dolarDegeri);
                }
                if (euroDegeri != null)
                {
                    charEuro = lbl_euro.Text.Substring(0, 6).ToCharArray();
                    for (int i = 0; i < charEuro.Length; i++)
                    {
                        if (charEuro[i] == '.')
                            charEuro[i] = ',';
                    }
                    euroDegeri = string.Empty;
                    for (int i = 0; i < charEuro.Length; i++)
                    {
                        euroDegeri += charEuro[i];
                    }
                    euro = Convert.ToDouble(euroDegeri);
                }
                charKullaniciDolar = ini.oku("Kur Bilgileri", "Dolar").ToCharArray();
                charKullaniciEuro = ini.oku("Kur Bilgileri", "Euro").ToCharArray();
                for (int i = 0; i < charKullaniciDolar.Length; i++)
                {
                    if (charKullaniciDolar[i] == '.')
                        charKullaniciDolar[i] = ',';
                }
                for (int i = 0; i < charKullaniciEuro.Length; i++)
                {
                    if (charKullaniciEuro[i] == '.')
                        charKullaniciEuro[i] = ',';
                }
                dolarkontrol = string.Empty;
                eurokontrol = string.Empty;
                for (int i = 0; i < charKullaniciDolar.Length; i++)
                {
                    dolarkontrol += charKullaniciDolar[i];
                    eurokontrol += charKullaniciEuro[i];
                }
                kullaniciDolar = Convert.ToDouble(dolarkontrol);
                kullaniciEuro = Convert.ToDouble(eurokontrol);
                if ((dolar < kullaniciDolar) && (dolar != 0))
                {
                    if (!okundumuDolar)
                    {
                        okundumuDolar = true;
                        MessageBox.Show("Dolar kuru belirlediğiniz oranın altına düştü!\n\nGüncel Dolar Kuru: " + dolar + "\nSizin Sınırınız: " + kullaniciDolar);

                    }
                }
                if ((euro < kullaniciEuro) && (euro != 0))
                {
                    if (!okundumuEuro)
                    {
                        okundumuEuro = true;
                        MessageBox.Show("Euro kuru belirlediğiniz oranın altına düştü!\n\nGüncel Euro Kuru: " + euro + "\nSizin Sınırınız: " + kullaniciEuro);

                    }
                }

            }

        }

        private void programAyarlariniYukle()
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\ayarlar.ini"))
                {
                    dosyaislemleri ini = new dosyaislemleri(Application.StartupPath + @"\ayarlar.ini");
                    tmr_cek.Interval = Convert.ToInt32(ini.oku("Program Ayarlari", "GuncellemeAraligi"));
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Program ayarları yüklenirken hata oluştu." + hata.Message);
            }
        }

        private void checkDollar()
        {
            try
            {
                WebRequest SiteyeBaglantiTalebi = HttpWebRequest.Create("https://tlkur.com");
                WebResponse GelenCevap = SiteyeBaglantiTalebi.GetResponse();
                StreamReader CevapOku = new StreamReader(GelenCevap.GetResponseStream());
                dolarDegeri = CevapOku.ReadToEnd();
                dollarStartIndex = dolarDegeri.IndexOf("id=\"USDTRY\"") + 12;
                dollarEndIndex = dolarDegeri.Substring(dollarStartIndex).IndexOf("</span>");
                dollarIndex = dolarDegeri.IndexOf("class=\"range\"") + 14;
                dollarIndexEnd = dolarDegeri.Substring(dollarIndex).IndexOf("</div>");

            }
            catch (Exception)
            {
                //MessageBox.Show(hata.Message, "Hata");
            }
        }

        private void checkEuro()
        {
            try
            {
                WebRequest SiteyeBaglantiTalebi = HttpWebRequest.Create("https://tlkur.com");
                WebResponse GelenCevap = SiteyeBaglantiTalebi.GetResponse();
                StreamReader CevapOku = new StreamReader(GelenCevap.GetResponseStream());
                euroDegeri = CevapOku.ReadToEnd();
                euroStartIndex = euroDegeri.IndexOf("id=\"EURTRY\"") + 12;
                euroEndIndex = euroDegeri.Substring(euroStartIndex).IndexOf("</span>");
                euroIndex = euroDegeri.IndexOf("id=\"EURTRY\"") + 91;
                euroIndexEnd = euroDegeri.Substring(dollarIndex).IndexOf("</div>");


            }
            catch (Exception)
            {
                //MessageBox.Show(hata.Message, "Hata");
            }
        }

        private void backgroundWorkerEuro_DoWork(object sender, DoWorkEventArgs e)
        {
            checkEuro();
        }

        private void backgroundWorkerEuro_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //MessageBox.Show(e.Error.Message);
            }
            else
            {
                if (e.Cancelled)
                {
                    MessageBox.Show("Veri güncelleme işlemi iptal edildi.", "Hata");
                }
                else
                {
                    lbl_euro.Text = euroDegeri.Substring(euroStartIndex, euroEndIndex) + " ₺";
                    lbl_minmaxeuro.Text = euroDegeri.Substring(euroIndex, euroIndexEnd);
                }
            }
        }

        private bool InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coded: hakanbey", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okundumuDolar = false;
            okundumuEuro = false;
            frm_settings show = new frm_settings();
            show.ShowDialog();
            programAyarlariniYukle();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmr_cek_Tick(object sender, EventArgs e)
        {
            try
            {
                if (InternetKontrol())
                {
                    lbl_baglanti.Text = "Bağlantı Kuruldu!";
                    lbl_baglanti.ForeColor = Color.DarkGreen;
                    lbl_sondeger1.Visible = false;
                    lbl_sondeger2.Visible = false;
                    lbl_minmaxdolar.Visible = true;
                    lbl_minmaxeuro.Visible = true;
                }
                else
                {
                    lbl_minmaxdolar.Visible = false;
                    lbl_minmaxeuro.Visible = false;
                    lbl_sondeger1.Visible = true;
                    lbl_sondeger2.Visible = true;
                    lbl_baglanti.Text = "Bağlantı Kesildi!";
                    lbl_baglanti.ForeColor = Color.Red;
                }
                backgroundWorkerDolar.RunWorkerAsync();
                backgroundWorkerEuro.RunWorkerAsync();
                uyarilariKontrolEt();
            }
            catch (Exception hata)
            {
                tmr_cek.Stop();
                Console.WriteLine(hata.Message);
                tmr_cek.Start();
            }
        }

        private void backgroundWorkerDolar_DoWork(object sender, DoWorkEventArgs e)
        {
            checkDollar();
        }

        private void backgroundWorkerDolar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //MessageBox.Show(e.Error.Message);
            }
            else
            {
                if (e.Cancelled)
                {
                    MessageBox.Show("Veri güncelleme işlemi iptal edildi.", "Hata");
                }
                else
                {
                    lbl_dolar.Text = dolarDegeri.Substring(dollarStartIndex, dollarEndIndex) + " ₺";
                    lbl_minmaxdolar.Text = dolarDegeri.Substring(dollarIndex, dollarIndexEnd);
                }
            }
        }
    }
}
