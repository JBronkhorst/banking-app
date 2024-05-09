using System;
using System.Windows.Forms;
using InterfaceDesktop.ClientAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class registerIndividual : Form
    {
        //Creating instance of service
        private ClientAccountManagementServiceSoapClient clientClient = new ClientAccountManagementServiceSoapClient();

        //Default Form Constructor
        public registerIndividual()
        {
            InitializeComponent();
            //Populating the drop-down menu
            genderComboBox.Items.Insert(0, "Female");
            genderComboBox.Items.Insert(1, "Male");
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            //Performing validation on input fields
            if (nameTextbox.Text == string.Empty || surnameTextbox.Text == string.Empty || addressTextbox.Text == string.Empty || contactNumberTextbox.Text == string.Empty || genderComboBox.SelectedIndex == -1 || passwordTextbox.Text == string.Empty || (!staffRadioButton.Checked && !clientRadioButton.Checked))
            {
                MessageBox.Show("Please fill all fields.", "Error");
            }
            else if (!int.TryParse(contactNumberTextbox.Text, out int parsedValue))
            {
                MessageBox.Show("Contact number can only contain numbers.", "Error");
            }
            else
            {
                if (staffRadioButton.Checked)
                {
                    bool output = clientClient.CreateNewClientAccountStaff(nameTextbox.Text, addressTextbox.Text, contactNumberTextbox.Text, emailTextbox.Text, passwordTextbox.Text, surnameTextbox.Text, genderComboBox.SelectedItem.ToString());
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
                else
                {
                    bool output = clientClient.CreateNewClientAccountIndividual(nameTextbox.Text, addressTextbox.Text, contactNumberTextbox.Text, emailTextbox.Text, passwordTextbox.Text, surnameTextbox.Text, genderComboBox.SelectedItem.ToString());
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
}
