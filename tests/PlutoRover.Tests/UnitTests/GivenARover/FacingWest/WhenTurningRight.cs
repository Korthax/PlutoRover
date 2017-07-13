using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingWest
{
    public class WhenTurningRight
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeNorth()
        {
            var subject = new Rover(Position.Zero, Heading.W);
            subject.TurnRight();

            subject.GetLocation().Should().Be("0,0,N");
        }
    }
}