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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }
        public static string gelenform;
        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonuDataSet1.musteri_tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteri_tanimTableAdapter.Fill(this.market_otomasyonuDataSet1.musteri_tanim);

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnAdaGore.Checked) {
                musteri_tanimTableAdapter.AdaGoreArama(market_otomasyonuDataSet1.musteri_tanim,"%" + txtArama.Text + "%");
            }
           else if (rdbtnSoyadaGore.Checked) { 
            musteri_tanimTableAdapter.SoyadaGoreArama(market_otomasyonuDataSet1.musteri_tanim,"%"+txtArama.Text+"%");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gelenform == "Fatura Satış")
            {
                DataRowView AktifKayit;
                AktifKayit = (DataRowView)musteritanimBindingSource.Current;
                FaturaSatis.ad = (AktifKayit["Ad"].ToString());
                FaturaSatis.soyad = (AktifKayit["soyad"].ToString());
                FaturaSatis.mid = (AktifKayit["mid"].ToString());
            }
            Close();

            if (gelenform == "Fatura Alış")
            {
                DataRowView AktifKayit;
                AktifKayit = (DataRowView)musteritanimBindingSource.Current;
                FaturaAlis.ad = (AktifKayit["Ad"].ToString());
                FaturaAlis.soyad = (AktifKayit["Soyad"].ToString());
                FaturaAlis.mid = (AktifKayit["mid"].ToString());
            }
            Close();


        }
    }
}
