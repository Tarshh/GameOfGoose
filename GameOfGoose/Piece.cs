using System;

namespace GameOfGoose
{
    public class Piece
    {
        public int PieceNumber { get; set; }
        public int Position { get; set; }
        public int AmountSkipTurn { get; set; }
        public bool StepBack { get; set; }
        private int _win = 63;
        private readonly Logger _logger = new Logger();
        private Space _space = new Space();
        public Piece(int pieceNumber, int position)
        {
            PieceNumber = pieceNumber;
            Position = position;
        }

        public string Move(int totalThrow)
        {
            int position = Position + totalThrow;
            position = _space.CheckSpace(this, position, totalThrow);
            var newPosition = CheckPosition(position, totalThrow);
            return newPosition;
        }

        public string CheckPosition(int newPosition, int totalThrow)
        {
            string message;
            if (newPosition > _win)
            {
                StepBack = true;
                var stepsBack = newPosition - _win;
                Position = _win - stepsBack;
                Position = _space.CheckSpace(this, Position, totalThrow);
                message = ($"Piece {PieceNumber} => {Position} \n");
                StepBack = false;
                return message;
            }

            if (newPosition == _win)
            {
                 message = $"{newPosition}! Piece {PieceNumber} has won the game";
                 Position = 63;
                return message;
            }

            Position = newPosition;
            message = ($"Piece {PieceNumber} => {newPosition} \n");
           return message;
        }

        public bool CheckSkip(int turn)
        {
            if (AmountSkipTurn > 0)
            {
                AmountSkipTurn--;
                if (AmountSkipTurn == 0)
                {
                    _logger.Log($"Piece {PieceNumber} can play again next round \n");
                    return true;
                }
                else
                {
                    _logger.Log($"Piece {PieceNumber} is skipping {AmountSkipTurn} more turn(s)");
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool CheckWin(int newPosition)
        {
            if (newPosition == 63)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}