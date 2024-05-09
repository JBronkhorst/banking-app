using System;
using System.Windows.Forms;
using InterfaceDesktop.TransactionServiceReference;

namespace InterfaceDesktop
{
    public partial class transactionHistory : Form
    {
        //Class Variables
        private int accountID;
        private int accountIDPassed;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private ServiceFinancialTransactionSoapClient transactionClientVar = new ServiceFinancialTransactionSoapClient();

        //Default Constructor
        public transactionHistory()
        {
            InitializeComponent();
        }

        private void transactionHistory_Load(object sender, EventArgs e)
        {
            accountID = this.AccountIDPassed;
            transactionsGridView.DataSource = transactionClientVar.ShowClientTransactions(accountID);
        }
    }
}
