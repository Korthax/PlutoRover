namespace PlutoRover.Core
{
    public class Grid
    {
        private readonly bool[,] _grid;

        public static Grid InitialiseFrom(int width, int height)
        {
            var data = new bool[width, height];
            return new Grid(data);
        }

        private Grid(bool[,] grid)
        {
            _grid = grid;
        }

        public Position Wrap(Position position)
        {
            var x = position.X < _grid.GetUpperBound(0)
                ? position.X < 0 ? _grid.GetUpperBound(0) : position.X
                : 0;

            var y = position.Y < _grid.GetUpperBound(1)
                ? position.Y < 0 ? _grid.GetUpperBound(1) : position.Y
                : 0;

            return new Position(x, y);
        }
    }
}