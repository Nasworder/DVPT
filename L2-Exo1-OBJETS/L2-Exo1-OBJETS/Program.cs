namespace L2_Exo1_OBJETS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Voiture maVoiture = new Voiture("Jaune", 100.5, 100);
            maVoiture.MettreEnMarche();
            maVoiture.Avancer();
            Console.WriteLine("Tout OK !");
        }
    }
}