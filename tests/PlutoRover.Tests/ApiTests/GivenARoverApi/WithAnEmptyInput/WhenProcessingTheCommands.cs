﻿using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.ApiTests.GivenARoverApi.WithAnEmptyInput
{
    public class WhenProcessingTheCommands
    {
        [Fact]
        public void ThenTheStartingLocationIsReturned()
        {
            var subject = new RoverApi(new Rover(Position.Zero, Heading.N, Grid.InitialiseFrom(100, 100)));
            var result = subject.Process(string.Empty);

            result.Should().Be("0,0,N");
        }
    }
}