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
    public partial class FaturaSatis : Form
    {
        public FaturaSatis()
        {
            InitializeComponent();
        }
        public static string ad, soyad, mid;
        public static string uid, uad, sfiyat;
        public static int fustid = -1;

        DataRowView AktifKayitUst;
        DataRowView AktifKayitDetay;
        DataRowView AktifKayit;

        private void FaturaSatis_Load(object sender, EventArgs e)
        {
            buttunKontrol(true);
            Kayitlar(-11111);

        }
        private void genelToplam()
        {
            Double AraToplam = 0, tutar = 0, kdv = 0, ToplamKdv = 0, GenelToplam = 0;
            int kayitsayisi, sirasi;
            kayitsayisi = satisDetayBindingSource.Count;
            sirasi = satisDetayBindingSource.Position;
            satisDetayBindingSource.MoveFirst();
            for (int i = 1; i <= kayitsayisi; i++)
            {
                AktifKayitDetay = (DataRowView)satisDetayBindingSource.Current;
                if (AktifKayitDetay["tutar"].ToString().Trim() == "")
                    tutar = 0;
                else
                    tutar = Convert.ToDouble(AktifKayitDetay["tutar"].ToString());
                if (AktifKayitDetay["kdv"].ToString().Trim() == "")
                    kdv = 0;
                else
                    kdv = Convert.ToDouble(AktifKayitDetay["kdv"].ToString());
                AraToplam = AraToplam + tutar;
                kdv = tutar * kdv / 100;
                ToplamKdv = ToplamKdv + kdv;
                satisDetayBindingSource.MoveNext();

            }
            GenelToplam = AraToplam + ToplamKdv;
            lblGenelToplam.Text = GenelToplam.ToString();
            lblToplamKdv.Text = ToplamKdv.ToString();
            lblAraToplam.Text = AraToplam.ToString();

            satisDetayBindingSource.Position = sirasi;

        }
        private void buttunKontrol(Boolean durum) {
            btnDüzelt.Enabled= durum;
            btnKaydet.Enabled= !durum;
            btnSil.Enabled= durum;
            btnVazgec.Enabled= !durum;
            btnYeni.Enabled= durum;
            txtAd.Enabled = !durum;
            txtFiyat.Enabled = !durum;
            txtSoyad.Enabled = !durum;
            txtFaturaNo.Enabled = !durum;
            txtSeriNo.Enabled = !durum;
            txturunEkle.Enabled = !durum;
            txtKdv.Enabled = !durum;
            txtMiktar.Enabled = !durum;
            txturunAd.Enabled = !durum;
            txtTutar.Enabled = !durum;

        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Kayitlar(-111111);
            faturaSatisBindingSource.AddNew();
            faturaSatisBindingSource.EndEdit();
            txtAd.Focus();
            AktifKayitUst = (DataRowView)faturaSatisBindingSource.Current;
            AktifKayitUst["faturaTarih"] = DateTime.Today;
            buttunKontrol(false);

        }
        private void müşteriListesiF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mid = "-1";

            MusteriListesi yeni = new MusteriListesi();
            yeni.ShowDialog();
            MusteriListesi.gelenform = "Fatura Satış";
            if (mid != "-1")
            {

                AktifKayitUst = (DataRowView)faturaSatisBindingSource.Current;
                AktifKayitUst["Ad"] = ad;
                AktifKayitUst["soyadı"] = soyad;
                AktifKayitUst["mid"] = mid;
            }
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AktifKayitUst = (DataRowView)faturaSatisBindingSource.Current;
            fustid = Convert.ToInt32(AktifKayitUst["Fatura_id"].ToString());
             Kayitlar(fustid);
            buttunKontrol(true);
        }
        private void Kayitlar(int id)
        {

            satis_DetayTableAdapter.Fill(market_otomasyonuDataSet.Satis_Detay, id);
            faturaSatisTableAdapter.Fill(market_otomasyonuDataSet.FaturaSatis, id);
            genelToplam();

        }
        private void satırSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (satisDetayBindingSource.Count == 0) return;
            satisDetayBindingSource.RemoveCurrent();
            genelToplam();


        }

        private void txtMiktar_Leave(object sender, EventArgs e)
        {
            TutarBul();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus;
            basilantus = Convert.ToInt32((byte)e.KeyChar);

            if (basilantus == 13)
                TutarBul();
          
        }
        private void TutarBul()
        {
            double miktar = 0, fiyat = 0, tutar = 0;
            if (txtFiyat.Text.Trim() == "")
                fiyat = 0;
            else
                fiyat = Convert.ToDouble(txtFiyat.Text);
            if (txtMiktar.Text.Trim() == "")
                miktar = 0;
            else
                miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = fiyat * miktar;
            txtTutar.Text = tutar.ToString();
            genelToplam();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;
            sil = MessageBox.Show("Bu kaydı silmek istediğinize eminmisiniz", "silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {

                AktifKayitUst = (DataRowView)faturaSatisBindingSource.Current;
                fustid = Convert.ToInt32(AktifKayitUst["Fatura_id"].ToString());

                satis_DetayTableAdapter.DeleteQuery(fustid);
                faturaSatisTableAdapter.DeleteQuery(fustid);

               Kayitlar(fustid);
            }
            buttunKontrol(true);

        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uid = "-1";
            urunListesi yeni = new urunListesi();
            yeni.ShowDialog();
            urunListesi.gelenform = "Fatura Satış";
            if (uid != "-1")
            {


                satisDetayBindingSource.AddNew();
                satisDetayBindingSource.EndEdit();
                AktifKayitDetay = (DataRowView)satisDetayBindingSource.Current;
                AktifKayitDetay["uid"] = uid;
                AktifKayitDetay["urun_ad"] = uad;
                AktifKayitDetay["fiyat"] = sfiyat;
                AktifKayitDetay["miktar"] = 1;
                AktifKayitDetay["kdv"] = 18;
                AktifKayitDetay["tutar"] = sfiyat;

            }
            genelToplam();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            String Fatura_id;
            int kayitsayisi;
            faturaSatisBindingSource.EndEdit();
            faturaSatisTableAdapter.Update(market_otomasyonuDataSet.FaturaSatis);
            market_otomasyonuDataSet.FaturaSatis.AcceptChanges();

            AktifKayitUst = (DataRowView)faturaSatisBindingSource.Current;
            Fatura_id = AktifKayitUst["Fatura_id"].ToString();
            satisDetayBindingSource.MoveFirst();
            kayitsayisi = satisDetayBindingSource.Count;
            for (int i = 1; i <= kayitsayisi; i++)
            {
                AktifKayitDetay = (DataRowView)satisDetayBindingSource.Current;
                AktifKayitDetay["Fatura_id"] = fustid;
                satisDetayBindingSource.MoveNext();
            }
            satisDetayBindingSource.EndEdit();
            satis_DetayTableAdapter.Update(market_otomasyonuDataSet.Satis_Detay);
            market_otomasyonuDataSet.Satis_Detay.AcceptChanges();
            buttunKontrol(true);
        }
        private void btnDüzelt_Click(object sender, EventArgs e)
        {
            buttunKontrol(false);

        }
    }
}
