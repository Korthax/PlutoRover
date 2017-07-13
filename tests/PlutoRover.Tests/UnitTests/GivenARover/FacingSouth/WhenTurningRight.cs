using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingSouth
{
    public class WhenTurningRight
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeWest()
        {
            var subject = new Rover(Position.Zero, Heading.S);
            subject.TurnRight();

            subject.GetLocation().Should().Be("0,0,W");
        }
    }
}