namespace L3L4_Exo1_HERITGAE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Animal chien = new Chien();
            Animal oiseau = new Oiseau();
            Animal chienPourAveugles = new ChienPourAveugles();

            Console.WriteLine(chien.manger());
            Console.WriteLine(oiseau.manger());
            Console.WriteLine((chienPourAveugles as ChienPourAveugles).manger());
            

            
            // Crée une liste d'annimaux
            List<Animal> animaux = new List<Animal>();

            // Ajoute des animaux à la liste
            animaux.Add(new Chien());
            animaux.Add(new Oiseau());
            animaux.Add(new ChienPourAveugles());


            // Affiche les animaux de la liste
            foreach (Animal animal in animaux)
            {
                Console.WriteLine(animal.manger());
            }
        }
    }
}