using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingEast
{
    public class WhenMovingForwards
    {
        [Fact]
        public void ThenTheXCoordinateIncrementsByOne()
        {
            var subject = new Rover(0, 0, Direction.E);
            subject.MoveForwards();

            subject.GetLocation().Should().Be("1,0,E");
        }
    }
}