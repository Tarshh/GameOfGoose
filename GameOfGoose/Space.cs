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

        public int CheckSpace(Piece piece, int currentPosition, int totalThrow)
        {
            if (obstacles.Contains(currentPosition))
            {
                var newPosition = obstacle.CheckObstacle(piece, currentPosition, totalThrow);
                return newPosition;
            }
            else
            {
                return currentPosition;
            }


        }


    }
}