using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingWest
{
    public class WhenMovingBackwards
    {
        [Fact]
        public void ThenTheXCoordinateIncreasesByOne()
        {
            var subject = new Rover(Position.Zero, Direction.W);
            subject.MoveBackwards();

            subject.GetLocation().Should().Be("1,0,W");
        }
    }
}