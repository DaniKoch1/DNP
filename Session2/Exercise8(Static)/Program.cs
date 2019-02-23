using System;

namespace Exercise8_Static_
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun one=new Gun();
            Gun two=new Gun();
            Gun three=new Gun();

            one.Shoot();
            one.Shoot();
            two.Shoot();
            three.Shoot();
            three.Shoot();
            three.Shoot();
            System.Console.WriteLine(one.bulletCount+", "+Gun.gunCount+", "+Gun.shotsFired);
            System.Console.WriteLine(two.bulletCount+", "+Gun.gunCount+", "+Gun.shotsFired);
            System.Console.WriteLine(three.bulletCount+", "+Gun.gunCount+", "+Gun.shotsFired);
        }
    }
}
