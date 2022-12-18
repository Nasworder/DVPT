namespace L5_Exo3_GESTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Create sorted dictionary
            SortedDictionary<string, Employe> employes = new SortedDictionary<string, Employe>();


            employes.Add("jeandupont", new Employe("Dupont", "Jean", 2000));
            employes.Add("mariedupont", new Employe("Dupont", "Marie", 2500));
            employes.Add("jeanmichel", new Employe("Michel", "Jean", 3000));
            employes.Add("mariejean", new Employe("Jean", "Marie", 3500));
            employes.Add("jeanpierre", new Employe("Pierre", "Jean", 4000));
            employes.Add("mariepierre", new Employe("Pierre", "Marie", 4500));
            employes.Add("jeanclaude", new Employe("Claude", "Jean", 5000));
            employes.Add("marieclaude", new Employe("Claude", "Marie", 5500));

            // Display jeandupont
            Console.WriteLine(employes["jeandupont"].Nom + " " + employes["jeandupont"].Prenom + " " + employes["jeandupont"].Salaire);

            Employe employeTest = employes["jeandupont"];
            Console.WriteLine(employeTest.Nom + " " + employeTest.Prenom + " " + employeTest.Salaire);


            // Display sorted dictionary
            foreach (KeyValuePair<string, Employe> employe in employes)
            {
                Console.WriteLine(employe.Key + " " + employe.Value.Nom + " " + employe.Value.Prenom + " " + employe.Value.Salaire);
            }






        }
    }
}