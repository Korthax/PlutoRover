using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithMultipleCommands
{
    public class WhenACommandFails
    {
        [Theory]
        [InlineData("FFRFF", "0,2,E")]
        public void ThenTheOtherCommandsAreNotExecuted(string input, string expectedValue)
        {
            var grid = Grid.InitialiseFrom(100, 100)
                .AddObstacle(new Position(1, 2));

            var subject = new RoverApi(new Rover(Position.Zero, Heading.N, grid));
            var result = subject.Process(input);

            result.Should().Be(expectedValue);
        }
    }
}