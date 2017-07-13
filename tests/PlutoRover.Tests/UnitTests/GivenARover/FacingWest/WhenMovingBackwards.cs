using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingWest
{
    public class WhenMovingBackwards
    {
        [Fact]
        public void ThenTheXCoordinateIncreasesByOne()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);
            grid.Setup(x => x.IsValid(It.IsAny<Position>())).Returns(true);

            var subject = new Rover(Position.Zero, Heading.W, grid.Object);
            subject.MoveBackwards();

            subject.GetLocation().Should().Be("1,0,W");
        }
    }
}