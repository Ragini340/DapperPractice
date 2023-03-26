using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace DapperPractice
{
    public class DynamicParameters
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost;Initial Catalog = Ragini_Practice_DB;Integrated Security = True;  Encrypt=False;";

            using var con = new SqlConnection(connectionString);
            con.Open();

            var query = "INSERT INTO CarNew(Name, price) VALUES(@Name, @price)";

            var obj = new Dapper.DynamicParameters();
            obj.Add("@Name", "BMW", DbType.AnsiString, ParameterDirection.Input, 255);
            obj.Add("@price", 36600);

            int result = con.Execute(query, obj);

            if (result > 0)
            {
                Console.WriteLine("Row inserted");
            }
        }
    }
}