using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public class Ihtiyac : Kredi

    {
        public override void KrediHesapla(int cekilecekpara, int vade)
        {
            faizOrani = 1.3;
            krediTutari = (cekilecekpara * faizOrani * vade)/100 + cekilecekpara;
            MessageBox.Show("İhtiyaç kredi sorgulamanız için\nKredi Tutarınız : "+krediTutari);
        }
    }
}
