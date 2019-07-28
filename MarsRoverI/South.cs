using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverI
{
    public class South:IDirection
    {
        public string CharacterTellerOfDirectionOfEachClass()
        {
            return "S";
        }
        public IDirection TurnLeft()
        {
            return new SouthEast();
        }
        public IDirection TurnRight()
        {
            return new SouthWest();
        }
        public Coordinate MoveForward(Coordinate coordinate,Map map)
        {
            Coordinate finalCoordinate = new Coordinate();
            finalCoordinate.X = coordinate.X;
            finalCoordinate.Y = coordinate.Y-1;
            map.CheckWhetherLiesInsideMap(finalCoordinate);
            return finalCoordinate;


        }
    }
}
