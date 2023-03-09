using System.Data.SqlClient;

namespace testsql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = "Integrated Security = True; Initial Catalog = Northwind; Data Source=localhost";
            db.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = "select CustomerID, CompanyName, ContactName from Customers";
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Console.WriteLine(rd["CustomerID"] + " " + rd["CompanyName"] + " " + rd["ContactName"]);
            }

            rd.Close();
            db.Close();
        }
    }
}