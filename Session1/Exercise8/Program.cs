using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("What's your name dear?");
            name=Console.ReadLine();
            char[] letters=new char[name.Length];
            letters=name.ToCharArray();
            char letter;
            for(int i=0;i<name.Length/2;i++){
                letter=letters[i];
                letters[i]=letters[name.Length-i-1];
                letters[name.Length-i-1]=letter;
            }
            name=new string(letters);
            Console.WriteLine($"Your name backward is {name}");
        }
    }
}
