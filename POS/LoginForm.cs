using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class LoginForm : Form
    {
        string username;
        string password;
        int id;

        POSForm posForm;

        public LoginForm()
        {
            InitializeComponent();
            usersTableAdapter.Fill(pOSDataSet.Users);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;

            id = Convert.ToInt32(usersTableAdapter.SelectID(username, password));

            if (id != 0)
            {
                posForm = new POSForm(username);
                Hide();
                posForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter the correct Username and Password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
