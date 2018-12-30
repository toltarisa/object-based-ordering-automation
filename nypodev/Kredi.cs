using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypodev
{
    class Kredi:Ödeme
    {
        public int KartNo { get; set; }
        public string KartTipi { get; set; }
        public int SonKullanma { get; set; }
        public int GuvenlikKodu { get; set; }
        public string KartAdi { get; set; }


        public string yetkili(int n, string t, int s, int k, string a)
        {
            string test = "olumsuz";
            KartNo = 789;
            KartTipi = "Kredi Kartı";
            SonKullanma = 2024;
            GuvenlikKodu = 563;
            KartAdi = "İSA TOLTAR";
            if (n == KartNo && t == KartTipi && s == SonKullanma && k == GuvenlikKodu && a == KartAdi)
            {
                test = "olumlu";
            }
            return test;
        }


    }
}
