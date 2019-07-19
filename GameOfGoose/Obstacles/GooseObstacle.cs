namespace GameOfGoose
{
    public class GooseObstacle : IGooseObstacle
    {
        private Logger logger = new Logger();

        public int Meaning(Piece piece, int currentPosition, int thrownNumbers)
        {
            if (piece.StepBack == true )
            {
                logger.Log("Goose!");
                int positon = currentPosition - thrownNumbers;
                return positon;
            }
            else
            {
                logger.Log("Goose!");
                int positon = currentPosition + thrownNumbers;
                return positon;
            }

        }


    }
}