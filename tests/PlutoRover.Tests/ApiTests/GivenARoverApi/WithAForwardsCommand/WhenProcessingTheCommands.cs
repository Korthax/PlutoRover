using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithAForwardsCommand
{
    public class WhenProcessingTheCommands
    {
        [Theory]
        [InlineData(Heading.N, "1,2,N")]
        [InlineData(Heading.E, "2,1,E")]
        [InlineData(Heading.S, "1,0,S")]
        [InlineData(Heading.W, "0,1,W")]
        public void ThenTheRoverShouldMoveForwardsInTheDirectionItIsFacing(Heading startingHeading, string expectedValue)
        {
            var subject = new RoverApi(new Rover(new Position(1, 1), startingHeading));
            var result = subject.Process("F");

            result.Should().Be(expectedValue);
        }
    }
}