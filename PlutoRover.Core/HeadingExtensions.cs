namespace PlutoRover.Core
{
    public static class HeadingExtensions
    {
        public static Heading RotateLeft(this Heading heading)
        {
            return heading == 0 ? Heading.Count - 1 : heading - 1;
        }

        public static Heading RotateRight(this Heading heading)
        {
            return heading == Heading.Count - 1 ? 0 : heading + 1;
        }
    }
}