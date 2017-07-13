using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingEast
{
    public class WhenMovingBackwards
    {
        [Fact]
        public void ThenTheXCoordinateDecreasesByOne()
        {
            var subject = new Rover(Position.Zero, Direction.E);
            subject.MoveBackwards();

            subject.GetLocation().Should().Be("-1,0,E");
        }
    }
}