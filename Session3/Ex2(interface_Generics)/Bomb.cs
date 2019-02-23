using System;

class Bomb :IExpldable<double>
{
    public void Explode(double radius){
        System.Console.WriteLine($"BOOM!!\nDestroyed area: {radius}");
    }
}
