using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfGoose
{
    public class Space
    {

        private Obstacle obstacle = new Obstacle();

        //List<IObstacle> obstacles = new List<IObstacle>();
        int[] obstacles = { 5, 6, 9, 14, 18, 19, 23, 27, 31, 32, 36, 41, 42, 45, 50, 52, 54, 58, 59 };

        //public List<IObstacle> CreateObstacles()
        //{
            
        //    foreach (var i in goose)
        //    {
        //        obstacles.Add(new GooseObstacle(i));
        //    }


        //    return obstacles;
        //}

        public int CheckSpace(Piece piece, int currentPosition, int totalThrow, int turn)
        {
            var newPosition = new int();
            if (obstacles.Contains(currentPosition))
            {
                newPosition = obstacle.CheckObstacle(piece, currentPosition, totalThrow, turn);
            //obstacles.Contains(newPosition) ? obstacle.CheckObstacle(piece, newPosition) : checkAgain = false;

                while (obstacles.Contains(newPosition))
                {
                    obstacle.CheckObstacle(piece, newPosition, totalThrow, turn);
                    return newPosition;
                }

                //if newPosition contains obstaclenumbres --> opnieuw checkObstacle 
            }
            else
            {
                return currentPosition;
            }

            return newPosition;
        }


    }
}