using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public class Egitim : Kredi
    {
        public override void KrediHesapla(int cekilecekpara, int vade)
        {
            faizOrani = 1.4;
            krediTutari = (cekilecekpara * faizOrani * vade) / 100 + cekilecekpara;
            MessageBox.Show("Eğitim kredi sorgulamanız için\nKredi Tutarınız : " + krediTutari);


        }
    }
}
