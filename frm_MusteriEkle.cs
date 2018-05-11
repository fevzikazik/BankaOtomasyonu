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
    public partial class frm_MusteriEkle : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public frm_MusteriEkle()
        {
            InitializeComponent();
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text == "" || txtMusteriMail.Text == "" || txtMusteriSoyad.Text == "" || txtMusteriTc.Text == "" || txtMusteriTel.Text == "" || txt_adres.Text == "")
            {
                MessageBox.Show("Lütfen Bilgilerinizi Boş Bırakmayınız!");
            }
            else
            {
                if (cmbMusTip.Text == "Bireysel" || cmbMusTip.Text == "Ticari")
                {
                    Musteri m = new Musteri();
                    m.Ad = this.txtMusteriAd.Text;
                    m.Soyad = this.txtMusteriSoyad.Text;
                    m.TCKN = this.txtMusteriTc.Text;
                    m.Telefon = this.txtMusteriTel.Text;
                    m.Mail = this.txtMusteriMail.Text;
                    m.Adres = this.txt_adres.Text;
                    m.musteriID = BankaApp.id;
                    m.musteriTip = cmbMusTip.SelectedItem.ToString();


                    BankaApp.MusteriEkle(m);
                    BankaApp.id++;
                    MessageBox.Show("Müşteri Başarıyla Eklendi!");


                    txtMusteriAd.Text = txtMusteriMail.Text = txtMusteriSoyad.Text = txtMusteriTc.Text = txtMusteriTel.Text = txt_adres.Text = "";
                    txtMusteriTc.Focus();
                    cmbMusTip.Text = "Seçiniz";
                }
                else
                { MessageBox.Show("Lütfen Müşteri Tipini Seçiniz"); }
            }
        }

        

        private void frm_MusteriEkle_Load(object sender, EventArgs e)
        {
            cmbMusTip.Text = "Seçiniz";
        }
    }
}
