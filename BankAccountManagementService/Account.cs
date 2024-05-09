using System;
using System.Data.SqlClient;
using System.Data;

namespace BankAccountManagementService
{
    public class Account
    {
        //Class Variables
        private String query;
        private DateTime openDate;
        private decimal runningTotal;
        private String accountType;
        private String accountPin;
        private int accountCount;

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //Bank Account Methods
        public DateTime GetOpenDate(int accountID)  //No need to do set, because that is done automatically by the DB
        {
            query = "SELECT openDate FROM Account WHERE accountID=@accountID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@accountID", accountID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                openDate = Convert.ToDateTime(row["openDate"]);
                return openDate;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public decimal GetRunningTotal(int accountID)
        {
            query = "SELECT runningTotal FROM Account WHERE accountID=@accountID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@accountID", accountID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                runningTotal = Convert.ToDecimal(row["runningTotal"]);
                return runningTotal;
            }
            else
            {
                return -1;
            }
        }

        public bool SetRunningTotal(int accountID, decimal runningTotal)
        {
            if (String.IsNullOrEmpty(accountID.ToString()) && String.IsNullOrEmpty(runningTotal.ToString()))
            {
                return false;
            }
            else
            {
                query = "UPDATE Account SET runningTotal = @runningTotal WHERE accountID = @accountID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@runningTotal", runningTotal);
                runQuery.Parameters.AddWithValue("@accountID", accountID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public String GetAccountType(int accountID) //No need to do set, because account types cannot be changed
        {
            query = "SELECT accountType FROM Account WHERE accountID=@accountID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@accountID", accountID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                accountType = row["accountType"].ToString();
                return accountType;
            }
            else
            {
                return "false";
            }
        }

        public String GetAccountPin(int accountID)
        {
            query = "SELECT accountPin FROM Account WHERE accountID=@accountID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@accountID", accountID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                accountPin = row["accountPin"].ToString();
                return accountPin;
            }
            else
            {
                return "false";
            }
        }

        public bool SetAccountPin(int accountID, String accountPin)
        {
            if (String.IsNullOrEmpty(accountID.ToString()) && String.IsNullOrEmpty(accountPin))
            {
                return false;
            }
            else
            {
                query = "UPDATE Account SET accountPin = @accountPin WHERE accountID = @accountID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@accountPin", accountPin);
                runQuery.Parameters.AddWithValue("@accountID", accountID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public DataTable ShowAllAccounts()
        {
            query = "SELECT accountID, openDate, runningTotal, interestRate, overdraftLimit, accountType, clientID FROM Account";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();
            return dtbl;
        }

        public DataTable ShowAccountsForClient(int clientID)
        {
            query = "SELECT accountID, accountType FROM Account WHERE clientID=@clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();
            return dtbl;
        }

        public bool DeleteBankAccount(int accountID)
        {
            if (String.IsNullOrEmpty(accountID.ToString()))
            {
                return false;
            }
            else
            {
                query = "DELETE FROM Account WHERE accountID=@accountID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@accountID", accountID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public int ShowTotalAmountOfAccounts()
        {
            query = "SELECT COUNT(accountID) AS accountNumber FROM Account";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                accountCount = Convert.ToInt32(row["accountNumber"]);
                return accountCount;
            }
            else
            {
                return -1;
            }
        }
    }
}