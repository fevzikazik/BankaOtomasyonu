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
    public partial class frm_MusteriSil : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public frm_MusteriSil()
        {
            InitializeComponent();
        }
        Musteri silinecek = new Musteri();
        private void cmbara_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilen = cmbara.SelectedItem;

            var detay = BankaApp.musteriListesi.Where(a => a.TCKN == secilen).FirstOrDefault();

            if (detay != null)
            {

                lbl_ad.Text = detay.Ad;
                lbl_soyad.Text = detay.Soyad;
                lbl_tel.Text = detay.Telefon;
                lbl_mail.Text = detay.Mail;
                lbl_musteri.Text = detay.musteriTip;
                lbl_adres.Text = detay.Adres;

                btnCikar.Enabled = true;
                silinecek = detay;
            }
            else
            {
                MessageBox.Show("Bu TCNO ya ait müşteri bilgisi bulunamadı");
            }
        }
        private void btnCikar_Click(object sender, EventArgs e)
        {
            if(cmbara.Text == "Seçiniz")
            {
                MessageBox.Show("Lütfen Hesap No Seçiniz!");
            }
            else {
            BankaApp.MusteriCikar(silinecek);
            MessageBox.Show("Müşteri Silindi");
            lbl_ad.Text = "";
            lbl_soyad.Text = "";
            lbl_tel.Text = "";
            lbl_mail.Text = "";
            lbl_musteri.Text = "";
            lbl_adres.Text = "";
            cmbara.Text = "Seçiniz";
            cmbara.Items.Clear();
            MusteriTazele();
            }
        }

        private void frm_MusteriSil_Load(object sender, EventArgs e)
        {
            MusteriTazele();
            cmbara.Text = "Seçiniz";
        }

        private void MusteriTazele()
        {
            foreach (Musteri m in BankaApp.musteriListesi)
            {
                cmbara.Items.Add(m.TCKN);
            }
        }
    }
}