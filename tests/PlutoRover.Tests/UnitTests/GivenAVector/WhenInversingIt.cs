using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenAVector
{
    public class WhenInversingIt
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 1, -1, -1)]
        [InlineData(-1, -1, 1, 1)]
        public void ThenTheCorrectValueIsReturned(int x, int y, int expectedX, int expectedY)
        {
            var result = Vector.Inverse(new Vector(x, y));
            result.Should().Be(new Vector(expectedX, expectedY));
        }
    }
}