using System;
using Xunit;
using FluentAssertions;
namespace MarsRoverI.Tests
{
    public class MapFixture
    {
        [Fact]
        public void Map_Initialization_Test()
        {
            var map = new Map();
            map.width = 100;
            map.length = 100;
            map.length.Should().Be(100);
            map.width.Should().Be(100);
        }
    }
}
