using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverI
{
    public class NorthWest : IDirection
    {
        public string CharacterTellerOfDirectionOfEachClass()
        {
            return "NW";
        }
        public Coordinate MoveForward(Coordinate currentCoordinates,Map map)
        {
            var finalCoordinate = new Coordinate();
            finalCoordinate.X = currentCoordinates.X - 1;
            finalCoordinate.Y = currentCoordinates.Y + 1;
            map.CheckWhetherLiesInsideMap(finalCoordinate);
            return finalCoordinate;
        }

        public IDirection TurnLeft()
        {
            return new West();
        }

        public IDirection TurnRight()
        {
            return new North();
        }
    }
}
