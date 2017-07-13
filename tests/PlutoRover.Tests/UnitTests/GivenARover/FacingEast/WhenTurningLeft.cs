using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingEast
{
    public class WhenTurningLeft
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeNorth()
        {
            var subject = new Rover(Position.Zero, Heading.E);
            subject.TurnLeft();

            subject.GetLocation().Should().Be("0,0,N");
        }
    }
}