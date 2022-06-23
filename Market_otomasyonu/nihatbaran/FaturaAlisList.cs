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
    public partial class FaturaAlisList : Form
    {
        public FaturaAlisList()
        {
            InitializeComponent();
        }

        private void FaturaAlisList_Load(object sender, EventArgs e)
        {
            this.alis_DetayTableAdapter.FillBy(this.market_otomasyonuDataSet.Alis_Detay);
        }
    }
}
