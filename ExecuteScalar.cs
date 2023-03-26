using Dapper;
using System.Data.SqlClient;

namespace DapperPractice
{
   public class ExecuteScalar
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost;Initial Catalog = Ragini_Practice_DB;Integrated Security = True;  Encrypt=False;";

            using var con = new SqlConnection(connectionString);
            con.Open();

            var version = con.ExecuteScalar<string>("SELECT @@VERSION");

            Console.WriteLine(version);
        }
    }
}