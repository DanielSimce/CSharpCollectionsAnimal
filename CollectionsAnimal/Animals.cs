using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAnimal
{
    public class Animals:CollectionBase
    {
        public void Add(Animal animal)
        {
            List.Add(animal);
        }

        public void Delete(Animal animal)
        {
            List.Remove(animal);
        }

        public Animal this[int animalIndex]
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}
