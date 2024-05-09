using System;
using System.Windows.Forms;
using InterfaceDesktop.ClientAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class editDetailsCorporate : Form
    {
        //Class variables
        private int clientIDPassed;
        private int clientID;

        //Getters and Setters
        public int ClientIDPassed { get => clientIDPassed; set => clientIDPassed = value; }

        //Creating instance of service
        private ClientAccountManagementServiceSoapClient clientClientVarEdit = new ClientAccountManagementServiceSoapClient();

        //Default constructor.
        public editDetailsCorporate()
        {
            InitializeComponent();
            //Populating the drop-down menu
            companyTypeComboBox.Items.Insert(0, "PLC");
            companyTypeComboBox.Items.Insert(1, "LTD");
            companyTypeComboBox.Items.Insert(2, "unLTD");
            companyTypeComboBox.Items.Insert(3, "LLP");
        }
        //Grabbing the clientID when the form loads and showing current personal details of the user
        private void editDetailsCorporate_Load(object sender, EventArgs e)
        {
            clientID = this.clientIDPassed;
            companyNameTextbox.Text = clientClientVarEdit.GetClientName(clientID).Trim();
            companyAddressTextbox.Text = clientClientVarEdit.GetClientAddress(clientID).Trim();
            contactNumberTextbox.Text = clientClientVarEdit.GetClientContactNumber(clientID).Trim();
            companyEmailTextbox.Text = clientClientVarEdit.GetClientEmail(clientID).Trim();
            passwordTextbox.Text = clientClientVarEdit.GetClientPassword(clientID).Trim();
            companyTypeComboBox.SelectedItem = clientClientVarEdit.GetClientCompanyType(clientID).Trim();
        }

        private void updateDetailsButton_Click(object sender, EventArgs e)
        {
            //Performing validation on input fields
            if (companyNameTextbox.Text == string.Empty || companyAddressTextbox.Text == string.Empty || contactNumberTextbox.Text == string.Empty || companyEmailTextbox.Text == string.Empty || companyTypeComboBox.SelectedIndex == -1 || passwordTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.", "Error");
            }
            else
            {
                clientClientVarEdit.SetClientName(clientID, companyNameTextbox.Text);
                clientClientVarEdit.SetClientAddress(clientID, companyAddressTextbox.Text);
                clientClientVarEdit.SetClientContactNumber(clientID, contactNumberTextbox.Text);
                clientClientVarEdit.SetClientEmail(clientID, companyEmailTextbox.Text);
                clientClientVarEdit.SetClientPassword(clientID, passwordTextbox.Text);
                clientClientVarEdit.SetClientCompanyType(clientID, companyTypeComboBox.SelectedItem.ToString());
                MessageBox.Show("Personal Details were successfully updated!");
                this.Close();
            }
        }
    }
}
