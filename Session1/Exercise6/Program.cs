using System;
namespace DNP
{
    namespace MathLib
    {
        namespace Exercise6
        {
            class Program
            {
                static void Main(string[] args)
                {
                    var calc=new Calculator();
                    //Console.WriteLine(calc.Add(2, 5));
                    int[] numbers=new int[] {1,4,5,7};
                    //Console.WriteLine(calc.Add(numbers));
                    //Console.WriteLine(calc.Substraction(8,5));
                    //Console.WriteLine(calc.Substraction(2,5));
                     Console.WriteLine(calc.Substraction(numbers));
                    //Console.WriteLine(calc.Multiplication(8,5));
                     Console.WriteLine(calc.Multiplication(numbers));
                   // Console.WriteLine(calc.Division(8,5));
                   // Console.WriteLine(calc.Division(8,0));
                     Console.WriteLine(calc.Division(numbers));
                      Console.WriteLine(calc.Division(new int[]{1,8,5,0,9,3}));
                }
            }
        }
    }
}
