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
    public partial class frm_AnaSayfa : Form
    {
        private int childFormNumber = 0;

        public Banka BankaApp;
        public Musteri musterisinifi;
        public Hesap hesapsinifi;
        public Rapor raporsinifi;
        public Egitim egitimsinifi;
        public Emekli emeklisinifi;
        public Ihtiyac ihtiyacsinifi;
        public Yatirim yatirimsinifi;
        public frm_AnaSayfa()
        {
            InitializeComponent();
            BankaApp = new Banka();
            musterisinifi = new Musteri();
            hesapsinifi = new Hesap();
            raporsinifi = new Rapor();
            egitimsinifi = new Egitim();
            emeklisinifi = new Emekli();
            ihtiyacsinifi = new Ihtiyac();
            yatirimsinifi = new Yatirim();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void bankaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_BankaGuncelle"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_BankaGuncelle frmBankaGuncelle = new frm_BankaGuncelle();
                frmBankaGuncelle.MdiParent = this;
                frmBankaGuncelle.BankaApp = this.BankaApp;
                frmBankaGuncelle.WindowState = FormWindowState.Normal;
                frmBankaGuncelle.Show();
            }


        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fc = Application.OpenForms["frm_MusteriEkle"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_MusteriEkle frmMusteriEkle = new frm_MusteriEkle();
                frmMusteriEkle.MdiParent = this;
                frmMusteriEkle.BankaApp = this.BankaApp;
                frmMusteriEkle.musterisinifi = this.musterisinifi;
                frmMusteriEkle.WindowState = FormWindowState.Normal;
                frmMusteriEkle.Show();
            }
            
                
            
        }

        private void müşteriSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_MusteriSil"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_MusteriSil frmMusteriSil = new frm_MusteriSil();
                frmMusteriSil.MdiParent = this;
                frmMusteriSil.BankaApp = this.BankaApp;
                frmMusteriSil.musterisinifi = this.musterisinifi;
                frmMusteriSil.Show();
            }
              
            
        }

        private void müşteriListeleGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_MusteriListele"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_MusteriListele frmMusteriListele = new frm_MusteriListele();
                frmMusteriListele.MdiParent = this;
                frmMusteriListele.BankaApp = this.BankaApp;
                frmMusteriListele.musterisinifi = this.musterisinifi;
                frmMusteriListele.Show();
            }
               
            
        }

        private void müşteriİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_HesapAc"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_HesapAc frmHesapAc = new frm_HesapAc();
                frmHesapAc.MdiParent = this;
                frmHesapAc.BankaApp = this.BankaApp;
                frmHesapAc.musterisinifi = this.musterisinifi;
                frmHesapAc.hesapsinifi = this.hesapsinifi;
                frmHesapAc.Show();
            }            
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_HesapKapat"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_HesapKapat frmHesapKapat = new frm_HesapKapat();
                frmHesapKapat.MdiParent = this;
                frmHesapKapat.BankaApp = this.BankaApp;
                frmHesapKapat.musterisinifi = this.musterisinifi;
                frmHesapKapat.hesapsinifi = this.hesapsinifi;
                frmHesapKapat.Show();
            }
                
        }

        private void müşteriListGüncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_HesapListele"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_HesapListele frmHesapListele = new frm_HesapListele();
                frmHesapListele.MdiParent = this;
                frmHesapListele.BankaApp = this.BankaApp;
                frmHesapListele.musterisinifi = this.musterisinifi;
                frmHesapListele.Show();
            }
        }

        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_ParaCek"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_ParaCek frmParaCek = new frm_ParaCek();
                frmParaCek.MdiParent = this;
                frmParaCek.BankaApp = this.BankaApp;
                frmParaCek.musterisinifi = this.musterisinifi;
                frmParaCek.hesapsinifi = this.hesapsinifi;
                frmParaCek.raporsinifi = this.raporsinifi;
                frmParaCek.Show();
            }
        }

        private void paraYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_ParaYatır"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_ParaYatır frmParaYatır = new frm_ParaYatır();
                frmParaYatır.MdiParent = this;
                frmParaYatır.BankaApp = this.BankaApp;
                frmParaYatır.musterisinifi = this.musterisinifi;
                frmParaYatır.hesapsinifi = this.hesapsinifi;
                frmParaYatır.raporsinifi = this.raporsinifi;
                frmParaYatır.Show();
            }
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_Havale"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_Havale frmHavale = new frm_Havale();
                frmHavale.MdiParent = this;
                frmHavale.BankaApp = this.BankaApp;
                frmHavale.musterisinifi = this.musterisinifi;
                frmHavale.hesapsinifi = this.hesapsinifi;
                frmHavale.raporsinifi = this.raporsinifi;
                frmHavale.Show();
            }
        }

        private void gelirGiderRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_GelirGider"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_GelirGider frmGelirGider = new frm_GelirGider();
                frmGelirGider.MdiParent = this;
                frmGelirGider.BankaApp = this.BankaApp;
                frmGelirGider.musterisinifi = this.musterisinifi;
                frmGelirGider.hesapsinifi = this.hesapsinifi;
                frmGelirGider.raporsinifi = this.raporsinifi;
                frmGelirGider.Show();
            }
        }

        private void hesapÖzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_HesapOzeti"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_HesapOzeti frmHesapOzeti = new frm_HesapOzeti();
                frmHesapOzeti.MdiParent = this;
                frmHesapOzeti.BankaApp = this.BankaApp;
                frmHesapOzeti.musterisinifi = this.musterisinifi;
                frmHesapOzeti.hesapsinifi = this.hesapsinifi;
                frmHesapOzeti.raporsinifi = this.raporsinifi;
                frmHesapOzeti.Show();
    }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm_Giris"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
                this.Hide();
            }
            else
            {
                frm_Giris frmGiris = new frm_Giris();
                frmGiris.Show();
                this.Hide();
            }
        }

        private void frm_AnaSayfa_Load(object sender, EventArgs e)
        {
            
                this.WindowState = FormWindowState.Maximized;
                frm_BankaBilgi frmBankaBilgi = new frm_BankaBilgi();
                frmBankaBilgi.MdiParent = this;
                frmBankaBilgi.BankaApp = this.BankaApp;
                frmBankaBilgi.musterisinifi = this.musterisinifi;
                frmBankaBilgi.Show();
            
        }

        private void krediHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmKrediHesapla"];

            if (fc != null)
            {
                fc.Show();
                fc.BringToFront();
            }
            else
            {
                frm_KrediHesapla frmKrediHesapla = new frm_KrediHesapla();
                frmKrediHesapla.MdiParent = this;

                frmKrediHesapla.egitimsinifi = this.egitimsinifi;
                frmKrediHesapla.emeklisinifi = this.emeklisinifi;
                frmKrediHesapla.ihtiyacsinifi = this.ihtiyacsinifi;
                frmKrediHesapla.yatirimsinifi = this.yatirimsinifi;
                frmKrediHesapla.Show();
            }
        }
    }
}
