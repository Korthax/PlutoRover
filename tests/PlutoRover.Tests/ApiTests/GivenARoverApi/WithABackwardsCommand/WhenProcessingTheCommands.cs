using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithABackwardsCommand
{
    public class WhenProcessingTheCommands
    {
        [Theory]
        [InlineData(Direction.N, "1,0,N")]
        [InlineData(Direction.E, "0,1,E")]
        [InlineData(Direction.S, "1,2,S")]
        [InlineData(Direction.W, "2,1,W")]
        public void ThenTheRoverShouldMoveBackwardsInTheDirectionItIsFacing(Direction startingDirection, string expectedValue)
        {
            var subject = new RoverApi(new Rover(1, 1, startingDirection));
            var result = subject.Process("B");

            result.Should().Be(expectedValue);
        }
    }
}