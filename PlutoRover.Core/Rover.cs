using System;

namespace PlutoRover.Core
{
    public class Rover
    {
        private readonly Direction _direction;

        private int _x;
        private int _y;

        public Rover(int x, int y, Direction direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }

        public void MoveForwards()
        {
            switch (_direction)
            {
                case Direction.N:
                    _y += 1;
                    break;
                case Direction.E:
                    _x += 1;
                    break;
                case Direction.S:
                    _y -= 1;
                    break;
                case Direction.W:
                    _x -= 1;
                    break;
            }
        }

        public void MoveBackwards()
        {
            switch(_direction)
            {
                case Direction.N:
                    _y -= 1;
                    break;
                case Direction.E:
                    _x -= 1;
                    break;
                case Direction.S:
                    _y += 1;
                    break;
                case Direction.W:
                    _x += 1;
                    break;
            }
        }

        public string GetLocation()
        {
            return $"{_x},{_y},{_direction}";
        }
    }
}