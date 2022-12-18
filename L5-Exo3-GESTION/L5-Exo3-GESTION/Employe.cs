using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Exo3_GESTION
{
    internal class Employe
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public double Salaire { get; private set; }

        public Employe(string nom, string prenom, double salaire)
        {
            Nom = nom;
            Prenom = prenom;
            Salaire = salaire;
        }
    }
}
