using System;

namespace Ex5_OverloadingOperator_
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1=new Time(4, 45);
            Time time2=new Time(5, 15);
            System.Console.WriteLine(time1+time2);
            System.Console.WriteLine(20+time1);
        }
    }
}
