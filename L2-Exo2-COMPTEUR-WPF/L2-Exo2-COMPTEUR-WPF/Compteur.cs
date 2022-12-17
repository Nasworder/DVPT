using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Exo2_COMPTEUR_WPF
{
    internal class Compteur
    {
        public static int NbObj { get; private set; } = 0;

        public Compteur()
        {
            NbObj++;
        }

        // Destructor -> a la destruction de l'instance
        ~Compteur()
        {
            NbObj--;
        }
    }
}
