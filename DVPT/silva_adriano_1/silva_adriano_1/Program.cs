namespace silva_adriano_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création des projets
            SAProjet projet = new SAProjet("Projet DEVPT", "21/12/2022", "21/12/2012");
            projet.SAAfficherAttributs();
            Console.WriteLine();
            SAProjet projet2 = new SAProjet("Projet DEVPT2", "21/12/2022", "21/12/2012");
            projet2.SAAfficherAttributs();
            Console.WriteLine();
            SAProjet projet3 = new SAProjet("Projet DEVPT3", "21/12/2022", "21/12/2012");
            projet3.SAAfficherAttributs();
            Console.WriteLine();





            // Tests
            projet.SADemarrer();
            projet.SATerminer();
            projet.SAAccepter();
            projet.SATerminer();
            projet.SAAfficherAttributs();
            Console.WriteLine();
            projet2.SAAccepter();
            projet2.SADemarrer();
            projet2.SATerminer();
            projet.SAAfficherAttributs();
            Console.WriteLine();
            projet3.SADemarrer();
            projet3.SAAccepter();
            projet3.SATerminer();
            projet.SAAfficherAttributs();







        }
    }
}