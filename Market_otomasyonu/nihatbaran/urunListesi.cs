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
    public partial class urunListesi : Form
    {
        public urunListesi()
        {
            InitializeComponent();
        }
        public static string gelenform;
        private void urunListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonuDataSet.urun_tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urun_tanimTableAdapter.Fill(this.market_otomasyonuDataSet.urun_tanim);

        }


        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            urun_tanimTableAdapter.AdaGoreArama(market_otomasyonuDataSet.urun_tanim, "%" + txtArama.Text + "%");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gelenform == "Fatura Satış")
            {
                DataRowView AktifKayit;
                AktifKayit = (DataRowView)uruntanimBindingSource.Current;
                FaturaSatis.uid = (AktifKayit["uid"].ToString());
                FaturaSatis.uad = (AktifKayit["urun_ad"].ToString());
                FaturaSatis.sfiyat = (AktifKayit["urun_satis"].ToString());
                if (AktifKayit["urun_alis"].ToString().Trim() == "")
                    FaturaSatis.sfiyat = "0";
                else
                    FaturaSatis.sfiyat = AktifKayit["urun_alis"].ToString();
            }
            Close();
            if (gelenform == "Fatura Alış")
            {
                DataRowView AktifKayit;
                AktifKayit = (DataRowView)uruntanimBindingSource.Current;
                FaturaAlis.uid = (AktifKayit["uid"].ToString());
                FaturaAlis.uad = (AktifKayit["urun_ad"].ToString());
                FaturaAlis.sfiyat = (AktifKayit["urun_satis"].ToString());
                if (AktifKayit["urun_alis"].ToString().Trim() == "")
                    FaturaAlis.sfiyat = "0";
                else
                    FaturaAlis.sfiyat = AktifKayit["urun_alis"].ToString();
            }
            if (gelenform == "Stok Takip")
            {
                DataRowView AktifKayit;
                AktifKayit = (DataRowView)uruntanimBindingSource.Current;
                StokTakip.uad = AktifKayit["urun_ad"].ToString();
                StokTakip.uid = AktifKayit["uid"].ToString();
            }
            Close();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            double oran, fiyat, yeni_fiyat;
            int kayitsayisi;
           
            oran = Convert.ToDouble(txtİndirim.Text);
            if (comboBox1.Text == "indirim")
            {
                oran = -1 * oran;
            }
            DataRowView AktifKayit;
            kayitsayisi = uruntanimBindingSource.Count;
            uruntanimBindingSource.MoveFirst();

            for (int i= 0; i < kayitsayisi; i++) {
                AktifKayit = (DataRowView)uruntanimBindingSource.Current;
                if (AktifKayit["urun_satis"].ToString().Trim() == "")
                    fiyat = 0;
                else
                    fiyat = Convert.ToDouble(AktifKayit["urun_satis"].ToString());
                
                if (rdbYuzde.Checked) { 

                    yeni_fiyat = fiyat + fiyat * (oran / 100);
                }
                else {
                  
                    yeni_fiyat = fiyat + oran; }
                  


                AktifKayit["urun_satis"] = yeni_fiyat.ToString();

                uruntanimBindingSource.EndEdit();
                urun_tanimTableAdapter.Update(market_otomasyonuDataSet.urun_tanim);
                market_otomasyonuDataSet.AcceptChanges();
                uruntanimBindingSource.MoveNext();


            }
        }
    }
}
