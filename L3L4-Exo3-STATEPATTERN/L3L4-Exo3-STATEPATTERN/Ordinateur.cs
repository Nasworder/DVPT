using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3L4_Exo3_STATEPATTERN
{
    internal class Ordinateur
    {
        private State _state;

        public Ordinateur()
        {
            _state = new Eteint();
        }

        public void Allumer()
        {
            _state = _state.Allumer();
        }

        public void Eteindre()
        {
            _state = _state.Eteindre();
        }

        public void Redemarrer()
        {
            _state = _state.Redemarrer();
        }

        public void Hiberner()
        {
            _state = _state.Hiberner();
        }
    }
}
