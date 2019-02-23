using System;
using System.Collections.Generic;
using System.Linq;

namespace Session10LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingDeck = from s in Suits()
                                from r in Ranks()
                                select new{Suits=s, Ranks=r};
            // foreach(var card in startingDeck)
            //     System.Console.WriteLine(card);
            var top=startingDeck.Take(26);
            var bottom=startingDeck.Skip(26);
            var shuffle=top.InterleaveSequenceWith(bottom);
            // foreach(var c in shuffle)
            //     System.Console.WriteLine(c);

            int i=0;
            shuffle=startingDeck;
            do{
                shuffle=shuffle.Take(26).InterleaveSequenceWith(shuffle.Skip(26));
                i++;
                // foreach (var card in shuffle)
                // {
                //     Console.WriteLine(card);
                // }
                // Console.WriteLine();
            }while(!shuffle.SequenceEqual(startingDeck));
            System.Console.WriteLine(i);

        }
        static IEnumerable<string> Suits(){
                yield return "clubs";
                yield return "diamonds";
                yield return "hearts";
                yield return "spades";
            }
        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
