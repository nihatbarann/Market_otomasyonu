namespace nihatbaran
{
    partial class FirmaListesi
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
            this.market_otomasyonuDataSet1 = new nihatbaran.market_otomasyonuDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmatanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firma_tanimTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.Firma_tanimTableAdapter();
            this.firmaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masasayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmatanimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 148);
            this.panel1.TabIndex = 0;
            // 
            // market_otomasyonuDataSet1
            // 
            this.market_otomasyonuDataSet1.DataSetName = "market_otomasyonuDataSet";
            this.market_otomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaidDataGridViewTextBoxColumn,
            this.unvanDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.masasayisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmatanimBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 302);
            this.dataGridView1.TabIndex = 1;
            // 
            // firmatanimBindingSource
            // 
            this.firmatanimBindingSource.DataMember = "Firma_tanim";
            this.firmatanimBindingSource.DataSource = this.market_otomasyonuDataSet1;
            // 
            // firma_tanimTableAdapter
            // 
            this.firma_tanimTableAdapter.ClearBeforeFill = true;
            // 
            // firmaidDataGridViewTextBoxColumn
            // 
            this.firmaidDataGridViewTextBoxColumn.DataPropertyName = "Firma_id";
            this.firmaidDataGridViewTextBoxColumn.HeaderText = "Firma_id";
            this.firmaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firmaidDataGridViewTextBoxColumn.Name = "firmaidDataGridViewTextBoxColumn";
            this.firmaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // unvanDataGridViewTextBoxColumn
            // 
            this.unvanDataGridViewTextBoxColumn.DataPropertyName = "unvan";
            this.unvanDataGridViewTextBoxColumn.HeaderText = "unvan";
            this.unvanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
            this.unvanDataGridViewTextBoxColumn.Width = 125;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // masasayisiDataGridViewTextBoxColumn
            // 
            this.masasayisiDataGridViewTextBoxColumn.DataPropertyName = "masa_sayisi";
            this.masasayisiDataGridViewTextBoxColumn.HeaderText = "masa_sayisi";
            this.masasayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masasayisiDataGridViewTextBoxColumn.Name = "masasayisiDataGridViewTextBoxColumn";
            this.masasayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // FirmaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FirmaListesi";
            this.Text = "FirmaListesi";
            this.Load += new System.EventHandler(this.FirmaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmatanimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private market_otomasyonuDataSet market_otomasyonuDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource firmatanimBindingSource;
        private market_otomasyonuDataSetTableAdapters.Firma_tanimTableAdapter firma_tanimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masasayisiDataGridViewTextBoxColumn;
    }
}