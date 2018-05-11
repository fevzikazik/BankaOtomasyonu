using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public class Yatirim : Kredi
    {

        public override void KrediHesapla(int cekilecekpara, int vade)
        {
            faizOrani = 1.6;
            krediTutari = (cekilecekpara * faizOrani * vade) / 100 + cekilecekpara;
            MessageBox.Show("Yatırım kredi sorgulamanız için\nKredi Tutarınız : " + krediTutari);
        }
    }
}
