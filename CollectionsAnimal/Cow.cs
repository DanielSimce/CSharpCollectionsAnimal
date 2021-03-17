using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAnimal
{
    public class Cow : Animal
    {
        public void Moo() => Console.WriteLine($"{name} Makes  sound mooo");
        public Cow(string newName) : base(newName) { }
        

        
    }
}
