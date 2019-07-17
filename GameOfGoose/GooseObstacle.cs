namespace GameOfGoose
{
    public class GooseObstacle : IObstacle
    {
        public int _positionNumber { get; set; }
        private Logger logger = new Logger();


        //public GooseObstacle(int positionNumber)
        //{
        //    _positionNumber = positionNumber;
        //}

        public int Meaning(int currentPosition, int thrownNumbers)
        {
            logger.Log("Goose!");
            int positon = currentPosition + thrownNumbers;
            return positon;
        }


    }
}