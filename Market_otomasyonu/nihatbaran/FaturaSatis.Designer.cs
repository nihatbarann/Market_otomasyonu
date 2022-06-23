namespace nihatbaran
{
    partial class FaturaSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dTimeFatura = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txturunAd = new System.Windows.Forms.TextBox();
            this.txturunEkle = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblToplamKdv = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnDüzelt = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.satırSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazgeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaDetayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.market_otomasyonuDataSet = new nihatbaran.market_otomasyonuDataSet();
            this.faturaSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satis_DetayTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.Satis_DetayTableAdapter();
            this.faturaSatisTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.FaturaSatisTableAdapter();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaSatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.dTimeFatura);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtSeriNo);
            this.panel1.Controls.Add(this.txtFaturaNo);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 153);
            this.panel1.TabIndex = 0;
            // 
            // dTimeFatura
            // 
            this.dTimeFatura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faturaSatisBindingSource, "faturaTarih", true));
            this.dTimeFatura.Location = new System.Drawing.Point(508, 83);
            this.dTimeFatura.Name = "dTimeFatura";
            this.dTimeFatura.Size = new System.Drawing.Size(200, 22);
            this.dTimeFatura.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faturaSatisBindingSource, "soyadı", true));
            this.txtSoyad.Location = new System.Drawing.Point(159, 85);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faturaSatisBindingSource, "faturaNo", true));
            this.txtSeriNo.Location = new System.Drawing.Point(488, 26);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(100, 22);
            this.txtSeriNo.TabIndex = 7;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faturaSatisBindingSource, "faturaNo", true));
            this.txtFaturaNo.Location = new System.Drawing.Point(697, 26);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(100, 22);
            this.txtFaturaNo.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faturaSatisBindingSource, "Ad", true));
            this.txtAd.Location = new System.Drawing.Point(159, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fatura No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtFiyat);
            this.panel2.Controls.Add(this.txtMiktar);
            this.panel2.Controls.Add(this.txturunAd);
            this.panel2.Controls.Add(this.txturunEkle);
            this.panel2.Controls.Add(this.txtTutar);
            this.panel2.Controls.Add(this.txtKdv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 73);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(824, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Ürün Ekle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(657, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tutar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "KDV(%18)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Miktar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ürün Adı";
            // 
            // txtFiyat
            // 
            this.txtFiyat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satisDetayBindingSource, "fiyat", true));
            this.txtFiyat.Location = new System.Drawing.Point(208, 45);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 5;
            // 
            // txtMiktar
            // 
            this.txtMiktar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satisDetayBindingSource, "miktar", true));
            this.txtMiktar.Location = new System.Drawing.Point(344, 45);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtMiktar.TabIndex = 4;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            this.txtMiktar.Leave += new System.EventHandler(this.txtMiktar_Leave);
            // 
            // txturunAd
            // 
            this.txturunAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satisDetayBindingSource, "urun_ad", true));
            this.txturunAd.Location = new System.Drawing.Point(74, 45);
            this.txturunAd.Name = "txturunAd";
            this.txturunAd.Size = new System.Drawing.Size(100, 22);
            this.txturunAd.TabIndex = 3;
            // 
            // txturunEkle
            // 
            this.txturunEkle.Location = new System.Drawing.Point(797, 45);
            this.txturunEkle.Name = "txturunEkle";
            this.txturunEkle.Size = new System.Drawing.Size(100, 22);
            this.txturunEkle.TabIndex = 2;
            // 
            // txtTutar
            // 
            this.txtTutar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satisDetayBindingSource, "tutar", true));
            this.txtTutar.Location = new System.Drawing.Point(639, 45);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 1;
            // 
            // txtKdv
            // 
            this.txtKdv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satisDetayBindingSource, "kdv", true));
            this.txtKdv.Location = new System.Drawing.Point(488, 45);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(100, 22);
            this.txtKdv.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblToplamKdv);
            this.panel3.Controls.Add(this.lblAraToplam);
            this.panel3.Controls.Add(this.lblGenelToplam);
            this.panel3.Controls.Add(this.btnKaydet);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Controls.Add(this.btnVazgec);
            this.panel3.Controls.Add(this.btnDüzelt);
            this.panel3.Controls.Add(this.btnYeni);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 662);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1251, 100);
            this.panel3.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(783, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Genel Toplam:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(798, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Ara Toplam:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(842, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "KDV:";
            // 
            // lblToplamKdv
            // 
            this.lblToplamKdv.AutoSize = true;
            this.lblToplamKdv.Location = new System.Drawing.Point(885, 12);
            this.lblToplamKdv.Name = "lblToplamKdv";
            this.lblToplamKdv.Size = new System.Drawing.Size(51, 16);
            this.lblToplamKdv.TabIndex = 7;
            this.lblToplamKdv.Text = "label14";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Location = new System.Drawing.Point(885, 35);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(51, 16);
            this.lblAraToplam.TabIndex = 6;
            this.lblAraToplam.Text = "label13";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(885, 56);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(51, 16);
            this.lblGenelToplam.TabIndex = 5;
            this.lblGenelToplam.Text = "label12";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(680, 28);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet(F10)";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(577, 28);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil(F5)";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(467, 28);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(88, 23);
            this.btnVazgec.TabIndex = 2;
            this.btnVazgec.Text = "Vazgeç(F4)";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnDüzelt
            // 
            this.btnDüzelt.Location = new System.Drawing.Point(369, 28);
            this.btnDüzelt.Name = "btnDüzelt";
            this.btnDüzelt.Size = new System.Drawing.Size(75, 23);
            this.btnDüzelt.TabIndex = 1;
            this.btnDüzelt.Text = "Düzelt(F2)";
            this.btnDüzelt.UseVisualStyleBackColor = true;
            this.btnDüzelt.Click += new System.EventHandler(this.btnDüzelt_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(269, 28);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni(F1)";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaDetayIDDataGridViewTextBoxColumn,
            this.faturaidDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn,
            this.urunadDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.DataSource = this.satisDetayBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 436);
            this.dataGridView1.TabIndex = 3;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satırSilToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(129, 28);
            // 
            // satırSilToolStripMenuItem
            // 
            this.satırSilToolStripMenuItem.Name = "satırSilToolStripMenuItem";
            this.satırSilToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.satırSilToolStripMenuItem.Text = "Satır Sil";
            this.satırSilToolStripMenuItem.Click += new System.EventHandler(this.satırSilToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.düzeltToolStripMenuItem,
            this.vazgeçToolStripMenuItem,
            this.silToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.müşteriListesiF8ToolStripMenuItem,
            this.ürünListesiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 200);
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // düzeltToolStripMenuItem
            // 
            this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
            this.düzeltToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.düzeltToolStripMenuItem.Text = "Düzelt";
            this.düzeltToolStripMenuItem.Click += new System.EventHandler(this.btnDüzelt_Click);
            // 
            // vazgeçToolStripMenuItem
            // 
            this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
            this.vazgeçToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.vazgeçToolStripMenuItem.Text = "Vazgeç";
            this.vazgeçToolStripMenuItem.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.silToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.btnDüzelt_Click);
            // 
            // müşteriListesiF8ToolStripMenuItem
            // 
            this.müşteriListesiF8ToolStripMenuItem.Name = "müşteriListesiF8ToolStripMenuItem";
            this.müşteriListesiF8ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.müşteriListesiF8ToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.müşteriListesiF8ToolStripMenuItem.Text = "Müşteri Listesi(F8))";
            this.müşteriListesiF8ToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiF8ToolStripMenuItem_Click);
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi ";
            this.ürünListesiToolStripMenuItem.Click += new System.EventHandler(this.ürünListesiToolStripMenuItem_Click);
            // 
            // faturaDetayIDDataGridViewTextBoxColumn
            // 
            this.faturaDetayIDDataGridViewTextBoxColumn.DataPropertyName = "faturaDetayID";
            this.faturaDetayIDDataGridViewTextBoxColumn.HeaderText = "faturaDetayID";
            this.faturaDetayIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaDetayIDDataGridViewTextBoxColumn.Name = "faturaDetayIDDataGridViewTextBoxColumn";
            this.faturaDetayIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.faturaDetayIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaidDataGridViewTextBoxColumn
            // 
            this.faturaidDataGridViewTextBoxColumn.DataPropertyName = "Fatura_id";
            this.faturaidDataGridViewTextBoxColumn.HeaderText = "Fatura_id";
            this.faturaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaidDataGridViewTextBoxColumn.Name = "faturaidDataGridViewTextBoxColumn";
            this.faturaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "uid";
            this.uidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            this.uidDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunadDataGridViewTextBoxColumn
            // 
            this.urunadDataGridViewTextBoxColumn.DataPropertyName = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.HeaderText = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadDataGridViewTextBoxColumn.Name = "urunadDataGridViewTextBoxColumn";
            this.urunadDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "miktar";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "kdv";
            this.kdvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            this.kdvDataGridViewTextBoxColumn.Width = 125;
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "tutar";
            this.tutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            this.tutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // satisDetayBindingSource
            // 
            this.satisDetayBindingSource.DataMember = "Satis_Detay";
            this.satisDetayBindingSource.DataSource = this.market_otomasyonuDataSet;
            // 
            // market_otomasyonuDataSet
            // 
            this.market_otomasyonuDataSet.DataSetName = "market_otomasyonuDataSet";
            this.market_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturaSatisBindingSource
            // 
            this.faturaSatisBindingSource.DataMember = "FaturaSatis";
            this.faturaSatisBindingSource.DataSource = this.market_otomasyonuDataSet;
            // 
            // satis_DetayTableAdapter
            // 
            this.satis_DetayTableAdapter.ClearBeforeFill = true;
            // 
            // faturaSatisTableAdapter
            // 
            this.faturaSatisTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip1";
            this.contextMenuStrip3.Size = new System.Drawing.Size(129, 28);
            // 
            // FaturaSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 762);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FaturaSatis";
            this.Text = "FaturaSatis";
            this.Load += new System.EventHandler(this.FaturaSatis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.satisDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaSatisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private market_otomasyonuDataSet market_otomasyonuDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource satisDetayBindingSource;
        private market_otomasyonuDataSetTableAdapters.Satis_DetayTableAdapter satis_DetayTableAdapter;
        private System.Windows.Forms.DateTimePicker dTimeFatura;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaDetayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txturunAd;
        private System.Windows.Forms.TextBox txturunEkle;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnDüzelt;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiF8ToolStripMenuItem;
        private System.Windows.Forms.BindingSource faturaSatisBindingSource;
        private market_otomasyonuDataSetTableAdapters.FaturaSatisTableAdapter faturaSatisTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem satırSilToolStripMenuItem;
        private System.Windows.Forms.Label lblToplamKdv;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    }
}