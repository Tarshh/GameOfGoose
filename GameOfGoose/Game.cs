using System;
using System.Collections.Generic;

namespace GameOfGoose
{
    public class Game
    {
        //public List<Piece> Pieces { get; set; }
        //public List<Space> Spaces { get; set; }
        //public Dice Dice { get; set; }


        public void PlayGame(List<Piece>pieces)
        {
            Dice dice = new Dice();
            Logger logger = new Logger();
            int win = 63;
            int turn = 0;
            bool won = true;

            do
            {
                turn++;
                logger.Log($"Turn {turn}");

                foreach (var piece in pieces)
                {
                    logger.Log($"Piece {piece.PieceNumber}, Press < Enter > to throw dice");
                    logger.Read();

                    var totalThrow = dice.ThrowTotal(piece);

                    var newPosition = piece.Move(piece, totalThrow);

                    var checkPosition = piece.CheckPosition(newPosition, piece);

                    logger.Log(checkPosition);

                    //Dit nog checken, kan niet zien of de string 63 bevat. won wordt niet op false gezet.
                    if (checkPosition.Contains("63"))
                    {
                        won = false;
                    }

                }
            } while (won);

        }
    }
}