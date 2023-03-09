using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silva_adriano_1
{
    internal class SAEnAttente : SAState
    {
        public override string SAActualState
        {
            get { return "En attente"; }
        }
        
        public override SAState SAAccepter()
        {
            Console.WriteLine("Le projet est accepté");
            return new SAAccepte();
        }

        public override SAState SADemarrer()
        {
            Console.WriteLine("Le projet n'as pas été accepté");
            return this;
        }

        public override SAState SATerminer()
        {
            Console.WriteLine("Le projet n'as pas été accepté");
            return this;
        }

    }
}
