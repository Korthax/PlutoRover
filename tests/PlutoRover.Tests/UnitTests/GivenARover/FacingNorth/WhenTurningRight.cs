using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingNorth
{
    public class WhenTurningRight
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeEast()
        {
            var subject = new Rover(Position.Zero, Heading.N);
            subject.TurnRight();

            subject.GetLocation().Should().Be("0,0,E");
        }
    }
}