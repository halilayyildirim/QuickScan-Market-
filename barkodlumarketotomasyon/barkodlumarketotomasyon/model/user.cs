using barkodlumarketotomasyon.enumaration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodlumarketotomasyon.model
{
    public class user
    {
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public string emailadres { get; set; }
        public string guvenliksorusu { get; set; }
        public string guvenlikcevabi { get; set; }

        public loginstatus status { get; set; }
    }
}
