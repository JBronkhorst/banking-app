using System;
using System.Windows.Forms;
using InterfaceDesktop.BankAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class editClientBankSettings : Form
    {
        //Creating instance of service
        private BankAccountManagementServiceSoapClient bankClient = new BankAccountManagementServiceSoapClient();

        //Default Form Constructor
        public editClientBankSettings()
        {
            InitializeComponent();
            accountIDtextBox.Select();  //Focusing on this input fields
        }
        //Methods linking buttons to services
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (accountIDtextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter Accoint ID and try again.", "Error");
            }
            else if (!int.TryParse(accountIDtextBox.Text, out int parsedValue))
            {
                MessageBox.Show("Account ID can only contain numbers.", "Error");
            }
            else if (bankClient.GetAccountType(Convert.ToInt32(accountIDtextBox.Text)) == "false")
            {
                MessageBox.Show("Account with this ID does not exist. Please try again.", "Error");
            }
            else
            {
                interestRateTextbox.Text = bankClient.GetInterestRate(Convert.ToInt32(accountIDtextBox.Text)).ToString();
                overdraftTextbox.Text = bankClient.GetOverdraftLimit(Convert.ToInt32(accountIDtextBox.Text)).ToString();
                if (bankClient.GetAccountType(Convert.ToInt32(accountIDtextBox.Text)).ToString() == "S")
                {
                    accountTypeTextbox.Text = "Saving Account";
                    overdraftTextbox.Enabled = false;
                    interestRateTextbox.Enabled = true;
                }
                else
                {
                    accountTypeTextbox.Text = "Current Account";
                    interestRateTextbox.Enabled = false;
                    overdraftTextbox.Enabled = true;
                }
            }
        }

        private void updateSettingsButton_Click(object sender, EventArgs e)
        {
            if (bankClient.GetAccountType(Convert.ToInt32(accountIDtextBox.Text)) == "S")
            {
                bankClient.SetInterestRate(Convert.ToInt32(accountIDtextBox.Text), Convert.ToDecimal(interestRateTextbox.Text));
                MessageBox.Show("Interest Rate was successfully updated.", "Success");
            }
            else
            {
                bankClient.SetOverdraftLimit(Convert.ToInt32(accountIDtextBox.Text), Convert.ToDecimal(overdraftTextbox.Text));
                MessageBox.Show("Overdraft Limit was successfully updated.", "Success");
            }
        }

        private void deleteBankAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this bank account? This will remove all data from the system. This change is irreversible.", "Are you sure?", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                bool output = bankClient.DeleteBankAccount(Convert.ToInt32(accountIDtextBox.Text));
                if (output == true)
                {
                    MessageBox.Show("Account was successfully deleted.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There was an error deleting bank account, please try again.");
                }
            }
            else
            {
                //Do nothing.
            }
        }
    }
}
