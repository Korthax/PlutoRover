namespace PlutoRover.Core
{
    public class Rover
    {
        private readonly Direction _direction;
        private readonly int _x;
        private readonly int _y;

        public Rover(int x, int y, Direction direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }

        public string GetLocation()
        {
            return $"{_x},{_y},{_direction}";
        }
    }
}