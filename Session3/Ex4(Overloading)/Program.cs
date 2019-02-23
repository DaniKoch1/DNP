using System;

namespace Ex4_Overloading_
{
    class Program
    {
        static void Main(string[] args)
        {
            Player me=new Player();
            me.Shout("Hello world!");
            me.Shout(14.5);
            me.Shout(4);
        }
    }
}
