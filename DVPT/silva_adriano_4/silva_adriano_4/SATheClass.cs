using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silva_adriano_4
{
    internal class SATheClass
    {
        private const int SAMAX = 3;
        private static SATheClass[] _saArray = new SATheClass[3];
        private static int saCurrentClass = 0;
        private static readonly object _saLock = new object();

        public int _saID { get; private set; }
        public static int SACompteur { get; private set; } = 0;



        private SATheClass(int saID)
        {
            _saID = saID;
        }


         public static SATheClass SAInstance()
        {
            // Permet de gérer le multi-thread
            lock (_saLock)
            {
                // Si ça dépasse les nombre max
                if (saCurrentClass >= 3)
                {
                    saCurrentClass = 0;
                }
                
                // Si pas de classe
                if (_saArray[saCurrentClass] == null)
                {              
                    _saArray[saCurrentClass] = new SATheClass(saCurrentClass);
                    SACompteur++;
                }
                    
                return _saArray[saCurrentClass++];
            }

        }


    }
}
