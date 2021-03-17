using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
             arrayList.Add(new Animal("Daniel"));
             arrayList.Add(new Chicken("Miki"));
             arrayList.Add(new Cow("Tomi"));

             foreach (var item in arrayList)
             {
                 Console.WriteLine($"{item.ToString()} with name {((Animal)item).Name}");
                 ((Animal)item).Feed();
             }

             ((Cow)arrayList[2]).Moo();
             ((Chicken)arrayList[1]).Cluck();
             ((Chicken)arrayList[1]).Name = "Gazda";

             foreach (var item in arrayList)
             {
                 Console.WriteLine($"{item.ToString()} with name {((Animal)item).Name}");
                 ((Animal)item).Feed();
             }

            Console.WriteLine("------------------------------------");
            AnimalsDictionary animals = new AnimalsDictionary();
            animals.Add("1",new Animal("Daniel"));
            animals.Add("2",new Chicken("Teo"));
            animals.Add("3", new Cow("Tomi"));

            foreach (Animal item in animals)
            {
                Console.WriteLine(item);
                item.Feed();
            }

            ((Chicken)animals["2"]).Cluck();
           

            Console.ReadLine();
        }

       




}
}
