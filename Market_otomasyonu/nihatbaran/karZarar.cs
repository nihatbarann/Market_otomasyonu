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
    public partial class karZarar : Form
    {
        public karZarar()
        {
            InitializeComponent();
        }

        private void karZarar_Load(object sender, EventArgs e)
        {
            vW_KarZararTableAdapter.Fill(market_otomasyonuDataSet.VW_KarZarar, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
            GenelToplam();
        }
        private void GenelToplam()
        {
            double geneltoplam = 0, alis = 0, satis = 0;
            String tur = "";
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                DataGridViewCell tutaralani = dataGridView1[8, i];
                tur = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                if (tur == "Fatura Alış")
                {
                    alis += Convert.ToDouble(tutaralani.Value);
                }
                else
                {
                    satis += Convert.ToDouble(tutaralani.Value);
                }
            }
            geneltoplam = satis - alis;
            label15.Text = geneltoplam.ToString();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            vW_KarZararTableAdapter.Fill(market_otomasyonuDataSet.VW_KarZarar,Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
            GenelToplam();
        }
    }
}
