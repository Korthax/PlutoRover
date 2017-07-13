using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenAGrid.WithAnObstacle
{
    public class WhenValidatingThatPosition
    {
        [Fact]
        public void ThenItIsNotValid()
        {
            var subject = Grid.InitialiseFrom(100, 100);
            subject.AddObstacle(new Position(10, 10));

            var result = subject.IsValid(new Position(10, 10));

            result.Should().BeFalse();
        }
    }
}