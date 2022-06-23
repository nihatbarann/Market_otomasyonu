namespace nihatbaran
{
    partial class FirmaTanim
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.mTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.firmatanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.market_otomasyonuDataSet = new nihatbaran.market_otomasyonuDataSet();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMasaSayısı = new System.Windows.Forms.TextBox();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firma_tanimTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.Firma_tanimTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazgeçF11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetF10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmatanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnVazgec);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Controls.Add(this.mTxtTel);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.txtMasaSayısı);
            this.panel1.Controls.Add(this.txtUnvan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 157);
            this.panel1.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(417, 119);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(336, 119);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(255, 119);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(174, 119);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 9;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(90, 119);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 8;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // mTxtTel
            // 
            this.mTxtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmatanimBindingSource, "tel", true));
            this.mTxtTel.Location = new System.Drawing.Point(134, 39);
            this.mTxtTel.Mask = "(999) 000-0000";
            this.mTxtTel.Name = "mTxtTel";
            this.mTxtTel.Size = new System.Drawing.Size(100, 22);
            this.mTxtTel.TabIndex = 7;
            // 
            // firmatanimBindingSource
            // 
            this.firmatanimBindingSource.DataMember = "Firma_tanim";
            this.firmatanimBindingSource.DataSource = this.market_otomasyonuDataSet;
            // 
            // market_otomasyonuDataSet
            // 
            this.market_otomasyonuDataSet.DataSetName = "market_otomasyonuDataSet";
            this.market_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAdres
            // 
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmatanimBindingSource, "adres", true));
            this.txtAdres.Location = new System.Drawing.Point(459, 35);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(188, 52);
            this.txtAdres.TabIndex = 6;
            // 
            // txtMasaSayısı
            // 
            this.txtMasaSayısı.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmatanimBindingSource, "masa_sayisi", true));
            this.txtMasaSayısı.Location = new System.Drawing.Point(459, 3);
            this.txtMasaSayısı.Name = "txtMasaSayısı";
            this.txtMasaSayısı.Size = new System.Drawing.Size(100, 22);
            this.txtMasaSayısı.TabIndex = 5;
            // 
            // txtUnvan
            // 
            this.txtUnvan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmatanimBindingSource, "unvan", true));
            this.txtUnvan.Location = new System.Drawing.Point(134, 9);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(100, 22);
            this.txtUnvan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masa Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unvan:";
            // 
            // firma_tanimTableAdapter
            // 
            this.firma_tanimTableAdapter.ClearBeforeFill = true;
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
            this.kapatESCToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // kaydetF10ToolStripMenuItem
            // 
            this.kaydetF10ToolStripMenuItem.Name = "kaydetF10ToolStripMenuItem";
            this.kaydetF10ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.kaydetF10ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.kaydetF10ToolStripMenuItem.Text = "Kaydet(F10)";
            this.kaydetF10ToolStripMenuItem.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FirmaTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 152);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Name = "FirmaTanim";
            this.Text = "FirmaTanim";
            this.Load += new System.EventHandler(this.FirmaTanim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmatanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private market_otomasyonuDataSet market_otomasyonuDataSet;
        private System.Windows.Forms.BindingSource firmatanimBindingSource;
        private market_otomasyonuDataSetTableAdapters.Firma_tanimTableAdapter firma_tanimTableAdapter;
        private System.Windows.Forms.MaskedTextBox mTxtTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMasaSayısı;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçF11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetF10ToolStripMenuItem;
    }
}