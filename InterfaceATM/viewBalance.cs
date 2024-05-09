using System;
using System.Windows.Forms;
using InterfaceATM.BankAccountServiceReference;

namespace InterfaceATM
{
    public partial class viewBalance : Form
    {
        //Class Variables
        private int accountID;
        private int accountIDPassed;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private BankAccountManagementServiceSoapClient bankAccountClientVar = new BankAccountManagementServiceSoapClient();

        //Default Constructor
        public viewBalance()
        {
            InitializeComponent();
        }

        //Form Methods
        
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
