using System;

namespace GameOfGoose
{
    public class Dice
    {
        private readonly Random rnd;

        public Dice()
        {
            rnd = new Random();
        }

        public int ThrowDice()
        {
            int throwDice = rnd.Next(1, 7);
            return throwDice;
        }
    }
}