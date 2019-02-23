using System;
using Random.cs;

namespace GameModel
{
    public class Combat
    {
        /*
         * Two Heroes battle until a winner is found.
         */
         private Random rand=new Random();
        public void Battle(Hero hero1, Hero hero2)
        {
            var attacking = hero1;
            var defending = hero2;

            if (rand.FlipCoin())
            {
                swap(attacking, defending);
            }

            while (attacking.IsAlive() && defending.IsAlive())
            {
                defending.Defend(attacking);
                swap(attacking, defending);
            }
        }

        private void swap(Hero attacking, Hero defending)
        {
            var temp = attacking;
            attacking = defending;
            defending = temp;
        }

        /* 
         * The attacking hero get to attack first, and will
         * get an extra attack if 20 is rolled.
         */
        public void Ambush(Hero attacking, Hero defending)
        {

            if (rand.RollDice(20) == 20)
            {
                defending.Defend(attacking);
            }

            while (attacking.IsAlive() && defending.IsAlive())
            {
                defending.Defend(attacking);
                swap(attacking, defending);
            }
        }

        /*
         * The attacking hero will succesfully deal damage without
         * getting hit if a 6'er is rolled.
         */
        public void HitAndRun(Hero attacking, Hero defending)
        {
            if (rand.RollDice(6) == 6)
            {
                defending.Defend(attacking);
            }
        }
    }
}