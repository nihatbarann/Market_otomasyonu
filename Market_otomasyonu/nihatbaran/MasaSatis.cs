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
    public partial class MasaSatis : Form
    {

        public MasaSatis()
        {
            InitializeComponent();
        }

       
        public static int genelid=0, hesapturu=0,miktar=0;
        public string file_path = "D:/nihatbaran/test.xlsx";
        public static string barkodu, cinsi, adi, soyadi;
        public static int uid, ustid= -20000;
        DataRowView AktifKayit;
        private void MasaSatis_Load(object sender, EventArgs e)
        {

            Kayitlar(-2500);
            ButtonKontrol(true);
            masaEkleme();

           
        }
        private void Kayitlar(int gelenid)
        {

            masaSatisUstTableAdapter.Fill(this.market_otomasyonuDataSet.MasaSatisUst, gelenid);
            // TODO: This line of code loads data into the 'marketOtomasyonuDataSet.FaturaSatisDetay' table. You can move, or remove it, as needed.
            masaSatisDetayTableAdapter.Fill(this.market_otomasyonuDataSet.MasaSatisDetay, gelenid);
            genelToplam();
        }
        private void UrunBul()
        {
            urun_tanimTableAdapter.FillBy(this.market_otomasyonuDataSet.urun_tanim, '%' + txtArama.Text.Trim() + '%');
        


            if (uruntanimBindingSource.Count > 0)
            {
                DataRowView BulunanUrun;// Aktif Kayıt
                BulunanUrun = (DataRowView)uruntanimBindingSource.Current;
               

                masaSatisDetayBindingSource.AddNew();
                masaSatisDetayBindingSource.EndEdit();

                DataRowView DetayKayit;
                DetayKayit = (DataRowView)masaSatisDetayBindingSource.Current;
                DetayKayit["urun_adi"] = BulunanUrun["urun_ad"].ToString();
                DetayKayit["barkod"] = BulunanUrun["barkod"].ToString();
                DetayKayit["urun_id"] = Convert.ToInt32(BulunanUrun["uid"].ToString());
                if (BulunanUrun["urun_satis"].ToString().Trim() == "")
                    DetayKayit["satis_fiyat"] = 0;
                else
                    DetayKayit["satis_fiyat"] = Convert.ToDouble(BulunanUrun["urun_satis"].ToString());
                if (BulunanUrun["kdv"].ToString().Trim() == "")
                    DetayKayit["kdv"] = 18;
                else
                    DetayKayit["kdv"] = Convert.ToDouble(BulunanUrun["kdv"].ToString());
                DetayKayit["tutar"] = DetayKayit["satis_fiyat"];
                DetayKayit["urun_miktar"] = 1;


                masaSatisDetayBindingSource.MoveLast();
                //ToplamTutarBul();

            }
            else
            {
                MessageBox.Show("Ürün Bulunamadı");
            }
            txtArama.Text = "";
        }
        private void ButtonKontrol(Boolean durum)
        {
            txtAciklama.Enabled = !durum;
          
            txtFiyat.Enabled = !durum;
            txtKdv.Enabled = !durum;
            txtMasa.Enabled = !durum;
            txtMiktar.Enabled = !durum;
           txtArama.Enabled= !durum;
            txtSeri.Enabled = !durum;
            txtTutar.Enabled = !durum;
            txtürünAd.Enabled = !durum;
            cBoxOdemeSekil.Enabled = !durum;
            dTimeTarih.Enabled = !durum;
            btnDuzenle.Enabled = durum;
            btnKaydet.Enabled = !durum;
            btnSil.Enabled = durum;
            btnVazgec.Enabled = !durum;
            btnYeni.Enabled = durum;
            dataGridView1.ReadOnly = true;
            satırıSilToolStripMenuItem.Enabled = !durum;

        }
        private void masaEkleme()
        {
            int masasayisi;
            DataRowView kayitlar;
            firma_tanimTableAdapter.Fill(market_otomasyonuDataSet.Firma_tanim);
            kayitlar = (DataRowView)firmatanimBindingSource.Current;
            masasayisi = Convert.ToInt32(kayitlar["masa_sayisi"].ToString());
            listBoxMasaSayisi.Items.Clear();
            for (int i = 1; i <= masasayisi; i++)
            {
                masaSatisUstTableAdapter.masaDurumu(this.market_otomasyonuDataSet.MasaSatisUst, "Masa=" + (i.ToString()));

                if (masaSatisUstBindingSource.Count > 0) {
                    listBoxMasaSayisi.Items.Add("Masa=" + (i.ToString()) + "  D");

                }
                else
                listBoxMasaSayisi.Items.Add("Masa=" + i.ToString());
            }
        }
        private void txtMiktar_Leave(object sender, EventArgs e)
        {
            Toplamtutar();
            
        }
        private void Toplamtutar()
        {
            double miktar = 0, fiyat = 0, tutar = 0;
            if (txtFiyat.Text.Trim() == "")
                fiyat = 0;
            else
                fiyat=Convert.ToDouble(txtFiyat.Text);
            if (txtMiktar.Text.Trim() == "")
                miktar = 0;
            else
                miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = fiyat * miktar;
            txtTutar.Text= tutar.ToString();
            genelToplam();

        }
        private void btnUygula_Click(object sender, EventArgs e)
        {
            genelToplam();
        }
        private void genelToplam()
        {
            double aratoplam = 0, toplamKdv = 0, kdv = 0, tutar = 0, geneltoplam=0, oran = 0, indirim = 0;
            int kayitsayisi, sirasi ;
            kayitsayisi = masaSatisDetayBindingSource.Count;
            sirasi = masaSatisDetayBindingSource.Position;
            masaSatisDetayBindingSource.MoveFirst();
            for(int i = 1; i <= kayitsayisi; i++)
            {
                AktifKayit=(DataRowView)masaSatisDetayBindingSource.Current;
                if (AktifKayit["tutar"].ToString().Trim() == "")
                    tutar = 0;
                else
                    tutar = Convert.ToDouble(AktifKayit["tutar"].ToString());
                if (AktifKayit["kdv"].ToString().Trim() == "")
                    kdv = 18;
                else
                    kdv = Convert.ToDouble(AktifKayit["kdv"].ToString());
                aratoplam = aratoplam + tutar;
                kdv = tutar * kdv / 100;
                toplamKdv = toplamKdv + kdv;
                masaSatisDetayBindingSource.MoveNext();
                geneltoplam = aratoplam + toplamKdv;
                if (cbxIndırım.Text.Trim() == "TL")
                {
                    if (txtindirim.Text.Trim() == "")
                        indirim = 0;
                    else
                    {
                        indirim = Convert.ToDouble(txtindirim.Text.ToString());
                        lblIndirim.Text = indirim.ToString();
                    }
                    
                }
                if (cbxIndırım.Text.Trim() == "%")
                {

                    if (txtindirim.Text.Trim() == "")
                        indirim = 0;
                    else
                    {
                        oran = Convert.ToDouble(txtindirim.Text.ToString());
                        lblIndirim.Text = oran.ToString();

                        indirim = geneltoplam * oran / 100;
                    }
                }

            }
        
            geneltoplam =geneltoplam - indirim;
            lblGenelToplam.Text = geneltoplam.ToString();
            lblKdv.Text = toplamKdv.ToString();
            lblAraToplam.Text = aratoplam.ToString();
            masaSatisDetayBindingSource.Position = sirasi;
        }

        private void KayitArama(string masa)
        {
            masaSatisUstTableAdapter.masaDurumu(this.market_otomasyonuDataSet.MasaSatisUst, masa);
            DataRowView UstKayit;
            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
            if (masaSatisUstBindingSource.Count > 0)
                ustid = Convert.ToInt32(UstKayit["masa_ust_id"].ToString());
            else
                ustid = -12000;
            Kayitlar(ustid);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

       private void satırıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (masaSatisDetayBindingSource.Count == 0) return;

            masaSatisDetayBindingSource.RemoveCurrent();
            genelToplam();
        }

        private void txtArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus;
            basilantus = Convert.ToInt32((byte)e.KeyChar);

            if (basilantus == 13)
               UrunBul();
            genelToplam();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            {
                if (masaSatisUstBindingSource.Count == 0)
                {

                    return;
                }

                DataRowView UstKayit;

                UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
                if (UstKayit["masa_durumu"].ToString() == "1")
                {
                    ustid = Convert.ToInt32(UstKayit["masa_ust_id"].ToString());
                    masaSatisUstBindingSource.EndEdit();
                    UstKayit["masa_durumu"] = 0;

                    masaSatisUstTableAdapter.Update(market_otomasyonuDataSet.MasaSatisUst);
                    market_otomasyonuDataSet.MasaSatisUst.AcceptChanges();
                    masaEkleme();
                    Toplamtutar();
                    MessageBox.Show("Ödenecek Tutar : " + lblAraToplam.Text.ToString());
                    Kayitlar(-12223);
                }
                else
                {
                    MessageBox.Show("Lütfen Önce Verileri Kaydediniz");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataRowView UstKayit;
            Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
            Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
            Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
            ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat
            CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
            CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı aç

            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;




            CalismaSayfasi0.Cells[1, 1] ="masa";                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[1, 2] = "Acıklama"; // dataya yaz
            CalismaSayfasi0.Cells[1, 3] = "odemeSekli";
            CalismaSayfasi0.Cells[1, 4] = "tarih";
            CalismaSayfasi0.Cells[1, 5] = "seri_no";

            CalismaSayfasi0.Cells[2, 1] = txtMasa.Text;                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[2, 2] = txtAciklama.Text;    // dataya yaz
            CalismaSayfasi0.Cells[2, 3] = cBoxOdemeSekil.Text;
            CalismaSayfasi0.Cells[2, 4] = dTimeTarih.Text;
            CalismaSayfasi0.Cells[2, 5] = txtSeri.Text;


            int kayitSayisi;
            DataRowView AktifKayit;
            kayitSayisi = masaSatisDetayBindingSource.Count;

            CalismaSayfasi0.Cells[5, 1] = "masaID";                                // dataya yaz (satır, sutun)
            CalismaSayfasi0.Cells[5, 2] = "masaUstID"; // dataya yaz
            CalismaSayfasi0.Cells[5, 3] = "urunID";
            CalismaSayfasi0.Cells[5, 4] = "urunAdı";
            CalismaSayfasi0.Cells[5, 5] = "urunMiktarı";
            CalismaSayfasi0.Cells[5, 6] = "satıs fiyat";
            CalismaSayfasi0.Cells[5, 7] = "kdv";
            CalismaSayfasi0.Cells[5, 8] = "tutar";
            for (int i = 0; i < kayitSayisi; i++)
            {
               


                AktifKayit = (DataRowView)masaSatisDetayBindingSource.Current;
                CalismaSayfasi0.Cells[i+6, 1] = AktifKayit["masa_detay_id"].ToString();                        // dataya yaz (satır, sutun)
                CalismaSayfasi0.Cells[i+6, 2] = AktifKayit["masa_ust_id"].ToString();                                // dataya yaz
                CalismaSayfasi0.Cells[i+6, 3] = AktifKayit["urun_id"].ToString();
                CalismaSayfasi0.Cells[i+6, 4] = AktifKayit["urun_adi"].ToString();
                CalismaSayfasi0.Cells[i+6, 5] = AktifKayit["urun_miktar"].ToString();
                CalismaSayfasi0.Cells[i+6, 6] = AktifKayit["satis_fiyat"].ToString();
                CalismaSayfasi0.Cells[i+6, 7] = AktifKayit["kdv"].ToString();
                CalismaSayfasi0.Cells[i+6, 8] = AktifKayit["tutar"].ToString();

                masaSatisDetayBindingSource.MoveNext();



            }


            ExcelUygulama0.Visible = true;                 // excel' i görünür yap

            //ExcelUygulama0.Quit();      // excel uygulamasını kapat
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DataRowView UstKayit;
            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
            if (masaSatisUstBindingSource.Count == 0) return;
            ButtonKontrol(false);
        }

        private void listBoxMasaSayisi_DoubleClick(object sender, EventArgs e)
        {
            string masa = listBoxMasaSayisi.SelectedItem.ToString();

            if (btnYeni.Enabled)
            {
                if (masa.IndexOf("  D") == -1)
                    KayitArama(masa);
                else
                    KayitArama(masa.Substring(0, masa.Length - 3));
            }


            txtMasa.Text=listBoxMasaSayisi.SelectedItem.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int kayitsayisi;
            if (masaSatisUstBindingSource.Count == 0) return;

            DataRowView UstKayit, DetayKayit;
            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;
            masaSatisUstBindingSource.EndEdit();
            UstKayit["masa_durumu"] = 1;
            masaSatisUstTableAdapter.Update(market_otomasyonuDataSet.MasaSatisUst);
            market_otomasyonuDataSet.MasaSatisUst.AcceptChanges();

            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;

            masaSatisDetayBindingSource.EndEdit();

            kayitsayisi = masaSatisDetayBindingSource.Count;
            masaSatisDetayBindingSource.MoveFirst();// ilk kayda Konumlan
            ustid = Convert.ToInt32(UstKayit["masa_ust_id"].ToString());

            for (int i = 1; i <= kayitsayisi; i++)
            {
                DetayKayit = (DataRowView)masaSatisDetayBindingSource.Current;
                DetayKayit["masa_ust_id"] = ustid;
                masaSatisDetayBindingSource.MoveNext();
               
            }

            masaSatisDetayTableAdapter.Update(market_otomasyonuDataSet.MasaSatisDetay);
            market_otomasyonuDataSet.AcceptChanges();
            masaEkleme();
            Kayitlar(ustid);
            ButtonKontrol(true);
            genelToplam();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataRowView UstKayit;
            DialogResult sil;
            if (masaSatisUstBindingSource.Count == 0) return;
            sil = MessageBox.Show("bu kaydı silmek istediğinize eminmisiniz", "silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {

                UstKayit = (DataRowView)masaSatisDetayBindingSource.Current;
                genelid = Convert.ToInt32(UstKayit["masa_ust_id"].ToString());
                masaSatisUstTableAdapter.DeleteQuery(genelid);
                masaSatisDetayTableAdapter.DeleteQuery(genelid);
                masaSatisDetayTableAdapter.Fill(market_otomasyonuDataSet.MasaSatisDetay, genelid);
                masaSatisUstTableAdapter.Fill(market_otomasyonuDataSet.MasaSatisUst, genelid);
                market_otomasyonuDataSet.MasaSatisUst.AcceptChanges();
                masaEkleme();
            

            }
            ButtonKontrol(true);
            genelToplam();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            DataRowView UstKayit;
            UstKayit = (DataRowView)masaSatisUstBindingSource.Current;

            ustid = Convert.ToInt32(UstKayit["masa_ust_id"].ToString());

            Kayitlar(ustid);

            ButtonKontrol(true);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (masaSatisDetayBindingSource.Count > 0) {
                MessageBox.Show("Yeni Kayit için lütfen hesabı Kapatın.");
            }
            else { Kayitlar(-2500);
                masaSatisUstBindingSource.AddNew();
                masaSatisUstBindingSource.EndEdit();
                ButtonKontrol(false);
                cBoxOdemeSekil.Text = "Nakit";
                if (listBoxMasaSayisi.SelectedIndex > 0)
                    txtMasa.Text = listBoxMasaSayisi.SelectedItem.ToString();
                txtArama.Focus();
            }
        }

    }
}