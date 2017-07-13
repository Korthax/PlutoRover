using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenAPosition
{
    public class WhenSubtractingAVector
    {
        [Fact]
        public void ThenTheCorrectValueIsCalculated()
        {
            var subject = new Position(35, 25);
            var result = subject - new Vector(5, 5);

            result.Should().Be(new Position(30, 20));
        }
    }
}