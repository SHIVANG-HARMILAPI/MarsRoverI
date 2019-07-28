using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverI
{
    public class West:IDirection
    {
        public string CharacterTellerOfDirectionOfEachClass()
        {
            return "W";
        }
        public IDirection TurnLeft()
        {
            return new SouthWest();
        }
        public IDirection TurnRight()
        {
            return new NorthWest();
        }
        public Coordinate MoveForward(Coordinate coordinate,Map map)
        {
            Coordinate finalCoordinate = new Coordinate();
            finalCoordinate.X = coordinate.X-1;
            finalCoordinate.Y = coordinate.Y;

            map.CheckWhetherLiesInsideMap(finalCoordinate);
            return finalCoordinate;


        }
    }
}
