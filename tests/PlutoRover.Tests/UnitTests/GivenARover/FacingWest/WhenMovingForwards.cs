using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingWest
{
    public class WhenMovingForwards
    {
        [Fact]
        public void ThenTheXCoordinateDecreasesByOne()
        {
            var subject = new Rover(0, 0, Direction.W);
            subject.MoveForwards();

            subject.GetLocation().Should().Be("-1,0,W");
        }
    }
}