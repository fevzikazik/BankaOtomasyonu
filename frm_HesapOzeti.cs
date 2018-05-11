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
    public partial class frm_HesapOzeti : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public Hesap hesapsinifi;
        public Rapor raporsinifi;

        public List<Rapor> secilenhesaplar { get; set; }
        public frm_HesapOzeti()
        {
            InitializeComponent();
            secilenhesaplar = new List<Rapor>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ilktarih = dtp_ilkTarih.Value.Date;
            DateTime sontarih = dtp_sonTarih.Value.Date;

            if (cmb_HesapNo.Text == "Tüm Hesapları Listele")
            {
                dtGrdMusteriler.DataSource = null;
                dtGrdMusteriler.DataSource = hesapsinifi.RaporListele();
                lblAd.Text = lblSoyad.Text = lblTCKN.Text = "--------";
            }
            else
            {
                var secilen = Convert.ToInt32(cmb_HesapNo.SelectedItem);

                secilenhesaplar.Clear();
                foreach (Rapor h in hesapsinifi.Hesaphareketleri)
                {
                    
                    if (h.islemyapanHesapNo == secilen || h.islemAliciNo == secilen)
                    {
                        if (h.islemTarihi.Date >= ilktarih && h.islemTarihi.Date <= sontarih)
                        { secilenhesaplar.Add(h); }
                        else
                            MessageBox.Show("Aradığınız tarihklerde kayıt bulunamamaktadır.");
                    }


                }
                dtGrdMusteriler.DataSource = null;
                dtGrdMusteriler.DataSource = secilenhesaplar;

            }
        }

        private void frm_HesapOzeti_Load(object sender, EventArgs e)
        {
            lblAd.Text = lblSoyad.Text = lblTCKN.Text = "--------";
            cmb_HesapNo.Text = "Seçiniz";
            cmb_HesapNo.Items.Add("Tüm Hesapları Listele");
            cmbdoldur();


            dtGrdMusteriler.DataSource = null;
            dtGrdMusteriler.DataSource = hesapsinifi.RaporListele();
        }


        private void cmbdoldur()
        {
            foreach (Hesap m in musterisinifi.Hesaplar)
            {
                cmb_HesapNo.Items.Add(m.hesapNo);
            }
        }
        private void cmb_HesapNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_HesapNo.Text == "Tüm Hesapları Listele")
            {
                dtp_ilkTarih.Enabled = false;
                dtp_sonTarih.Enabled = false;
            }
            else
            {
                dtp_ilkTarih.Enabled = true;
                dtp_sonTarih.Enabled = true;
            }


            var secilen = Convert.ToInt32(cmb_HesapNo.SelectedItem);
            var raporbilgi = BankaApp.musteriListesi.Where(a => a.hesapno == secilen).FirstOrDefault();

            if (raporbilgi != null)
            {

                lblAd.Text = raporbilgi.Ad;
                lblSoyad.Text = raporbilgi.Soyad;
                lblTCKN.Text = raporbilgi.TCKN;

            }
        }
    }
}
