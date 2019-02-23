using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number in the range from 0 to 10");
            number=Convert.ToInt32(Console.ReadLine());
            switch(number){
                case 0 :
                    Console.WriteLine("this is the first number");
                    break;
                case 10 :
                    Console.WriteLine("this is the last number");
                    break;
                default :
                    Console.WriteLine("invalid number");
                    break;
                case 1:
                      Console.WriteLine("This is the first number");
                      break;
                  case 2:
                   Console.WriteLine("This is the second number");
                      break;
                  case 3:
                   Console.WriteLine("This is the third number");
                    break;
                  case 4:
                   Console.WriteLine("This is the fourth number");
                    break;
                    case 5:
                   Console.WriteLine("This is the fifth number");
                    break;
                    case 6:
                   Console.WriteLine("This is the sixth number");
                    break;
                    case 7:
                   Console.WriteLine("This is the seventh number");
                    break;
                    case 8:
                   Console.WriteLine("This is the eighth number");
                    break;
            }
        }
    }
}
