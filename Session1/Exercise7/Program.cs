using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a, b, max;
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            if(a>b){
                max=a;
            } 
            else {
                 max=b;
            }
            Console.WriteLine("The bigger number is "+max);
        }
    }
}
