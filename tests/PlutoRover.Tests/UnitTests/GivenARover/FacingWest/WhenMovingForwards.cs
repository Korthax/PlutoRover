using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingWest
{
    public class WhenMovingForwards
    {
        [Fact]
        public void ThenTheXCoordinateDecreasesByOne()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);

            var subject = new Rover(Position.Zero, Heading.W, grid.Object);
            subject.MoveForwards();

            subject.GetLocation().Should().Be("-1,0,W");
        }
    }
}