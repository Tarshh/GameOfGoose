using System;
using System.Collections.Generic;

namespace GameOfGoose
{
    public class Players
    {
        private Logger _logger = new Logger();
        public List<Piece> GetPieces()
        {
            List<Piece> pieces = new List<Piece>();
            do
            {
                Logger _logger = new Logger();
                _logger.Log("How many pieces will join the game?");
                int.TryParse(Console.ReadLine(), out var pieceCount);

                if (pieceCount < 2 || pieceCount > 4)
                {
                    _logger.Log($"This game is for 2 - 4 Players");
                }

                else
                {
                    for (int i = 1; i < pieceCount + 1; i++)
                    {
                        Piece piece = new Piece(i, 0);
                        pieces.Add(piece);
                    }
                    Console.WriteLine($"The game will be played with {pieces.Count} players \n");
                }

            } while (pieces.Count == 0);

            return pieces;
        }
    }
}