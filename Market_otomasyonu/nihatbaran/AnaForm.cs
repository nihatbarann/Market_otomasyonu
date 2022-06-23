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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void müşteriTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriTanim yeni =new MusteriTanim();
            yeni.ShowDialog (); 
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriListesi yeni = new MusteriListesi();
            yeni.ShowDialog();
        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunListesi yeni=new urunListesi();
            yeni.ShowDialog();
        }

        private void ürünTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunTanim yeni=new urunTanim();
            yeni.ShowDialog();
        }

        private void firmaTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaTanim yeni =new FirmaTanim();
            yeni.ShowDialog();
        }

        private void firmaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaListesi yeni =new FirmaListesi();
            yeni.ShowDialog();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaSatis yeni = new FaturaSatis();
            yeni.ShowDialog();
        }

        private void alışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaSatis yeni = new MasaSatis();
            yeni.ShowDialog();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void faturaAlışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaAlis yeni = new FaturaAlis();
            yeni.ShowDialog();

        }

        private void faturaAlisListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaAlisList yeni = new FaturaAlisList();
            yeni.ShowDialog();
        }

        private void faturaSatısListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaSatisList yeni = new FaturaSatisList();
            yeni.ShowDialog();
        }

        private void karZararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            karZarar yeni = new karZarar();
            yeni.ShowDialog();
        }

        private void gelirGiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gelirGider yeni = new gelirGider();
            yeni.ShowDialog();
        }

        private void stokTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokTakip yeni = new StokTakip();
            yeni.ShowDialog();
        }
    }
}
