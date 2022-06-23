using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace nihatbaran
{
    public partial class MusteriTanim : Form
    {
        public string file_path = "D:/nihatbaran/test.xlsx";

        public MusteriTanim()
        {
            InitializeComponent();
        }

        private void MusteriTanim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonuDataSet.musteri_tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteri_tanimTableAdapter.Fill(this.market_otomasyonuDataSet.musteri_tanim);
            Button_Control(true);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            musteritanimBindingSource.AddNew();
            Button_Control(false);

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            musteritanimBindingSource.CancelEdit();
            Button_Control(true);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            musteritanimBindingSource.EndEdit();
            musteri_tanimTableAdapter.Update(market_otomasyonuDataSet.musteri_tanim);
            market_otomasyonuDataSet.musteri_tanim.AcceptChanges();
            Button_Control(true);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Button_Control(Boolean durum)
        {
            btnSil.Enabled = durum;
            btnDuzelt.Enabled = durum;
            btnYeni.Enabled = durum;
            btnKaydet.Enabled = !durum;
            btnVazgec.Enabled = !durum;
            txtAd.Enabled = !durum;
            txtAdres.Enabled = !durum;
            txtSoyad.Enabled = !durum;
            maskedTextBox1.Enabled = !durum;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;
            sil = MessageBox.Show("bu kaydı silmek istediğinize eminmisiniz","silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {
                musteritanimBindingSource.RemoveCurrent();
                musteri_tanimTableAdapter.Update(market_otomasyonuDataSet.musteri_tanim);
                market_otomasyonuDataSet.musteri_tanim.AcceptChanges();
            }
            Button_Control(true);

        }

        private void btnilkKayit_Click(object sender, EventArgs e)
        {
            musteritanimBindingSource.MoveFirst();
        }

        private void btnSonKayit_Click(object sender, EventArgs e)
        {
            musteritanimBindingSource.MoveLast();
        }

        private void btnOnceKayit_Click(object sender, EventArgs e)
        {
            musteritanimBindingSource.MovePrevious();
        }

        private void btnSonrakiKayit_Click(object sender, EventArgs e)
        {
            musteritanimBindingSource.MoveNext();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnAdaGore.Checked) { 
            musteri_tanimTableAdapter.AdaGoreArama(market_otomasyonuDataSet.musteri_tanim,"%"+txtArama.Text+"%");
            }
            else if (rdbtnSoyadaGore.Checked)
            {
                musteri_tanimTableAdapter.SoyadaGoreArama(market_otomasyonuDataSet.musteri_tanim, "%" + txtArama.Text + "%");
            }
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            Button_Control(false);

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
            Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
            Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
            ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat
            CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
            CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı aç



            CalismaSayfasi0.Cells[1, 1] = "Adı";                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[1, 2] = "Soyadı";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 3] = "Adres";
            CalismaSayfasi0.Cells[1, 4] = "tel";

            int kayitSayisi;
            DataRowView AktifKayit;
            kayitSayisi = musteritanimBindingSource.Count;
            musteritanimBindingSource.MoveFirst();
            Range MyRange;

            for (int i = 0; i < kayitSayisi; i++)
            {

                AktifKayit = (DataRowView)musteritanimBindingSource.Current;
                CalismaSayfasi0.Cells[i + 2, 1] = AktifKayit["ad"].ToString();                        // dataya yaz (satır, sutun)
                CalismaSayfasi0.Cells[i + 2, 2] = AktifKayit["soyad"].ToString();                                // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 3] = AktifKayit["adres"].ToString();
                CalismaSayfasi0.Cells[i + 2, 4] = AktifKayit["tel"].ToString();

                musteritanimBindingSource.MoveNext();

        
            MyRange = (Range)CalismaSayfasi0.Cells[i + 2, 1];MyRange.EntireColumn.AutoFit();
                MyRange = (Range)CalismaSayfasi0.Cells[i + 2, 2]; MyRange.EntireColumn.AutoFit();
                MyRange = (Range)CalismaSayfasi0.Cells[i + 2, 3]; MyRange.EntireColumn.AutoFit();
                MyRange = (Range)CalismaSayfasi0.Cells[i + 2, 4]; MyRange.EntireColumn.AutoFit();

            }

        ExcelUygulama0.Visible = true;                 // excel' i görünür yap


            //ExcelUygulama0.Quit();      // excel uygulamasını kapat
        }
    }
}
