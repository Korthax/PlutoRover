using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingSouth
{
    public class WhenMovingForwards
    {
        [Fact]
        public void ThenTheYCoordinateDecreasesByOne()
        {
            var subject = new Rover(0, 0, Direction.S);
            subject.MoveForwards();

            subject.GetLocation().Should().Be("0,-1,S");
        }
    }
}