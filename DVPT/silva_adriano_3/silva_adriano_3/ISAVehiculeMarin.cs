using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silva_adriano_3
{
    internal interface ISAVehiculeMarin : ISAVehicule
    {
        bool tirrantEau { get; set; }
        public void SANaviguer()
        {
            Console.WriteLine("La voiture navigue" + saVitesseCourante);
        }
    }
}
