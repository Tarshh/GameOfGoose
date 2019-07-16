using System;

namespace GameOfGoose
{
    public class Piece
    {
        public int PieceNumber { get; set; }
        public int Position { get; set; }

        public Piece(int pieceNumber, int position)
        {
            PieceNumber = pieceNumber;
            Position = position;
        }

        public int move(Piece piece, int diceNumber, int diceNumber2)
        {
            int position = Position + (diceNumber + diceNumber2);
            return position;
        }

    }
}