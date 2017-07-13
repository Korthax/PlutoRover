using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingEast
{
    public class WhenTurningRight
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeSouth()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);

            var subject = new Rover(Position.Zero, Heading.E, grid.Object);
            subject.Turn(Rotation.Right);

            subject.GetLocation().Should().Be("0,0,S");
        }
    }
}