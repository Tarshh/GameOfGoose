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

                    var throwDice = dice.ThrowDice();
                    var throwDice2 = dice.ThrowDice();
                    var throwDiceTotal = throwDice + throwDice2;
                    logger.Log($"You have thrown {throwDice} + {throwDice2} for total {throwDiceTotal}");

                    if (piece.Position == 0)
                    {
                        if (throwDice == 5 && throwDice2 == 4 || throwDice == 4 && throwDice2 == 5)
                        {
                            piece.Position = 26;
                            logger.Log($"Piece {piece.PieceNumber} has landed on space {piece.Position} \n");
                            continue;
                        }

                        if (throwDice == 6 && throwDice2 == 3 || throwDice == 3 && throwDice2 == 6)
                        {
                            piece.Position = 53;
                            logger.Log($"Piece {piece.PieceNumber} has landed on space {piece.Position} \n");
                            continue;
                        }
                    }

                    var newPosition = piece.move(piece, throwDice, throwDice2);
                    piece.Position = newPosition;
                    

                    if (newPosition > win)
                    {
                        var stepsBack = newPosition - win;
                        piece.Position = win - stepsBack;
                        logger.Log($"Piece {piece.PieceNumber} has landed on space {piece.Position} \n");
                        continue;
                    }

                    if (piece.Position == win)
                    {
                        logger.Log($"Piece {piece.PieceNumber} has won the game");
                        won = false;
                        continue;
                    }

                    logger.Log($"Piece {piece.PieceNumber} has landed on space {newPosition} \n");
                }
            } while (won);

            Console.ReadLine();

        }
    }
}