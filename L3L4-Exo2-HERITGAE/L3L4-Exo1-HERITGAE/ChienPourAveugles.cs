using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3L4_Exo1_HERITGAE
{
    internal class ChienPourAveugles : Chien, IGuiderMaitre
    {
        public void ApprendAGuider()
        {
            Console.WriteLine("Je suis un chien pour aveugles et je suis en train d'apprendre à guider mon maitre");
        }

        public void GuiderMaitre()
        {
            Console.WriteLine("Je suis un chien pour aveugles et je guide mon maitre");
        }

        new public string manger()
        {
            return "Je mange des croquettes pour chien pour aveugles";
        }
    }
}
