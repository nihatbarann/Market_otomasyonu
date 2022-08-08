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
    public partial class FaturaAlis : Form
    {

        public static string ad, soyad, mid;
        public static string uid, uad, sfiyat;
        public static int fustid = -1;
        DataRowView AktifKayitUst, AktifKayitDetay;
        public FaturaAlis()
        {
            InitializeComponent();
        }

        private void FaturaAlis_Load(object sender, EventArgs e)
        {
            buttunKontrol(true);
            Kayitlar(-11111);
        }
          private void Kayitlar(int id)
        {

            alis_DetayTableAdapter.Fill(market_otomasyonuDataSet.Alis_Detay, id);
            faturaAlisUstTableAdapter.Fill(market_otomasyonuDataSet.FaturaAlisUst, id);
            genelToplam();

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Kayitlar(-111111);
            faturaAlisUstBindingSource.AddNew();
            faturaAlisUstBindingSource.EndEdit();
            txtAd.Focus();
            AktifKayitUst = (DataRowView)faturaAlisUstBindingSource.Current;
            AktifKayitUst["faturaTarih"] = DateTime.Today;
            buttunKontrol(false);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AktifKayitUst = (DataRowView)faturaAlisUstBindingSource.Current;
            fustid = Convert.ToInt32(AktifKayitUst["FaturaAlisID"].ToString());
            Kayitlar(fustid);
            buttunKontrol(true);
        }

        private void satırSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alisDetayBindingSource.Count == 0) return;
            alisDetayBindingSource.RemoveCurrent();
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

                AktifKayitUst = (DataRowView)faturaAlisUstBindingSource.Current;
                fustid = Convert.ToInt32(AktifKayitUst["FaturaAlisID"].ToString());

                alis_DetayTableAdapter.DeleteQuery(fustid);
                faturaAlisUstTableAdapter.DeleteQuery(fustid);

                Kayitlar(fustid);
            }
            buttunKontrol(true);

        }

        private void btnDüzelt_Click(object sender, EventArgs e)
        {
            buttunKontrol(false);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            String Fatura_id;
            int kayitsayisi;
            faturaAlisUstBindingSource.EndEdit();
            faturaAlisUstTableAdapter.Update(market_otomasyonuDataSet.FaturaAlisUst);
            market_otomasyonuDataSet.FaturaSatis.AcceptChanges();

            AktifKayitUst = (DataRowView)faturaAlisUstBindingSource.Current;
            Fatura_id = AktifKayitUst["FaturaAlisID"].ToString();
            alisDetayBindingSource.MoveFirst();
            kayitsayisi = alisDetayBindingSource.Count;
            for (int i = 1; i <= kayitsayisi; i++)
            {
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                AktifKayitDetay["FaturaAlisID"] = Fatura_id;
                alisDetayBindingSource.MoveNext();
            }
            alisDetayBindingSource.EndEdit();
            alis_DetayTableAdapter.Update(market_otomasyonuDataSet.Alis_Detay);
            market_otomasyonuDataSet.Satis_Detay.AcceptChanges();
            buttunKontrol(true);
        }
        private void buttunKontrol(Boolean durum)
        {
            btnDüzelt.Enabled = durum;
            btnKaydet.Enabled = !durum;
            btnSil.Enabled = durum;
            btnVazgec.Enabled = !durum;
            btnYeni.Enabled = durum;
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
        private void genelToplam()
        {
            Double AraToplam = 0, tutar = 0, kdv = 0, ToplamKdv = 0, GenelToplam = 0;
            int kayitsayisi, sirasi;
            kayitsayisi = alisDetayBindingSource.Count;
            sirasi = alisDetayBindingSource.Position;
            alisDetayBindingSource.MoveFirst();
            for (int i = 1; i <= kayitsayisi; i++)
            {
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
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
                alisDetayBindingSource.MoveNext();

            }
            GenelToplam = AraToplam + ToplamKdv;
            lblGenelToplam.Text = GenelToplam.ToString();
            lblToplamKdv.Text = ToplamKdv.ToString();
            lblAraToplam.Text = AraToplam.ToString();

            alisDetayBindingSource.Position = sirasi;

        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uid = "-1";
            urunListesi.gelenform = "Fatura Alış";

            urunListesi yeni = new urunListesi();
            yeni.ShowDialog();
            if (uid != "-1")
            {


                alisDetayBindingSource.AddNew();
                alisDetayBindingSource.EndEdit();
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                AktifKayitDetay["uid"] = uid;
                AktifKayitDetay["urun_ad"] = uad;
                AktifKayitDetay["fiyat"] = sfiyat;
                AktifKayitDetay["miktar"] = 1;
                AktifKayitDetay["kdv"] = 18;
                AktifKayitDetay["tutar"] = sfiyat;

            }
             genelToplam();
        }
    
    

    private void müşteriListesiF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mid = "-1";
            MusteriListesi.gelenform = "Fatura Alış";

            MusteriListesi yeni = new MusteriListesi();
            yeni.ShowDialog();
            if (mid != "-1")
            {

                AktifKayitUst = (DataRowView)faturaAlisUstBindingSource.Current;
                AktifKayitUst["Ad"] = ad;
                AktifKayitUst["Soyad"] =soyad;
                AktifKayitUst["mid"] =mid;
            }
        }
    }
}
