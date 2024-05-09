using System;
using System.Windows.Forms;
using InterfaceDesktop.ClientAccountServiceReference;
using InterfaceDesktop.AuthenticationServiceReference;

namespace InterfaceDesktop
{
    public partial class loginPageDesktop : Form
    {
        //Class variables
        private int clientID;
        private String clientType;

        //Creating instance of the services, which allows to call them.
        private AuthServiceSoapClient validationClientVar = new AuthServiceSoapClient();
        private ClientAccountManagementServiceSoapClient clientClientVar = new ClientAccountManagementServiceSoapClient();
        
        public loginPageDesktop()
        {
            InitializeComponent();
        }

        //GUI methods, fundamentally linking services to the form elements.
        public void loginButton_Click(object sender, EventArgs e)
        {
            //Performing validation on input fields
            if (usernameTextbox.Text == string.Empty || passwordTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.", "Error");
            }
            else
            {
                //Getting clientID and checking whether supplies credentials exist in the system.
                clientID = validationClientVar.AuthenticateUserByPassword(usernameTextbox.Text, passwordTextbox.Text);
                //Checking userType
                clientType = clientClientVar.GetClientType(clientID);

                //clientID of 0 is returned by the service if the credentials do not match any account.
                if (clientID != 0)
                {
                    if (clientType == "S")
                    {
                        StaffClientMain staffMainForm = new StaffClientMain();
                        staffMainForm.ClientIDPassed = clientID;
                        this.Hide();
                        staffMainForm.Show();
                    }
                    else if (clientType == "C")
                    {
                        CorporateClientMain corporateMainForm = new CorporateClientMain();
                        corporateMainForm.ClientIDPassed = clientID;
                        this.Hide();
                        corporateMainForm.Show();
                    }
                    else
                    {
                        IndividualClientMain individualMainForm = new IndividualClientMain();
                        individualMainForm.ClientIDPassed = clientID;
                        this.Hide();
                        individualMainForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect. Please try again.", "Error");
                }
            }
        }

        //Opening other forms.
        private void corporateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating instance of form and opening it
            registerCorporate corporateRegister = new registerCorporate();
            corporateRegister.Show();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating instance of form and opening it
            registerIndividual individualRegister = new registerIndividual();
            individualRegister.Show();
        }

        //Closing the application.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
