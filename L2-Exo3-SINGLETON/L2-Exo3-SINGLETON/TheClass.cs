using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Exo3_SINGLETON
{
    internal sealed class TheClass
    {
        private static TheClass _instance;
        private static readonly object _lock = new object();
        
        // Permet de vérifier que cela fonctionne correctement
        public string Value { get; set; }

        private TheClass()
        {
            
        }

        public static TheClass Instance(string value)
        {
            // Permet de gérer le multi-thread
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new TheClass();
                    _instance.Value = value;
                }
                return _instance;
            }
           
        }
    }
}
