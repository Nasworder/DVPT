namespace L5_Exo2_ZOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Zoo zoo = new Zoo();
            zoo.AjouterAnimal(new Animal("Lion", "Viande"));
            zoo.AjouterAnimal(new Animal("Zèbre", "Herbe"));
            zoo.AjouterAnimal(new Animal("Girafe", "Herbe"));
            zoo.AjouterAnimal(new Animal("Panthère", "Viande"));
            zoo.AjouterAnimal(new Animal("Tigre", "Viande"));
            zoo.AjouterAnimal(new Animal("Singe", "Banane"));
            zoo.AjouterAnimal(new Animal("Poule", "Graines"));
            zoo.AjouterAnimal(new Animal("Poulet", "Graines"));
            zoo.AjouterAnimal(new Animal("Canard", "Graines"));
            zoo.AjouterAnimal(new Animal("Oie", "Graines"));

            Console.WriteLine(zoo["Lion"]);
            Console.WriteLine(zoo["Zèbre"]);
            Console.WriteLine(zoo["Girafe"]);
            Console.WriteLine(zoo["Panthère"]);
            Console.WriteLine(zoo["Tigre"]);
            Console.WriteLine(zoo["Singe"]);
            Console.WriteLine(zoo["Poule"]);
            Console.WriteLine(zoo["Poulet"]);
            Console.WriteLine(zoo["Canard"]);
            Console.WriteLine(zoo["Oie"]);
            Console.WriteLine(zoo["Chien"]);
        }
    }
}