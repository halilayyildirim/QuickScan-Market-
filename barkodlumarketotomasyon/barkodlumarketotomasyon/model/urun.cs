using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodlumarketotomasyon.model
{
    public class urun
    {
        public int id { get; set; }
        public string qrkod { get; set; }
        public string barkodkod { get; set; }
        public DateTime olusturulma_traih { get; set; }
        public DateTime guncelleme_tarih { get; set; }
        public string urun_isim { get; set; }
        public float kilo { get; set; }
        public int fiyat { get; set; }
        public int ciro { get; set; }


    }
}
