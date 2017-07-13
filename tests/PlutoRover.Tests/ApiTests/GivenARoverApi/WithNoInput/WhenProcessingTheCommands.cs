using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithNoInput
{
    public class WhenProcessingTheCommands
    {
        [Theory]
        [InlineData(0, 0, Direction.N, "0,0,N")]
        [InlineData(10, 0, Direction.N, "10,0,N")]
        [InlineData(0, 10, Direction.N, "0,10,N")]
        [InlineData(10, 10, Direction.N, "10,10,N")]
        public void ThenTheStartingLocationIsReturned(int x, int y, Direction direction, string expectedValue)
        {
            var subject = new RoverApi(new Rover(x, y, direction));
            var result = subject.Process(null);

            result.Should().Be(expectedValue);
        }
    }
}