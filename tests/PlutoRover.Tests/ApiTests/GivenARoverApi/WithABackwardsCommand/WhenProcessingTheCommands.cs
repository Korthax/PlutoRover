using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithABackwardsCommand
{
    public class WhenProcessingTheCommands
    {
        [Fact]
        public void ThenTheRoverShouldMoveBackwardsFromTheDirectionItIsFacing()
        {
            var subject = new RoverApi(new Rover(0, 1, Direction.N));
            var result = subject.Process("B");

            result.Should().Be("0,0,N");
        }
    }
}