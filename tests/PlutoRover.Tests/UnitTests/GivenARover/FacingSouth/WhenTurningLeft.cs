using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingSouth
{
    public class WhenTurningLeft
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeEast()
        {
            var subject = new Rover(Position.Zero, Heading.S);
            subject.TurnLeft();

            subject.GetLocation().Should().Be("0,0,E");
        }
    }
}