using System;
using System.Windows.Forms;
using InterfaceATM.AuthenticationServiceReference;

namespace InterfaceATM
{
    public partial class loginPage : Form
    {
        //Creating instance of the services, which allows to call them.
        private AuthServiceSoapClient loginClientVar = new AuthServiceSoapClient();
        public loginPage()
        {
            InitializeComponent();
        }

        //Form methods
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (accountIDTextbox.Text == string.Empty || pinTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.", "Error");
            }
            else if (!int.TryParse(pinTextbox.Text, out int parsedValue) || pinTextbox.Text.Length != 4 || !int.TryParse(accountIDTextbox.Text, out int parsedValue1))
            {
                MessageBox.Show("PIN can only contain numbers and must have 4 digits. Account Number must consist of numbers.", "Error");
            }
            else
            {
                int accountID = loginClientVar.AuthenticateUserByPin(Convert.ToInt32(accountIDTextbox.Text), pinTextbox.Text);
                if (accountID == 0)
                {
                    MessageBox.Show("Please check entered details and try again.", "Error");
                }
                else
                {
                    mainPage mainScreenForm = new mainPage();
                    mainScreenForm.AccountIDPassed = accountID;
                    this.Hide();
                    mainScreenForm.Show();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monitorPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
