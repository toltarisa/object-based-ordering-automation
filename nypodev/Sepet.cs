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
    public partial class Sepet : Form
    {
        public Sepet()
        {            
            InitializeComponent();
        }
        //  Ürün ürn = new Ürün();
        // Sipariş spr = new Sipariş();
        Sipariş s = new Sipariş();
        private void Sepet_Load(object sender, EventArgs e)
         {
            int row = 0;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            string temp = "";

            foreach (Sipariş s in Sipariş.Siparişler)
            {
                
                temp = s.ürün.Marka +"-"+s.ürün.Model+"-"+s.Spr.fiyat+"-"+s.Spr.Adet+"-"+s.Tarih;
                string[] parca = temp.Split('-');
                dataGridView1.Rows.Add();
                for (int i = 0; i < 5; i++)
                { 
                    dataGridView1.Rows[row].Cells[i].Value = parca[i];
                }
                row++;

            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            s.SiparişSil(rowIndex);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdemeSayfasi odemeSayfasi = new OdemeSayfasi();
            odemeSayfasi.MdiParent = this.ParentForm;
            odemeSayfasi.Show();
           
        }
    }
}
