using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3L4_Exo3_STATEPATTERN
{
    internal abstract class State
    {
        public abstract State Allumer();
        public abstract State Eteindre();
        public abstract State Redemarrer();
        public abstract State Hiberner();
    }
}
