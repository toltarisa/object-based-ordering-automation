using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypodev
{
    public partial class OdemeSayfasi : Form
    {
        public OdemeSayfasi()
        {
            InitializeComponent();
            
        }

        private void OdemeSayfasi_Load(object sender, EventArgs e)
        {
            Sipariş s = new Sipariş();
            label16.Text = s.topAgırlıkHesabı().ToString();
            label17.Text = s.VergiHesabı().ToString();
            label14.Text = s.toplamFiyat().ToString();
            label1.Text = s.VergisizToplam().ToString();

        }

        private void sepetGoster_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            spt.MdiParent = this.ParentForm;
            spt.Show();
        }

        private void buttonOde_Click(object sender, EventArgs e)
        {
            Kredi krd = new Kredi();
            krd.KartNo = Convert.ToInt32(textBox1.Text);
            krd.KartTipi = textBox5.Text;
            krd.SonKullanma = Convert.ToInt32(textBox6.Text);
            krd.GuvenlikKodu = Convert.ToInt32(textBox2.Text);
            krd.KartAdi = textBox7.Text;
            krd.Tutar = Convert.ToInt32(label14.Text);

            if (krd.yetkili(krd.KartNo, krd.KartTipi, krd.SonKullanma, krd.GuvenlikKodu, krd.KartAdi) == "olumlu")
            {
                MessageBox.Show("Bilgileriniz Doğrulandı.Yönlendiriliyorsunuz...");
                MessageBox.Show("Toplam Tutar : " + krd.Tutar);
                textBox1.Text = " ";
                textBox6.Text = " ";
                textBox2.Text = " ";
                textBox5.Text = " ";
                BankaClient client = new BankaClient();
                client.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Tekrar Deneyiniz ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cek cek = new Cek();
            cek.Ad = textBox3.Text;
            cek.BankId = Convert.ToInt32(textBox4.Text);
            cek.Tutar = Convert.ToInt32(label14.Text);

            if (cek.Yetkili(cek.Ad, cek.BankId) == "olumlu")
            {
                MessageBox.Show("Toplam Borcunuz : " + cek.Tutar);
                MessageBox.Show("Talebiniz Bankanıza İletilmiştir.İyi Alışverişler");
                textBox3.Text = " ";
                textBox4.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz en kısa zamanda kargoya verilecektir.");
        }
    }
}
