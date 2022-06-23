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
    public partial class urunTanim : Form
    {
        public string file_path = "D:/nihatbaran/test.xlsx";
        public urunTanim()
        {
            InitializeComponent();
        }

        private void urunTanim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonuDataSet.urun_tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urun_tanimTableAdapter.Fill(this.market_otomasyonuDataSet.urun_tanim);
            // TODO: Bu kod satırı 'market_otomasyonuDataSet.urun_tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urun_tanimTableAdapter.Fill(this.market_otomasyonuDataSet.urun_tanim);
            Button_Conrol(true);

        }
        public void Button_Conrol(Boolean durum)
        {
            btnYeni.Enabled = durum;
            btnDuzelt.Enabled = durum;
            btnSil.Enabled = durum;
            btnKaydet.Enabled = !durum;
            btnVazgec.Enabled = !durum;
            textBox1.Enabled = !durum;
            textBox2.Enabled = !durum;
            textBox3.Enabled = !durum;
            textBox4.Enabled = !durum;
        }


        private void btnYeni_Click(object sender, EventArgs e)
        {
            uruntanimBindingSource.AddNew();
            Button_Conrol(false);

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            uruntanimBindingSource.CancelEdit();
            Button_Conrol(true);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;
            sil = MessageBox.Show("bu kaydı silmek istediğinize eminmisiniz", "silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {
                uruntanimBindingSource.RemoveCurrent();
                urun_tanimTableAdapter.Update(market_otomasyonuDataSet.urun_tanim);
                market_otomasyonuDataSet.musteri_tanim.AcceptChanges();
            
            }
            Button_Conrol(true);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDüzelt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            uruntanimBindingSource.EndEdit();
            urun_tanimTableAdapter.Update(market_otomasyonuDataSet.urun_tanim);
            market_otomasyonuDataSet.musteri_tanim.AcceptChanges();
            Button_Conrol(true);

        }

        private void btnilkKayit_Click(object sender, EventArgs e)
        {
            uruntanimBindingSource.MoveFirst();
        }

        private void btnoncekiKayit_Click(object sender, EventArgs e)
        {
            uruntanimBindingSource.MovePrevious();
        }

        private void btnSonrakiKayit_Click(object sender, EventArgs e)
        {
            uruntanimBindingSource.MoveNext();
        }

        private void btnSonKayit_Click(object sender, EventArgs e)
        {
            uruntanimBindingSource.MoveLast();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            Button_Conrol(false);

        }

        private void btnExcelKaydet_Click(object sender, EventArgs e)
        {

            Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
            Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
            Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
            ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat
            CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
            CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı aç



            CalismaSayfasi0.Cells[1, 1] ="Barkod";                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[1, 2] = "Ürün Adı";                                // dataya yaz
            CalismaSayfasi0.Cells[1, 3] = "Alış Fiyatı";

            int kayitSayisi;
            DataRowView AktifKayit;
            kayitSayisi = uruntanimBindingSource.Count;
            uruntanimBindingSource.MoveFirst();
            Range myRange;


            for(int i = 0; i < kayitSayisi; i++)
            {

                AktifKayit = (DataRowView)uruntanimBindingSource.Current;
                CalismaSayfasi0.Cells[i+2, 1] = AktifKayit["barkod"].ToString();                        // dataya yaz (satır, sutun)
                CalismaSayfasi0.Cells[i + 2, 2] = AktifKayit["urun_ad"].ToString();                                // dataya yaz
                CalismaSayfasi0.Cells[i + 2, 3] = AktifKayit["urun_alis"].ToString();

                uruntanimBindingSource.MoveNext();

            }


            ExcelUygulama0.Visible = true;                 // excel' i görünür yap

            //ExcelUygulama0.Quit();      // excel uygulamasını kapat
        }
    

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            urun_tanimTableAdapter.AdaGoreArama(market_otomasyonuDataSet.urun_tanim, "%" + txtArama.Text + "%");
        }
    }
}
