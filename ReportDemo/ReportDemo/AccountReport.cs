using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace ReportDemo
{
    public partial class AccountReport : Form
    {
        public AccountReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BrowseAccounts();
        }

        private void BrowseAccounts()
        {
            var con = new MySqlConnection
            {
                ConnectionString = "server=localhost;uid=root;password=AVANTSolutions;database=northwind;"
            };

            con.Open();

            BsAccounts.DataSource = con.Query<AccountsMdl>("SELECT * FROM Accounts WHERE UserName LIKE CONCAT('%', @un, '%')", new { un = txtSearch.Text }, commandType: CommandType.Text);

            this.rptAccounts.RefreshReport();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BrowseAccounts();
        }
    }
}
