namespace POS
{
    partial class ViewPayslip
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
            this.payslipDataGridView = new System.Windows.Forms.DataGridView();
            this.DatePayslip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payslipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new POS.POSDataSet();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payslipTableAdapter = new POS.POSDataSetTableAdapters.PayslipTableAdapter();
            this.countriesTableAdapter = new POS.POSDataSetTableAdapters.CountriesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.labTotalVAT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payslipDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // payslipDataGridView
            // 
            this.payslipDataGridView.AutoGenerateColumns = false;
            this.payslipDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payslipDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DatePayslip,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.payslipDataGridView.DataSource = this.payslipBindingSource;
            this.payslipDataGridView.Location = new System.Drawing.Point(12, 92);
            this.payslipDataGridView.Name = "payslipDataGridView";
            this.payslipDataGridView.Size = new System.Drawing.Size(444, 404);
            this.payslipDataGridView.TabIndex = 1;
            // 
            // DatePayslip
            // 
            this.DatePayslip.DataPropertyName = "DatePayslip";
            this.DatePayslip.HeaderText = "Date";
            this.DatePayslip.Name = "DatePayslip";
            // 
            // dtTo
            // 
            this.dtTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(97, 47);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(133, 29);
            this.dtTo.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Date to";
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(97, 10);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(133, 29);
            this.dtFrom.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Date from";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(247, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 30);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFill
            // 
            this.btnFill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFill.Location = new System.Drawing.Point(351, 27);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(88, 30);
            this.btnFill.TabIndex = 50;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TotalVAT";
            this.dataGridViewTextBoxColumn4.HeaderText = "TotalVAT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // payslipBindingSource
            // 
            this.payslipBindingSource.DataMember = "Payslip";
            this.payslipBindingSource.DataSource = this.pOSDataSet;
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
            // payslipTableAdapter
            // 
            this.payslipTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Total:";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(57, 508);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(0, 22);
            this.labTotal.TabIndex = 52;
            // 
            // labTotalVAT
            // 
            this.labTotalVAT.AutoSize = true;
            this.labTotalVAT.Location = new System.Drawing.Point(382, 508);
            this.labTotalVAT.Name = "labTotalVAT";
            this.labTotalVAT.Size = new System.Drawing.Size(0, 22);
            this.labTotalVAT.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "Total VAT:";
            // 
            // ViewPayslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 539);
            this.Controls.Add(this.labTotalVAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.payslipDataGridView);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ViewPayslip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPayslips";
            this.Load += new System.EventHandler(this.ViewPayslip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payslipDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource payslipBindingSource;
        private POSDataSetTableAdapters.PayslipTableAdapter payslipTableAdapter;
        private System.Windows.Forms.DataGridView payslipDataGridView;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private POSDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePayslip;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labTotalVAT;
        private System.Windows.Forms.Label label6;
    }
}