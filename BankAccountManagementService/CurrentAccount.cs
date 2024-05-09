using System;
using System.Data.SqlClient;
using System.Data;

namespace BankAccountManagementService
{
    public class CurrentAccount : Account
    {
        //Class variables       
        private String query;
        private decimal overdraftLimit = 0.00M;

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //Current Account Methods
        public bool CreateCurrentBankAccount(int clientID, String accountPin)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(accountPin))
            {
                return false;
            }
            else
            {
                query = "INSERT INTO Account (runningTotal, overdraftLimit, accountType, clientID, accountPin) VALUES(@runningTotal, @overdraftLimit, @accountType, @clientID, @accountPin)";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@runningTotal", "0");
                runQuery.Parameters.AddWithValue("@overdraftLimit", "0");
                runQuery.Parameters.AddWithValue("@accountType", "C");
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.Parameters.AddWithValue("@accountPin", accountPin);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public decimal GetOverdraftLimit(int accountID)
        {
            query = "SELECT overdraftLimit FROM Account WHERE accountID=@accountID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@accountID", accountID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                Decimal.TryParse(row["overdraftLimit"].ToString(), out overdraftLimit);
                return overdraftLimit;
            }
            else
            {
                return -1;
            }
        }

        public bool SetOverdraftLimit(int accountID, decimal overdraftLimit)
        {
            if (String.IsNullOrEmpty(accountID.ToString()) || String.IsNullOrEmpty(overdraftLimit.ToString()))
            {
                return false;
            }
            else
            {
                query = "UPDATE Account SET overdraftLimit = @overdraftLimit WHERE accountID = @accountID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@overdraftLimit", overdraftLimit);
                runQuery.Parameters.AddWithValue("@accountID", accountID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }
    }
}