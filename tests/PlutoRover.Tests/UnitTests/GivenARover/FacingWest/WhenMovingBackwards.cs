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
            var subject = new Rover(0, 0, Direction.W);
            subject.MoveBackwards();

            subject.GetLocation().Should().Be("1,0,W");
        }
    }
}