using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenAGrid.WithAPositionOffTheGrid
{
    public class WhenWrappingAPosition
    {
        [Theory]
        [InlineData(-1, 10, 99, 10)]
        [InlineData(100, 10, 0, 10)]
        [InlineData(10, -1, 10, 99)]
        [InlineData(10, 100, 10, 0)]
        public void ThenThePositionIsWrappedAroundToTheOtherSideCorrectly(int x, int y, int expectedX, int expectedY)
        {
            var subject = Grid.InitialiseFrom(100, 100);
            var result = subject.Wrap(new Position(x, y));

            result.Should().Be(new Position(expectedX, expectedY));
        }
    }
}