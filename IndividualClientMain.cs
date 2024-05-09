using System;
using System.Data;
using System.Windows.Forms;
using InterfaceDesktop.ClientAccountServiceReference;
using InterfaceDesktop.BankAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class IndividualClientMain : Form
    {
        //Class variables
        private int clientIDPassed;
        private int clientID;
        private int counter = 0;

        //Getters and Setters
        public int ClientIDPassed { get => clientIDPassed; set => clientIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private ClientAccountManagementServiceSoapClient clientClientVar = new ClientAccountManagementServiceSoapClient();
        private BankAccountManagementServiceSoapClient bankClientVar = new BankAccountManagementServiceSoapClient();

        //Default constructor.
        public IndividualClientMain()
        {
            InitializeComponent();
        }
        //Class methods, linking buttons to services and other forms.
        private void delteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete your account? This will remove all your data from the system. This change is irreversible.", "Are you sure?", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                bool output = clientClientVar.DeleteClientAccount(clientID);
                if (output == true)
                {
                    MessageBox.Show("Account was successfully deleted. The system will now exit.");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("There was an error deleting your account, please try again.");
                }
            }
            else
            {
                //Do nothing.
            }
        }

        //Grabbing client bank accounts and adding them to combo box
        private void GetClientBankAccounts()
        {
            if (bankClientVar.ShowAccountsForClient(clientID) == null || bankClientVar.ShowAccountsForClient(clientID).Rows.Count == 0)
            {
                accountIDComboBox.Enabled = false;
            }
            else
            {
                foreach (DataRow row in bankClientVar.ShowAccountsForClient(clientID).Rows)
                {
                    accountIDComboBox.Items.Insert(counter++, row["accountID"].ToString());
                }
            }
        }

        //Grabbing the clientID when the form loads & loading their Bank Accounts
        private void IndividualClientMain_Load(object sender, EventArgs e)
        {
            clientID = this.clientIDPassed;
            GetClientBankAccounts();
        }

        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating instance of form, passing clientID and opening it
            editDetailsStaffIndividual editPersonalDetailsForm = new editDetailsStaffIndividual();
            editPersonalDetailsForm.ClientIDPassed = clientID;
            editPersonalDetailsForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IndividualClientMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            addNewBankAccount newBankAccountForm = new addNewBankAccount();
            newBankAccountForm.ClientIDPassed = clientID;
            newBankAccountForm.Show();
            this.Hide();
        }

        private void viewBankAccountID_Click(object sender, EventArgs e)
        {
            if (accountIDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Account Number.");
            }
            else
            {
                BankAccountMain bankAccountForm = new BankAccountMain();
                bankAccountForm.AccountIDPassed = Convert.ToInt32(accountIDComboBox.SelectedItem);
                bankAccountForm.Show();
            }
        }
    }
}
