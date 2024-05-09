using System;
using System.Windows.Forms;
using InterfaceDesktop.ClientAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class editDetailsStaffIndividual : Form
    {
        //Class variables
        private int clientIDPassed;
        private int clientID;

        //Getters and Setters
        public int ClientIDPassed { get => clientIDPassed; set => clientIDPassed = value; }

        //Creating instance of service
        private ClientAccountManagementServiceSoapClient clientClientVarEdit = new ClientAccountManagementServiceSoapClient();

        //Default constructor.
        public editDetailsStaffIndividual()
        {
            InitializeComponent();
            genderComboBox.Items.Insert(0, "Female");
            genderComboBox.Items.Insert(1, "Male");
        }
        //Grabbing the clientID when the form loads and showing current personal details of the user
        private void editDetailsStaffIndividual_Load(object sender, EventArgs e)
        {
            clientID = this.clientIDPassed;
            nameTextbox.Text = clientClientVarEdit.GetClientName(clientID).Trim();
            surnameTextbox.Text = clientClientVarEdit.GetClientSurname(clientID).Trim();
            addressTextbox.Text = clientClientVarEdit.GetClientAddress(clientID).Trim();
            emailTextbox.Text = clientClientVarEdit.GetClientEmail(clientID).Trim();
            genderComboBox.SelectedItem = clientClientVarEdit.GetClientGender(clientID).Trim();
            contactNumberTextbox.Text = clientClientVarEdit.GetClientContactNumber(clientID);
            passwordTextbox.Text = clientClientVarEdit.GetClientPassword(clientID).Trim();
        }

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {
            //Performing validation on input fields
            if (nameTextbox.Text == string.Empty || surnameTextbox.Text == string.Empty || addressTextbox.Text == string.Empty || contactNumberTextbox.Text == string.Empty || genderComboBox.SelectedIndex == -1 || passwordTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.", "Error");
            }
            else
            {
                clientClientVarEdit.SetClientName(clientID, nameTextbox.Text);
                clientClientVarEdit.SetClientSurname(clientID, surnameTextbox.Text);
                clientClientVarEdit.SetClientAddress(clientID, addressTextbox.Text);
                clientClientVarEdit.SetClientEmail(clientID, emailTextbox.Text);
                clientClientVarEdit.SetClientGender(clientID, genderComboBox.SelectedItem.ToString());
                clientClientVarEdit.SetClientContactNumber(clientID, contactNumberTextbox.Text);
                clientClientVarEdit.SetClientPassword(clientID, passwordTextbox.Text);
                MessageBox.Show("Personal Details were successfully updated!");
                this.Close();
            }
        }
    }
}
