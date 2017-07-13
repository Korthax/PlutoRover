using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithNoInput
{
    public class WhenProcessing
    {
        [Fact]
        public void ThenTheStartingLocationIsReturned()
        {
            var subject = new RoverApi(new Rover());
            var result = subject.Process(null);

            result.Should().Be("0,0,N");
        }
    }
}