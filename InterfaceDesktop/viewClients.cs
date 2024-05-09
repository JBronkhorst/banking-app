using System;
using System.Windows.Forms;
using InterfaceDesktop.ClientAccountServiceReference;

namespace InterfaceDesktop
{
    public partial class viewClients : Form
    {
        //Creating instance of the services, which allows to call them
        private ClientAccountManagementServiceSoapClient clientClientVar = new ClientAccountManagementServiceSoapClient();

        //Default constructor
        public viewClients()
        {
            InitializeComponent();
        }

        //Loading clients into the table
        private void viewClients_Load(object sender, EventArgs e)
        {
            viewClientsGridView.DataSource = clientClientVar.ShowAllClients();
            clientAmountTextbox.Text = clientClientVar.ShowTotalAmountOfClients().ToString();
        }
    }
}
