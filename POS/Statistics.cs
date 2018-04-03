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
    public partial class Statistics : Form
    {

        int countryID;

        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            countriesTableAdapter.Fill(pOSDataSet.Countries);
            articlesTableAdapter.Fill(pOSDataSet.Articles);

            countryID = Convert.ToInt32(countriesTableAdapter.SelectID(cbCountry.Text));
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            countryID = Convert.ToInt32(countriesTableAdapter.SelectID(cbCountry.Text));
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            articlesTableAdapter.FillTopTenArticals(pOSDataSet.Articles, countryID);
        }

        private void btnMoreThreeSales_Click(object sender, EventArgs e)
        {
            articlesTableAdapter.FillArticlesMoreThreeSales(pOSDataSet.Articles);
        }

        private void btnUnused_Click(object sender, EventArgs e)
        {
            articlesTableAdapter.FillUnusedArticals(pOSDataSet.Articles);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            articlesTableAdapter.Fill(pOSDataSet.Articles);
        }
    }
}
