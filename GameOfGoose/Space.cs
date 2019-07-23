using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfGoose
{
    public class Space
    {
        private Obstacle obstacle = new Obstacle();

        int[] _obstacles = { 5, 6, 9, 14, 18, 19, 23, 27, 31, 32, 36, 41, 42, 45, 50, 52, 54, 58, 59 };

        public int CheckSpace(Piece piece, int currentPosition, int totalThrow)
        {
            var newPosition = new int();
            if (_obstacles.Contains(currentPosition))
            {
                newPosition = obstacle.CheckObstacle(piece, currentPosition, totalThrow);

                while (_obstacles.Contains(newPosition))
                {
                   newPosition =  obstacle.CheckObstacle(piece, newPosition, totalThrow);
                   //if (newPosition == 19 || newPosition == 52 && piece.StepBack == false)
                   //{
                   //    return newPosition;
                   //}
                   if (newPosition == 19)
                   {
                       obstacle.CheckObstacle(piece, newPosition, totalThrow);
                       return newPosition;
                   }


                   if (newPosition == 52)
                   {
                       obstacle.CheckObstacle(piece, newPosition, totalThrow);
                       return newPosition;
                   }
                }
                return newPosition;
            }
            else
            {
                return currentPosition;
            }
        }


    }
}