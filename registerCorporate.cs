using System;
using System.Windows.Forms;
using InterfaceDesktop.ClientAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class registerCorporate : Form
    { 
    //Creating instance of service
    private ClientAccountManagementServiceSoapClient clientClient = new ClientAccountManagementServiceSoapClient();

    //Default Form Constructor
    public registerCorporate()
    {
        InitializeComponent();
        //Populating the drop-down menu
        companyTypeComboBox.Items.Insert(0, "PLC");
        companyTypeComboBox.Items.Insert(1, "LTD");
        companyTypeComboBox.Items.Insert(2, "unLTD");
        companyTypeComboBox.Items.Insert(3, "LLP");
    }

    private void createAccountButton_Click(object sender, EventArgs e)
    {
        //Performing validation on inout fields
        if (companyNameTextbox.Text == string.Empty || companyAddressTextbox.Text == string.Empty || contactNumberTextbox.Text == string.Empty || companyEmailTextbox.Text == string.Empty || companyTypeComboBox.SelectedIndex == -1 || passwordTextbox.Text == string.Empty)
        {
            MessageBox.Show("Please fill all fields.", "Error");
        }
        else if (!int.TryParse(contactNumberTextbox.Text, out int parsedValue))
        {
            MessageBox.Show("Contact number can only contain numbers.", "Error");
        }
        else
        {
            bool output = clientClient.CreateNewClientAccountCorporate(companyNameTextbox.Text, companyAddressTextbox.Text, contactNumberTextbox.Text, companyEmailTextbox.Text, passwordTextbox.Text, companyTypeComboBox.SelectedItem.ToString());
            if (output == true)
            {
                this.Close();
                MessageBox.Show("Account was successfully created! Please login using the provided Email and Password.", "Success");
            }
            else
            {
                this.Close();
                MessageBox.Show("There was an error creating your account, please try again.", "Error");
            }
        }
    }
}
}
