using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Exo1_OBJETS
{
    internal class Voiture
    {
        private string couleur;
        private double contenanceReservoir;
        private Moteur moteur;

        public Voiture(string couleur, double contenanceReservoir, double puissance)
        {
            this.couleur = couleur;
            this.contenanceReservoir = contenanceReservoir;
            moteur = new Moteur(puissance);
        }

        public void Avancer()
        {
            moteur.ChangerRegime(1000);
        }

        public void MettreEnMarche()
        {
            moteur.Demarrer();
        }
    }
}
