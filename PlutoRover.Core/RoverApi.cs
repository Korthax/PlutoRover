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
            switch(input)
            {
                case "F":
                    _rover.MoveForwards();
                    break;
                case "B":
                    _rover.MoveBackwards();
                    break;
            }

            return _rover.GetLocation();
        }
    }
}