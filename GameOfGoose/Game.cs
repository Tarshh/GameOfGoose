using System;
using System.Collections.Generic;

namespace GameOfGoose
{
    public class Game
    {
        public void PlayGame(List<Piece>pieces)
        {
            Dice dice = new Dice();
            Logger logger = new Logger();
            int turn = 0;
            bool won = true;

            do
            {
                turn++;
                logger.Log($"Turn {turn}");

                foreach (var piece in pieces)
                {
                    var checkAmountSkip = piece.CheckSkip(turn);

                    if (checkAmountSkip == true)
                    {
                       continue;
                    }
                    else
                    {
                        logger.Log($"Piece {piece.PieceNumber}, Press < Enter > to throw dice");

                        logger.Read();

                        var totalThrow = dice.ThrowTotal(piece);

                        var newPosition = piece.Move(totalThrow);

                        logger.Log(newPosition);

                        won = piece.CheckWin(piece.Position);
//
                    }
                }
            } while (won);

        }
    }
}