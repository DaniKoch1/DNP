using System;
using System.Collections.Generic;

namespace q1
{
    delegate double Function(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            double operation=Apply(2,4,Add);
            System.Console.WriteLine(operation);
            operation=Apply(4,5,Multiply);
            System.Console.WriteLine(operation);
            operation+=Apply(3, 2, Substract);
            System.Console.WriteLine(operation);
            operation=Apply(3,2,(double a, double b)=>2*a*b);
            System.Console.WriteLine(operation);

            int a=2, b=4;
            System.Console.Write($"{a}, {b}, ");
            Swap(ref a, ref b);
            System.Console.WriteLine($"{a}, {b}, ");

            Fraction f1=new Fraction(2,5);
            Fraction f2=new Fraction(7,2);
            System.Console.WriteLine(f1*f2);

            List<int> list=new List<int>() {1,2,3,4,10,35,88,23};
            System.Console.WriteLine(list.RandomElement());
        }
        static double Multiply(double a, double b)=>a*b;
        static double Add(double a, double b)=>a+b;
        static double Substract(double a, double b)=>a>b?a-b:b-a;
        static double Divide(double a, double b)=>(double)(a/b);
        static double Apply(double a, double b, Function f)=>f(a,b);

        
        static void Swap(ref int a,ref int b)
        {
            int temp=a;
            a=b;
            b=temp;
        }

    }
}
