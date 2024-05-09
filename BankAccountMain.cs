using System;
using System.Windows.Forms;
using InterfaceDesktop.BankAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class BankAccountMain : Form
    {
        //Class variables
        private int accountIDPassed;
        private int accountID;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private BankAccountManagementServiceSoapClient bankClientVar = new BankAccountManagementServiceSoapClient();

        //Default constructor
        public BankAccountMain()
        {
            InitializeComponent();
        }

        //Grabbing the passed values when the form loads
        private void BankAccountMain_Load(object sender, EventArgs e)
        {
            accountID = this.accountIDPassed;
            accountIDText.Text = accountID.ToString();
            openDateText.Text = bankClientVar.GetOpenDate(accountID).ToString();
            if (bankClientVar.GetAccountType(accountID).ToString() == "S")
            {
                accountTypeText.Text = "Saving Account";
            }
            else
            {
                accountTypeText.Text = "Current Account";
            }
            if (bankClientVar.GetInterestRate(accountID) == 0)
            {
                interestRateText.Text = "N/A";
            }
            else
            {
                interestRateText.Text = bankClientVar.GetInterestRate(accountID).ToString() + "%";
            }
            if (bankClientVar.GetOverdraftLimit(accountID) == 0)
            {
                overdraftLimitText.Text = "N/A";
            }
            else
            {
                overdraftLimitText.Text = "£" + bankClientVar.GetOverdraftLimit(accountID).ToString();
            }
        }

        //Methods linking buttons to services
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionHistory transactionHistoryForm = new transactionHistory();
            transactionHistoryForm.AccountIDPassed = accountID;
            transactionHistoryForm.Show();
        }

        private void withdrawAndDepositMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withdrawDepositMoney withdrawDepositMoneyForm = new withdrawDepositMoney();
            withdrawDepositMoneyForm.AccountIDPassed = accountID;
            withdrawDepositMoneyForm.Show();
        }

        private void viewBalanceButton_Click(object sender, EventArgs e)
        {
            viewAccountBalance viewBalanceForm = new viewAccountBalance();
            viewBalanceForm.AccountIDPassed = accountID;
            viewBalanceForm.Show();
        }

        private void transferMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transferMoney transferMoneyForm = new transferMoney();
            transferMoneyForm.AccountIDPassed = accountID;
            transferMoneyForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
