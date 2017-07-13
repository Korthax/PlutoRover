using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithMultipleCommands
{
    public class WhenProcessingTheCommands
    {
        [Theory]
        [InlineData("FFRFF", "2,2,E")]
        public void ThenTheRoverShouldMoveForwardsInTheDirectionItIsFacing(string input, string expectedValue)
        {
            var subject = new RoverApi(new Rover(Position.Zero, Heading.N, Grid.InitialiseFrom(100, 100)));
            var result = subject.Process(input);

            result.Should().Be(expectedValue);
        }
    }
}