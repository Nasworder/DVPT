using L9_ExoEntity.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace L9_ExoEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (var dbContext = new NorthwindContext()) // créer un objet DbContext
                {
                    Console.WriteLine("Connexion à la base de données réussie");
                    Console.WriteLine("Liste des utilisateurs");


                    var clients = dbContext.Customers.ToList();
                    foreach (var cli in clients)
                    {
                        Console.WriteLine(cli.CustomerId + " " + cli.CompanyName); // afficher le nom du client
                    }
                    Console.WriteLine("Indiquez l'id du client :");
                    string id = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Liste des commandes du client " + id);
                    
                    var orders = dbContext.Orders.Where(o => o.CustomerId == id).ToList();
                    foreach (var ord in orders)
                    {
                        DateTime date = DateTime.ParseExact(ord.OrderDate.ToString(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        string formattedDate = date.ToString("dd/MM/yyyy");
                        Console.WriteLine("\nID commande : " + ord.OrderId + " Date commande : " + formattedDate); // afficher le nom du client
                        var orderDetails = dbContext.OrderDetails.Where(od => od.OrderId == ord.OrderId).ToList();
                        foreach (var od in orderDetails)
                        {
                            var product = dbContext.Products.Where(p => p.ProductId == od.ProductId).FirstOrDefault();
                            Console.WriteLine("ID Produit : "+ product.ProductId +", Produit : " + product.ProductName + ", Quantité : " + od.Quantity + ", Prix unitaire : " + od.UnitPrice.ToString("0.00") + ", Prix total : " + (od.Quantity * od.UnitPrice).ToString("0.00"));
                        }

                        var total = dbContext.OrderDetails.Where(od => od.OrderId == ord.OrderId).Sum(od => od.Quantity * od.UnitPrice);
                        Console.WriteLine("Total commande : " + total.ToString("0.00 fr"));
                    }




                    dbContext.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la connexion à la base de données : " + ex.Message);
            }

        }
    }
}
