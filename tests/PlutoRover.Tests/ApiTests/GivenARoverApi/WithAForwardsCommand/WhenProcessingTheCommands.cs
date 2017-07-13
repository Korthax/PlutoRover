using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithAForwardsCommand
{
    public class WhenProcessingTheCommands
    {
        [Theory]
        [InlineData(Direction.N, "1,2,N")]
        [InlineData(Direction.E, "2,1,E")]
        [InlineData(Direction.S, "1,0,S")]
        [InlineData(Direction.W, "0,1,W")]
        public void ThenTheRoverShouldMoveForwardsInTheDirectionItIsFacing(Direction startingDirection, string expectedValue)
        {
            var subject = new RoverApi(new Rover(new Position(1, 1), startingDirection));
            var result = subject.Process("F");

            result.Should().Be(expectedValue);
        }
    }
}