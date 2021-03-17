using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAnimal
{
    public class Chicken:Animal
    {
        public void Cluck() => Console.WriteLine($"{name} Makes  sound cluck");
        public Chicken(string newName) : base(newName) { }

    }
}
