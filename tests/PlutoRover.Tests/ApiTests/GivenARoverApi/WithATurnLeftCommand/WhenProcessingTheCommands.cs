using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithATurnLeftCommand
{
    public class WhenProcessingTheCommands
    {
        [Theory]
        [InlineData(Heading.N, "1,1,W")]
        [InlineData(Heading.E, "1,1,N")]
        [InlineData(Heading.S, "1,1,E")]
        [InlineData(Heading.W, "1,1,S")]
        public void ThenTheRoverShouldMoveForwardsInTheDirectionItIsFacing(Heading startingHeading, string expectedValue)
        {
            var subject = new RoverApi(new Rover(new Position(1, 1), startingHeading));
            var result = subject.Process("L");

            result.Should().Be(expectedValue);
        }
    }
}