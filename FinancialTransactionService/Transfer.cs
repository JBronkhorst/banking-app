using System;
using System.Data.SqlClient;
using FinancialTransactionService.BankAccountUtilisingServiceReference;

namespace FinancialTransactionService
{
    public class Transfer : Transaction
    {
        //Class Variables
        private String querySender;
        private String queryReceiver;

        //Creating instance of service
        private BankAccountManagementServiceSoapClient bankClient = new BankAccountManagementServiceSoapClient();

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //Transfer Methods
        public bool TransferMoney(int accountIDFrom, int accountIDTo, decimal amount)
        {
            if (accountIDFrom == accountIDTo)
            {
                return false;
            }
            else if (bankClient.GetRunningTotal(accountIDFrom) < 0)
            {
                return false;
            }
            else
            {
                bankClient.SetRunningTotal(accountIDFrom, bankClient.GetRunningTotal(accountIDFrom) - amount);  //Updating running total of sender
                bankClient.SetRunningTotal(accountIDTo, bankClient.GetRunningTotal(accountIDTo) + amount);      //Updating running total of receiver
                //Inserting a transaction into DB table for sender
                querySender = "INSERT INTO FinancialTransaction (amount, transactionType, otherInformation, accountID) VALUES(@amount, @transactionType, @otherInformation, @accountID)";
                SqlCommand runQuery = new SqlCommand(querySender, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@amount", amount);
                runQuery.Parameters.AddWithValue("@transactionType", 'T');
                runQuery.Parameters.AddWithValue("@otherInformation", "- (to " + accountIDTo + ")");
                runQuery.Parameters.AddWithValue("@accountID", accountIDFrom);
                runQuery.ExecuteNonQuery();
                //Inserting a transaction into DB table for receiver
                queryReceiver = "INSERT INTO FinancialTransaction (amount, transactionType, otherInformation, accountID) VALUES(@amount, @transactionType, @otherInformation, @accountID)";
                SqlCommand runQuery1 = new SqlCommand(queryReceiver, connection.DatabaseConnect());
                runQuery1.Parameters.AddWithValue("@amount", amount);
                runQuery1.Parameters.AddWithValue("@transactionType", 'T');
                runQuery1.Parameters.AddWithValue("@otherInformation", "+ (from " + accountIDFrom + ")");
                runQuery1.Parameters.AddWithValue("@accountID", accountIDTo);
                runQuery1.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }
    }
}