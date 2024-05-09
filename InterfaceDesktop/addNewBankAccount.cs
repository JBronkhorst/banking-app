using System.Windows.Forms;
using InterfaceDesktop.BankAccountServiceReference;
using InterfaceDesktop.ClientAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class addNewBankAccount : Form
    {
        //Class variables
        private int clientID;
        private int clientIDPassed;

        //Getters and Setters
        public int ClientIDPassed { get => clientIDPassed; set => clientIDPassed = value; }

        //Creating instance of service
        private BankAccountManagementServiceSoapClient bankClient = new BankAccountManagementServiceSoapClient();
        private ClientAccountManagementServiceSoapClient clientClient = new ClientAccountManagementServiceSoapClient();

        //Default Constructor
        public addNewBankAccount()
        {
            InitializeComponent();
        }

        //Grabbing the passed values when the form loads
        private void addNewBankAccount_Load(object sender, System.EventArgs e)
        {
            clientID = this.clientIDPassed;
        }

        //Methods linking buttons to services
        private void createAccountButton_Click(object sender, System.EventArgs e)
        {
            if (pinTextBox.Text == string.Empty || (!savingRadioButton.Checked && !currentRadioButton.Checked))
            {
                MessageBox.Show("Please fill all fields.", "Error");
            }
            else if (!int.TryParse(pinTextBox.Text, out int parsedValue) || pinTextBox.Text.Length != 4)
            {
                MessageBox.Show("PIN can only contain numbers and must have 4 digits.", "Error");
            }
            else
            {
                if (savingRadioButton.Checked)
                {
                    bankClient.CreateSavingsBankAccount(clientID, pinTextBox.Text);
                    MessageBox.Show("Account was successfully created.", "Success");
                    this.Close();
                }
                else
                {
                    bankClient.CreateCurrentBankAccount(clientID, pinTextBox.Text);
                    MessageBox.Show("Account was successfully created.", "Success");
                    this.Close();
                }
            }
        }

        private void addNewBankAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (clientClient.GetClientType(clientID) == "I")
            {
                IndividualClientMain individualForm = new IndividualClientMain();
                individualForm.ClientIDPassed = clientID;
                individualForm.Show();
            }
            else
            {
                CorporateClientMain corporateForm = new CorporateClientMain();
                corporateForm.ClientIDPassed = clientID;
                corporateForm.Show();
            }
        }
    }
}
