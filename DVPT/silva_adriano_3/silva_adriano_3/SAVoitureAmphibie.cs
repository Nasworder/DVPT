using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silva_adriano_3
{
    // implement interface explicitly
    
    internal class SAVoitureAmphibie : ISAVehiculeTerrestre, ISAVehiculeMarin
    {
        //modify value of explicite interface
        
        
        bool ISAVehiculeMarin.tirrantEau { get; set; }
        double ISAVehicule.saVitesseCourante { get; set; }

        public SAVoitureAmphibie()
        {
          
        }
        
        void ISAVehiculeTerrestre.SARouler()
        {
            Console.WriteLine("La voiture Roule");
           
            
        }


        void ISAVehiculeMarin.SANaviguer()
        {
            Console.WriteLine("La voiture navigue");
      
        }
    }

}
