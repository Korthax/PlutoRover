using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingNorth
{
    public class WhenTurningLeft
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeWest()
        {
            var subject = new Rover(Position.Zero, Heading.N);
            subject.TurnLeft();

            subject.GetLocation().Should().Be("0,0,W");
        }
    }
}