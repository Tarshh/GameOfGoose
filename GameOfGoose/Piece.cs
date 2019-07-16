using System;

namespace GameOfGoose
{
    public class Piece
    {
        public int PieceNumber { get; set; }
        public int Position { get; set; }
        private int _win = 63;
        private readonly Logger logger;
        public Piece(int pieceNumber, int position)
        {
            PieceNumber = pieceNumber;
            Position = position;
            Logger log = logger;
        }

        public int Move(Piece piece, int totalThrow)
        {
            int position = Position + totalThrow;
            return position;
        }

        public string CheckPosition(int newPosition, Piece piece)
        {
            string message;
            if (newPosition > _win)
            {
                var stepsBack = newPosition - _win;
                piece.Position = _win - stepsBack;
                message = ($"Piece {piece.PieceNumber} has landed on space {piece.Position} \n");
                return message;
            }

            if (newPosition == _win)
            {
                 message = $"Piece {piece.PieceNumber} has won the game";
                return message;
            }

            piece.Position = newPosition;
           message = ($"Piece {piece.PieceNumber} has landed on space {newPosition} \n");
           return message;
        }
    }
}