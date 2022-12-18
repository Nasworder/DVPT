using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3L4_Exo3_STATEPATTERN
{
    internal class Eteint : State
    {
        public override State Allumer()
        {
            Console.WriteLine("L'ordinateur va s'allumer");
            return new Allume();
        }

        public override State Eteindre()
        {
            Console.WriteLine("L'ordinateur est eteint");
            return this;
        }

        public override State Redemarrer()
        {
            Console.WriteLine("L'ordinateur est eteint");
            return this;
        }

        public override State Hiberner()
        {
            Console.WriteLine("L'ordinateur est eteint");
            return this;
        }
    }
}
