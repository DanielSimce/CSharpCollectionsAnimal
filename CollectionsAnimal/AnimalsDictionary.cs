using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAnimal
{
    public class AnimalsDictionary:DictionaryBase
    {
        public void Add(string newId,Animal animal)
        {
            Dictionary.Add(newId, animal);
        }

        public void Remove(string newId)
        {
            Dictionary.Remove(newId);
        }

        public new IEnumerator GetEnumerator()
        {
            foreach (object item in Dictionary.Values)
            {
                yield return item;
            }
        }

        public Animal this[string animalIndex]
        {
            get { return (Animal)Dictionary[animalIndex]; }
            set { Dictionary[animalIndex] = value; }
        }
    }
}
