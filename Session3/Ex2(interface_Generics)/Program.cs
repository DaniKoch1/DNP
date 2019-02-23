using System;

namespace Ex2_interface_Generics_
{
    class Program
    {
        static void Main(string[] args)
        {
            Bomb bomb=new Bomb();
            bomb.Explode(50);
            bomb.Explode(500);
            bomb.Explode(12);
        }
    }
}
