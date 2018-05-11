using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public class Emekli : Kredi
    {
        public override void KrediHesapla(int cekilecekpara, int vade)
        {

            faizOrani = 1.5;
            krediTutari = (cekilecekpara * faizOrani * vade) / 100 + cekilecekpara;
            MessageBox.Show("Emekli kredi sorgulamanız için\nKredi Tutarınız : " + krediTutari);
        }
    }
}
