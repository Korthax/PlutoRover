using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithABackwardsCommand
{
    public class WhenProcessingTheCommands
    {
        [Theory]
        [InlineData(Heading.N, "1,0,N")]
        [InlineData(Heading.E, "0,1,E")]
        [InlineData(Heading.S, "1,2,S")]
        [InlineData(Heading.W, "2,1,W")]
        public void ThenTheRoverShouldMoveBackwardsInTheDirectionItIsFacing(Heading startingHeading, string expectedValue)
        {
            var subject = new RoverApi(new Rover(new Position(1, 1), startingHeading, Grid.InitialiseFrom(100, 100)));
            var result = subject.Process("B");

            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(Heading.N, 0, 0, "0,99,N")]
        [InlineData(Heading.E, 0, 0, "99,0,E")]
        [InlineData(Heading.S, 99, 99, "99,0,S")]
        [InlineData(Heading.W, 99, 99, "0,99,W")]
        public void ThenTheRoverShouldWrapAroundTheGrid(Heading startingHeading, int x, int y, string expectedValue)
        {
            var subject = new RoverApi(new Rover(new Position(x, y), startingHeading, Grid.InitialiseFrom(100, 100)));
            var result = subject.Process("B");

            result.Should().Be(expectedValue);
        }
    }
}