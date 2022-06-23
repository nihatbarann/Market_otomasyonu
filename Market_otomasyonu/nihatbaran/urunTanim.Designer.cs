namespace nihatbaran
{
    partial class urunTanim
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
            this.btnExcelKaydet = new System.Windows.Forms.Button();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.uruntanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.market_otomasyonuDataSet = new nihatbaran.market_otomasyonuDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSonKayit = new System.Windows.Forms.Button();
            this.btnoncekiKayit = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSonrakiKayit = new System.Windows.Forms.Button();
            this.btnilkKayit = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazgeçF11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetF10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunsatisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunalisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satilanmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_tanimTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.urun_tanimTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlinanMiktar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uruntanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.txtAlinanMiktar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnExcelKaydet);
            this.panel1.Controls.Add(this.btnDuzelt);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSonKayit);
            this.panel1.Controls.Add(this.btnoncekiKayit);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnVazgec);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnSonrakiKayit);
            this.panel1.Controls.Add(this.btnilkKayit);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 189);
            this.panel1.TabIndex = 0;
            // 
            // btnExcelKaydet
            // 
            this.btnExcelKaydet.Location = new System.Drawing.Point(542, 145);
            this.btnExcelKaydet.Name = "btnExcelKaydet";
            this.btnExcelKaydet.Size = new System.Drawing.Size(103, 23);
            this.btnExcelKaydet.TabIndex = 22;
            this.btnExcelKaydet.Text = "Excele Yazdır";
            this.btnExcelKaydet.UseVisualStyleBackColor = true;
            this.btnExcelKaydet.Click += new System.EventHandler(this.btnExcelKaydet_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Location = new System.Drawing.Point(245, 163);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(75, 23);
            this.btnDuzelt.TabIndex = 21;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uruntanimBindingSource, "barkod", true));
            this.textBox4.Location = new System.Drawing.Point(126, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 20;
            // 
            // uruntanimBindingSource
            // 
            this.uruntanimBindingSource.DataMember = "urun_tanim";
            this.uruntanimBindingSource.DataSource = this.market_otomasyonuDataSet;
            // 
            // market_otomasyonuDataSet
            // 
            this.market_otomasyonuDataSet.DataSetName = "market_otomasyonuDataSet";
            this.market_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Barkod:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(635, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(132, 26);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(163, 22);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ada Göre Arama:";
            // 
            // btnSonKayit
            // 
            this.btnSonKayit.Location = new System.Drawing.Point(440, 163);
            this.btnSonKayit.Name = "btnSonKayit";
            this.btnSonKayit.Size = new System.Drawing.Size(75, 23);
            this.btnSonKayit.TabIndex = 17;
            this.btnSonKayit.Text = "Son Kayıt";
            this.btnSonKayit.UseVisualStyleBackColor = true;
            this.btnSonKayit.Click += new System.EventHandler(this.btnSonKayit_Click);
            // 
            // btnoncekiKayit
            // 
            this.btnoncekiKayit.Location = new System.Drawing.Point(151, 160);
            this.btnoncekiKayit.Name = "btnoncekiKayit";
            this.btnoncekiKayit.Size = new System.Drawing.Size(75, 23);
            this.btnoncekiKayit.TabIndex = 15;
            this.btnoncekiKayit.Text = "<<<";
            this.btnoncekiKayit.UseVisualStyleBackColor = true;
            this.btnoncekiKayit.Click += new System.EventHandler(this.btnoncekiKayit_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(336, 131);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(245, 131);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(151, 131);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 12;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(57, 131);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 11;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(440, 131);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSonrakiKayit
            // 
            this.btnSonrakiKayit.Location = new System.Drawing.Point(336, 166);
            this.btnSonrakiKayit.Name = "btnSonrakiKayit";
            this.btnSonrakiKayit.Size = new System.Drawing.Size(75, 23);
            this.btnSonrakiKayit.TabIndex = 9;
            this.btnSonrakiKayit.Text = ">>>";
            this.btnSonrakiKayit.UseVisualStyleBackColor = true;
            this.btnSonrakiKayit.Click += new System.EventHandler(this.btnSonrakiKayit_Click);
            // 
            // btnilkKayit
            // 
            this.btnilkKayit.Location = new System.Drawing.Point(57, 163);
            this.btnilkKayit.Name = "btnilkKayit";
            this.btnilkKayit.Size = new System.Drawing.Size(75, 23);
            this.btnilkKayit.TabIndex = 8;
            this.btnilkKayit.Text = "İlk Kayıt";
            this.btnilkKayit.UseVisualStyleBackColor = true;
            this.btnilkKayit.Click += new System.EventHandler(this.btnilkKayit_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uruntanimBindingSource, "urun_alis", true));
            this.textBox3.Location = new System.Drawing.Point(390, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uruntanimBindingSource, "urun_satis", true));
            this.textBox2.Location = new System.Drawing.Point(390, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uruntanimBindingSource, "urun_ad", true));
            this.textBox1.Location = new System.Drawing.Point(126, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Satış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Alış Fiyatı:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniF5ToolStripMenuItem,
            this.vazgeçF11ToolStripMenuItem,
            this.silF1ToolStripMenuItem,
            this.kapatESCToolStripMenuItem,
            this.kaydetF10ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 124);
            // 
            // yeniF5ToolStripMenuItem
            // 
            this.yeniF5ToolStripMenuItem.Name = "yeniF5ToolStripMenuItem";
            this.yeniF5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.yeniF5ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.yeniF5ToolStripMenuItem.Text = "Yeni (F5)";
            this.yeniF5ToolStripMenuItem.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // vazgeçF11ToolStripMenuItem
            // 
            this.vazgeçF11ToolStripMenuItem.Name = "vazgeçF11ToolStripMenuItem";
            this.vazgeçF11ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.vazgeçF11ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.vazgeçF11ToolStripMenuItem.Text = "Vazgeç(F11)";
            this.vazgeçF11ToolStripMenuItem.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // silF1ToolStripMenuItem
            // 
            this.silF1ToolStripMenuItem.Name = "silF1ToolStripMenuItem";
            this.silF1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.silF1ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.silF1ToolStripMenuItem.Text = "Sil(F1)";
            this.silF1ToolStripMenuItem.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // kapatESCToolStripMenuItem
            // 
            this.kapatESCToolStripMenuItem.Name = "kapatESCToolStripMenuItem";
            this.kapatESCToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.kapatESCToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.kapatESCToolStripMenuItem.Text = "Kapat(ESC)";
            this.kapatESCToolStripMenuItem.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // kaydetF10ToolStripMenuItem
            // 
            this.kaydetF10ToolStripMenuItem.Name = "kaydetF10ToolStripMenuItem";
            this.kaydetF10ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.kaydetF10ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.kaydetF10ToolStripMenuItem.Text = "Kaydet(F10)";
            this.kaydetF10ToolStripMenuItem.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkod,
            this.uidDataGridViewTextBoxColumn,
            this.barkodDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.urunadDataGridViewTextBoxColumn,
            this.urunsatisDataGridViewTextBoxColumn,
            this.urunalisDataGridViewTextBoxColumn,
            this.satilanmiktarDataGridViewTextBoxColumn,
            this.alinanmiktarDataGridViewTextBoxColumn,
            this.kalanmiktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uruntanimBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1313, 261);
            this.dataGridView1.TabIndex = 1;
            // 
            // barkod
            // 
            this.barkod.DataPropertyName = "barkod";
            this.barkod.HeaderText = "barkod";
            this.barkod.MinimumWidth = 6;
            this.barkod.Name = "barkod";
            this.barkod.Width = 125;
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "uid";
            this.uidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            this.uidDataGridViewTextBoxColumn.ReadOnly = true;
            this.uidDataGridViewTextBoxColumn.Width = 125;
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "barkod";
            this.barkodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            this.barkodDataGridViewTextBoxColumn.Width = 125;
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "kdv";
            this.kdvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            this.kdvDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunadDataGridViewTextBoxColumn
            // 
            this.urunadDataGridViewTextBoxColumn.DataPropertyName = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.HeaderText = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadDataGridViewTextBoxColumn.Name = "urunadDataGridViewTextBoxColumn";
            this.urunadDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunsatisDataGridViewTextBoxColumn
            // 
            this.urunsatisDataGridViewTextBoxColumn.DataPropertyName = "urun_satis";
            this.urunsatisDataGridViewTextBoxColumn.HeaderText = "urun_satis";
            this.urunsatisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunsatisDataGridViewTextBoxColumn.Name = "urunsatisDataGridViewTextBoxColumn";
            this.urunsatisDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunalisDataGridViewTextBoxColumn
            // 
            this.urunalisDataGridViewTextBoxColumn.DataPropertyName = "urun_alis";
            this.urunalisDataGridViewTextBoxColumn.HeaderText = "urun_alis";
            this.urunalisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunalisDataGridViewTextBoxColumn.Name = "urunalisDataGridViewTextBoxColumn";
            this.urunalisDataGridViewTextBoxColumn.Width = 125;
            // 
            // satilanmiktarDataGridViewTextBoxColumn
            // 
            this.satilanmiktarDataGridViewTextBoxColumn.DataPropertyName = "satilan_miktar";
            this.satilanmiktarDataGridViewTextBoxColumn.HeaderText = "satilan_miktar";
            this.satilanmiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satilanmiktarDataGridViewTextBoxColumn.Name = "satilanmiktarDataGridViewTextBoxColumn";
            this.satilanmiktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // alinanmiktarDataGridViewTextBoxColumn
            // 
            this.alinanmiktarDataGridViewTextBoxColumn.DataPropertyName = "alinan_miktar";
            this.alinanmiktarDataGridViewTextBoxColumn.HeaderText = "alinan_miktar";
            this.alinanmiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alinanmiktarDataGridViewTextBoxColumn.Name = "alinanmiktarDataGridViewTextBoxColumn";
            this.alinanmiktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // kalanmiktarDataGridViewTextBoxColumn
            // 
            this.kalanmiktarDataGridViewTextBoxColumn.DataPropertyName = "Kalanmiktar";
            this.kalanmiktarDataGridViewTextBoxColumn.HeaderText = "Kalanmiktar";
            this.kalanmiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalanmiktarDataGridViewTextBoxColumn.Name = "kalanmiktarDataGridViewTextBoxColumn";
            this.kalanmiktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.kalanmiktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // urun_tanimTableAdapter
            // 
            this.urun_tanimTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Alınan Miktar:";
            // 
            // txtAlinanMiktar
            // 
            this.txtAlinanMiktar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uruntanimBindingSource, "alinan_miktar", true));
            this.txtAlinanMiktar.Location = new System.Drawing.Point(390, 87);
            this.txtAlinanMiktar.Name = "txtAlinanMiktar";
            this.txtAlinanMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtAlinanMiktar.TabIndex = 24;
            // 
            // urunTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "urunTanim";
            this.Text = "urunTanim";
            this.Load += new System.EventHandler(this.urunTanim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uruntanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private market_otomasyonuDataSet market_otomasyonuDataSet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnoncekiKayit;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSonrakiKayit;
        private System.Windows.Forms.Button btnilkKayit;
        private System.Windows.Forms.Button btnSonKayit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçF11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetF10ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Button btnExcelKaydet;
        private System.Windows.Forms.BindingSource uruntanimBindingSource;
        private market_otomasyonuDataSetTableAdapters.urun_tanimTableAdapter urun_tanimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunsatisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunalisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satilanmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinanmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAlinanMiktar;
        private System.Windows.Forms.Label label6;
    }
}