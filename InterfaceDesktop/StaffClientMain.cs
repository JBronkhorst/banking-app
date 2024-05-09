using System;
using System.Windows.Forms;
using InterfaceDesktop.ClientAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class StaffClientMain : Form
    {
        //Class variables
        private int clientIDPassed;
        private int clientID;

        //Getters and Setters
        public int ClientIDPassed { get => clientIDPassed; set => clientIDPassed = value; }

        //Creating instance of the services, which allows to call them.
        private ClientAccountManagementServiceSoapClient clientClientVar = new ClientAccountManagementServiceSoapClient();

        //Default constructor.
        public StaffClientMain()
        {
            InitializeComponent();
        }
        //Class methods, linking buttons to services and other forms.
        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating instance of form, passing clientID and opening it
            editDetailsStaffIndividual editPersonalDetailsForm = new editDetailsStaffIndividual();
            editPersonalDetailsForm.ClientIDPassed = clientID;
            editPersonalDetailsForm.Show();
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

        //Grabbing the clientID when the form loads
        private void StaffClientMain_Load(object sender, EventArgs e)
        {
            clientID = this.clientIDPassed;
        }

        private void exitApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StaffClientMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void viewClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewClients clientList = new viewClients();
            clientList.Show();
        }

        private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAccounts accountList = new viewAccounts();
            accountList.Show();
        }

        private void changeAccountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editClientBankSettings accountSettings = new editClientBankSettings();
            accountSettings.Show();
        }

        private void externalTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            externalTransaction externalTransactionForm = new externalTransaction();
            externalTransactionForm.Show();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
