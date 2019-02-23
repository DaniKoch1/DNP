using System;

namespace GameModel{
    public class Random : IRandom
    {
        private var rnd = new Random();
        public bool FlipCoin() => (rnd.Next(2) == 0);

        public int RollDice(int sides) => rnd.Next(sides) + 1;
    }
}