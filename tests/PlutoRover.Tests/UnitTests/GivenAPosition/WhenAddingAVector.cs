using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenAPosition
{
    public class WhenAddingAVector
    {
        [Fact]
        public void ThenTheCorrectValueIsCalculated()
        {
            var subject = new Position(10, 10);
            var result = subject + new Vector(5, 5);

            result.Should().Be(new Position(15, 15));
        }
    }
}