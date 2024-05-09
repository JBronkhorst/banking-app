using System.Data.SqlClient;

namespace FinancialTransactionService
{
    public class dbConnection
    {
        //Database Connection String, which can be reused by all classes within the component.
        public SqlConnection DatabaseConnect()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=JEROEN\SQLEXPRESS;Initial Catalog=ABCBankingGroup;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=False");
            sqlCon.Open();
            return sqlCon;
        }
    }
}