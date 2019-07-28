using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
namespace MarsRoverI.Tests
{
   public class RoverFixture
    {
        [Fact]
        public void Is_Rover_Present_On_Mars()
        {
            var maps = new Map();
            maps.length = 100;
            maps.width = 100;
            var coordinates = new Coordinate();
            coordinates.X = 0;
            coordinates.Y = 0;
            var startingDirection = new North();
            //startingDirection.direction = "N";
            var rover = new Rover(maps, coordinates, startingDirection);
            Assert.InRange(Rover.coordinate.X, 0, Rover.map.width);
            Assert.InRange(Rover.coordinate.Y, 0, Rover.map.length);

        }
    }

}
