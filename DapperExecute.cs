using Dapper;
using System.Data.SqlClient;

namespace DapperPractice
{
    public class DapperExecute
    { 
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost;Initial Catalog = Ragini_Practice_DB;Integrated Security = True;  Encrypt=False;";
            using var con = new SqlConnection(connectionString);
            con.Open();

            int nOfRows = con.Execute("UPDATE dbo.[CarNew] SET [price] = 52000 WHERE [id] = 1");
            Console.WriteLine("'UPDATE' affected rows: {0}", nOfRows);
        }
    }
}