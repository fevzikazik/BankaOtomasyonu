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
    public partial class frm_GelirGider : Form
    {
        public Banka BankaApp;
        public Musteri musterisinifi;
        public Hesap hesapsinifi;
        public Rapor raporsinifi;
        public List<Rapor> GelirListe { get; set; }
        public List<Rapor> GiderListe { get; set; }
        public frm_GelirGider()
        {
            InitializeComponent();
            GelirListe = new List<Rapor>();
            GiderListe = new List<Rapor>();
        }

        private void frm_GelirGider_Load(object sender, EventArgs e)

        {
            foreach (Rapor h in hesapsinifi.Hesaphareketleri)
            {

                if (h.islemTuru == "ParaCek")
                {
                    GiderListe.Add(h);
                    BankaApp.bankaGider += h.islemTutar;
                }
                else if (h.islemTuru == "ParaYatir")
                {
                    GelirListe.Add(h);
                    BankaApp.bankaGelir += h.islemTutar;
                }
            }
            lbl_toplamPara.Text = BankaApp.genelBakiye.ToString();
            lbl_gelenPara.Text = BankaApp.bankaGelir.ToString();
            lbl_gidenPara.Text = BankaApp.bankaGider.ToString();

            dtGrvGelir.DataSource = null;
            dtGrvGelir.DataSource = GelirListe;
            dtGrvGelir.Columns[3].Visible=false;

            dtGrwGider.DataSource = null;
            dtGrwGider.DataSource = GiderListe;
            dtGrwGider.Columns[3].Visible = false;
        }
    }
}
