using System;
using System.Windows.Forms;
using InterfaceATM.BankAccountServiceReference;

namespace InterfaceATM
{
    public partial class editPin : Form
    {
        //Class Variables
        private int accountID;
        private int accountIDPassed;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private BankAccountManagementServiceSoapClient bankAccountClientVar = new BankAccountManagementServiceSoapClient();

        //Default Constructor
        public editPin()
        {
            InitializeComponent();
        }
        //Form Methods
        private void editPinButton_Click(object sender, EventArgs e)
        {
            if (newPinTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please enter new PIN.", "Error");
            }
            else if (!int.TryParse(newPinTextbox.Text, out int parsedValue) || newPinTextbox.Text.Length != 4)
            {
                MessageBox.Show("PIN can only contain numbers and must have 4 digits.", "Error");
            }
            else
            {
                bool result = bankAccountClientVar.SetAccountPin(accountID, newPinTextbox.Text);
                if (result == true)
                {
                    MessageBox.Show("PIN was successfully changed. Window will now close.", "Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There was an error, please try again.", "Error");
                }
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
