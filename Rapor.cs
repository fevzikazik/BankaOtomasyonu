using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public class Rapor
    {
        public int islemID{ get; set; }
        public string islemTuru { get; set; }
        public int islemyapanHesapNo { get; set; }
        public int islemAliciNo { get; set; }
        public int islemTutar { get; set; }
        public DateTime islemTarihi { get; set; }


        public int id = 0;
    }
}
