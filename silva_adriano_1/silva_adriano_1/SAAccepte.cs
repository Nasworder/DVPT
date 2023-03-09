using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silva_adriano_1
{
    internal class SAAccepte : SAState
    {
        public override string SAActualState
        {
            get { return "Accepté"; }
        }
        
        public override SAState SAAccepter()
        {
            Console.WriteLine("Le projet avait déjà été accepté");
            return this;
        }

        public override SAState SADemarrer()
        {
            Console.WriteLine("Le projet démarre");
            return new SAEnCours();
        }

        public override SAState SATerminer()
        {
            Console.WriteLine("Le projet n'as même pas démarré");
            return this;
        }
    }
}
