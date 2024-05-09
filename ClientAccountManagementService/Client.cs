using System;
using System.Data.SqlClient;
using System.Data;

namespace ClientAccountManagementService
{
    public class Client
    {
        //Class variables       
        private String query;
        private String clientName;
        private String clientAddress;
        private String clientContactNumber;   //Cannot use int because it ignores 0 at the front. No manipulations are done on this variable, so keeping it as String.
        private String clientEmail;
        private String clientPassword;
        private String clientType;
        private int clientCount;

        //Creating instance of another class to call the methods
        dbConnection connection = new dbConnection();

        //client Account Methods
        public String GetClientName(int clientID)
        {
            query = "SELECT clientName FROM Client WHERE clientID=@clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientName = row["clientName"].ToString();
                return clientName;
            }
            else
            {
                return "false";
            }
        }

        public bool SetClientName(int clientID, String name)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(name))
            {
                return false;
            }
            else
            {
                query = "UPDATE Client SET clientName = @name WHERE clientID = @clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@name", name);
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public String GetClientAddress(int clientID)
        {
            query = "SELECT clientAddress FROM Client WHERE clientID=@clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientAddress = row["clientAddress"].ToString();
                return clientAddress;
            }
            else
            {
                return "false";
            }
        }

        public bool SetClientAddress(int clientID, String address)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(address))
            {
                return false;
            }
            else
            {
                query = "UPDATE Client SET clientAddress = @address WHERE clientID = @clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@address", address);
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public String GetClientContactNumber(int clientID)
        {
            query = "SELECT clientContactNumber FROM Client WHERE clientID=@clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientContactNumber = row["clientContactNumber"].ToString();
                return clientContactNumber;
            }
            else
            {
                return "false";
            }
        }

        public bool SetClientContactNumber(int clientID, String contactNumber)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(contactNumber))
            {
                return false;
            }
            else
            {
                query = "UPDATE Client SET clientContactNumber = @contactNumber WHERE clientID = @clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@contactNumber", contactNumber);
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public String GetClientEmail(int clientID)
        {
            query = "SELECT clientEmail FROM Client WHERE clientID = @clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientEmail = row["clientEmail"].ToString();
                return clientEmail;
            }
            else
            {
                return "false";
            }
        }

        public bool SetClientEmail(int clientID, String email)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(email))
            {
                return false;
            }
            else
            {
                query = "UPDATE Client SET clientEmail = @email WHERE clientID = @clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@email", email);
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public String GetClientPassword(int clientID)
        {
            query = "SELECT clientPassword FROM client WHERE clientID=@clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientPassword = row["clientPassword"].ToString();
                return clientPassword;
            }
            else
            {
                return "false";
            }
        }

        public bool SetClientPassword(int clientID, String password)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(password))
            {
                return false;
            }
            else
            {
                query = "UPDATE Client SET clientPassword = @password WHERE clientID = @clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@password", password);
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public String GetClientType(int clientID)
        {
            query = "SELECT clientType FROM Client WHERE clientID=@clientID";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            adapter.SelectCommand.Parameters.AddWithValue("@clientID", clientID);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientType = row["clientType"].ToString();
                return clientType;
            }
            else
            {
                return "false";
            }
        }

        public bool SetClientType(int clientID, String type)
        {
            if (String.IsNullOrEmpty(clientID.ToString()) && String.IsNullOrEmpty(type))
            {
                return false;
            }
            else
            {
                query = "UPDATE Client SET clientType = @type WHERE clientID = @clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@type", type);
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public bool DeleteClientAccount(int clientID)
        {
            if (String.IsNullOrEmpty(clientID.ToString()))
            {
                return false;
            }
            else
            {
                query = "DELETE FROM Client WHERE clientID=@clientID";
                SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
                runQuery.Parameters.AddWithValue("@clientID", clientID);
                runQuery.ExecuteNonQuery();
                connection.DatabaseConnect().Close();
                return true;
            }
        }

        public DataTable ShowAllClients()
        {
            query = "SELECT clientID, clientName, clientSurname, clientAddress, clientContactNumber, clientEmail, clientGender, clientCompanyType, clientType FROM Client WHERE clientType='I' OR clientType='C'";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();
            return dtbl;
        }

        public int ShowTotalAmountOfClients()
        {
            query = "SELECT COUNT(clientID) AS clientNumber FROM Client WHERE clientType='I' OR clientType='C'";
            SqlCommand runQuery = new SqlCommand(query, connection.DatabaseConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection.DatabaseConnect());
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            connection.DatabaseConnect().Close();

            if (dtbl.Rows.Count != 0)
            {
                DataRow row = dtbl.Rows[0];
                clientCount = Convert.ToInt32(row["clientNumber"]);
                return clientCount;
            }
            else
            {
                return -1;
            }
        }
    }
}