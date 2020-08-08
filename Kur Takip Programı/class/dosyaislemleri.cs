using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kur_Takip_Programı
{
    class dosyaislemleri
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder refVal, int size, string filePath);

        private string dosyayolu;
        public dosyaislemleri(string dosyayolu)
        {
            this.dosyayolu = dosyayolu;
        }
        public string Varsayilan { get; set; }
        public string oku(string bolum, string ayaradi)
        {
            Varsayilan = Varsayilan ?? string.Empty;
            StringBuilder StrBuild = new StringBuilder(256);
            GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, dosyayolu);
            return StrBuild.ToString();
        }
        public long yaz(string bolum, string ayaradi, string deger)
        {
            return WritePrivateProfileString(bolum, ayaradi, deger, dosyayolu);
        }
    }
}
