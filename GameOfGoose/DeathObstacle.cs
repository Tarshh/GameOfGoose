namespace GameOfGoose
{
    public class DeathObstacle : IObstacle
    {
        private Logger logger = new Logger();

        public int Meaning(int currentPosition, int thrownNumbers)
        {
            logger.Log("Death!");
            return 0;
        }
    }
}