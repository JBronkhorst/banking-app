using System;
using System.Windows.Forms;
using InterfaceDesktop.BankAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class viewAccountBalance : Form
    {
        //Class Variables
        private int accountID;
        private int accountIDPassed;

        //Getters and Setters
        public int AccountIDPassed { get => accountIDPassed; set => accountIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private BankAccountManagementServiceSoapClient bankAccountClientVar = new BankAccountManagementServiceSoapClient();

        //Default Constructor
        public viewAccountBalance()
        {
            InitializeComponent();
        }

        private void viewAccountBalance_Load(object sender, EventArgs e)
        {
            accountID = this.AccountIDPassed;
            balanceTextBow.Text = "£" + bankAccountClientVar.GetRunningTotal(accountID).ToString();
        }
    }
}
