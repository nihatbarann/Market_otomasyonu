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
    public partial class FaturaSatisList : Form
    {
        public FaturaSatisList()
        {
            InitializeComponent();
        }

        private void FaturaSatisList_Load(object sender, EventArgs e)
        {
            this.satis_DetayTableAdapter.FillBy(this.market_otomasyonuDataSet.Satis_Detay);
        }
    }
}
