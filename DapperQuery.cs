using Dapper;
using System.Data.SqlClient;

namespace DapperPractice
{
    public class DapperQuery
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {name} {Price}";
        }
    }
   class DapperQueryMainMethod
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost;Initial Catalog = Ragini_Practice_DB;Integrated Security = True;  Encrypt=False;";

            using var con = new SqlConnection(connectionString);
            con.Open();

            var CarNew = con.Query<DapperQuery>("SELECT * FROM CarNew").ToList();

            CarNew.ForEach(car => Console.WriteLine(car));
        }
    }
}