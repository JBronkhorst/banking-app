using System;
using System.Windows.Forms;
using InterfaceDesktop.TransactionServiceReference;

namespace InterfaceDesktop
{
    public partial class transferMoney : Form
    {
        //Class Variables
        private int accountID;
        private int accountIDPassed;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private ServiceFinancialTransactionSoapClient transactionClientVar = new ServiceFinancialTransactionSoapClient();

        //Default Constructor
        public transferMoney()
        {
            InitializeComponent();
        }

        private void transferMoney_Load(object sender, EventArgs e)
        {
            accountID = this.AccountIDPassed;
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (accountNumberTextbox.Text == string.Empty || amountTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.", "Error");
            }
            else if (!decimal.TryParse(amountTextbox.Text, out decimal parsedValue) || !int.TryParse(accountNumberTextbox.Text, out int parsedValue1))
            {
                MessageBox.Show("Amount and account Number can only contain numbers.", "Error");
            }
            else
            {
                bool result = transactionClientVar.TransferMoney(accountID, Convert.ToInt32(accountNumberTextbox.Text), Convert.ToDecimal(amountTextbox.Text));
                if (result == true)
                {
                    MessageBox.Show("Money successfully transfered", "Success");
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
