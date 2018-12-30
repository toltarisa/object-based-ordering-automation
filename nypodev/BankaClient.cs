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
    public partial class BankaClient : Form
    {
        public BankaClient()
        {
            InitializeComponent();
        }

        string dortBas = "";
        private void BankaClient_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int bas1 = r.Next(1, 9);
            int bas2 = r.Next(1, 9);
            int bas3 = r.Next(1, 9);
            int bas4 = r.Next(1, 9);

            dortBas = bas1.ToString() + "" + bas2.ToString() + "" + bas3.ToString() + "" + bas4.ToString();
            MessageBox.Show("Onay Kodunuz : " + dortBas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == dortBas)
            {
                MessageBox.Show("Siparişiniz Alındı.En Kısa Sürede Kargoya Verilecektir");
                this.Close();
            }
        }
    }
}
