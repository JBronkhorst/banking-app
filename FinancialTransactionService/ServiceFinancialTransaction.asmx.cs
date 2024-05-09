using System;
using System.Data;
using System.Web.Services;

namespace FinancialTransactionService
{
    /// <summary>
    /// Summary description for FinancialTransactionService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceFinancialTransaction : System.Web.Services.WebService
    {

        //Creating an instance of other classes to call methods
        Transaction transactionVar = new Transaction();
        ExternalTransaction externalTransactionVar = new ExternalTransaction();
        Transfer transferVar = new Transfer();

        //All available Services within this component
        //Methods from Transaction Class

        [WebMethod]
        public bool WithdrawMoney(int accountID, decimal amount)
        {
            bool output = transactionVar.WithdrawMoney(accountID, amount);
            return output;
        }

        [WebMethod]
        public bool DepositMoney(int accountID, decimal amount)
        {
            bool output = transactionVar.DepositMoney(accountID, amount);
            return output;
        }

        [WebMethod]
        public DataTable ShowClientTransactions(int accountID)
        {
            DataTable dtbl = new DataTable();
            dtbl = transactionVar.ShowClientTransactions(accountID);
            dtbl.TableName = "List of all transactions for a client";
            return dtbl;
        }

        //Methods from ExternalTransactions Class

        [WebMethod]
        public bool PerformExternalTransaction(int accountID, decimal amount, String branchCode)
        {
            bool output = externalTransactionVar.PerformExternalTransaction(accountID, amount, branchCode);
            return output;
        }

        //Methods from Transfer Class

        [WebMethod]
        public bool TransferMoney(int accountIDFrom, int accountIDTo, decimal amount)
        {
            bool output = transferVar.TransferMoney(accountIDFrom, accountIDTo, amount);
            return output;
        }
    }
}
