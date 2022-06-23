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
    public partial class FirmaTanim : Form
    {
        public FirmaTanim()
        {
            InitializeComponent();
        }

        private void FirmaTanim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonuDataSet.Firma_tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.firma_tanimTableAdapter.Fill(this.market_otomasyonuDataSet.Firma_tanim);
           

        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            firmatanimBindingSource.AddNew();
            txtUnvan.Focus();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            firmatanimBindingSource.CancelEdit();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;
            sil = MessageBox.Show("bu kaydı silmek istediğinize eminmisiniz", "silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {
                firmatanimBindingSource.RemoveCurrent();
                firma_tanimTableAdapter.Update(market_otomasyonuDataSet.Firma_tanim);
                market_otomasyonuDataSet.musteri_tanim.AcceptChanges();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            firmatanimBindingSource.EndEdit();
            firma_tanimTableAdapter.Update(market_otomasyonuDataSet.Firma_tanim);
            market_otomasyonuDataSet.musteri_tanim.AcceptChanges();
        }

    }
}
