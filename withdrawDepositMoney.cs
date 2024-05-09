using System;
using System.Windows.Forms;
using InterfaceDesktop.TransactionServiceReference;

namespace InterfaceDesktop
{
    public partial class withdrawDepositMoney : Form
    {
        //Class Variables
        private int accountID;
        private int accountIDPassed;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private ServiceFinancialTransactionSoapClient transactionClientVar = new ServiceFinancialTransactionSoapClient();

        //Default Constructor
        public withdrawDepositMoney()
        {
            InitializeComponent();
        }

        private void withdrawDepositMoney_Load(object sender, System.EventArgs e)
        {
            accountID = this.AccountIDPassed;
            withdrawTextbox.Select();
        }

        private void withdrawButton_Click(object sender, System.EventArgs e)
        {
            if (withdrawTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please enter Amount and try again.", "Error");
            }
            else if (!decimal.TryParse(withdrawTextbox.Text, out decimal parsedValue))
            {
                MessageBox.Show("Amount can only contain numbers.", "Error");
            }
            else
            {
                bool output = transactionClientVar.WithdrawMoney(accountID, Convert.ToDecimal(withdrawTextbox.Text));
                if (output == true)
                {
                    MessageBox.Show("Money successfully withdrawn", "Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There was an error, please try again.", "Error");
                }
            }
        }

        private void depositButton_Click(object sender, System.EventArgs e)
        {
            if (depositTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please enter Amount and try again.", "Error");
            }
            else if (!decimal.TryParse(depositTextbox.Text, out decimal parsedValue))
            {
                MessageBox.Show("Amount can only contain numbers.", "Error");
            }
            else
            {
                bool output = transactionClientVar.DepositMoney(accountID, Convert.ToDecimal(depositTextbox.Text));
                if (output == true)
                {
                    MessageBox.Show("Money successfully deposited", "Success");
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
