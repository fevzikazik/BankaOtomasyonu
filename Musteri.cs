using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public class Musteri : Kisi
    {
        public int musteriID { get; set; }
        public string musteriTip { get; set; }

        public List<Hesap> Hesaplar = new List<Hesap>();

        int limit;
        public int id = 0;
        public int hesapno = 500;
        public int LimitBelirle(string s)
        {
            
            if (s == "Vadeli")
            { limit = 500; }
            else if (s == "Vadesiz")
            { limit = 1000; }
            return limit;
        }

        public void HesapAc(Hesap h)
        {
            Hesaplar.Add(h);
        }

        public void HesapKapat(Hesap h)
        {
            Hesaplar.Remove(h);
        }
        public List<Hesap> HesaplariListele()
        {
            return Hesaplar;
        }
    }
}
