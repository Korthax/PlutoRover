using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingEast
{
    public class WhenTurningRight
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeSouth()
        {
            var subject = new Rover(Position.Zero, Heading.E);
            subject.TurnRight();

            subject.GetLocation().Should().Be("0,0,S");
        }
    }
}