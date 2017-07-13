using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenAGrid.WithNoObstacles
{
    public class WhenValidatingAPositionOffTheGrid
    {
        [Theory]
        [InlineData(100, 0)]
        [InlineData(-1, 0)]
        [InlineData(0, 100)]
        [InlineData(0, -1)]
        public void ThenItShouldBeInvalid(int x, int y)
        {
            var subject = Grid.InitialiseFrom(100, 100);
            var result = subject.IsValid(new Position(x, y));
            result.Should().BeFalse();
        }
    }
}