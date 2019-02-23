using System;
using System.Collections.Generic;

namespace Ex3_ExtentionMethod_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list=new List<string>(){"Hello","Ahoj","Aloha","Hola","Bonjour","Haloj"};
            Console.WriteLine(list.RandomElement());
            list=list.Shuffle();
            System.Console.WriteLine(ListExtention.toString(list));
        }
    }
}
