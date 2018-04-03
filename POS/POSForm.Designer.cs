namespace POS
{
    partial class POSForm
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
            System.Windows.Forms.Label articleIDLabel;
            this.pOSDataSet = new POS.POSDataSet();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new POS.POSDataSetTableAdapters.CountriesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryArticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryArticleTableAdapter = new POS.POSDataSetTableAdapters.CountryArticleTableAdapter();
            this.articlesTableAdapter = new POS.POSDataSetTableAdapters.ArticlesTableAdapter();
            this.payslipArticleTableAdapter = new POS.POSDataSetTableAdapters.PayslipArticleTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.payslipArticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payslipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payslipTableAdapter = new POS.POSDataSetTableAdapters.PayslipTableAdapter();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labVAT = new System.Windows.Forms.Label();
            this.articlesDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.payslipArticleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.articleIDTextBox = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            articleIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryArticleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipArticleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipArticleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // articleIDLabel
            // 
            articleIDLabel.AutoSize = true;
            articleIDLabel.Location = new System.Drawing.Point(419, 63);
            articleIDLabel.Name = "articleIDLabel";
            articleIDLabel.Size = new System.Drawing.Size(79, 22);
            articleIDLabel.TabIndex = 50;
            articleIDLabel.Text = "Article ID:";
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome,";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.Location = new System.Drawing.Point(360, 9);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(123, 32);
            this.labUsername.TabIndex = 13;
            this.labUsername.Text = "Username";
            // 
            // articlesBindingSource
            // 
            this.articlesBindingSource.DataMember = "Articles";
            this.articlesBindingSource.DataSource = this.pOSDataSet;
            // 
            // countryArticleBindingSource
            // 
            this.countryArticleBindingSource.DataMember = "CountryArticle";
            this.countryArticleBindingSource.DataSource = this.pOSDataSet;
            // 
            // countryArticleTableAdapter
            // 
            this.countryArticleTableAdapter.ClearBeforeFill = true;
            // 
            // articlesTableAdapter
            // 
            this.articlesTableAdapter.ClearBeforeFill = true;
            // 
            // payslipArticleTableAdapter
            // 
            this.payslipArticleTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(712, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 29);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(712, 61);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(64, 29);
            this.txtQuantity.TabIndex = 21;
            this.txtQuantity.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quantity:";
            // 
            // payslipArticleBindingSource
            // 
            this.payslipArticleBindingSource.DataMember = "PayslipArticle";
            this.payslipArticleBindingSource.DataSource = this.pOSDataSet;
            // 
            // payslipBindingSource
            // 
            this.payslipBindingSource.DataMember = "Payslip";
            this.payslipBindingSource.DataSource = this.pOSDataSet;
            // 
            // payslipTableAdapter
            // 
            this.payslipTableAdapter.ClearBeforeFill = true;
            // 
            // dt
            // 
            this.dt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(504, 100);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(120, 29);
            this.dt.TabIndex = 43;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(634, 100);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(64, 29);
            this.btnNew.TabIndex = 44;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.DataSource = this.countriesBindingSource;
            this.cbCountry.DisplayMember = "Name";
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(103, 61);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(148, 30);
            this.cbCountry.TabIndex = 0;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "VAT:";
            // 
            // labVAT
            // 
            this.labVAT.AutoSize = true;
            this.labVAT.Location = new System.Drawing.Point(320, 64);
            this.labVAT.Name = "labVAT";
            this.labVAT.Size = new System.Drawing.Size(0, 22);
            this.labVAT.TabIndex = 16;
            // 
            // articlesDataGridView
            // 
            this.articlesDataGridView.AutoGenerateColumns = false;
            this.articlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articlesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ArticleName,
            this.articleIDDataGridViewTextBoxColumn});
            this.articlesDataGridView.DataSource = this.countryArticleBindingSource;
            this.articlesDataGridView.Location = new System.Drawing.Point(29, 134);
            this.articlesDataGridView.Name = "articlesDataGridView";
            this.articlesDataGridView.Size = new System.Drawing.Size(338, 382);
            this.articlesDataGridView.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Articles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Country:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 45;
            this.label8.Text = "Payslip:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(683, 522);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 33);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(423, 522);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(132, 33);
            this.btnView.TabIndex = 47;
            this.btnView.Text = "&View Payslips";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // payslipArticleDataGridView
            // 
            this.payslipArticleDataGridView.AutoGenerateColumns = false;
            this.payslipArticleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payslipArticleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7});
            this.payslipArticleDataGridView.DataSource = this.payslipArticleBindingSource;
            this.payslipArticleDataGridView.Location = new System.Drawing.Point(423, 170);
            this.payslipArticleDataGridView.Name = "payslipArticleDataGridView";
            this.payslipArticleDataGridView.Size = new System.Drawing.Size(353, 346);
            this.payslipArticleDataGridView.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PayslipID";
            this.dataGridViewTextBoxColumn4.HeaderText = "PayslipID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CountryArticleID";
            this.dataGridViewTextBoxColumn2.DataSource = this.countryArticleBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "ArticleName";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "Article";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(136, 522);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(138, 32);
            this.btnStatistics.TabIndex = 50;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "Date:";
            // 
            // articleIDTextBox
            // 
            this.articleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryArticleBindingSource, "ArticleID", true));
            this.articleIDTextBox.Location = new System.Drawing.Point(504, 60);
            this.articleIDTextBox.Name = "articleIDTextBox";
            this.articleIDTextBox.Size = new System.Drawing.Size(120, 29);
            this.articleIDTextBox.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CountryID";
            this.Column1.DataSource = this.countriesBindingSource;
            this.Column1.DisplayMember = "Name";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Country";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.ValueMember = "ID";
            // 
            // ArticleName
            // 
            this.ArticleName.DataPropertyName = "ArticleName";
            this.ArticleName.HeaderText = "Article";
            this.ArticleName.Name = "ArticleName";
            // 
            // articleIDDataGridViewTextBoxColumn
            // 
            this.articleIDDataGridViewTextBoxColumn.DataPropertyName = "ArticleID";
            this.articleIDDataGridViewTextBoxColumn.DataSource = this.articlesBindingSource;
            this.articleIDDataGridViewTextBoxColumn.DisplayMember = "Price";
            this.articleIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.articleIDDataGridViewTextBoxColumn.HeaderText = "Price";
            this.articleIDDataGridViewTextBoxColumn.Name = "articleIDDataGridViewTextBoxColumn";
            this.articleIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.articleIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.articleIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 575);
            this.Controls.Add(articleIDLabel);
            this.Controls.Add(this.articleIDTextBox);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.payslipArticleDataGridView);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.articlesDataGridView);
            this.Controls.Add(this.labVAT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labUsername);
            this.Controls.Add(this.cbCountry);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.POSForm_FormClosing);
            this.Load += new System.EventHandler(this.POSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryArticleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipArticleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipArticleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private POSDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.BindingSource countryArticleBindingSource;
        private POSDataSetTableAdapters.CountryArticleTableAdapter countryArticleTableAdapter;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private POSDataSetTableAdapters.ArticlesTableAdapter articlesTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private POSDataSetTableAdapters.PayslipArticleTableAdapter payslipArticleTableAdapter;
        private System.Windows.Forms.BindingSource payslipArticleBindingSource;
        private System.Windows.Forms.BindingSource payslipBindingSource;
        private POSDataSetTableAdapters.PayslipTableAdapter payslipTableAdapter;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labVAT;
        private System.Windows.Forms.DataGridView articlesDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView payslipArticleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox articleIDTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleName;
        private System.Windows.Forms.DataGridViewComboBoxColumn articleIDDataGridViewTextBoxColumn;
    }
}