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
    
    public partial class frm_BankaBilgi : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public frm_BankaBilgi()
        {
            InitializeComponent();
        }

        private void frm_BankaBilgi_Load(object sender, EventArgs e)
        {
            lbBankName.Text = BankaApp.bankaAdi;
            lbBankaID.Text = BankaApp.bankaID.ToString();
            lbeftKodu.Text = BankaApp.eftKodu;
            lbSwiftKodu.Text = BankaApp.swiftKodu;
            lbBankaKurucu.Text = BankaApp.bankaKurucu;
            lbBankaSlogan.Text = BankaApp.bankaSlogan;
            lbSubeSayisi.Text = BankaApp.bankaSubeSayisi;
            lbBankaAtmSayisi.Text = BankaApp.bankaAtmSayisi;
            lbAcilisTarihi.Text = BankaApp.AcilisTarihi;
            lbBankaKonum.Text = BankaApp.bankaKonum;
            lbBankaWebAdresi.Text = BankaApp.bankaWebAdres;

        }
    }
}
