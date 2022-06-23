namespace nihatbaran
{
    partial class karZarar
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.türDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWKarZararBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.market_otomasyonuDataSet = new nihatbaran.market_otomasyonuDataSet();
            this.vW_KarZararTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.VW_KarZararTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWKarZararBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnGetir);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 198);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(548, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 172);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(108, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "Genel Toplam:";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(172, 71);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(224, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.türDataGridViewTextBoxColumn,
            this.faturaTarihDataGridViewTextBoxColumn,
            this.faturaSeriDataGridViewTextBoxColumn,
            this.faturaNoDataGridViewTextBoxColumn,
            this.urunadDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vWKarZararBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 549);
            this.dataGridView1.TabIndex = 2;
            // 
            // türDataGridViewTextBoxColumn
            // 
            this.türDataGridViewTextBoxColumn.DataPropertyName = "Tür";
            this.türDataGridViewTextBoxColumn.HeaderText = "Tür";
            this.türDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.türDataGridViewTextBoxColumn.Name = "türDataGridViewTextBoxColumn";
            this.türDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaTarihDataGridViewTextBoxColumn
            // 
            this.faturaTarihDataGridViewTextBoxColumn.DataPropertyName = "faturaTarih";
            this.faturaTarihDataGridViewTextBoxColumn.HeaderText = "faturaTarih";
            this.faturaTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaTarihDataGridViewTextBoxColumn.Name = "faturaTarihDataGridViewTextBoxColumn";
            this.faturaTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaSeriDataGridViewTextBoxColumn
            // 
            this.faturaSeriDataGridViewTextBoxColumn.DataPropertyName = "faturaSeri";
            this.faturaSeriDataGridViewTextBoxColumn.HeaderText = "faturaSeri";
            this.faturaSeriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaSeriDataGridViewTextBoxColumn.Name = "faturaSeriDataGridViewTextBoxColumn";
            this.faturaSeriDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "faturaNo";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "faturaNo";
            this.faturaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
            this.faturaNoDataGridViewTextBoxColumn.Width = 125;
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
            // vWKarZararBindingSource
            // 
            this.vWKarZararBindingSource.DataMember = "VW_KarZarar";
            this.vWKarZararBindingSource.DataSource = this.market_otomasyonuDataSet;
            // 
            // market_otomasyonuDataSet
            // 
            this.market_otomasyonuDataSet.DataSetName = "market_otomasyonuDataSet";
            this.market_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_KarZararTableAdapter
            // 
            this.vW_KarZararTableAdapter.ClearBeforeFill = true;
            // 
            // karZarar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 746);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "karZarar";
            this.Text = "karZarar";
            this.Load += new System.EventHandler(this.karZarar_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWKarZararBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn türDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vWKarZararBindingSource;
        private market_otomasyonuDataSet market_otomasyonuDataSet;
        private market_otomasyonuDataSetTableAdapters.VW_KarZararTableAdapter vW_KarZararTableAdapter;
    }
}