﻿using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingWest
{
    public class WhenTurningLeft
    {
        [Fact]
        public void ThenTheNewHeadingShouldBeSouth()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);

            var subject = new Rover(Position.Zero, Heading.W, grid.Object);
            subject.Turn(Rotation.Left);

            subject.GetLocation().Should().Be("0,0,S");
        }
    }
}