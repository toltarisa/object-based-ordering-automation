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
    public partial class Yetkiligiris : Form
    {
        public Yetkiligiris()
        {
            InitializeComponent();
        }
        Form1 frm1 = new Form1();

        private void Yetkiligiris_Load(object sender, EventArgs e)
        {

        }

        private void YetkiliGir_Click(object sender, EventArgs e)
        {
            string satır = "a";

            string[] lines = File.ReadAllLines(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\personel.txt");

            int sayac = 0;
            while (satır != null)
            {
                satır = lines[sayac];

                string[] parça = satır.Split('-');

                if (textYetkiliAd.Text == parça[2] && textYetkiliPass.Text == parça[3])
                {
                    
                    Form1.mdiObj.ürünlerToolStripMenuItem.Visible = false;
                    Form1.mdiObj.sepetToolStripMenuItem.Visible = false;
                    Form1.mdiObj.ürünEkleToolStripMenuItem.Visible = true;
                    Form1.mdiObj.ürünDüzenleToolStripMenuItem.Visible = true;
                    Form1.mdiObj.ürünSilToolStripMenuItem.Visible = true;
                    Form1.mdiObj.personelEkleToolStripMenuItem.Visible = true;
                    Form1.mdiObj.çıkışToolStripMenuItem.Visible = true;
                    this.Hide();

                    break;

                }

                if (textYetkiliAd.Text != parça[2] && textYetkiliPass.Text != parça[3])
                {
                    sayac++;
                }

                else
                {
                    MessageBox.Show("Hatalı Giriş");
                    break;
                }

            }
        }

        private void textYetkiliPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textYetkiliAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

