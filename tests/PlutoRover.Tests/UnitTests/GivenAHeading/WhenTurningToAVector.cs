using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenAHeading
{
    public class WhenTurningToAVector
    {
        [Theory]
        [InlineData(Heading.N, 0, 1)]
        [InlineData(Heading.S, 0, -1)]
        [InlineData(Heading.E, 1, 0)]
        [InlineData(Heading.W, -1, 0)]
        public void ThenTheCorrectForwardVectorIsReturned(Heading heading, int expectedX, int expectedY)
        {
            var result = Vector.From(heading);
            result.Should().Be(new Vector(expectedX, expectedY));
        }
    }
}