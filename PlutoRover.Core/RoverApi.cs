﻿namespace PlutoRover.Core
{
    public class RoverApi
    {
        private readonly Rover _rover;

        public RoverApi(Rover rover)
        {
            _rover = rover;
        }

        public string Process(string input)
        {
            foreach(var command in input ?? "")
            {
                switch (command)
                {
                    case 'F':
                        _rover.Move(Direction.Forward);
                        break;
                    case 'B':
                        _rover.Move(Direction.Backwards);
                        break;
                    case 'L':
                        _rover.TurnLeft();
                        break;
                    case 'R':
                        _rover.TurnRight();
                        break;
                }
            }

            return _rover.GetLocation();
        }
    }
}