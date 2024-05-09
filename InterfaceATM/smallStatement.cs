using System;
using System.Windows.Forms;
using InterfaceATM.TransactionServiceReference;
using InterfaceATM.BankAccountServiceReference;

namespace InterfaceATM
{
    public partial class smallStatement : Form
    {
        //Class Variables
        private int accountID;
        private int accountIDPassed;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private ServiceFinancialTransactionSoapClient transactionClientVar = new ServiceFinancialTransactionSoapClient();
        private BankAccountManagementServiceSoapClient bankClientVar = new BankAccountManagementServiceSoapClient();

        //Default Constructor
        public smallStatement()
        {
            InitializeComponent();
        }

        //Form Methods
        private void smallStatement_Load(object sender, EventArgs e)
        {
            accountID = this.AccountIDPassed;
            transactionsGridView.DataSource = transactionClientVar.ShowClientTransactions(accountID);
            balanceTextbox.Text = "£" + bankClientVar.GetRunningTotal(accountID).ToString();
        }
    }
}
