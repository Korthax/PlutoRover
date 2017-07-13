namespace PlutoRover.Core
{
    public class Rover
    {
        private readonly Heading _heading;
        private Position _position;

        public Rover(Position position, Heading heading)
        {
            _position = position;
            _heading = heading;
        }

        public void MoveForwards()
        {
            _position += Vector.From(_heading);
        }

        public void MoveBackwards()
        {
            _position -= Vector.From(_heading);
        }

        public string GetLocation()
        {
            return $"{_position.X},{_position.Y},{_heading}";
        }
    }
}