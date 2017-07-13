using System.Collections.Generic;

namespace PlutoRover.Core
{
    public class Vector
    {
        private static readonly Dictionary<Heading, Vector> Directions = new Dictionary<Heading, Vector>
        {
            [Heading.N] = new Vector(0, 1),
            [Heading.S] = new Vector(0, -1),
            [Heading.E] = new Vector(1, 0),
            [Heading.W] = new Vector(-1, 0)
        };

        public int X { get; }
        public int Y { get; }

        public static Vector Inverse(Vector vector)
        {
            return new Vector(-vector.X, -vector.Y);
        }

        public static Vector From(Heading heading)
        {
            return Directions[heading];
        }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        protected bool Equals(Vector other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj))
                return false;

            if(ReferenceEquals(this, obj))
                return true;

            return obj.GetType() == GetType() && Equals((Vector)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }

    public class Position
    {
        public static Position Zero => new Position(0, 0);

        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Position operator +(Position left, Vector right)
        {
            return new Position(left.X + right.X, left.Y + right.Y);
        }

        public static Position operator -(Position left, Vector right)
        {
            return new Position(left.X - right.X, left.Y - right.Y);
        }

        protected bool Equals(Position other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj))
                return false;

            if(ReferenceEquals(this, obj))
                return true;

            return obj.GetType() == GetType() && Equals((Position)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}