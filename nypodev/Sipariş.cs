using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypodev
{
    public class Sipariş
    {
        public string Tarih { get; set; }
        public string Durum { get; set; }
        public Musteri musteri { get; set; }
        public Ürün ürün;
        private static List<Sipariş> siparişler = new List<Sipariş>();
        public static List<Sipariş> Siparişler
        {
            get { return siparişler; }
            set { siparişler = value; }
        }
       
        private SiparişDetay spr;
        public SiparişDetay Spr
        {
            get
            {
                if(spr==null)
                {
                    spr = new SiparişDetay();
                }
                return spr;
            }
        }
        public void SiparişEkle(Sipariş s)
        {
            siparişler.Add(s);
        }

        public void SiparişSil(int siparişIndex)
        {
            siparişler.RemoveAt(siparişIndex);
        }

        public string SiparişListele()
        {
            string temp = "";
            foreach(Sipariş s in siparişler)
            {
                temp += "Tarih " + s.Tarih+"Ad "+s.ürün.Marka+"Kargo ağırlığı "+s.ürün.KargoAgırlıgı+"Adet "+s.Spr.Adet+
                    "Vergi Durumu "+s.Spr.VergiOrani+Environment.NewLine;
            }
            return temp;
        }

        public int VergiHesabı()
        {
            int toplamVergi = 0;
           foreach(Sipariş s in Siparişler)
           {
                 toplamVergi += s.Spr.VergiOrani;
           }
            return toplamVergi;
        }

        public int toplamFiyat()
        {
            int toplamFiyat = 0;
            int genelToplam = 0;
            foreach (Sipariş s in Siparişler)
            {
                toplamFiyat += s.Spr.fiyat;
                genelToplam = (toplamFiyat * s.Spr.Adet);
                genelToplam = genelToplam + (genelToplam * VergiHesabı() / 100);
            }
            return genelToplam;
        }

        public int VergisizToplam()
        {
            int toplamFiyat = 0;
            int genelToplam = 0;
            foreach (Sipariş s in Sipariş.Siparişler)
            {
                toplamFiyat += s.Spr.fiyat;
                genelToplam = (toplamFiyat * s.Spr.Adet);
            }
            return genelToplam;
        }

        public int topAgırlıkHesabı()
        {
            int topAgırlık = 0;
            foreach(Sipariş s in Siparişler)
            {
                topAgırlık += s.ürün.KargoAgırlıgı;
            }
            return topAgırlık;
        }
    }
}
