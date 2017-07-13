using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingNorth
{
    public class WhenMovingBackwards
    {
        [Fact]
        public void ThenTheYCoordinateIncrementsByOne()
        {
            var subject = new Rover(0, 0, Direction.N);
            subject.MoveBackwards();

            subject.GetLocation().Should().Be("0,-1,N");
        }
    }
}