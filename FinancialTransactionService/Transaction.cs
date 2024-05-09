using System;
using System.Data.SqlClient;
using System.Data;
using FinancialTransactionService.BankAccountUtilisingServiceReference;

namespace FinancialTransactionService
{
    public class Transaction
    {
        //Class variables
        private String query;

        //Creating instance of service to avoid code duplication, as this service must manage running total of the account (could rewrite queries here too, but no reason)
        private BankAccountManagementServiceSoapClient bankClient = new BankAccountManagementServiceSoapClient();

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //Transaction Methods
        public bool WithdrawMoney(int accountID, decimal amount)
        {
            if (amount >= (bankClient.GetRunningTotal(accountID) + bankClient.GetOverdraftLimit(accountID)))
            {
                return false;
            }
            else if (bankClient.GetRunningTotal(accountID) < 0)
            {
                return false;
            }
            else
            {
                bankClient.SetRunningTotal(accountID, bankClient.GetRunningTotal(accountID) - amount);  //Updating running total
                //Inserting a transaction into DB table
                query = "INSERT INTO FinancialTransaction (amount, transactionType, accountID, otherInformation) VALUES(@amount, @transactionType, @accountID, @otherInformation)";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@amount", amount);
                runQuery.Parameters.AddWithValue("@transactionType", 'W');
                runQuery.Parameters.AddWithValue("@accountID", accountID);
                runQuery.Parameters.AddWithValue("@otherInformation", '-');
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public bool DepositMoney(int accountID, decimal amount)
        {
            bankClient.SetRunningTotal(accountID, bankClient.GetRunningTotal(accountID) + amount);  //Updating running total
            //Inserting a transaction into DB table
            query = "INSERT INTO FinancialTransaction (amount, transactionType, accountID, otherInformation) VALUES(@amount, @transactionType, @accountID, @otherInformation)";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            runQuery.Parameters.AddWithValue("@amount", amount);
            runQuery.Parameters.AddWithValue("@transactionType", 'D');
            runQuery.Parameters.AddWithValue("@accountID", accountID);
            runQuery.Parameters.AddWithValue("@otherInformation", '+');
            runQuery.ExecuteNonQuery();
            connection.DatabaseConnect().Close();
            return true;
        }

        public DataTable ShowClientTransactions(int accountID)
        {
            query = "SELECT timeStamp, otherInformation, amount, branchCode, transactionType FROM FinancialTransaction WHERE accountID=@accountID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@accountID", accountID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();
            return dtbl;
        }
    }
}