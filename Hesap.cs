using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public class Hesap
    {
        public string hesapSahibiTC { get; set; }
        public int hesapID { get; set; }
        public string hesapTuru { get; set; }
        public int hesapNo { get; set; }
        public double bakiye { get; set; }
        public DateTime acilisTarihi { get; set; }
        public int limit { get; set; }


        public Rapor rapor { get; set; }

        public List<Rapor> Hesaphareketleri = new List<Rapor>();

        public void ParaCek(int tutar, Hesap cekilecekliste)
        {
            cekilecekliste.bakiye -= tutar;
        }
        public void ParaYatir(int tutar, Hesap cekilecekliste)
        {
            cekilecekliste.bakiye += tutar;
        }

        public void HavaleYap(double tutar, Hesap cekilecekliste, Hesap aliciliste, string musteriTip)
        {
            cekilecekliste.bakiye -= tutar;
            
            if (musteriTip == "Bireysel")
            {
                tutar *= 0.98;
            }
            aliciliste.bakiye += tutar;
            
            
        }

        public void RaporEkle(Rapor rpr)
        {
            Hesaphareketleri.Add(rpr);
            
        }
        public List<Rapor> RaporListele()
        {
            return Hesaphareketleri;
        }


    }
}
