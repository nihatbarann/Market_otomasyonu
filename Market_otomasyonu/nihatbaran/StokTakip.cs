using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nihatbaran
{
    public partial class StokTakip : Form
    {
        public StokTakip()
        {
            InitializeComponent();
        }
        public static String uid = "-1", uad = "";
     
        private void btnGetir_Click(object sender, EventArgs e)
        {
            Getir();
            GenelToplam();
        }

        private void StokTakip_Load(object sender, EventArgs e)
        {
           Getir();
           
        }
        private void GenelToplam()
        {
            double kalan = 0, alis = 0, satis = 0;
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                DataGridViewCell miktar = dataGridView1[7, i];
                satis += Convert.ToDouble(miktar.Value);
            }
            for (int i = 0; i <= dataGridView2.RowCount - 1; i++)
            {
                DataGridViewCell miktar = dataGridView2[7, i];
                alis += Convert.ToDouble(miktar.Value);
            }
            kalan = alis - satis;
            lblAlinan.Text = alis.ToString();
            lblSatilan.Text = satis.ToString();
            lblKalan.Text = kalan.ToString();
        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            uid = "-1";
            urunListesi.gelenform = "Stok Takip";
            urunListesi yeni = new urunListesi();
            yeni.ShowDialog();
            if (uid != "-1")
            {
                textBox1.Text = uad;
                Getir();
                GenelToplam();
            }
        }

        private void Getir()
        {
            if (uid == "-1")
            {
                vW_StokSatisTableAdapter.Tarih(market_otomasyonuDataSet1.VW_StokSatis, dateTimePicker1.Value, dateTimePicker2.Value);
                vW_StokAlisTableAdapter.Tarih(market_otomasyonuDataSet1.VW_StokAlis, dateTimePicker1.Text, dateTimePicker2.Text);
            }
            else
            {
                
                vW_StokSatisTableAdapter.urunAdaGore(market_otomasyonuDataSet1.VW_StokSatis, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(uid));
                vW_StokAlisTableAdapter.AdaGoreArama(market_otomasyonuDataSet1.VW_StokAlis, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(uid));
            }
            GenelToplam();
        }
     
    }
}
