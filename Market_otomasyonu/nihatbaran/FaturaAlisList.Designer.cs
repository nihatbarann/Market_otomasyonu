namespace nihatbaran
{
    partial class FaturaAlisList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.market_otomasyonuDataSet = new nihatbaran.market_otomasyonuDataSet();
            this.alisDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alis_DetayTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.Alis_DetayTableAdapter();
            this.faturaAlisDetayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaAlisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alisDetayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 208);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaAlisDetayIDDataGridViewTextBoxColumn,
            this.faturaAlisIDDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn,
            this.urunadDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alisDetayBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // market_otomasyonuDataSet
            // 
            this.market_otomasyonuDataSet.DataSetName = "market_otomasyonuDataSet";
            this.market_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alisDetayBindingSource
            // 
            this.alisDetayBindingSource.DataMember = "Alis_Detay";
            this.alisDetayBindingSource.DataSource = this.market_otomasyonuDataSet;
            // 
            // alis_DetayTableAdapter
            // 
            this.alis_DetayTableAdapter.ClearBeforeFill = true;
            // 
            // faturaAlisDetayIDDataGridViewTextBoxColumn
            // 
            this.faturaAlisDetayIDDataGridViewTextBoxColumn.DataPropertyName = "faturaAlisDetayID";
            this.faturaAlisDetayIDDataGridViewTextBoxColumn.HeaderText = "faturaAlisDetayID";
            this.faturaAlisDetayIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaAlisDetayIDDataGridViewTextBoxColumn.Name = "faturaAlisDetayIDDataGridViewTextBoxColumn";
            this.faturaAlisDetayIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.faturaAlisDetayIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaAlisIDDataGridViewTextBoxColumn
            // 
            this.faturaAlisIDDataGridViewTextBoxColumn.DataPropertyName = "FaturaAlisID";
            this.faturaAlisIDDataGridViewTextBoxColumn.HeaderText = "FaturaAlisID";
            this.faturaAlisIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaAlisIDDataGridViewTextBoxColumn.Name = "faturaAlisIDDataGridViewTextBoxColumn";
            this.faturaAlisIDDataGridViewTextBoxColumn.Width = 125;
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
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "tutar";
            this.tutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            this.tutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "kdv";
            this.kdvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            this.kdvDataGridViewTextBoxColumn.Width = 125;
            // 
            // FaturaAlisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FaturaAlisList";
            this.Text = "FaturaAlisList";
            this.Load += new System.EventHandler(this.FaturaAlisList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alisDetayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaAlisDetayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaAlisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alisDetayBindingSource;
        private market_otomasyonuDataSet market_otomasyonuDataSet;
        private market_otomasyonuDataSetTableAdapters.Alis_DetayTableAdapter alis_DetayTableAdapter;
    }
}