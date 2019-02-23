using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
           Person me=new Person{name="Dani"};
           Console.WriteLine(me.Introduce());
        }
    }
}
