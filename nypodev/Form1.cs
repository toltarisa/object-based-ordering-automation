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
    public partial class Form1 : Form
    {
        public static Form1 mdiObj;
        public Form1()
        {
            InitializeComponent();
        }

        private void müşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıGiris kullanıcıGiris = new KullanıcıGiris();
            kullanıcıGiris.MdiParent = this;
            kullanıcıGiris.Show();
            mdiObj = this;
        }

        private void personelGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yetkiligiris yetkiligiris = new Yetkiligiris();
            yetkiligiris.MdiParent = this;
            yetkiligiris.Show();
            mdiObj = this; 
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ürünler ürünler = new Ürünler();
            ürünler.MdiParent = this;
            ürünler.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ürünlerToolStripMenuItem.Visible = false;
            sepetToolStripMenuItem.Visible = false;
            ödemeGerçekleştirToolStripMenuItem.Visible = false;
            ürünEkleToolStripMenuItem.Visible = false;
            ürünSilToolStripMenuItem.Visible = false;
            ürünDüzenleToolStripMenuItem.Visible = false;


        }

        private void sepetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.MdiParent = this;
            sepet.Show();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünEkle ürün = new ÜrünEkle();
            ürün.MdiParent = this;
            ürün.Show();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ÜrünSil ürün = new ÜrünSil();
            ürün.MdiParent = this;
            ürün.Show();
        }

        private void ürünDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünDüzenle ürün = new ÜrünDüzenle();
            ürün.MdiParent = this;
            ürün.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

      

        private void kaydolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kaydol kayıt = new Kaydol();
            kayıt.MdiParent = this;
            kayıt.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PersonelEkle  prsnl = new PersonelEkle();
            prsnl.MdiParent = this;
            prsnl.Show();

        }
    }
}
