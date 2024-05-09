using System;
using System.Data.SqlClient;
using FinancialTransactionService.BankAccountUtilisingServiceReference;

namespace FinancialTransactionService
{
    public class ExternalTransaction : Transaction
    {
        //Class Variables
        private String query;

        //Creating instance of service to avoid code duplication, as this service must manage running total of the account (could rewrite queries here too, but no reason)
        private BankAccountManagementServiceSoapClient bankClient = new BankAccountManagementServiceSoapClient();

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //ExternalTransactions Methods
        public bool PerformExternalTransaction(int accountID, decimal amount, String branchCode)
        {
            bankClient.SetRunningTotal(accountID, bankClient.GetRunningTotal(accountID) + amount);  //Updating running total
            //Inserting a transaction into DB table
            query = "INSERT INTO TransactionTbl (amount, transactionType, branchCode, otherInformation, accountID) VALUES(@amount, @transactionType, @branchCode, @otherInformation, @accountID)";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            runQuery.Parameters.AddWithValue("@amount", amount);
            runQuery.Parameters.AddWithValue("@transactionType", "ET");
            runQuery.Parameters.AddWithValue("@branchCode", branchCode);
            runQuery.Parameters.AddWithValue("@otherInformation", "+");
            runQuery.Parameters.AddWithValue("@accountID", accountID);
            runQuery.ExecuteNonQuery();
            connection.DatabaseConnect().Close();
            return true;
        }
    }
}