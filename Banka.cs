using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public class Banka
    {
        public string bankaAdi { get; set; }
        public short bankaID { get; set; }
        public string eftKodu { get; set; }
        public string swiftKodu { get; set; }
        public string bankaSlogan { get; set; }
        public string bankaKurucu { get; set; }
        public string bankaSubeSayisi { get; set; }
        public string bankaAtmSayisi { get; set; }
        public string AcilisTarihi { get; set; }
        public string bankaKonum { get; set; }
        public string bankaWebAdres { get; set; }
        public double genelBakiye { get; set; }
        public double bankaGelir { get; set; }
        public double bankaGider { get; set; }

        public List<Musteri> musteriListesi = new List<Musteri>();


        public int id = 0;

        public Banka()
        {
            this.bankaAdi = "FZF";
            this.bankaID = 102;
            this.eftKodu = "1001";
            this.swiftKodu = "5005";
            this.bankaSlogan = "Biliyoruz da ticaretini yapıyoruz";
            this.bankaKurucu = "Anonim";
            this.bankaSubeSayisi = "35";
            this.bankaAtmSayisi = "200";
            this.AcilisTarihi = "1930";
            this.bankaKonum = "İstanbul / Avcılar";
            this.bankaWebAdres= "www.fzf.org.tr";
        }

        public void BankaBilgiGuncelle(Banka bilgi)
        {
            this.bankaAdi = bilgi.bankaAdi;
            this.bankaID = bilgi.bankaID;
            this.eftKodu = bilgi.eftKodu;
            this.swiftKodu = bilgi.swiftKodu;
            this.bankaSlogan = bilgi.bankaSlogan;
            this.bankaKurucu = bilgi.bankaKurucu;
            this.bankaSubeSayisi = bilgi.bankaSubeSayisi;
            this.bankaAtmSayisi = bilgi.bankaAtmSayisi;
            this.AcilisTarihi = bilgi.AcilisTarihi;
            this.bankaKonum = bilgi.bankaKonum;
            this.bankaWebAdres = bilgi.bankaWebAdres;
        }

        public List<Musteri> MusteriListele()
        {
            return musteriListesi;        
        }
        public void MusteriEkle(Musteri m)
        {
            musteriListesi.Add(m);
        }

        public void MusteriCikar(Musteri m)
        {
                musteriListesi.Remove(m); 
            
            
        }

    }
}
