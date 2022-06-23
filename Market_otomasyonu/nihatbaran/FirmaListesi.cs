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
    public partial class FirmaListesi : Form
    {
        public FirmaListesi()
        {
            InitializeComponent();
        }

        private void FirmaListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'market_otomasyonuDataSet1.Firma_tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.firma_tanimTableAdapter.Fill(this.market_otomasyonuDataSet1.Firma_tanim);

        }
    }
}
