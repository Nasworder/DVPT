using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silva_adriano_1
{
    internal class SAProjet
    {
        private string _saNomDuProjet;
        private string _saDateDebut;
        private string _saDateFin;
        private SAState _saState;

        public SAProjet(string saNomDuProjet, string saDateDebut, string saDateFin)
        {
            _saNomDuProjet = saNomDuProjet;
            _saDateDebut = saDateDebut;
            _saDateFin = saDateFin;
            _saState = new SAEnAttente(); // Permet de stocker l'état
        }
        
        public void SAAfficherAttributs()
        {
            Console.WriteLine("Nom du projet: " + _saNomDuProjet);
            Console.WriteLine("Date de début: " + _saDateDebut);
            Console.WriteLine("Date de fin: " + _saDateFin);
            Console.WriteLine("Etat du projet: " + _saState.SAActualState);
        }
        
        public void SAAccepter()
        {
            _saState = _saState.SAAccepter();
        }

        public void SADemarrer()
        {
            _saState = _saState.SADemarrer();
        }

        public void SATerminer()
        {
            _saState = _saState.SATerminer();
        }
    }
}
