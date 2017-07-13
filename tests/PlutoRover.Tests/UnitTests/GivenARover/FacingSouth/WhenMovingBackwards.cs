using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingSouth
{
    public class WhenMovingBackwards
    {
        [Fact]
        public void ThenTheYCoordinateIncreasesByOne()
        {
            var subject = new Rover(Position.Zero, Heading.S);
            subject.MoveBackwards();

            subject.GetLocation().Should().Be("0,1,S");
        }
    }
}