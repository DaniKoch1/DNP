using System;
using System.Collections.Generic;

namespace Ex1_GenericStack_param_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers=new Stack<int>();
            Stack<string> words=new Stack<string>();

            StackClass<int>.add(numbers, 1, 2, 4, 7, 13);
            StackClass<string>.add(words, new string[]{"Hip-hop", "Ballet","Contemporary","Cha-cha"});
            StackClass<int>.add(numbers, 6, 99);
            System.Console.WriteLine(StackClass<int>.toString(numbers));
            System.Console.WriteLine(StackClass<string>.toString(words));
        }
    }
}
