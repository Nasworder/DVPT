using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Exo1_VOITURE
{
    internal class Voiture
    {
        public double VitesseCourante { get; private set; }

        public Voiture()
        {
            VitesseCourante = 0;
        }

        public void Accelerer(double vitesse)
        {
            VitesseCourante += vitesse;
        }
    }
}
