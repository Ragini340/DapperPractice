using Dapper;
using System.Data.SqlClient;

namespace DapperPractice
{
    public class DapperDeleteRow
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost;Initial Catalog = Ragini_Practice_DB;Integrated Security = True;  Encrypt=False;";

            using var con = new SqlConnection(connectionString);
            con.Open();

            int deleteRows = con.Execute(@"DELETE FROM [CarNew] WHERE Id = @Id", new { Id = 1 });

            if (deleteRows > 0)
            {
                Console.WriteLine("Car deleted");
            }
        }
    }
}