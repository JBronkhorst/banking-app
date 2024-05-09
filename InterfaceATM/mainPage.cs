using System;
using System.Windows.Forms;

namespace InterfaceATM
{
    public partial class mainPage : Form
    {
        //Class Variables
        private int accountID;
        private int accountIDPassed;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Default Constructor
        public mainPage()
        {
            InitializeComponent();
        }

        //Class Methods
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please take your card. The application will now exit.", "Success");
            this.Close();
        }

        //Creating an instance of other forms, passing accoundID and opening the forms
        private void viewTransactionsButton_Click(object sender, EventArgs e)
        {
            smallStatement statementForm = new smallStatement();
            statementForm.AccountIDPassed = accountID;
            statementForm.Show();
        }

        private void viewBalanceButton_Click(object sender, EventArgs e)
        {
            viewBalance balanceForm = new viewBalance();
            balanceForm.AccountIDPassed = accountID;
            balanceForm.Show();
        }

        private void changePinButton_Click(object sender, EventArgs e)
        {
            editPin pinForm = new editPin();
            pinForm.AccountIDPassed = accountID;
            pinForm.Show();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            withdrawMoney withdrawMoneyForm = new withdrawMoney();
            withdrawMoneyForm.AccountIDPassed = accountID;
            withdrawMoneyForm.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            depositMoney depositMoneyForm = new depositMoney();
            depositMoneyForm.AccountIDPassed = accountID;
            depositMoneyForm.Show();
        }
    }
}
