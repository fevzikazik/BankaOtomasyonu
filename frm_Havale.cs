using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class frm_Havale : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public Hesap hesapsinifi;
        public Rapor raporsinifi;

        Hesap gonderenbilgi = new Hesap();
        Hesap alanbilgi = new Hesap();
        string gonderentc, alantc;
        public frm_Havale()
        {
            InitializeComponent();
        }

        private void frm_Havale_Load(object sender, EventArgs e)
        {
            cmbGonderenTC.Text = "Seçiniz";
            musteriListele();
            hesapListeleGonderen();
            hesapListeleAlici();
            cmbGonderenHesap.Enabled = false;
            cmbAlanTC.Enabled = false;
            cmbAlanHesap.Enabled = false;
            btnhavaleYap.Enabled = false;

        }
        private void musteriListele()
        {
            foreach (Musteri mus in BankaApp.musteriListesi)
            {
                cmbGonderenTC.Items.Add(mus.TCKN);

            }
        }
        public void hesapListeleGonderen()
        {
            gonderentc = cmbGonderenTC.Text;
            foreach (Hesap h in musterisinifi.Hesaplar)
            {
                if (gonderentc == h.hesapSahibiTC)
                    cmbGonderenHesap.Items.Add(h.hesapNo);
            }
        }
        public void hesapListeleAlici()
        {
            alantc= cmbAlanTC.Text;
            foreach (Hesap h in musterisinifi.Hesaplar)
            {
                if (alantc == h.hesapSahibiTC)
                    cmbAlanHesap.Items.Add(h.hesapNo);
            }
        }
        private void cmbGonderenTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmbGonderenHesap.Enabled = true;
            cmbGonderenHesap.Text = "Seçiniz";
            cmbAlanTC.Text = "Seçiniz";
            cmbAlanHesap.Text = "Seçiniz";
            lbl_gonderenBakiye.Text = "---------";
            lbl_alanBakiye.Text = "---------";
            btnhavaleYap.Enabled = false;


            var secilengon = cmbGonderenTC.SelectedItem;
            var detaymus = BankaApp.musteriListesi.Where(a => a.TCKN == secilengon).FirstOrDefault();

            if (detaymus != null)
            {

                lbl_gonderenAd.Text = detaymus.Ad;
                lbl_gonderenSoyad.Text = detaymus.Soyad;
                if(detaymus.musteriTip=="Bireysel")
                { 
                lbl_musTipi.Text =  "Bireysel (%2 Komisyon Kesilecektir!)";
                }
                else if (detaymus.musteriTip == "Ticari")
                {
                    lbl_musTipi.Text = "Ticari";
                }
            }
            else
            {
                MessageBox.Show("Bu TCNO ya ait müşteri bilgisi bulunamadı");
            }
            cmbGonderenHesap.Items.Clear();
            hesapListeleGonderen();
            cmbAlanTC.Items.Clear();
            foreach (Musteri mus in BankaApp.musteriListesi)
            {
                if (gonderentc != mus.TCKN)
                {

                    cmbAlanTC.Items.Add(mus.TCKN);
                }
            }
        }

        private void cmbGonderenHesap_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAlanTC.Text = "Seçiniz";
            btnhavaleYap.Enabled = false;
            var secilenhesapNo = Convert.ToInt32(cmbGonderenHesap.SelectedItem);
            var detayhesap = musterisinifi.Hesaplar.Where(a => a.hesapNo == secilenhesapNo).FirstOrDefault();
            var detaymus = BankaApp.musteriListesi.Where(a => a.TCKN == gonderenbilgi.hesapSahibiTC).FirstOrDefault();

            if (detayhesap != null)
            {

                lbl_gonderenBakiye.Text = detayhesap.bakiye.ToString();
                gonderenbilgi = detayhesap;
                cmbAlanTC.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bu TCNO ya ait hesap bilgisi bulunamadı");
            }
        }

        private void cmbAlanTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAlanHesap.Enabled = true;
            btnhavaleYap.Enabled = false;
            cmbAlanHesap.Text = "Seçiniz";
            lbl_alanBakiye.Text = "---------";

            var secilenalici = cmbAlanTC.SelectedItem;
            var detaymus = BankaApp.musteriListesi.Where(a => a.TCKN == secilenalici).FirstOrDefault();

            if (detaymus != null)
            {

                lbl_alanAd.Text = detaymus.Ad;
                lbl_alanSoyad.Text = detaymus.Soyad;

            }
            else
            {
                MessageBox.Show("Bu TCNO ya ait müşteri bilgisi bulunamadı");
            }
            cmbAlanHesap.Items.Clear();
            hesapListeleAlici();
        }

        private void btnhavaleYap_Click(object sender, EventArgs e)
        {
            int havaletutar = Convert.ToInt32(txthavaleTutar.Text);
            double ata=0;
            var secilengon = cmbGonderenTC.SelectedItem;
            var detayata = BankaApp.musteriListesi.Where(a => a.TCKN == secilengon).FirstOrDefault();

            if (detayata != null)
            {
                if (detayata.musteriTip == "Bireysel")
                {
                    ata = havaletutar * 0.02;
                }
            }
            BankaApp.genelBakiye += ata;
            if (gonderenbilgi.bakiye >= havaletutar) {
                var detaymus = BankaApp.musteriListesi.Where(a => a.TCKN == gonderenbilgi.hesapSahibiTC).FirstOrDefault();

                hesapsinifi.HavaleYap(havaletutar, gonderenbilgi, alanbilgi, detaymus.musteriTip);
                MessageBox.Show("Havale işlemi başarıyla gerçekleştirildi!");
                lbl_gonderenBakiye.Text = gonderenbilgi.bakiye.ToString();
                lbl_alanBakiye.Text = alanbilgi.bakiye.ToString();

                Rapor rpr = new Rapor();
                rpr.islemyapanHesapNo = gonderenbilgi.hesapNo;
                rpr.islemAliciNo = alanbilgi.hesapNo;
                rpr.islemTutar = havaletutar;
                rpr.islemTarihi = DateTime.Now;
                rpr.islemTuru = "Havale";
                rpr.islemID = raporsinifi.id; 

                hesapsinifi.RaporEkle(rpr);
                raporsinifi.id++;
            }
            else
            {
                MessageBox.Show("Göndericinin Yetersiz Bakiyesi!");
            }
        }

        private void cmbAlanHesap_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnhavaleYap.Enabled = true;
            var secilenhesapNo = Convert.ToInt32(cmbAlanHesap.SelectedItem);
            var detayhesap = musterisinifi.Hesaplar.Where(a => a.hesapNo == secilenhesapNo).FirstOrDefault();

            if (detayhesap != null)
            {

                lbl_alanBakiye.Text = detayhesap.bakiye.ToString(); ;
                alanbilgi = detayhesap;
            }
            else
            {
                MessageBox.Show("Bu TCNO ya ait hesap bilgisi bulunamadı");
            }
        }
    }
}
