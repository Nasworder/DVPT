using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Exo2_ZOO
{
    internal class Zoo
    {
        List<Animal> animaux;

        public Zoo()
        {
            animaux = new List<Animal>();
        }

        public void AjouterAnimal(Animal a)
        {
            animaux.Add(a);
        }

        // Indexeur
        public string this[string a] {
            get
            {
                foreach (Animal animal in animaux)
                {
                    if (animal.nom == a)
                        return animal.nourriture;
                }
                return "Animal non trouvé";
            }

        }
    }
}
