namespace GameOfGoose
{
    public class MazeObstacle : IObstacle
    {
        private Logger _logger = new Logger();

        public int Meaning(int currentPosition, int thrownNumbers)
        {
            _logger.Log("Maze!");
            return 39;
        }
    }
}