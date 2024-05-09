using System;
using System.Data;
using System.Web.Services;

namespace ClientAccountManagementService
{
    /// <summary>
    /// Summary description for ClientAccountManagementService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ClientAccountManagementService : System.Web.Services.WebService
    {

        //Creating an instance of other classes to call methods
        Client clientVar = new Client();
        Individual individualClientVar = new Individual();
        Corporate corporateClientVar = new Corporate();

        //All available Services within this component
        //Methods from Client Class

        [WebMethod]
        public bool DeleteClientAccount(int clientID)
        {
            bool output = clientVar.DeleteClientAccount(clientID);
            return output;
        }

        [WebMethod]
        public int ShowTotalAmountOfClients()
        {
            int output = clientVar.ShowTotalAmountOfClients();
            return output;
        }

        [WebMethod]
        public DataTable ShowAllClients()
        {
            DataTable dtbl = new DataTable();
            dtbl = clientVar.ShowAllClients();
            dtbl.TableName = "List of all system clients";
            return dtbl;
        }

        [WebMethod]
        public String GetClientName(int clientID)
        {
            String output = clientVar.GetClientName(clientID);
            return output;
        }

        [WebMethod]
        public bool SetClientName(int clientID, String name)
        {
            bool output = clientVar.SetClientName(clientID, name);
            return output;
        }

        [WebMethod]
        public String GetClientAddress(int clientID)
        {
            String output = clientVar.GetClientAddress(clientID);
            return output;
        }

        [WebMethod]
        public bool SetClientAddress(int clientID, String address)
        {
            bool output = clientVar.SetClientAddress(clientID, address);
            return output;
        }

        [WebMethod]
        public String GetClientContactNumber(int clientID)
        {
            String output = clientVar.GetClientContactNumber(clientID);
            return output;
        }

        [WebMethod]
        public bool SetClientContactNumber(int clientID, String contactNumber)
        {
            bool output = clientVar.SetClientContactNumber(clientID, contactNumber);
            return output;
        }

        [WebMethod]
        public String GetClientEmail(int clientID)
        {
            String output = clientVar.GetClientEmail(clientID);
            return output;
        }

        [WebMethod]
        public bool SetClientEmail(int clientID, String email)
        {
            bool output = clientVar.SetClientEmail(clientID, email);
            return output;
        }

        [WebMethod]
        public String GetClientPassword(int clientID)
        {
            String output = clientVar.GetClientPassword(clientID);
            return output;
        }

        [WebMethod]
        public bool SetClientPassword(int clientID, String password)
        {
            bool output = clientVar.SetClientPassword(clientID, password);
            return output;
        }

        [WebMethod]
        public String GetClientType(int clientID)
        {
            String output = clientVar.GetClientType(clientID);
            return output;
        }

        [WebMethod]
        public bool SetClientType(int clientID, String type)
        {
            bool output = clientVar.SetClientType(clientID, type);
            return output;
        }

        //Methods from Individual Class

        [WebMethod]
        public bool CreateNewClientAccountIndividual(String name, String address, String contactNumber, String email, String password, String surname, String gender)
        {
            bool output = individualClientVar.CreateClientAccountIndividual(name, address, contactNumber, email, password, surname, gender);
            return output;
        }

        [WebMethod]
        public bool CreateNewClientAccountStaff(String name, String address, String contactNumber, String email, String password, String surname, String gender)
        {
            bool output = individualClientVar.CreateClientAccountStaff(name, address, contactNumber, email, password, surname, gender);
            return output;
        }

        [WebMethod]
        public String GetClientSurname(int clientID)
        {
            String output = individualClientVar.GetClientSurname(clientID);
            return output;
        }

        [WebMethod]
        public bool SetClientSurname(int clientID, String surname)
        {
            bool output = individualClientVar.SetClientSurname(clientID, surname);
            return output;
        }

        [WebMethod]
        public String GetClientGender(int clientID)
        {
            String output = individualClientVar.GetClientGender(clientID);
            return output;
        }

        [WebMethod]
        public bool SetClientGender(int clientID, String gender)
        {
            bool output = individualClientVar.SetClientGender(clientID, gender);
            return output;
        }

        //Methods from Corporate Class

        [WebMethod]
        public bool CreateNewClientAccountCorporate(String name, String address, String contactNumber, String email, String password, String companyType)
        {
            bool output = corporateClientVar.CreateClientAccountCorporate(name, address, contactNumber, email, password, companyType);
            return output;
        }

        [WebMethod]
        public String GetClientCompanyType(int clientID)
        {
            String output = corporateClientVar.GetClientCompanyType(clientID);
            return output;
        }

        [WebMethod]
        public bool SetClientCompanyType(int clientID, String companyType)
        {
            bool output = corporateClientVar.SetClientCompanyType(clientID, companyType);
            return output;
        }
    }
}
