using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithATurnRightCommand
{
    public class WhenProcessingTheCommands
    {
        [Theory]
        [InlineData(Heading.N, "1,1,E")]
        [InlineData(Heading.E, "1,1,S")]
        [InlineData(Heading.S, "1,1,W")]
        [InlineData(Heading.W, "1,1,N")]
        public void ThenTheRoverShouldMoveForwardsInTheDirectionItIsFacing(Heading startingHeading, string expectedValue)
        {
            var subject = new RoverApi(new Rover(new Position(1, 1), startingHeading, Grid.InitialiseFrom(100, 100)));
            var result = subject.Process("R");

            result.Should().Be(expectedValue);
        }
    }
}