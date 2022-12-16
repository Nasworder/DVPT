using System.Diagnostics;

namespace L1_Exo1_DEPASSEMENT
{
 


    internal class Program
    {
        static void Main(string[] args)
        {
            float valeurFinale = 0;
            Console.WriteLine(Traitement(10, 1000, out valeurFinale));
            Console.WriteLine(valeurFinale);


        }

        private static bool Traitement(int nbIteration, float valeurDepart, out float valeurFinale)
        {
            try
            {
                for (int i = 0; i < nbIteration; i++)
                {
                    valeurDepart *= 2;
                }

                valeurFinale = valeurDepart;
                return (!float.IsNaN(valeurFinale) && !float.IsInfinity(valeurFinale));
            }
            catch (OverflowException e)
            {
                EventLog eventLog = new EventLog();
                eventLog.Source = "Application";
                eventLog.WriteEntry(e.Message, EventLogEntryType.Error, 1002, 1);
                
                valeurFinale = valeurDepart;
                return false;
            }
        }






    }
}