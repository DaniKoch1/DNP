using System;
using System.Collections.Generic;

namespace Exercise7_Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Daniela=new Person("Daniela",19, 120);
            Person Monika=new Person("Monika",20, 125);
            Person Aleksandra=new Person("Ola",17,115);

            Dictionary<string, Person> people=new Dictionary<string, Person>();
            people.Add("Dani",Daniela);
            people.Add("Monia",Monika);
            people.Add("Ola",Aleksandra);

            System.Console.WriteLine(people["Monia"].name);

        }
    }
}
