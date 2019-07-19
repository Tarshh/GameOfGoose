using System.Linq;

namespace GameOfGoose
{
    public class Obstacle
    {
        private IGooseObstacle _gooseObstacle = new GooseObstacle();
        private ISkipTurnObstacle _skipTurnObstacle = new SkipTurnObstacle();
        private IObstacle _bridgeObstacle = new BridgeObstacle();
        private IObstacle _deathObstacle = new DeathObstacle();
        private IObstacle _mazeObstacle = new MazeObstacle();

        private readonly int[] _gooseObstacles = {5, 9, 14, 18, 23, 27, 32, 36, 41, 45, 50, 54, 59};

        public int CheckObstacle(Piece piece, int currentPosition, int totalThrow)
        {
            while (true)
            {
                if (_gooseObstacles.Contains(currentPosition))
                {
                    var newPosition = _gooseObstacle.Meaning(piece, currentPosition, totalThrow );
                    piece.StepBack = false;
                    return newPosition;
                }

                //Bridge
                if (currentPosition == 6)
                {
                    var newPosition = _bridgeObstacle.Meaning(currentPosition, totalThrow);
                    return newPosition;
                }

                //Inn
                if (currentPosition == 19)
                {
                    var turns = 1;
                    _skipTurnObstacle.SkipTurn(piece, turns);
                    return currentPosition;
                }

                ////well
                //if (currentPosition == 31)
                //{
                //    var newPosition = piece.Well();
                //    return newPosition;
                //}

                //Maze
                if (currentPosition == 42)
                {
                    var newPosition = _mazeObstacle.Meaning(currentPosition, totalThrow);
                    return newPosition;
                }

                //Prison
                if (currentPosition == 52)
                {
                    var turns = 3;
                    _skipTurnObstacle.SkipTurn(piece, turns);
                    return currentPosition;
                }

                //Death
                if (currentPosition == 58)
                {
                    var newPosition = _deathObstacle.Meaning(currentPosition, totalThrow);
                    return newPosition;
                }

                else
                {
                    return currentPosition;
                }
            }
        }
    }
}