using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover
{
    public class WhenMovingToAnOccupiedPosition
    {
        [Fact]
        public void ThenTheRoverShouldNotMove()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);
            grid.Setup(x => x.IsValid(It.IsAny<Position>())).Returns(false);

            var subject = new Rover(Position.Zero, Heading.N, grid.Object);
            var result = subject.MoveForwards();

            result.Should().BeFalse();
            subject.GetLocation().Should().Be("0,0,N");
        }
    }
}