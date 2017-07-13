using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingSouth
{
    public class WhenMovingBackwards
    {
        [Fact]
        public void ThenTheYCoordinateIncreasesByOne()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);

            var subject = new Rover(Position.Zero, Heading.S, grid.Object);
            subject.MoveBackwards();

            subject.GetLocation().Should().Be("0,1,S");
        }
    }
}