using System;

namespace GameOfGoose
{
    public class Dice
    {
        private readonly Random rnd;
        private readonly Logger logger;

        public Dice()
        {
            rnd = new Random();
            logger = new Logger();
        }

        public int ThrowDice()
        {
            int throwDice = rnd.Next(1, 7);
            return throwDice;
        }

        public int ThrowTotal(Piece piece)
        {
            var throwDice = ThrowDice();
            var throwDice2 = ThrowDice();

            var throwDiceTotal = throwDice + throwDice2;

            logger.Log($"{throwDice} + {throwDice2} = {throwDiceTotal}");

            if (throwDiceTotal == 9 && piece.Position == 0)
            {
                var specialThrow = CheckThrow(throwDice, throwDice2, piece, throwDiceTotal);
                return specialThrow;
            }

            return throwDiceTotal;
        }

        public int CheckThrow(int throw1, int throw2, Piece piece, int throwDiceTotal)
        {
            if (throw1 == 5 && throw2 == 4 || throw1 == 4 && throw2 == 5)
            {
                var specialThrow = 26;
                return specialThrow;
            }

            if (throw1 == 6 && throw2 == 3 || throw1 == 3 && throw2 == 6)
            {
                var specialThrow = 53;
                return specialThrow;
            }

            return throwDiceTotal;
        }
    }
}