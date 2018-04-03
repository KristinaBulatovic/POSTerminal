namespace POS
{
    partial class Statistics
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
            this.pOSDataSet = new POS.POSDataSet();
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articlesTableAdapter = new POS.POSDataSetTableAdapters.ArticlesTableAdapter();
            this.tableAdapterManager = new POS.POSDataSetTableAdapters.TableAdapterManager();
            this.articlesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnused = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new POS.POSDataSetTableAdapters.CountriesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnMoreThreeSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articlesBindingSource
            // 
            this.articlesBindingSource.DataMember = "Articles";
            this.articlesBindingSource.DataSource = this.pOSDataSet;
            // 
            // articlesTableAdapter
            // 
            this.articlesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArticlesTableAdapter = this.articlesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountriesTableAdapter = this.countriesTableAdapter;
            this.tableAdapterManager.CountryArticleTableAdapter = null;
            this.tableAdapterManager.PayslipArticleTableAdapter = null;
            this.tableAdapterManager.PayslipTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POS.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // articlesDataGridView
            // 
            this.articlesDataGridView.AutoGenerateColumns = false;
            this.articlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articlesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.articlesDataGridView.DataSource = this.articlesBindingSource;
            this.articlesDataGridView.Location = new System.Drawing.Point(13, 14);
            this.articlesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.articlesDataGridView.Name = "articlesDataGridView";
            this.articlesDataGridView.Size = new System.Drawing.Size(342, 372);
            this.articlesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnUnused
            // 
            this.btnUnused.Location = new System.Drawing.Point(381, 245);
            this.btnUnused.Name = "btnUnused";
            this.btnUnused.Size = new System.Drawing.Size(209, 32);
            this.btnUnused.TabIndex = 51;
            this.btnUnused.Text = "&All Unused Articals";
            this.btnUnused.UseVisualStyleBackColor = true;
            this.btnUnused.Click += new System.EventHandler(this.btnUnused_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(381, 52);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(213, 29);
            this.btnTop.TabIndex = 52;
            this.btnTop.Text = "&Top 10 Articlas by Country";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.pOSDataSet;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Country:";
            // 
            // cbCountry
            // 
            this.cbCountry.DataSource = this.countriesBindingSource;
            this.cbCountry.DisplayMember = "Name";
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(458, 14);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(135, 30);
            this.cbCountry.TabIndex = 53;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(385, 354);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(209, 32);
            this.btnFill.TabIndex = 55;
            this.btnFill.Text = "&Fill All Articals";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnMoreThreeSales
            // 
            this.btnMoreThreeSales.Location = new System.Drawing.Point(384, 142);
            this.btnMoreThreeSales.Name = "btnMoreThreeSales";
            this.btnMoreThreeSales.Size = new System.Drawing.Size(209, 32);
            this.btnMoreThreeSales.TabIndex = 56;
            this.btnMoreThreeSales.Text = "Articals &More Three Sales";
            this.btnMoreThreeSales.UseVisualStyleBackColor = true;
            this.btnMoreThreeSales.Click += new System.EventHandler(this.btnMoreThreeSales_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 410);
            this.Controls.Add(this.btnMoreThreeSales);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnUnused);
            this.Controls.Add(this.articlesDataGridView);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private POSDataSetTableAdapters.ArticlesTableAdapter articlesTableAdapter;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView articlesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnUnused;
        private System.Windows.Forms.Button btnTop;
        private POSDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnMoreThreeSales;
    }
}