using System;
using System.Data.SqlClient;
using System.Data;

namespace ClientAccountManagementService
{
    public class Corporate : Client
    {
        //Class variables       
        private String query;
        private String clientCompanyType;

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //Corporate Account Methods
        public bool CreateClientAccountCorporate(String name, String address, String contactNumber, String email, String password, String companyType)
        {
            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(address) && String.IsNullOrEmpty(contactNumber) && String.IsNullOrEmpty(email) && String.IsNullOrEmpty(password) && String.IsNullOrEmpty(companyType))
            {
                return false;
            }
            else
            {
                query = "INSERT INTO Client (clientName, clientAddress, clientContactNumber, clientEmail, clientPassword, clientCompanyType, clientType) VALUES(@name, @address, @contactNumber, @email, @password, @companyType, @type)";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@name", name);
                runQuery.Parameters.AddWithValue("@address", address);
                runQuery.Parameters.AddWithValue("@contactNumber", contactNumber);
                runQuery.Parameters.AddWithValue("@email", email);
                runQuery.Parameters.AddWithValue("@password", password);
                runQuery.Parameters.AddWithValue("@companyType", companyType);
                runQuery.Parameters.AddWithValue("@type", 'C');
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public String GetClientCompanyType(int clientID)
        {
            query = "SELECT clientCompanyType FROM Client WHERE clientID=@clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientCompanyType = row["clientCompanyType"].ToString();
                return clientCompanyType;
            }
            else
            {
                return "false";
            }
        }

        public bool SetClientCompanyType(int clientID, String companyType)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(companyType))
            {
                return false;
            }
            else
            {
                query = "UPDATE Client SET clientCompanyType = @companyType WHERE clientID = @clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@companyType", companyType);
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }
    }
}