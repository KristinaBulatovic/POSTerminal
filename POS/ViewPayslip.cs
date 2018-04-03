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
    public partial class ViewPayslip : Form
    {
        int id;

        string dateFrom;
        string dateTo;

        public ViewPayslip(int countryID)
        {
            InitializeComponent();
            id = countryID;
        }

        private void ViewPayslip_Load(object sender, EventArgs e)
        {
            countriesTableAdapter.Fill(pOSDataSet.Countries);
            payslipTableAdapter.FillPayslipByCountry(pOSDataSet.Payslip, id);

            labTotal.Text = payslipTableAdapter.SelectTotal(id).ToString();
            labTotalVAT.Text = payslipTableAdapter.SelectTotalVAT(id).ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dateFrom = dtFrom.Value.ToShortDateString();
            dateTo = dtTo.Value.ToShortDateString();

            payslipTableAdapter.FillPayslipByCountriAndDate(pOSDataSet.Payslip, dateFrom, dateTo, id);

            labTotal.Text = payslipTableAdapter.SelectTotalByDate(dateFrom, dateTo, id).ToString();
            labTotalVAT.Text = payslipTableAdapter.SelectTotalVATByDate(dateFrom, dateTo, id).ToString();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            payslipTableAdapter.FillPayslipByCountry(pOSDataSet.Payslip, id);

            labTotal.Text = payslipTableAdapter.SelectTotal(id).ToString();
            labTotalVAT.Text = payslipTableAdapter.SelectTotalVAT(id).ToString();
        }
    }
}
