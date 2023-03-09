using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silva_adriano_1
{
    internal class SAEnCours : SAState
    {
        public override string SAActualState
        {
            get { return "En cours"; }
        }
        
        public override SAState SAAccepter()
        {
            Console.WriteLine("Le projet a déjà été accepté");
            return this;
        }

        public override SAState SADemarrer()
        {
            Console.WriteLine("Le projet a déjà été démarré");
            return this;
        }

        public override SAState SATerminer()
        {
            Console.WriteLine("Le projet est terminé");
            return new SATermine();
        }
    }
}
