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
    public partial class frm_BankaGuncelle : Form
    {
        public Banka BankaApp;
        public frm_BankaGuncelle()
        {
            InitializeComponent();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtBankaAdi.Text == "" || txtBankaAcilisTarihi.Text == "" || txtBankaAtmSayisi.Text == "" || txtBankaID.Text == "" || txtBankaKonum.Text == "" || txtBankaKurucu.Text == "")
            {
                MessageBox.Show("Lütfen Banka Bilgilerini Boş Bırakmayınız!");
            }
            else
            {
                Banka bilgi = new Banka();

            bilgi.bankaAdi= txtBankaAdi.Text;
            bilgi.bankaID= Convert.ToInt16( txtBankaID.Text);
            bilgi.eftKodu= txtEftKodu.Text;
            bilgi.swiftKodu = txtBankaSwiftKodu.Text;
            bilgi.bankaSlogan= txtBankaSlogan.Text;
            bilgi.bankaSubeSayisi= txtBankaSubeSayisi.Text;
            bilgi.bankaAtmSayisi= txtBankaAtmSayisi.Text;
            bilgi.AcilisTarihi= txtBankaAcilisTarihi.Text;
            bilgi.bankaKonum= txtBankaKonum.Text;
            bilgi.bankaWebAdres= txtBankaWebAdres.Text;
            bilgi.bankaKurucu = txtBankaKurucu.Text;

            BankaApp.BankaBilgiGuncelle(bilgi);


            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "frm_BankaBilgi")
                {
                    item.Close();
                    break;
                }
            }

            

            frm_BankaBilgi frmBankaBilgi = new frm_BankaBilgi();
            frmBankaBilgi.BankaApp = this.BankaApp;
            frmBankaBilgi.MdiParent = this.MdiParent;
            frmBankaBilgi.Show();
            }
        }

        private void frm_BankaGuncelle_Load(object sender, EventArgs e)
        {
            txtBankaKurucu.Text = BankaApp.bankaKurucu;
            txtBankaAdi.Text= BankaApp.bankaAdi;
            txtBankaID.Text = BankaApp.bankaID.ToString() ;
            txtEftKodu.Text= BankaApp.eftKodu;
            txtBankaSwiftKodu.Text=BankaApp.swiftKodu ;
            txtBankaSlogan.Text= BankaApp.bankaSlogan;
            txtBankaSubeSayisi.Text=BankaApp.bankaSubeSayisi;
            txtBankaAtmSayisi.Text = BankaApp.bankaAtmSayisi;
            txtBankaAcilisTarihi.Text=BankaApp.AcilisTarihi ;
            txtBankaKonum.Text=BankaApp.bankaKonum;
            txtBankaWebAdres.Text = BankaApp.bankaWebAdres;
        }
    }
}
