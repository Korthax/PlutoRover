using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithAForwardsCommand
{
    public class WhenProcessingTheCommands
    {
        [Fact]
        public void ThenTheRoverShouldMoveForwardsInTheDirectionItIsFacing()
        {
            var subject = new RoverApi(new Rover(0, 0, Direction.N));
            var result = subject.Process("F");

            result.Should().Be("0,1,N");
        }
    }
}