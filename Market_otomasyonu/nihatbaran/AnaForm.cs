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

      


      
      

        private void alışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaSatis yeni = new MasaSatis();
            yeni.ShowDialog();
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


        private void ürünTanımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            urunTanim yeni = new urunTanim();
            yeni.ShowDialog();
        }

        private void müşteriTanımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriTanim yeni = new MusteriTanim();
            yeni.ShowDialog();
        }

        private void firmaTanımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FirmaTanim yeni = new FirmaTanim();
            yeni.ShowDialog();
        }

        private void ürünListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            urunListesi yeni = new urunListesi();
            yeni.ShowDialog();
        }

        private void müşteriListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriListesi yeni = new MusteriListesi();
            yeni.ShowDialog();
        }

        private void faturaAlışListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaAlisList yeni = new FaturaAlisList();
            yeni.ShowDialog();
        }

        private void faturaSatışListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaSatisList yeni = new FaturaSatisList();
            yeni.ShowDialog();
        }

        private void firmaListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FirmaListesi yeni = new FirmaListesi();
            yeni.ShowDialog();
        }

        private void masaSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaSatis yeni = new MasaSatis();
            yeni.ShowDialog();
        }

        private void faturaSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaSatis yeni = new FaturaSatis();
            yeni.ShowDialog();
        }

        private void faturaSatışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FaturaAlis yeni = new FaturaAlis();
            yeni.ShowDialog();
        }

        private void stokTakipToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StokTakip yeni = new StokTakip();
            yeni.ShowDialog();
        }

        private void karZararToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            karZarar yeni = new karZarar();
            yeni.ShowDialog();
        }

        private void gelirGiderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gelirGider yeni = new gelirGider();
            yeni.ShowDialog();
        }
    }
}
