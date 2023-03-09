using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silva_adriano_1
{
    internal class SATermine : SAState
    {
        public override string SAActualState
        {
            get { return "Terminé"; }
        }
        
        public override SAState SAAccepter()
        {
            Console.WriteLine("Le projet est terminé");
            return this;
        }

        public override SAState SADemarrer()
        {
            Console.WriteLine("Le projet est terminé");
            return this;
        }

        public override SAState SATerminer()
        {
            Console.WriteLine("Le projet a déjà été terminé");
            return this;
        }



    }
}
