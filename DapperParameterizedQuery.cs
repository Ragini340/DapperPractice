using Dapper;
using System.Data.SqlClient;

namespace DapperPractice
{
    public class DapperParameterizedQuery
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {name} {Price}";
        }
    }
    public class DapperParameterizedQueryMainMethod
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost;Initial Catalog = Ragini_Practice_DB;Integrated Security = True;  Encrypt=False;";
            using var con = new SqlConnection(connectionString);
            con.Open();

            var car = con.QueryFirst<DapperParameterizedQuery>("SELECT * FROM CarNew WHERE id=@id",
                new { id = 3 });

            Console.WriteLine(car);

        }
    }
}