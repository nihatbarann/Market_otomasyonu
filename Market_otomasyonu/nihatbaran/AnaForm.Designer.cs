namespace nihatbaran
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünTanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaTanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaAlisListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaSatısListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaAlışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karZararToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.listelerToolStripMenuItem,
            this.faturalarToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriTanımToolStripMenuItem,
            this.ürünTanımToolStripMenuItem,
            this.firmaTanımToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // müşteriTanımToolStripMenuItem
            // 
            this.müşteriTanımToolStripMenuItem.Name = "müşteriTanımToolStripMenuItem";
            this.müşteriTanımToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.müşteriTanımToolStripMenuItem.Text = "Müşteri Tanım";
            this.müşteriTanımToolStripMenuItem.Click += new System.EventHandler(this.müşteriTanımToolStripMenuItem_Click);
            // 
            // ürünTanımToolStripMenuItem
            // 
            this.ürünTanımToolStripMenuItem.Name = "ürünTanımToolStripMenuItem";
            this.ürünTanımToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ürünTanımToolStripMenuItem.Text = "Ürün Tanım";
            this.ürünTanımToolStripMenuItem.Click += new System.EventHandler(this.ürünTanımToolStripMenuItem_Click);
            // 
            // firmaTanımToolStripMenuItem
            // 
            this.firmaTanımToolStripMenuItem.Name = "firmaTanımToolStripMenuItem";
            this.firmaTanımToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.firmaTanımToolStripMenuItem.Text = "Firma Tanım";
            this.firmaTanımToolStripMenuItem.Click += new System.EventHandler(this.firmaTanımToolStripMenuItem_Click);
            // 
            // listelerToolStripMenuItem
            // 
            this.listelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListesiToolStripMenuItem,
            this.ürünListesiToolStripMenuItem,
            this.firmaListesiToolStripMenuItem,
            this.faturaAlisListesiToolStripMenuItem,
            this.faturaSatısListesiToolStripMenuItem});
            this.listelerToolStripMenuItem.Name = "listelerToolStripMenuItem";
            this.listelerToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.listelerToolStripMenuItem.Text = "Listeler";
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem_Click);
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            this.ürünListesiToolStripMenuItem.Click += new System.EventHandler(this.ürünListesiToolStripMenuItem_Click);
            // 
            // firmaListesiToolStripMenuItem
            // 
            this.firmaListesiToolStripMenuItem.Name = "firmaListesiToolStripMenuItem";
            this.firmaListesiToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.firmaListesiToolStripMenuItem.Text = "Firma Listesi";
            this.firmaListesiToolStripMenuItem.Click += new System.EventHandler(this.firmaListesiToolStripMenuItem_Click);
            // 
            // faturaAlisListesiToolStripMenuItem
            // 
            this.faturaAlisListesiToolStripMenuItem.Name = "faturaAlisListesiToolStripMenuItem";
            this.faturaAlisListesiToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.faturaAlisListesiToolStripMenuItem.Text = "Fatura Alis Listesi";
            this.faturaAlisListesiToolStripMenuItem.Click += new System.EventHandler(this.faturaAlisListesiToolStripMenuItem_Click);
            // 
            // faturaSatısListesiToolStripMenuItem
            // 
            this.faturaSatısListesiToolStripMenuItem.Name = "faturaSatısListesiToolStripMenuItem";
            this.faturaSatısListesiToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.faturaSatısListesiToolStripMenuItem.Text = "Fatura Satıs Listesi";
            this.faturaSatısListesiToolStripMenuItem.Click += new System.EventHandler(this.faturaSatısListesiToolStripMenuItem_Click);
            // 
            // faturalarToolStripMenuItem
            // 
            this.faturalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alışToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.faturaAlışToolStripMenuItem});
            this.faturalarToolStripMenuItem.Name = "faturalarToolStripMenuItem";
            this.faturalarToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.faturalarToolStripMenuItem.Text = "Satış";
            // 
            // alışToolStripMenuItem
            // 
            this.alışToolStripMenuItem.Name = "alışToolStripMenuItem";
            this.alışToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.alışToolStripMenuItem.Text = "Masa Satış";
            this.alışToolStripMenuItem.Click += new System.EventHandler(this.alışToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.satışToolStripMenuItem.Text = "Fatura Satış";
            this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
            // 
            // faturaAlışToolStripMenuItem
            // 
            this.faturaAlışToolStripMenuItem.Name = "faturaAlışToolStripMenuItem";
            this.faturaAlışToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.faturaAlışToolStripMenuItem.Text = "Fatura Alış";
            this.faturaAlışToolStripMenuItem.Click += new System.EventHandler(this.faturaAlışToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokTakipToolStripMenuItem,
            this.karZararToolStripMenuItem,
            this.gelirGiderToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // stokTakipToolStripMenuItem
            // 
            this.stokTakipToolStripMenuItem.Name = "stokTakipToolStripMenuItem";
            this.stokTakipToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.stokTakipToolStripMenuItem.Text = "Stok Takip";
            this.stokTakipToolStripMenuItem.Click += new System.EventHandler(this.stokTakipToolStripMenuItem_Click);
            // 
            // karZararToolStripMenuItem
            // 
            this.karZararToolStripMenuItem.Name = "karZararToolStripMenuItem";
            this.karZararToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.karZararToolStripMenuItem.Text = "Kar Zarar";
            this.karZararToolStripMenuItem.Click += new System.EventHandler(this.karZararToolStripMenuItem_Click);
            // 
            // gelirGiderToolStripMenuItem
            // 
            this.gelirGiderToolStripMenuItem.Name = "gelirGiderToolStripMenuItem";
            this.gelirGiderToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.gelirGiderToolStripMenuItem.Text = "Gelir Gider";
            this.gelirGiderToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 143);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yusuf Özbek Cafe";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Cafe Otomasyonu";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriTanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünTanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaTanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaAlışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaAlisListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaSatısListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karZararToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

