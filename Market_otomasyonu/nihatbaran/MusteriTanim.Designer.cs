namespace nihatbaran
{
    partial class MusteriTanim
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.rdbtnSoyadaGore = new System.Windows.Forms.RadioButton();
            this.rdbtnAdaGore = new System.Windows.Forms.RadioButton();
            this.btnOnceKayit = new System.Windows.Forms.Button();
            this.btnSonrakiKayit = new System.Windows.Forms.Button();
            this.btnSonKayit = new System.Windows.Forms.Button();
            this.btnilkKayit = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.musteritanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.market_otomasyonuDataSet = new nihatbaran.market_otomasyonuDataSet();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_tanimTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.musteri_tanimTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazgeçF11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzeltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetF10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteritanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnOnceKayit);
            this.panel1.Controls.Add(this.btnSonrakiKayit);
            this.panel1.Controls.Add(this.btnSonKayit);
            this.panel1.Controls.Add(this.btnilkKayit);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnDuzelt);
            this.panel1.Controls.Add(this.btnVazgec);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 230);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Controls.Add(this.rdbtnSoyadaGore);
            this.groupBox1.Controls.Add(this.rdbtnAdaGore);
            this.groupBox1.Location = new System.Drawing.Point(498, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 118);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(163, 28);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(174, 22);
            this.txtArama.TabIndex = 2;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // rdbtnSoyadaGore
            // 
            this.rdbtnSoyadaGore.AutoSize = true;
            this.rdbtnSoyadaGore.Location = new System.Drawing.Point(6, 47);
            this.rdbtnSoyadaGore.Name = "rdbtnSoyadaGore";
            this.rdbtnSoyadaGore.Size = new System.Drawing.Size(152, 20);
            this.rdbtnSoyadaGore.TabIndex = 1;
            this.rdbtnSoyadaGore.TabStop = true;
            this.rdbtnSoyadaGore.Text = "Soyada Göre Arama";
            this.rdbtnSoyadaGore.UseVisualStyleBackColor = true;
            // 
            // rdbtnAdaGore
            // 
            this.rdbtnAdaGore.AutoSize = true;
            this.rdbtnAdaGore.Location = new System.Drawing.Point(6, 21);
            this.rdbtnAdaGore.Name = "rdbtnAdaGore";
            this.rdbtnAdaGore.Size = new System.Drawing.Size(129, 20);
            this.rdbtnAdaGore.TabIndex = 0;
            this.rdbtnAdaGore.TabStop = true;
            this.rdbtnAdaGore.Text = "Ada Göre Arama";
            this.rdbtnAdaGore.UseVisualStyleBackColor = true;
            // 
            // btnOnceKayit
            // 
            this.btnOnceKayit.Location = new System.Drawing.Point(207, 190);
            this.btnOnceKayit.Name = "btnOnceKayit";
            this.btnOnceKayit.Size = new System.Drawing.Size(75, 23);
            this.btnOnceKayit.TabIndex = 18;
            this.btnOnceKayit.Text = "<<<";
            this.btnOnceKayit.UseVisualStyleBackColor = true;
            this.btnOnceKayit.Click += new System.EventHandler(this.btnOnceKayit_Click);
            // 
            // btnSonrakiKayit
            // 
            this.btnSonrakiKayit.Location = new System.Drawing.Point(302, 190);
            this.btnSonrakiKayit.Name = "btnSonrakiKayit";
            this.btnSonrakiKayit.Size = new System.Drawing.Size(75, 23);
            this.btnSonrakiKayit.TabIndex = 17;
            this.btnSonrakiKayit.Text = ">>>";
            this.btnSonrakiKayit.UseVisualStyleBackColor = true;
            this.btnSonrakiKayit.Click += new System.EventHandler(this.btnSonrakiKayit_Click);
            // 
            // btnSonKayit
            // 
            this.btnSonKayit.Location = new System.Drawing.Point(396, 190);
            this.btnSonKayit.Name = "btnSonKayit";
            this.btnSonKayit.Size = new System.Drawing.Size(75, 23);
            this.btnSonKayit.TabIndex = 16;
            this.btnSonKayit.Text = "Son Kayıt";
            this.btnSonKayit.UseVisualStyleBackColor = true;
            this.btnSonKayit.Click += new System.EventHandler(this.btnSonKayit_Click);
            // 
            // btnilkKayit
            // 
            this.btnilkKayit.Location = new System.Drawing.Point(113, 190);
            this.btnilkKayit.Name = "btnilkKayit";
            this.btnilkKayit.Size = new System.Drawing.Size(75, 23);
            this.btnilkKayit.TabIndex = 15;
            this.btnilkKayit.Text = "İlk Kayıt";
            this.btnilkKayit.UseVisualStyleBackColor = true;
            this.btnilkKayit.Click += new System.EventHandler(this.btnilkKayit_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musteritanimBindingSource, "tel", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(84, 77);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 14;
            // 
            // musteritanimBindingSource
            // 
            this.musteritanimBindingSource.DataMember = "musteri_tanim";
            this.musteritanimBindingSource.DataSource = this.market_otomasyonuDataSet;
            // 
            // market_otomasyonuDataSet
            // 
            this.market_otomasyonuDataSet.DataSetName = "market_otomasyonuDataSet";
            this.market_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(487, 151);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(207, 151);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(302, 151);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Location = new System.Drawing.Point(396, 151);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(75, 23);
            this.btnDuzelt.TabIndex = 10;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(113, 151);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 9;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(19, 151);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 8;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musteritanimBindingSource, "adres", true));
            this.txtAdres.Location = new System.Drawing.Point(288, 18);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(173, 92);
            this.txtAdres.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musteritanimBindingSource, "soyad", true));
            this.txtSoyad.Location = new System.Drawing.Point(84, 49);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musteritanimBindingSource, "ad", true));
            this.txtAd.Location = new System.Drawing.Point(84, 21);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteritanimBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "mid";
            this.midDataGridViewTextBoxColumn.HeaderText = "mid";
            this.midDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            this.midDataGridViewTextBoxColumn.ReadOnly = true;
            this.midDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteri_tanimTableAdapter
            // 
            this.musteri_tanimTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniF5ToolStripMenuItem,
            this.vazgeçF11ToolStripMenuItem,
            this.silF1ToolStripMenuItem,
            this.kapatESCToolStripMenuItem,
            this.düzeltF4ToolStripMenuItem,
            this.kaydetF10ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 148);
            // 
            // yeniF5ToolStripMenuItem
            // 
            this.yeniF5ToolStripMenuItem.Name = "yeniF5ToolStripMenuItem";
            this.yeniF5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.yeniF5ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.yeniF5ToolStripMenuItem.Text = "Yeni (F5)";
            this.yeniF5ToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
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
            // düzeltF4ToolStripMenuItem
            // 
            this.düzeltF4ToolStripMenuItem.Name = "düzeltF4ToolStripMenuItem";
            this.düzeltF4ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.düzeltF4ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.düzeltF4ToolStripMenuItem.Text = "Düzelt(F4)";
            // 
            // kaydetF10ToolStripMenuItem
            // 
            this.kaydetF10ToolStripMenuItem.Name = "kaydetF10ToolStripMenuItem";
            this.kaydetF10ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.kaydetF10ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.kaydetF10ToolStripMenuItem.Text = "Kaydet(F10)";
            this.kaydetF10ToolStripMenuItem.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(623, 151);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 62);
            this.btnExcel.TabIndex = 21;
            this.btnExcel.Text = "Exccele Yazdır";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // MusteriTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "MusteriTanim";
            this.Text = "MusteriTanim";
            this.Load += new System.EventHandler(this.MusteriTanim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteritanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private market_otomasyonuDataSet market_otomasyonuDataSet;
        private System.Windows.Forms.BindingSource musteritanimBindingSource;
        private market_otomasyonuDataSetTableAdapters.musteri_tanimTableAdapter musteri_tanimTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnceKayit;
        private System.Windows.Forms.Button btnSonrakiKayit;
        private System.Windows.Forms.Button btnSonKayit;
        private System.Windows.Forms.Button btnilkKayit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.RadioButton rdbtnSoyadaGore;
        private System.Windows.Forms.RadioButton rdbtnAdaGore;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçF11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzeltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetF10ToolStripMenuItem;
        private System.Windows.Forms.Button btnExcel;
    }
}