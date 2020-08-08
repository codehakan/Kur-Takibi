using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kur_Takip_Programı.forms
{
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
            txt_tmrSiniri.Text = (frm_main.updateTime / 1000).ToString();
            ayarlariCek();
        }

        private void ayarlariCek()
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\ayarlar.ini"))
                {
                    dosyaislemleri ini = new dosyaislemleri(Application.StartupPath + @"\ayarlar.ini");
                    txt_dolarSiniri.Text = ini.oku("Kur Bilgileri", "Dolar");
                    txt_euroSiniri.Text = ini.oku("Kur Bilgileri", "Euro");
                    txt_tmrSiniri.Text = ini.oku("Program Ayarlari", "GuncellemeAraligi");
                    txt_tmrSiniri.Text = (Convert.ToDouble(txt_tmrSiniri.Text) / 1000).ToString();
                }
                else
                {
                    MessageBox.Show("Ayarlar dosyası bulunamadı. Lütfen ayarlarınızı yaptıktan sonra kayıt edin. Bu uyarıyı sadece programı ilk kullandığınızda göreceksiniz.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata tespit edildi.\n\n" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                dosyaislemleri ini = new dosyaislemleri(Application.StartupPath + @"\ayarlar.ini");
                ini.yaz("Kur Bilgileri", "Dolar", txt_dolarSiniri.Text);
                ini.yaz("Kur Bilgileri", "Euro", txt_euroSiniri.Text);
                ini.yaz("Program Ayarlari", "GuncellemeAraligi", (Convert.ToDouble(txt_tmrSiniri.Text) * 1000).ToString());
                this.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata tespit edildi.\n\n" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
