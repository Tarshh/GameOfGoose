namespace GameOfGoose
{
    public class SkipTurnObstacle : ISkipTurnObstacle
    {
        public void SkipTurn(Piece piece, int turns)
        {

            piece.AmountSkipTurn = turns;
        }
    }
}