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
            Space space = new Space();
            int turn = 0;
            bool won = true;

            do
            {
                turn++;
                logger.Log($"Turn {turn}");

                foreach (var piece in pieces)
                {
                    if (piece.AmountSkipTurn > 0)
                    {
                        piece.AmountSkipTurn--;
                        logger.Log($"Piece {piece.PieceNumber} is skipping turn \n");
                    }
                    else
                    {
                        logger.Log($"Piece {piece.PieceNumber}, Press < Enter > to throw dice");
                        logger.Read();

                        var totalThrow = dice.ThrowTotal(piece);

                        var newPosition = piece.Move(piece, totalThrow);

                        var checkedForObstacle = space.CheckSpace(piece, newPosition, totalThrow, turn);

                        var checkPosition = piece.CheckPosition(checkedForObstacle, piece);

                        logger.Log(checkPosition);

                        if (checkedForObstacle == 63)
                        {
                            won = false;
                        }
                    }
                }
            } while (won);

        }
    }
}