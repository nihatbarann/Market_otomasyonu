namespace nihatbaran
{
    partial class FaturaSatisList
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
            this.satisDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satis_DetayTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.Satis_DetayTableAdapter();
            this.faturaDetayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisDetayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 204);
            this.panel1.TabIndex = 0;
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
            this.dataGridView1.DataSource = this.satisDetayBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 524);
            this.dataGridView1.TabIndex = 1;
            // 
            // market_otomasyonuDataSet
            // 
            this.market_otomasyonuDataSet.DataSetName = "market_otomasyonuDataSet";
            this.market_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisDetayBindingSource
            // 
            this.satisDetayBindingSource.DataMember = "Satis_Detay";
            this.satisDetayBindingSource.DataSource = this.market_otomasyonuDataSet;
            // 
            // satis_DetayTableAdapter
            // 
            this.satis_DetayTableAdapter.ClearBeforeFill = true;
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
            // FaturaSatisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 728);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FaturaSatisList";
            this.Text = "FaturaSatisList";
            this.Load += new System.EventHandler(this.FaturaSatisList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisDetayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaDetayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource satisDetayBindingSource;
        private market_otomasyonuDataSet market_otomasyonuDataSet;
        private market_otomasyonuDataSetTableAdapters.Satis_DetayTableAdapter satis_DetayTableAdapter;
    }
}