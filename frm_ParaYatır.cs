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
    public partial class frm_ParaYatır : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public Hesap hesapsinifi;
        public Rapor raporsinifi;

        Hesap cekilecekliste = new Hesap();
        public frm_ParaYatır()
        {
            InitializeComponent();
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
        private void cmbmusteritc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ParaYatir.Enabled = false;
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

        private void cmbara_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ParaYatir.Enabled = true;
            var secilenhesapNo = Convert.ToInt32(cmbara.SelectedItem);
            var detayhesap = musterisinifi.Hesaplar.Where(a => a.hesapNo == secilenhesapNo).FirstOrDefault();

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

        private void btn_ParaYatir_Click(object sender, EventArgs e)
        {
            int yatirilantutar = Convert.ToInt32(txt_tutar.Text);
            hesapsinifi.ParaYatir(yatirilantutar, cekilecekliste);
            MessageBox.Show("Para yatırma işlemi başarıyla gerçekleştirildi!");
            lbl_bakiye.Text = cekilecekliste.bakiye.ToString();

            Rapor rpr = new Rapor();
            rpr.islemyapanHesapNo = cekilecekliste.hesapNo;
            rpr.islemTutar = yatirilantutar;
            rpr.islemTarihi = DateTime.Now;
            rpr.islemTuru = "ParaYatir";
            rpr.islemID = raporsinifi.id;
            hesapsinifi.RaporEkle(rpr);
            raporsinifi.id++;
        }
        

        private void frm_ParaYatır_Load(object sender, EventArgs e)
        {
            cmbmusteritc.Text = "Seçiniz";
            btn_ParaYatir.Enabled = false;
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
