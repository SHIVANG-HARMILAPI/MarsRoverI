using System;

namespace MarsRoverI
{
    public class Map
    {

        public int width { get; set; }
        public int length { get; set; }

        public void CheckWhetherLiesInsideMap(Coordinate coordinate)
        {
            if (coordinate.X> width || coordinate.X < 0)
                throw new ArgumentException("Sorry These Moves Will Cause The Rover To Fall");
            if (coordinate.Y> length || coordinate.Y< 0)
                throw new ArgumentException("Sorry These Moves Will Cause The Rover To Fall");
            
        }
    }
}
