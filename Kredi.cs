using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public abstract class Kredi
    {
        public double krediTutari { get; set; }
        public double faizOrani { get; set; }
        public abstract void KrediHesapla(int cekilecekpara,int vade);
    }
}
