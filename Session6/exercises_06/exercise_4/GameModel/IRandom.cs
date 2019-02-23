using System;

namespace GameModel{
    public interface IRandom{
        public int RollDice(int sides);
        public bool FlipCoin();
    }
}