using System;
using System.Windows.Forms;
using InterfaceDesktop.BankAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class viewAccounts : Form
    {
        //Creating instance of the services, which allows to call them
        private BankAccountManagementServiceSoapClient accountClientVar = new BankAccountManagementServiceSoapClient();

        //Default Constructor
        public viewAccounts()
        {
            InitializeComponent();
        }

        //Loading accounts into the table
        private void viewAccounts_Load(object sender, EventArgs e)
        {
            accountsGridView.DataSource = accountClientVar.ShowAllAccounts();
            accountTotalTextbox.Text = accountClientVar.ShowTotalAmountOfAccounts().ToString();
        }
    }
}
