using System;
using System.Windows.Forms;
using InterfaceDesktop.TransactionServiceReference;
using InterfaceDesktop.BankAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class externalTransaction : Form
    {
        //Creating instance of the services, which allows to call them.
        private ServiceFinancialTransactionSoapClient transactionClientVar = new ServiceFinancialTransactionSoapClient();
        private BankAccountManagementServiceSoapClient bankClientVar = new BankAccountManagementServiceSoapClient();

        //Default Constructor
        public externalTransaction()
        {
            InitializeComponent();
        }
        private void performTransactionButton_Click(object sender, EventArgs e)
        {
            if (accountNumberTextBox.Text == string.Empty || amountTextbox.Text == string.Empty || branchCodeTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.", "Error");
            }
            else if (!int.TryParse(accountNumberTextBox.Text, out int parsedValue) || !decimal.TryParse(amountTextbox.Text, out decimal parsedValueOther))
            {
                MessageBox.Show("Account Number and Amount can only contain numbers.", "Error");
            }
            else if (bankClientVar.GetAccountType(Convert.ToInt32(accountNumberTextBox.Text)) == "false")
            {
                MessageBox.Show("This account does not exist.", "Error");
            }
            else
            {
                bool output = transactionClientVar.PerformExternalTransaction(Convert.ToInt32(accountNumberTextBox.Text), Convert.ToDecimal(amountTextbox.Text), branchCodeTextbox.Text);
                if (output == true)
                {
                    MessageBox.Show("External Transaction was successfully done.", "Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There was an error, please try again.", "Error");
                }
            }
        }
    }
}
