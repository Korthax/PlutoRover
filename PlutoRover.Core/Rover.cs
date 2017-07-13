namespace PlutoRover.Core
{
    public class Rover
    {
        private readonly IGrid _grid;
        private Position _position;
        private Heading _heading;

        public Rover(Position position, Heading heading, IGrid grid)
        {
            _position = position;
            _heading = heading;
            _grid = grid;
        }

        public bool Move(Direction direction)
        {
            var vector = Vector.From(_heading);
            var newPosition = _grid.Wrap(_position + (direction == Direction.Forward ? vector : Vector.Inverse(vector)));

            if (!_grid.IsValid(newPosition))
                return false;

            _position = newPosition;
            return true;
        }

        public void TurnLeft()
        {
            _heading = _heading == 0 ? Heading.Count - 1 : _heading - 1;
        }

        public void TurnRight()
        {
            _heading = _heading == Heading.Count - 1 ? 0 : _heading + 1;
        }

        public string GetLocation()
        {
            return $"{_position.X},{_position.Y},{_heading}";
        }
    }
}