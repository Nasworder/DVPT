using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Exo2_ZOO
{
    internal class Animal
    {
        public string nom { get; private set; }
        public string nourriture { get; private set; }

        public Animal(string nom, string nourriture)
        {
            this.nom = nom;
            this.nourriture = nourriture;
        }
    }
}
