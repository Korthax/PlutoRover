using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingNorth
{
    public class WhenTurningRight
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeEast()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);

            var subject = new Rover(Position.Zero, Heading.N, grid.Object);
            subject.TurnRight();

            subject.GetLocation().Should().Be("0,0,E");
        }
    }
}