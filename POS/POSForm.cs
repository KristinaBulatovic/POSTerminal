using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class POSForm : Form
    {
        int payslipID;
        int countryID;
        int VAT;

        ViewPayslip viewPayslip;
        Statistics statistics;

        public POSForm(string username)
        {
            InitializeComponent();
            labUsername.Text = username;
        }

        private void AddArticleName()
        {
            foreach (POSDataSet.CountryArticleRow row in pOSDataSet.CountryArticle)
            {
                row.ArticleName = pOSDataSet.Articles.FindByID(row.ArticleID).Name;
            }
        }

        private void ChangeCountry()
        {
            VAT = Convert.ToInt32(countriesTableAdapter.SelectVat(cbCountry.Text));
            labVAT.Text = VAT.ToString() + "%";

            countryID = Convert.ToInt32(countriesTableAdapter.SelectID(cbCountry.Text));

            countryArticleTableAdapter.FillCountryArticleByCountry(pOSDataSet.CountryArticle, countryID);
            payslipArticleTableAdapter.FillPayslipArticleByCountry(pOSDataSet.PayslipArticle, countryID);

            AddArticleName();
        }

        private void POSForm_Load(object sender, EventArgs e)
        {
            payslipTableAdapter.Fill(pOSDataSet.Payslip);
            payslipArticleTableAdapter.Fill(pOSDataSet.PayslipArticle);
            articlesTableAdapter.Fill(pOSDataSet.Articles);
            countriesTableAdapter.Fill(pOSDataSet.Countries);

            ChangeCountry();
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCountry();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string date = dt.Value.ToShortDateString();
            payslipTableAdapter.InsertPayslip(date);

            payslipID = Convert.ToInt32(payslipTableAdapter.SelectID());

            payslipArticleTableAdapter.FillPayslipArticleByPayslip(pOSDataSet.PayslipArticle, payslipID);

            cbCountry.Enabled = false;
            dt.Enabled = false;
            btnNew.Enabled = false;
            btnStatistics.Enabled = false;
            btnView.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int counrtyArticleID = Convert.ToInt32(countryArticleTableAdapter.SelectID(Convert.ToInt32(articleIDTextBox.Text), countryID));
            payslipArticleTableAdapter.InsertPayslipArticle(counrtyArticleID, payslipID, Convert.ToInt32(txtQuantity.Text));

            payslipArticleTableAdapter.FillPayslipArticleByPayslip(pOSDataSet.PayslipArticle, payslipID);

            txtQuantity.Text = "1";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var q = from pa in pOSDataSet.PayslipArticle
                    join ca in pOSDataSet.CountryArticle on pa.CountryArticleID equals ca.ID
                    join a in pOSDataSet.Articles on ca.ArticleID equals a.ID
                    where pa.PayslipID == payslipID && pa.CountryArticleID == ca.ID && ca.ArticleID == a.ID
                    select new
                    {
                        price = a.Price,
                        quantity = pa.Quantity,
                    };

            List<decimal> price = new List<decimal>();
            List<int> quantity = new List<int>();
            foreach (var i in q)
            {
                price.Add(i.price);
                quantity.Add(i.quantity);
            }

            decimal sum = 0;
            for(int i = 0; i < price.Count; i++)
            {
                //sum = (price * quantity)
                sum += price[i] * Convert.ToDecimal(quantity[i]);
            }

            decimal sumVAT = sum + ((sum * VAT) / 100);
            payslipTableAdapter.UpdatePayslip(sum, sumVAT, payslipID);

            MessageBox.Show("Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cbCountry.Enabled = true;
            dt.Enabled = true;
            btnNew.Enabled = true;
            btnStatistics.Enabled = true;
            btnView.Enabled = true;
            btnAdd.Enabled = false;

            ChangeCountry();
            payslipArticleTableAdapter.FillPayslipArticleByCountry(pOSDataSet.PayslipArticle, countryID);
        }

        private void POSForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            viewPayslip = new ViewPayslip(countryID);
            viewPayslip.ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            statistics = new Statistics();
            statistics.ShowDialog();
        }
    }
}
