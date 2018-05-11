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
    public partial class frm_ParaCek : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public Hesap hesapsinifi;
        public Rapor raporsinifi;

        Hesap cekilecekliste = new Hesap();
        public frm_ParaCek()
        {
            InitializeComponent();
        }

        private void cmbmusteritc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ParaCek.Enabled = false;
            cmbara.Enabled = true;
            cmbara.Text = "Seçiniz";
            lbl_bakiye.Text = "---------";

            var secilenmus = cmbmusteritc.SelectedItem;
            var detaymus = BankaApp.musteriListesi.Where(a => a.TCKN == secilenmus).FirstOrDefault();

            if (detaymus != null)
            {

                lbl_ad.Text = detaymus.Ad;
                lbl_soyad.Text = detaymus.Soyad;
                lbl_Tc.Text = detaymus.TCKN;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbara_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ParaCek.Enabled = true;
            var secilenhesapNo = Convert.ToInt32(cmbara.SelectedItem);
            var detayhesap = musterisinifi.Hesaplar.Where(a => a.hesapNo == secilenhesapNo).FirstOrDefault();

            btn_ParaCek.Enabled = true;
            if (detayhesap != null)
            {

                lbl_bakiye.Text = detayhesap.bakiye.ToString(); ;
                cekilecekliste = detayhesap;
            }
            else
            {
                MessageBox.Show("Bu TCNO ya ait müşteri bilgisi bulunamadı");
            }
        }

        private void btn_ParaCek_Click(object sender, EventArgs e)
        {
            int soncekilen = 0;

            int cekilentutar = Convert.ToInt32(txt_tutar.Text);
            if (cekilecekliste.bakiye >= cekilentutar)
            { 

                    Rapor rpr = new Rapor();
                    rpr.islemyapanHesapNo = cekilecekliste.hesapNo;
                    rpr.islemTutar = cekilentutar;
                    rpr.islemTarihi = DateTime.Now;
                    rpr.islemTuru = "ParaCek";
                    rpr.islemID = raporsinifi.id;

                soncekilen += rpr.islemTutar;
                foreach (Rapor hsp in hesapsinifi.Hesaphareketleri)
                {
                    if (hsp.islemTuru == "ParaCek" && hsp.islemyapanHesapNo == Convert.ToInt32(cmbara.SelectedItem) && hsp.islemTarihi.Date == DateTime.Now.Date)
                    {
                        soncekilen += hsp.islemTutar;
                    }
                }

                if (soncekilen < 750)
                {
                    hesapsinifi.ParaCek(cekilentutar, cekilecekliste);
                    MessageBox.Show("Para çekme işlemi başarıyla gerçekleştirildi!");
                    lbl_bakiye.Text = cekilecekliste.bakiye.ToString();

                    hesapsinifi.RaporEkle(rpr);
                    raporsinifi.id++;
                }
                else
                {
                    MessageBox.Show("Günlük 750 TL limitinizden " + (soncekilen-750) + " TL geçtiniz!\nLütfen Günlük Limiti Geçmeyiniz(Kalan Para Çekme Tutarı: " +(cekilentutar - (soncekilen - 750)) + ")" );

                }

                
                
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye!");
            }
        }

        private void frm_ParaCek_Load(object sender, EventArgs e)
        {
            cmbmusteritc.Text = "Seçiniz";
            btn_ParaCek.Enabled = false;
            musteriListele();
            cmbara.Enabled = false;
        }
        private void musteriListele()
        {
            foreach (Musteri m in BankaApp.musteriListesi)
            {
                cmbmusteritc.Items.Add(m.TCKN);

            }
        }
    }
}
