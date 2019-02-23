using System;
using System.Collections.Generic;

namespace Exercise4_Interface_animals_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals=new List<Animal>();
            animals.Add(new Animal("cat",2,40));
            animals.Add(new Animal("jeopard",8,150));
            animals.Add(new Animal("dolphin",10,130));
            animals.Add(new Animal("monkey",1,60));
            animals.Add(new Animal("human",50,40));
            foreach(Animal a in animals)
                System.Console.WriteLine(a);
            animals.Sort();
            System.Console.WriteLine("Sorted:\n\n");
            foreach(Animal a in animals)
                System.Console.WriteLine(a);
        }
    }
}
