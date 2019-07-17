using System;
using System.Collections.Generic;

namespace GameOfGoose
{
    public class Game
    {
        //public List<Piece> Pieces { get; set; }
        public List<Space> Spaces { get; set; }
        //public Dice Dice { get; set; }


        public void PlayGame(List<Piece>pieces)
        {
            Dice dice = new Dice();
            Logger logger = new Logger();
            Space space = new Space();
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
                    //probleem --> Als er een special combo wordt gegooid logt hij de plaats, maar daarna gaat hij ook naar volgende functie.

                    //You have thrown 4 + 5 for total 9
                    //Piece 3 has landed on space 26

                    //Piece 3 has landed on space 35

                    var newPosition = piece.Move(piece, totalThrow);

                    //Hier space checken
                    var checkedForObstacle = space.CheckSpace(piece, newPosition, totalThrow);
                    ////
                    
                    var checkPosition = piece.CheckPosition(checkedForObstacle, piece);

                    logger.Log(checkPosition);

                    if (checkedForObstacle == 63)
                    {
                        won = false;
                    }

                }
            } while (won);

        }
    }
}