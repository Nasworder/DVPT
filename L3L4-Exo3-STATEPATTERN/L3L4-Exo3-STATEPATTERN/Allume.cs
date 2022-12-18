using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3L4_Exo3_STATEPATTERN
{
    internal class Allume : State
    {
        public override State Allumer()
        {
            Console.WriteLine("L'ordinateur est déjà allumé");
            return this;
        }

        public override State Eteindre()
        {
            Console.WriteLine("L'ordinateur s'éteint");
            return new Eteint();
        }

        public override State Redemarrer()
        {
            Console.WriteLine("L'ordinateur redémarre");
            return new Redemarage();
        }

        public override State Hiberner()
        {
            Console.WriteLine("L'ordinateur se met en veille");
            return new Veille();
        }
    }
}
