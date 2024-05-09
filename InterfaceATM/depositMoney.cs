using System;
using System.Windows.Forms;
using InterfaceATM.TransactionServiceReference;

namespace InterfaceATM
{
    public partial class depositMoney : Form
    {
        //Class Variables
        private int accountID;
        private int accountIDPassed;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private ServiceFinancialTransactionSoapClient transactionClientVar = new ServiceFinancialTransactionSoapClient();

        //Default Constructor
        public depositMoney()
        {
            InitializeComponent();
        }
        //Form Methods
        private void acceptButton_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (amountTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please enter an amount.", "Error");
            }
            else if (!decimal.TryParse(amountTextbox.Text, out decimal parsedValue))
            {
                MessageBox.Show("Amount can only contain numbers.", "Error");
            }
            else
            {
                bool result = transactionClientVar.DepositMoney(accountID, Convert.ToDecimal(amountTextbox.Text));
                if (result == true)
                {
                    MessageBox.Show("Success, money were disposited.", "Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There was an error, please try again.", "Error");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
