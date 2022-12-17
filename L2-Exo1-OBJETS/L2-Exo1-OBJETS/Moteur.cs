using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Exo1_OBJETS
{
    internal class Moteur
    {
        private double puissance;
        private double regimeCourant;


        public Moteur(double puissance)
        {
            this.puissance = puissance;
        }


        public void Demarrer()
        {

        }

        public void ChangerRegime(double value)
        {
            regimeCourant = value;
        }
    }
}
