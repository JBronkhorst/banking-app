using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using InterfaceDesktop.ClientAccountServiceReference;
using InterfaceDesktop.BankAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class CorporateClientMain : Form
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
        public CorporateClientMain()
        {
            InitializeComponent();
        }
        //Grabbing the passed values when the form loads
        private void CorporateClientMain_Load(object sender, EventArgs e)
        {
            clientID = this.clientIDPassed;
            GetClientBankAccounts();
        }

        //Methods linking buttons to services
        private void exitApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editDetailsCorporate editPersonalDetailsCorporateForm = new editDetailsCorporate();
            editPersonalDetailsCorporateForm.ClientIDPassed = clientID;
            editPersonalDetailsCorporateForm.Show();
        }

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

        private void CorporateClientMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void createNewAccountButton_Click_1(object sender, EventArgs e)
        {
            addNewBankAccount newBankAccountForm = new addNewBankAccount();
            newBankAccountForm.ClientIDPassed = clientID;
            newBankAccountForm.Show();
            this.Hide();
        }

        private void viewBankAccountID_Click_1(object sender, EventArgs e)
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
