using System;
using System.Data;
using System.Web.Services;

namespace BankAccountManagementService
{
    /// <summary>
    /// Summary description for BankAccountManagementService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BankAccountManagementService : System.Web.Services.WebService
    {

        //Creating an instance of other classes to call methods
        Account accountVar = new Account();
        CurrentAccount currentAccountVar = new CurrentAccount();
        SavingsAccount savingsAccountVar = new SavingsAccount();

        //All available Services within this component
        //Methods from Account Class

        [WebMethod]
        public DataTable ShowAllAccounts()
        {
            DataTable dtbl = new DataTable();
            dtbl = accountVar.ShowAllAccounts();
            dtbl.TableName = "List of all system accounts";
            return dtbl;
        }

        [WebMethod]
        public int ShowTotalAmountOfAccounts()
        {
            int output = accountVar.ShowTotalAmountOfAccounts();
            return output;
        }

        [WebMethod]
        public DataTable ShowAccountsForClient(int clientID)
        {
            DataTable dtbl = new DataTable();
            dtbl = accountVar.ShowAccountsForClient(clientID);
            dtbl.TableName = "List of all system accounts for a client";
            return dtbl;
        }

        [WebMethod]
        public bool DeleteBankAccount(int accountID)
        {
            bool output = accountVar.DeleteBankAccount(accountID);
            return output;
        }

        [WebMethod]
        public DateTime GetOpenDate(int accountID)
        {
            DateTime output = accountVar.GetOpenDate(accountID);
            return output;
        }

        [WebMethod]
        public decimal GetRunningTotal(int accountID)
        {
            decimal output = accountVar.GetRunningTotal(accountID);
            return output;
        }

        [WebMethod]
        public bool SetRunningTotal(int accountID, decimal runningTotal)
        {
            bool output = accountVar.SetRunningTotal(accountID, runningTotal);
            return output;
        }

        [WebMethod]
        public String GetAccountType(int accountID)
        {
            String output = accountVar.GetAccountType(accountID);
            return output;
        }

        [WebMethod]
        public String GetAccountPin(int accountID)
        {
            String output = accountVar.GetAccountPin(accountID);
            return output;
        }

        [WebMethod]
        public bool SetAccountPin(int accountID, String clientPin)
        {
            bool output = accountVar.SetAccountPin(accountID, clientPin);
            return output;
        }

        //Methods from CurrentAccount Class

        [WebMethod]
        public bool CreateCurrentBankAccount(int clientID, String accountPin)
        {
            bool output = currentAccountVar.CreateCurrentBankAccount(clientID, accountPin);
            return output;
        }

        [WebMethod]
        public decimal GetOverdraftLimit(int accountID)
        {
            decimal output = currentAccountVar.GetOverdraftLimit(accountID);
            return output;
        }

        [WebMethod]
        public bool SetOverdraftLimit(int accountID, decimal overdraftLimit)
        {
            bool output = currentAccountVar.SetOverdraftLimit(accountID, overdraftLimit);
            return output;
        }

        //Methods from SavingsAccount Class

        [WebMethod]
        public bool CreateSavingsBankAccount(int clientID, String accountPin)
        {
            bool output = savingsAccountVar.CreateSavingsBankAccount(clientID, accountPin);
            return output;
        }

        [WebMethod]
        public decimal GetInterestRate(int accountID)
        {
            decimal output = savingsAccountVar.GetInterestRate(accountID);
            return output;
        }

        [WebMethod]
        public bool SetInterestRate(int accountID, decimal interestRate)
        {
            bool output = savingsAccountVar.SetInterestRate(accountID, interestRate);
            return output;
        }
    }
}
