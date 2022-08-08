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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ürünTanımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTanımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaTanımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ürünListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaAlışListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaSatışListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masaSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaSatışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokTakipToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.karZararToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(22, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 98);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tanımlar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünTanımToolStripMenuItem1,
            this.müşteriTanımToolStripMenuItem1,
            this.firmaTanımToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 76);
            // 
            // ürünTanımToolStripMenuItem1
            // 
            this.ürünTanımToolStripMenuItem1.Name = "ürünTanımToolStripMenuItem1";
            this.ürünTanımToolStripMenuItem1.Size = new System.Drawing.Size(170, 24);
            this.ürünTanımToolStripMenuItem1.Text = "Ürün Tanım";
            this.ürünTanımToolStripMenuItem1.Click += new System.EventHandler(this.ürünTanımToolStripMenuItem1_Click);
            // 
            // müşteriTanımToolStripMenuItem1
            // 
            this.müşteriTanımToolStripMenuItem1.Name = "müşteriTanımToolStripMenuItem1";
            this.müşteriTanımToolStripMenuItem1.Size = new System.Drawing.Size(170, 24);
            this.müşteriTanımToolStripMenuItem1.Text = "Müşteri Tanım";
            this.müşteriTanımToolStripMenuItem1.Click += new System.EventHandler(this.müşteriTanımToolStripMenuItem1_Click);
            // 
            // firmaTanımToolStripMenuItem1
            // 
            this.firmaTanımToolStripMenuItem1.Name = "firmaTanımToolStripMenuItem1";
            this.firmaTanımToolStripMenuItem1.Size = new System.Drawing.Size(170, 24);
            this.firmaTanımToolStripMenuItem1.Text = "Firma Tanım";
            this.firmaTanımToolStripMenuItem1.Click += new System.EventHandler(this.firmaTanımToolStripMenuItem1_Click);
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip2;
            this.button2.Location = new System.Drawing.Point(211, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 98);
            this.button2.TabIndex = 2;
            this.button2.Text = "Listeler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünListesiToolStripMenuItem1,
            this.müşteriListesiToolStripMenuItem1,
            this.faturaAlışListesiToolStripMenuItem,
            this.faturaSatışListesiToolStripMenuItem,
            this.firmaListesiToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(198, 124);
            // 
            // ürünListesiToolStripMenuItem1
            // 
            this.ürünListesiToolStripMenuItem1.Name = "ürünListesiToolStripMenuItem1";
            this.ürünListesiToolStripMenuItem1.Size = new System.Drawing.Size(197, 24);
            this.ürünListesiToolStripMenuItem1.Text = "Ürün Listesi";
            this.ürünListesiToolStripMenuItem1.Click += new System.EventHandler(this.ürünListesiToolStripMenuItem1_Click);
            // 
            // müşteriListesiToolStripMenuItem1
            // 
            this.müşteriListesiToolStripMenuItem1.Name = "müşteriListesiToolStripMenuItem1";
            this.müşteriListesiToolStripMenuItem1.Size = new System.Drawing.Size(197, 24);
            this.müşteriListesiToolStripMenuItem1.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem1.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem1_Click);
            // 
            // faturaAlışListesiToolStripMenuItem
            // 
            this.faturaAlışListesiToolStripMenuItem.Name = "faturaAlışListesiToolStripMenuItem";
            this.faturaAlışListesiToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.faturaAlışListesiToolStripMenuItem.Text = "Fatura Alış Listesi";
            this.faturaAlışListesiToolStripMenuItem.Click += new System.EventHandler(this.faturaAlışListesiToolStripMenuItem_Click);
            // 
            // faturaSatışListesiToolStripMenuItem
            // 
            this.faturaSatışListesiToolStripMenuItem.Name = "faturaSatışListesiToolStripMenuItem";
            this.faturaSatışListesiToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.faturaSatışListesiToolStripMenuItem.Text = "Fatura Satış Listesi";
            this.faturaSatışListesiToolStripMenuItem.Click += new System.EventHandler(this.faturaSatışListesiToolStripMenuItem_Click);
            // 
            // firmaListesiToolStripMenuItem1
            // 
            this.firmaListesiToolStripMenuItem1.Name = "firmaListesiToolStripMenuItem1";
            this.firmaListesiToolStripMenuItem1.Size = new System.Drawing.Size(197, 24);
            this.firmaListesiToolStripMenuItem1.Text = "Firma Listesi";
            this.firmaListesiToolStripMenuItem1.Click += new System.EventHandler(this.firmaListesiToolStripMenuItem1_Click);
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.contextMenuStrip3;
            this.button3.Location = new System.Drawing.Point(411, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 98);
            this.button3.TabIndex = 3;
            this.button3.Text = "Satış-Alış";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaSatışToolStripMenuItem,
            this.faturaSatışToolStripMenuItem,
            this.faturaSatışToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(211, 104);
            // 
            // masaSatışToolStripMenuItem
            // 
            this.masaSatışToolStripMenuItem.Name = "masaSatışToolStripMenuItem";
            this.masaSatışToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.masaSatışToolStripMenuItem.Text = "Masa Satış";
            this.masaSatışToolStripMenuItem.Click += new System.EventHandler(this.masaSatışToolStripMenuItem_Click);
            // 
            // faturaSatışToolStripMenuItem
            // 
            this.faturaSatışToolStripMenuItem.Name = "faturaSatışToolStripMenuItem";
            this.faturaSatışToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.faturaSatışToolStripMenuItem.Text = "Fatura Satış";
            this.faturaSatışToolStripMenuItem.Click += new System.EventHandler(this.faturaSatışToolStripMenuItem_Click);
            // 
            // faturaSatışToolStripMenuItem1
            // 
            this.faturaSatışToolStripMenuItem1.Name = "faturaSatışToolStripMenuItem1";
            this.faturaSatışToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.faturaSatışToolStripMenuItem1.Text = "Fatura Alış";
            this.faturaSatışToolStripMenuItem1.Click += new System.EventHandler(this.faturaSatışToolStripMenuItem1_Click);
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.contextMenuStrip4;
            this.button4.Location = new System.Drawing.Point(622, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 98);
            this.button4.TabIndex = 4;
            this.button4.Text = "Raporlama";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokTakipToolStripMenuItem1,
            this.karZararToolStripMenuItem1,
            this.gelirGiderToolStripMenuItem1});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(150, 76);
            // 
            // stokTakipToolStripMenuItem1
            // 
            this.stokTakipToolStripMenuItem1.Name = "stokTakipToolStripMenuItem1";
            this.stokTakipToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.stokTakipToolStripMenuItem1.Text = "Stok Takip";
            this.stokTakipToolStripMenuItem1.Click += new System.EventHandler(this.stokTakipToolStripMenuItem1_Click);
            // 
            // karZararToolStripMenuItem1
            // 
            this.karZararToolStripMenuItem1.Name = "karZararToolStripMenuItem1";
            this.karZararToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.karZararToolStripMenuItem1.Text = "Kar Zarar";
            this.karZararToolStripMenuItem1.Click += new System.EventHandler(this.karZararToolStripMenuItem1_Click);
            // 
            // gelirGiderToolStripMenuItem1
            // 
            this.gelirGiderToolStripMenuItem1.Name = "gelirGiderToolStripMenuItem1";
            this.gelirGiderToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.gelirGiderToolStripMenuItem1.Text = "Gelir Gider";
            this.gelirGiderToolStripMenuItem1.Click += new System.EventHandler(this.gelirGiderToolStripMenuItem1_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AnaForm";
            this.Text = "Cafe Otomasyonu";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünTanımToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşteriTanımToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem firmaTanımToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faturaAlışListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaSatışListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaListesiToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem masaSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaSatışToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem stokTakipToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem karZararToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderToolStripMenuItem1;
    }
}

