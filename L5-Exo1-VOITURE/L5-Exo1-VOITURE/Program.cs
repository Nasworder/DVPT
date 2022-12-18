namespace L5_Exo1_VOITURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Voiture v = new Voiture();
            v.Accelerer(10);

            Console.WriteLine("Vitesse courante: " + v.VitesseCourante);

        }
    }
}