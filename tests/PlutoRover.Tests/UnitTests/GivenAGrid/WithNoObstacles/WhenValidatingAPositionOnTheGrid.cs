using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenAGrid.WithNoObstacles
{
    public class WhenValidatingAPositionOnTheGrid
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(10, 10)]
        [InlineData(99, 9)]
        public void ThenItIsValid(int x, int y)
        {
            var subject = Grid.InitialiseFrom(100, 100);
            var result = subject.IsValid(new Position(x, y));
            result.Should().BeTrue();
        }
    }
}