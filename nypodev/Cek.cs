using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypodev
{
    public class Cek:Ödeme
    {
        public string Ad { get; set; }
        public int BankId { get; set; }

        public string Yetkili(string ad, int id)
        {
            string test = "olumsuz";
            Ad = "İSA TOLTAR";
            BankId = 452313;

            if (Ad == ad && BankId == id)
            {
                test = "olumlu";
            }
            return test;
        }
    }
}
