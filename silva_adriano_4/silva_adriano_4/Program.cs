namespace silva_adriano_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Permet de tester le bon fonctionnement
            for (int i = 0; i < 10; i++)
            {
                SATheClass saClass = SATheClass.SAInstance();
                Console.WriteLine("ID: {0}", saClass._saID);
            }

            // Permet d'afficher le nombre de classe instancié
            Console.WriteLine(SATheClass.SACompteur);
        }
    }
}