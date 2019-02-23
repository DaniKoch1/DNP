using System;

namespace Ex7_ParamsModifier_
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Calculator.Add(new int[]{2,3,5,2}));
        }
    }
}
