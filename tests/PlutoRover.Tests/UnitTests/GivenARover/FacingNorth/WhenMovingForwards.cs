using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingNorth
{
    public class WhenMovingForwards
    {
        [Fact]
        public void ThenTheYCoordinateIncrementsByOne()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);
            grid.Setup(x => x.IsValid(It.IsAny<Position>())).Returns(true);

            var subject = new Rover(Position.Zero, Heading.N, grid.Object);
            subject.MoveForwards();

            subject.GetLocation().Should().Be("0,1,N");
        }
    }
}