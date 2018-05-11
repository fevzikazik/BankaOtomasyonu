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
    public partial class frm_KrediHesapla : Form
    {

        public Egitim egitimsinifi;
        public Emekli emeklisinifi;
        public Ihtiyac ihtiyacsinifi;
        public Yatirim yatirimsinifi;
        public frm_KrediHesapla()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (cmb_KrediTuru.Text == "Seçiniz")
            { MessageBox.Show("Lütfen Geçerli Bir Kredi TÜrü Giriniz!!"); }
            else
            {
                string kredituru;
                int cekilenPara = Convert.ToInt16(txtKrediTutari.Text);
                int krediVadesi = Convert.ToInt16(txtKrediVadeSuresi.Text);

                if (cmb_KrediTuru.SelectedItem == "İhtiyaç Kredisi")
                {
                    ihtiyacsinifi.KrediHesapla(cekilenPara, krediVadesi);
                }
                else if (cmb_KrediTuru.SelectedItem == "Emekli Kredisi")
                {
                    emeklisinifi.KrediHesapla(cekilenPara, krediVadesi);
                }
                else if (cmb_KrediTuru.SelectedItem == "Eğitim Kredisi")
                {
                    egitimsinifi.KrediHesapla(cekilenPara, krediVadesi);
                }
                else if (cmb_KrediTuru.SelectedItem == "Yatırım Kredisi")
                {
                    yatirimsinifi.KrediHesapla(cekilenPara, krediVadesi);
                }
                else
                    MessageBox.Show("Geçersiz Kredi Türü");


            }

        }

        private void frm_KrediHesapla_Load(object sender, EventArgs e)
        {
            cmb_KrediTuru.Text = "Seçiniz";
            cmb_KrediTuru.Items.Add("İhtiyaç Kredisi");
            cmb_KrediTuru.Items.Add("Eğitim Kredisi");
            cmb_KrediTuru.Items.Add("Emekli Kredisi");
            cmb_KrediTuru.Items.Add("Yatırım Kredisi");
        }
    }
}
