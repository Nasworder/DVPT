using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silva_adriano_1
{
    internal abstract class SAState
    {
        public abstract string SAActualState { get; }
        public abstract SAState SAAccepter();
        public abstract SAState SADemarrer();
        public abstract SAState SATerminer();
    }
}
