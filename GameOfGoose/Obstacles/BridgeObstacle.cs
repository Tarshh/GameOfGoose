namespace GameOfGoose
{
    public class BridgeObstacle : IObstacle
    {
        private Logger logger = new Logger();

        public int Meaning(int currentPosition, int thrownNumbers)
        {
            logger.Log("Bridge!");
            return 12;
        }
    }
}