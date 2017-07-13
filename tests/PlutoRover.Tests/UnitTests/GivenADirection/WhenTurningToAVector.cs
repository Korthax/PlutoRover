using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenADirection
{
    public class WhenTurningToAVector
    {
        [Theory]
        [InlineData(Direction.N, 0, 1)]
        [InlineData(Direction.S, 0, -1)]
        [InlineData(Direction.E, 1, 0)]
        [InlineData(Direction.W, -1, 0)]
        public void ThenTheCorrectForwardDirectionIsReturned(Direction direction, int expectedX, int expectedY)
        {
            var result = Vector.From(direction);
            result.Should().Be(new Vector(expectedX, expectedY));
        }
    }
}