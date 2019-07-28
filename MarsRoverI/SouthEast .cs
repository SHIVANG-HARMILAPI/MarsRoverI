using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverI
{
    public class SouthEast:IDirection
    {
        public string CharacterTellerOfDirectionOfEachClass()
        {
            return "SE";
        }
        public Coordinate MoveForward(Coordinate currentCoordinates,Map map)
        {
            var finalCoordinate = new Coordinate();
            finalCoordinate.X = currentCoordinates.X + 1;
            finalCoordinate.Y = currentCoordinates.Y - 1;
            map.CheckWhetherLiesInsideMap(finalCoordinate);
            return finalCoordinate;
        }

        public IDirection TurnLeft()
        {
            return new South();
        }

        public IDirection TurnRight()
        {
            return new East();
        }
    }
}
