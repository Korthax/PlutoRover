using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover
{
    public class WhenMovingToAnUnoccupiedPosition
    {
        [Fact]
        public void ThenTheCommandShouldBeSuccessful()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);
            grid.Setup(x => x.IsValid(It.IsAny<Position>())).Returns(true);

            var subject = new Rover(Position.Zero, Heading.N, grid.Object);
            var result = subject.Move(Direction.Forward);

            result.Should().BeTrue();
            subject.GetLocation().Should().Be("0,1,N");
        }
    }
}