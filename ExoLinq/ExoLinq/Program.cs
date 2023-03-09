namespace ExoLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new[]
            {
                new { IdCustomers = 1 , Name = "John", Age = 20 },
                new { IdCustomers =2, Name = "Mary", Age = 30 },
                new { IdCustomers=3 ,Name = "Tom", Age = 40 },
                new { IdCustomers = 4 ,Name = "Bob", Age = 50 },
                new { IdCustomers = 5,Name = "Alice", Age = 60 },
            };




            Console.WriteLine("Test Query");
            var query = from c in customers
                        where c.Age > 30
                        select c;
            foreach (var customer in query)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}