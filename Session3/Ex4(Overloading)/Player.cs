using System;

public class Player
{
    public void Shout(string arg) => System.Console.WriteLine(arg);
    public void Shout(int num) => System.Console.WriteLine(num+" is my lucky number!");
    public void Shout(double num) => System.Console.WriteLine($"The enemy can do {num} damage to me.");
}