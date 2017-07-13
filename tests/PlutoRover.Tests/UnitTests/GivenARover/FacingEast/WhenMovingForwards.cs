﻿using FluentAssertions;
using Moq;
using PlutoRover.Core;
using Xunit;

namespace PlutoRover.Tests.UnitTests.GivenARover.FacingEast
{
    public class WhenMovingForwards
    {
        [Fact]
        public void ThenTheXCoordinateIncrementsByOne()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Wrap(It.IsAny<Position>())).Returns<Position>(position => position);
            grid.Setup(x => x.IsValid(It.IsAny<Position>())).Returns(true);

            var subject = new Rover(Position.Zero, Heading.E, grid.Object);
            subject.Move(Direction.Forward);

            subject.GetLocation().Should().Be("1,0,E");
        }
    }
}