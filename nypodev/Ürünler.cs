using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nypodev
{
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }

        public void kontrol()
        {
            StreamReader st = new StreamReader(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");

            int SatırSayac = 0;
            while (st.Read() > 0)
            {
            st.ReadLine();
              SatırSayac++;
            }
            st.Close();
         

            string satır = "a";

            string[] lines = File.ReadAllLines(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
            int sayac = 0;

            while (sayac != SatırSayac)
            {
                StreamWriter yaz = File.AppendText("C:\\Users\\cem\\Desktop\\nypodev\\db\\yeni ürünler.txt");

                satır = lines[sayac];

                string[] parça = satır.Split('-');

                if (parça[3] == "" || parça[3] == "0" )
                {
                    
                    sayac++;
                    yaz.Close();
                    continue;
                }

                if(dataGridView1.Rows[0].Cells[0] == null)
                {
                    int rowindex = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(rowindex);
                }

                if (parça[3] != "0")
                {
                    yaz.Write(satır + Environment.NewLine);
                    yaz.Close();
                    sayac++;
                }

            }


            string yol = "C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt";  //Yol adında bir string oluşturuyoruz.
            File.Delete(yol);

            // txt dosyası adı değiştirme
            File.Move("C:\\Users\\cem\\Desktop\\nypodev\\db\\yeni ürünler.txt", "C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");

          
            

        }
        public void Listele()
        {
            StreamReader st = new StreamReader(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");

            int SatırSayac = 0;
            while (st.Read() > 0)
            {
                st.ReadLine();
                SatırSayac++;
            }
            st.Close();
            string satır = "a";
            int row = 0;
            string[] lines = File.ReadAllLines(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
            int sayac = 0; int i = 0;



            while (sayac != SatırSayac)
            {
                satır = lines[sayac];
                dataGridView1.Rows.Add();

                string[] parça = satır.Split('-');

                for (i = 0; i < 5; i++)
                {
                    dataGridView1.Rows[row].Cells[i].Value = parça[i];
                }

                sayac++; row++;
            }

        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            kontrol();
            Listele();
        }
        
        private void sepeteEkle()
        {
            Random r = new Random();
            Sipariş spr = new Sipariş();
            Kredi kredi = new Kredi();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                spr.ürün = new Ürün();
                spr.ürün.Marka = item.Cells[0].Value.ToString();
                spr.ürün.Model = item.Cells[1].Value.ToString();
                spr.ürün.KargoAgırlıgı = r.Next(1, 2);
                spr.Spr.fiyat = Convert.ToInt32(item.Cells[2].Value);
                spr.Spr.Adet= Convert.ToInt32(AdetText.Text);
                spr.Spr.VergiOrani = r.Next(4, 12);
                spr.SiparişEkle(spr);
                spr.Tarih = DateTime.UtcNow.ToShortDateString();
                MessageBox.Show("Siparişiniz Oluşturuldu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            StreamReader st = new StreamReader(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
            int SatırSayac = 0;
            while (st.Read() > 0)

            {
                st.ReadLine();
                SatırSayac++;
              
            }
            st.Close();



            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string marka = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string model = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            string fiyaT = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            string Adedi = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            string Ağırl = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            int a;
            a = Convert.ToInt32(Adedi); 
            a = a - Convert.ToInt32(AdetText.Text);

            if (a <= -1)
            {
                MessageBox.Show("Yeterli stok bulunamadı.");
            }
            else
            {
                Adedi = a.ToString();
               
                StringBuilder sb = new StringBuilder();
                string deger = string.Empty;

                string[] dosya = File.ReadAllLines(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");

                foreach (string satır in dosya)
                {
                    string[] parça = satır.Split('-');

                    if (parça[0] == marka && parça[1] == model)
                    {
                      

                        deger = satır.Replace(parça[0] + "-" + parça[1] + "-" + parça[2] + "-" + parça[3] + "-" + parça[4], marka + "-" + model + "-" + fiyaT + "-" + Adedi + "-" + Ağırl);

                        sepeteEkle();

                        sb.Append(deger + Environment.NewLine);
                        continue;
                    }
                    sb.Append(satır + Environment.NewLine);
                }

                File.WriteAllText(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\yeni ürünler.txt", sb.ToString());

                string yol = "C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt";
                File.Delete(yol);

                // txt dosyası adı değiştirme
                File.Move("C:\\Users\\cem\\Desktop\\nypodev\\db\\yeni ürünler.txt", "C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
                AdetText.Text = "";

                Listele();
                kontrol();
                

            }
        }
    }
}