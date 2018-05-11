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
    public partial class frm_HesapListele : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public List<Hesap> secilenhesaplar { get; set; }
        
        public frm_HesapListele()
        {
            InitializeComponent();
            secilenhesaplar  = new List<Hesap>();
        }
        
        private void cmbdoldur()
        {
            foreach (Musteri m in BankaApp.musteriListesi)
            {
                cmbara.Items.Add(m.TCKN);
            }
        }

        
        
        private void frm_HesapListele_Load(object sender, EventArgs e)
        {
            lbl_ad.Text = lbl_soyad.Text = "--------";
            cmbara.Text = "Seçiniz";
            cmbara.Items.Add("Tüm Hesapları Listele");
            cmbdoldur();
            
            dtGrdHesaplar.DataSource = null;
            dtGrdHesaplar.DataSource = musterisinifi.HesaplariListele();
            dtGrdHesaplar.Columns[1].Visible = false;
        }
        
        private void cmbara_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbara.Text == "Tüm Hesapları Listele")
            {
                dtGrdHesaplar.DataSource = null;
                dtGrdHesaplar.DataSource = musterisinifi.HesaplariListele();
                lbl_ad.Text = lbl_soyad.Text = "--------";
            }
            else
            { 
            var secilen = cmbara.SelectedItem;
            var detaymusteri = BankaApp.musteriListesi.Where(a => a.TCKN == secilen).FirstOrDefault();

            if (detaymusteri != null)
            {

                lbl_ad.Text = detaymusteri.Ad;
                lbl_soyad.Text = detaymusteri.Soyad;
            }
            else
            {
                MessageBox.Show("Bu TCNO ya ait müşteri bilgisi bulunamadı");
            }

            secilenhesaplar.Clear();
            foreach (Hesap h in musterisinifi.Hesaplar)
            {

                if (h.hesapSahibiTC == secilen)
                {
                    secilenhesaplar.Add(h);
                    
                }

            }
            dtGrdHesaplar.DataSource = null;
            dtGrdHesaplar.DataSource = secilenhesaplar;
                dtGrdHesaplar.Columns[1].Visible = false;

            }
        }
    }
}
