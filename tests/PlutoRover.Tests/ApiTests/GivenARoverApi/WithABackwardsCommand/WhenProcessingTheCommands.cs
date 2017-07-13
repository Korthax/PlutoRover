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
            var subject = new RoverApi(new Rover(new Position(1, 1), startingHeading));
            var result = subject.Process("B");

            result.Should().Be(expectedValue);
        }
    }
}