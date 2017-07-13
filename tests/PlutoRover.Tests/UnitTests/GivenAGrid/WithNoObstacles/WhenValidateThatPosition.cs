﻿using FluentAssertions;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenAGrid.WithNoObstacles
{
    public class WhenValidatingAPositionOnTheGrid
    {
        [Fact]
        public void ThenItIsValid()
        {
            var subject = Grid.InitialiseFrom(100, 100);
            var result = subject.IsValid(new Position(10, 10));
            result.Should().BeTrue();
        }
    }
}