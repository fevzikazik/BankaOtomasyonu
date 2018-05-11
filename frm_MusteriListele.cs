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
    public partial class frm_MusteriListele : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public frm_MusteriListele()
        {
            InitializeComponent();
        }

        private void frm_MusteriListele_Load(object sender, EventArgs e)
        {
            dtGrdMusteriler.DataSource = null;
            dtGrdMusteriler.DataSource = BankaApp.MusteriListele();
            dtGrdMusteriler.Columns[3].Visible = false; //KOLON GİZLEME
        }

        private void dtGrdMusteriler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int satirNo = dtGrdMusteriler.CurrentRow.Index;

            txtMusteriTc.Text = BankaApp.musteriListesi[satirNo].TCKN;
            txtMusteriAd.Text = BankaApp.musteriListesi[satirNo].Ad;
            txtMusteriSoyad.Text = BankaApp.musteriListesi[satirNo].Soyad;
            txtMusteriTel.Text = BankaApp.musteriListesi[satirNo].Telefon;
            txtMusteriMail.Text = BankaApp.musteriListesi[satirNo].Mail;                        // banka sınıfındaki musterilistesindeki secilen kaydı textboxlara aktarır
            txt_adres.Text = BankaApp.musteriListesi[satirNo].Adres;
            if (BankaApp.musteriListesi[satirNo].musteriTip == "Bireysel")
            { rdb_bireysel.Checked = true; }
            else
            { rdb_ticari.Checked = true; }
            btnGuncelle.Enabled = true;


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int satirNo = dtGrdMusteriler.CurrentRow.Index;
            BankaApp.musteriListesi[satirNo].TCKN = txtMusteriTc.Text;
            BankaApp.musteriListesi[satirNo].Ad = txtMusteriAd.Text;
            BankaApp.musteriListesi[satirNo].Soyad = txtMusteriSoyad.Text;
            BankaApp.musteriListesi[satirNo].Telefon = txtMusteriTel.Text;
            BankaApp.musteriListesi[satirNo].Mail = txtMusteriMail.Text;
            BankaApp.musteriListesi[satirNo].Adres = txt_adres.Text;
            if (rdb_bireysel.Checked == true)
            {BankaApp.musteriListesi[satirNo].musteriTip = "Bireysel";}
            else
            {BankaApp.musteriListesi[satirNo].musteriTip = "Ticari"; }

            dtGrdMusteriler.DataSource = null;
            dtGrdMusteriler.DataSource = BankaApp.MusteriListele();

            txt_adres.Text = txtMusteriTel.Text = txtMusteriTc.Text = txtMusteriSoyad.Text = txtMusteriMail.Text = txtMusteriAd.Text = "";
            rdb_bireysel.Checked = true;
            txtMusteriAd.Focus();

        }
    }
}
