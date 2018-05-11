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
    public partial class frm_HesapAc : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public Hesap hesapsinifi;
        public frm_HesapAc()
        {
            InitializeComponent();
        }

        
        private void cmbmusteritc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_hesapac.Enabled = true;

            hesapsinifi.hesapSahibiTC = cmbmusteritc.SelectedItem.ToString();
        }

        private void frm_HesapAc_Load(object sender, EventArgs e)
        {
            btn_hesapac.Enabled = false;
            cmbmusteritc.Text = "Seçiniz!";
            musteriListele();
        }

        private void musteriListele()
        {
            foreach (Musteri mus in BankaApp.musteriListesi)
            {
                cmbmusteritc.Items.Add(mus.TCKN);

            }
        }

        private void btn_hesapac_Click_1(object sender, EventArgs e)
            {
            Hesap h = new Hesap();
            h.hesapSahibiTC = hesapsinifi.hesapSahibiTC;
            h.hesapNo = musterisinifi.hesapno;
            h.bakiye = Convert.ToInt32 (txt_bakiye.Text);
            if (rdb_vadeli.Checked == true)
            {
                h.hesapTuru = rdb_vadeli.Text;
            }
            else
            {
                h.hesapTuru = rdb_vadesiz.Text;
                
            }
            
            h.limit = musterisinifi.LimitBelirle(h.hesapTuru);
            h.acilisTarihi = DateTime.Now;
            h.hesapID = musterisinifi.id;

            musterisinifi.HesapAc(h);

            
            musterisinifi.hesapno++;
            MessageBox.Show("Hesap başarıyla açıldı!");
        }
    }
}
