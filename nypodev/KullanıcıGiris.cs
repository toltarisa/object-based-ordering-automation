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
    public partial class KullanıcıGiris : Form
    {
        public KullanıcıGiris()
        {
            InitializeComponent();
        }
        Form1 form1 = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {


            string satır = "a";

            string[] lines = File.ReadAllLines(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\kullanıcı.txt");

            //string name = lines[0];
            //string pass = lines[1];
            int sayac = 0;
            while (satır != null)
            {
                satır = lines[sayac];

                string[] parça = satır.Split('-');

                if (textKullanıcı.Text == parça[2] && textKullanıcıPass.Text == parça[3])
                {

                    //  form1.ürünlerToolStripMenuItem.Visible = false;
                    //form1.sepetToolStripMenuItem.Visible = false;

                    Form1.mdiObj.ürünlerToolStripMenuItem.Visible = true;
                    Form1.mdiObj.sepetToolStripMenuItem.Visible = true;
                    Form1.mdiObj.ödemeGerçekleştirToolStripMenuItem.Visible = true;
                    Form1.mdiObj.çıkışToolStripMenuItem.Visible = true;

                    Form1.mdiObj.ürünEkleToolStripMenuItem.Visible = false;
                    Form1.mdiObj.ürünSilToolStripMenuItem.Visible = false;
                    Form1.mdiObj.ürünDüzenleToolStripMenuItem.Visible = false;
                    this.Hide();

                    break;

                }

                if (textKullanıcı.Text != parça[2] && textKullanıcıPass.Text != parça[3])
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
    }
}
