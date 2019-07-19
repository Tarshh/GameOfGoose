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
            Players players = new Players();
            var pieces = players.GetPieces();

            Game game = new Game();
            
            game.PlayGame(pieces);

            Console.ReadLine();
        }
    }
}
