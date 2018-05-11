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
    public partial class frm_HesapKapat : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public Hesap hesapsinifi;

        Hesap kapatilacak = new Hesap();
        public frm_HesapKapat()
        {
            InitializeComponent();
        }
        private void musteriListele()
        {
            foreach (Musteri m in BankaApp.musteriListesi)
            {
                cmbmusteritc.Items.Add(m.TCKN);

            }
        }
        

        private void cmbara_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_hesapkapat.Enabled = true;

            var secilenhesapNo = Convert.ToInt32(cmbara.SelectedItem);
            var detayhesap = musterisinifi.Hesaplar.Where(a => a.hesapNo == secilenhesapNo).FirstOrDefault();

            if (detayhesap != null)
            {

                lbl_bakiye.Text = detayhesap.bakiye.ToString(); ;
                kapatilacak = detayhesap;
            }
            else
            {
                MessageBox.Show("Bu TCNO ya ait müşteri bilgisi bulunamadı");
            }
        }

        private void frm_HesapKapat_Load(object sender, EventArgs e)
        {
            musteriListele();
            cmbara.Enabled = false;
            btn_hesapkapat.Enabled = false;
            cmbmusteritc.Text = "Seçiniz";
            cmbara.Text = "Seçiniz";
        }

        private void btn_hesapkapat_Click(object sender, EventArgs e)
        {
            if (kapatilacak.bakiye == 0)
            {
                musterisinifi.HesapKapat(kapatilacak);
                cmbara.Items.Clear();
                cmbara.Text = "Seçiniz";
                MessageBox.Show(kapatilacak.hesapSahibiTC + " nolu TCKN sahip müşterinin "+ kapatilacak.hesapNo + ".nolu Hesabı Başarıyla Kapatıldı");
                hesapListele();

            }
            else
            {
                MessageBox.Show("Lütfen Bakiyeyi Sıfırlayınız!", "UYARI");
            }
        }


        private void cmbmusteritc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbara.Enabled = true;
            cmbara.Text = "Seçiniz";
            lbl_bakiye.Text = "---------";

            var secilenmus = cmbmusteritc.SelectedItem;
            var detaymus = BankaApp.musteriListesi.Where(a => a.TCKN == secilenmus).FirstOrDefault();

            if (detaymus != null)
            {

                lbl_ad.Text = detaymus.Ad ;
                lbl_soyad.Text = detaymus.Soyad;
                lbl_Tc.Text = detaymus.TCKN ;
                
            }
            else
            {
                MessageBox.Show("Bu TCNO ya ait müşteri bilgisi bulunamadı");
            }
            cmbara.Items.Clear();
            hesapListele();


        }
        public void hesapListele()
        {
            var secilenmust = cmbmusteritc.SelectedItem;
            foreach (Hesap h in musterisinifi.Hesaplar)
            {
                if (secilenmust == h.hesapSahibiTC)
                    cmbara.Items.Add(h.hesapNo);
            }
        }
    }
}
