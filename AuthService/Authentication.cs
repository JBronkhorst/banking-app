using System;
using System.Data;
using System.Data.SqlClient;

namespace AuthService
{
    public class AuthenticationCode
    {
        //Class variables
        private String query;
        private int clientID;

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //Class Methods
        public int AuthenticateUserByPassword(String email, String password)
        {
            query = "SELECT clientID FROM Client WHERE clientEmail=@email AND clientPassword=@password";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@email", email);
            adapter.SelectCommand.Parameters.AddWithValue("@password", password);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientID = Convert.ToInt32(row["clientID"]);
                return clientID;
            }
            else
            {
                return 0;
            }
        }

        public int AuthenticateUserByPin(int accountID, String pin)
        {
            query = "SELECT accountID FROM Account WHERE accountID=@accountID AND accountPin=@pin";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@accountID", accountID);
            adapter.SelectCommand.Parameters.AddWithValue("@pin", pin);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                accountID = Convert.ToInt32(row["accountID"]);
                return accountID;
            }
            else
            {
                return 0;
            }
        }
    }
}