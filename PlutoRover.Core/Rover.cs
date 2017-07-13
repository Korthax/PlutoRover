using System;

namespace PlutoRover.Core
{
    public class Rover
    {
        private readonly Direction _direction;
        private Position _position;

        public Rover(Position position, Direction direction)
        {
            _position = position;
            _direction = direction;
        }

        public void MoveForwards()
        {
            _position += Vector.From(_direction);
        }

        public void MoveBackwards()
        {
            _position -= Vector.From(_direction);
        }

        public string GetLocation()
        {
            return $"{_position.X},{_position.Y},{_direction}";
        }
    }
}