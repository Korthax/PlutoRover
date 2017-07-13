namespace PlutoRover.Core
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
                var result = true;
                switch (command)
                {
                    case 'F':
                        result = _rover.Move(Direction.Forward);
                        break;
                    case 'B':
                        result = _rover.Move(Direction.Backwards);
                        break;
                    case 'L':
                        result = _rover.Turn(Rotation.Left);
                        break;
                    case 'R':
                        result = _rover.Turn(Rotation.Right);
                        break;
                }

                if(!result)
                    break;
            }

            return _rover.GetLocation();
        }
    }
}