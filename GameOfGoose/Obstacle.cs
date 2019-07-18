using System.Linq;

namespace GameOfGoose
{
    public class Obstacle
    {
        private IObstacle GooseObstacle = new GooseObstacle();
        private ISkipTurnObstacle skipTurnObstacle = new SkipTurnObstacle();
        //private IObstacle BridgeObstacle = new BridgeObstacle();
        //private IObstacle DeathObstacle = new DeathObstacle();
        //private IObstacle MazeObstacle = new MazeObstacle();

        private readonly int[] _gooseObstacle = {5, 9, 14, 18, 23, 27, 32, 36, 41, 45, 50, 54, 59};

        public int CheckObstacle(Piece piece, int currentPosition, int totalThrow, int turn)
        {
            while (true)
            {
                if (_gooseObstacle.Contains(currentPosition))
                {
                    var newPosition = GooseObstacle.Meaning(currentPosition, totalThrow);

                    return newPosition;
                }

                //Bridge
                if (currentPosition == 6)
                {
                    //var newPosition = BridgeObstacle.Meaning(currentPosition, totalThrow);
                    var newPosition = 12;
                    return newPosition;
                }

                //Death
                if (currentPosition == 58)
                {
                    //var newPosition = DeathObstacle.Meaning(currentPosition, totalThrow);
                    var newPosition = 0;
                    return newPosition;
                }

                //Maze
                if (currentPosition == 42)
                {
                    var newPostion = 39;
                    return newPostion;
                }

                //Inn
                if (currentPosition == 19)
                {
                    var turns = 1;
                    skipTurnObstacle.SkipTurn(piece, turns);
                    return currentPosition;
                }

                if (currentPosition == 52)
                {
                    var turns = 3;
                    skipTurnObstacle.SkipTurn(piece, turns);
                    return currentPosition;
                }
                else
                {
                    return currentPosition;
                    
                }
            }
            
           
        }
    }
}