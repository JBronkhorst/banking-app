using System;
using System.Data.SqlClient;
using System.Data;

namespace ClientAccountManagementService
{
    public class Individual : Client
    {
        //Class variables
        private String query;
        private String clientSurname;
        private String clientGender;

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //Individual Account Methods
        public bool CreateClientAccountIndividual(String name, String address, String contactNumber, String email, String password, String surname, String gender)
        {
            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(address) && String.IsNullOrEmpty(contactNumber) && String.IsNullOrEmpty(email) && String.IsNullOrEmpty(password) && String.IsNullOrEmpty(surname) && String.IsNullOrEmpty(gender))
            {
                return false;
            }
            else
            {
                query = "INSERT INTO Client (clientName, clientAddress, clientContactNumber, clientEmail, clientPassword, clientSurname, clientGender, clientType) VALUES(@name, @address, @contactNumber, @email, @password, @surname, @gender, @type)";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@name", name);
                runQuery.Parameters.AddWithValue("@address", address);
                runQuery.Parameters.AddWithValue("@contactNumber", contactNumber);
                runQuery.Parameters.AddWithValue("@email", email);
                runQuery.Parameters.AddWithValue("@password", password);
                runQuery.Parameters.AddWithValue("@surname", surname);
                runQuery.Parameters.AddWithValue("@gender", gender);
                runQuery.Parameters.AddWithValue("@type", 'I');
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public bool CreateClientAccountStaff(String name, String address, String contactNumber, String email, String password, String surname, String gender)
        {
            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(address) && String.IsNullOrEmpty(contactNumber) && String.IsNullOrEmpty(email) && String.IsNullOrEmpty(password) && String.IsNullOrEmpty(surname) && String.IsNullOrEmpty(gender))
            {
                return false;
            }
            else
            {
                query = "INSERT INTO Client (clientName, clientAddress, clientContactNumber, clientEmail, clientPassword, clientSurname, clientGender, clientType) VALUES(@name, @address, @contactNumber, @email, @password, @surname, @gender, @type)";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@name", name);
                runQuery.Parameters.AddWithValue("@address", address);
                runQuery.Parameters.AddWithValue("@contactNumber", contactNumber);
                runQuery.Parameters.AddWithValue("@email", email);
                runQuery.Parameters.AddWithValue("@password", password);
                runQuery.Parameters.AddWithValue("@surname", surname);
                runQuery.Parameters.AddWithValue("@gender", gender);
                runQuery.Parameters.AddWithValue("@type", 'S');
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public String GetClientSurname(int clientID)
        {
            query = "SELECT clientSurname FROM Client WHERE clientID=@clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientSurname = row["clientSurname"].ToString();
                return clientSurname;
            }
            else
            {
                return "false";
            }
        }

        public bool SetClientSurname(int clientID, String surname)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(surname))
            {
                return false;
            }
            else
            {
                query = "UPDATE Client SET clientSurname = @surname WHERE clientID = @clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@surname", surname);
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public String GetClientGender(int clientID)
        {
            query = "SELECT clientGender FROM Client WHERE clientID=@clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientGender = row["clientGender"].ToString();
                return clientGender;
            }
            else
            {
                return "false";
            }
        }

        public bool SetClientGender(int clientID, String gender)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(gender))
            {
                return false;
            }
            else
            {
                query = "UPDATE Client SET clientGender = @gender WHERE clientID = @clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@gender", gender);
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }
    }
}