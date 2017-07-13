using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingWest
{
    public class WhenTurningLeft
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeSouth()
        {
            var subject = new Rover(Position.Zero, Heading.W);
            subject.TurnLeft();

            subject.GetLocation().Should().Be("0,0,S");
        }
    }
}