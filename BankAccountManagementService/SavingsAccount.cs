using System;
using System.Data.SqlClient;
using System.Data;

namespace BankAccountManagementService
{
    public class SavingsAccount : Account
    {
        //Class variables       
        private String query;
        private decimal interestRate = 0.00M;

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //Savings Account Methods
        public bool CreateSavingsBankAccount(int clientID, String accountPin)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(accountPin))
            {
                return false;
            }
            else
            {
                query = "INSERT INTO Account (runningTotal, interestRate, accountType, clientID, accountPin) VALUES(@runningTotal, @interestRate, @accountType, @clientID, @accountPin)";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@runningTotal", "0");
                runQuery.Parameters.AddWithValue("@interestRate", "0.06");
                runQuery.Parameters.AddWithValue("@accountType", "S");
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.Parameters.AddWithValue("@accountPin", accountPin);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public decimal GetInterestRate(int accountID)
        {
            query = "SELECT interestRate FROM Account WHERE accountID=@accountID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@accountID", accountID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                Decimal.TryParse(row["interestRate"].ToString(), out interestRate);
                return interestRate;
            }
            else
            {
                return -1;
            }
        }

        public bool SetInterestRate(int accountID, decimal interestRate)
        {
            if (String.IsNullOrEmpty(accountID.ToString()) || String.IsNullOrEmpty(interestRate.ToString()))
            {
                return false;
            }
            else
            {
                query = "UPDATE Account SET interestRate = @interestRate WHERE accountID = @accountID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@interestRate", interestRate);
                runQuery.Parameters.AddWithValue("@accountID", accountID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }
    }
}