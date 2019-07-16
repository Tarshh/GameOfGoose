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

            logger.Log($"You have thrown {throwDice} + {throwDice2} for total {throwDiceTotal}");

            if (throwDiceTotal == 9 && piece.Position == 0)
            {
                logger.Log(CheckThrow(throwDice, throwDice2, piece));
            }

            return throwDiceTotal;
        }

        public string CheckThrow(int throw1, int throw2, Piece piece)
        {
            if (piece.Position == 0)
            {
                if (throw1 == 5 && throw2 == 4 || throw1 == 4 && throw2 == 5)
                {
                    piece.Position = 26;
                    string message = $"Piece {piece.PieceNumber} has landed on space {piece.Position} \n";
                    return message;
                }

                if (throw1 == 6 && throw2 == 3 || throw1 == 3 && throw2 == 6)
                {
                    piece.Position = 53;
                    string message = $"Piece {piece.PieceNumber} has landed on space {piece.Position} \n";
                    return message;
                }
            }

            return string.Empty;
        }
    }
}