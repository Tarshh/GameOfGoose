using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piece> pieces = new List<Piece>();
            Console.WriteLine("How many pieces will join the game?");
            int.TryParse(Console.ReadLine(), out var pieceCount);

            for (int i = 1; i < pieceCount + 1; i++)
            {
                Piece piece = new Piece(i, 0);
                pieces.Add(piece);
            }

            Console.WriteLine($"The game will be played with {pieces.Count} players \n");

            Game game = new Game();
            
            game.PlayGame(pieces);

            Console.ReadLine();
        }
    }
}
