namespace GameOfGoose
{
    public class DeathObstacle : IObstacle
    {
        private Logger _logger = new Logger();

        public int Meaning(int currentPosition, int thrownNumbers)
        {
            _logger.Log("Death!");
            return 0; 
        }
    }
}