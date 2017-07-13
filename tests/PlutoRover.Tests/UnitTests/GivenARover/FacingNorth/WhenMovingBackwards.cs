using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingNorth
{
    public class WhenMovingBackwards
    {
        [Fact]
        public void ThenTheYCoordinateDecreasesByOne()
        {
            var subject = new Rover(Position.Zero, Direction.N);
            subject.MoveBackwards();

            subject.GetLocation().Should().Be("0,-1,N");
        }
    }
}