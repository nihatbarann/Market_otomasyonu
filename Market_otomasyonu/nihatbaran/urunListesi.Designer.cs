namespace nihatbaran
{
    partial class urunListesi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUygula = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtİndirim = new System.Windows.Forms.TextBox();
            this.rdbYuzde = new System.Windows.Forms.RadioButton();
            this.rdbTl = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunsatisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunalisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uruntanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.market_otomasyonuDataSet = new nihatbaran.market_otomasyonuDataSet();
            this.urun_tanimTableAdapter = new nihatbaran.market_otomasyonuDataSetTableAdapters.urun_tanimTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uruntanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 175);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUygula);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtİndirim);
            this.groupBox2.Controls.Add(this.rdbYuzde);
            this.groupBox2.Controls.Add(this.rdbTl);
            this.groupBox2.Location = new System.Drawing.Point(546, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 143);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(183, 98);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(75, 23);
            this.btnUygula.TabIndex = 4;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "indirim",
            "zam"});
            this.comboBox1.Location = new System.Drawing.Point(164, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Zam";
            // 
            // txtİndirim
            // 
            this.txtİndirim.Location = new System.Drawing.Point(16, 49);
            this.txtİndirim.Name = "txtİndirim";
            this.txtİndirim.Size = new System.Drawing.Size(109, 22);
            this.txtİndirim.TabIndex = 2;
            // 
            // rdbYuzde
            // 
            this.rdbYuzde.AutoSize = true;
            this.rdbYuzde.Checked = true;
            this.rdbYuzde.Location = new System.Drawing.Point(81, 101);
            this.rdbYuzde.Name = "rdbYuzde";
            this.rdbYuzde.Size = new System.Drawing.Size(66, 20);
            this.rdbYuzde.TabIndex = 1;
            this.rdbYuzde.TabStop = true;
            this.rdbYuzde.Text = "Yüzde";
            this.rdbYuzde.UseVisualStyleBackColor = true;
            // 
            // rdbTl
            // 
            this.rdbTl.AutoSize = true;
            this.rdbTl.Location = new System.Drawing.Point(16, 101);
            this.rdbTl.Name = "rdbTl";
            this.rdbTl.Size = new System.Drawing.Size(44, 20);
            this.rdbTl.TabIndex = 0;
            this.rdbTl.TabStop = true;
            this.rdbTl.Text = "TL";
            this.rdbTl.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(42, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 100);
            this.groupBox1.TabIndex = 19;
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
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ada Göre Arama:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uidDataGridViewTextBoxColumn,
            this.urunadDataGridViewTextBoxColumn,
            this.urunsatisDataGridViewTextBoxColumn,
            this.urunalisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uruntanimBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 485);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            // urun_tanimTableAdapter
            // 
            this.urun_tanimTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 28);
            // 
            // enterToolStripMenuItem
            // 
            this.enterToolStripMenuItem.Name = "enterToolStripMenuItem";
            this.enterToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.enterToolStripMenuItem.Text = "enter";
            // 
            // urunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 660);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "urunListesi";
            this.Text = "urunListesi";
            this.Load += new System.EventHandler(this.urunListesi_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uruntanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonuDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private market_otomasyonuDataSet market_otomasyonuDataSet;
        private System.Windows.Forms.BindingSource uruntanimBindingSource;
        private market_otomasyonuDataSetTableAdapters.urun_tanimTableAdapter urun_tanimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunsatisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunalisDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enterToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtİndirim;
        private System.Windows.Forms.RadioButton rdbYuzde;
        private System.Windows.Forms.RadioButton rdbTl;
    }
}