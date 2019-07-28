using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverI
{
    public class East:IDirection
    {
        public string CharacterTellerOfDirectionOfEachClass()
        {
            return "E";
        }
        public IDirection TurnLeft()
        {
            return new NorthEast();
        }
        public IDirection TurnRight()
        {
            return new SouthEast();
        }
        public Coordinate MoveForward(Coordinate coordinate,Map map)
        {
            Coordinate finalCoordinate = new Coordinate();
            finalCoordinate.X = coordinate.X + 1;
            finalCoordinate.Y = coordinate.Y;
            map.CheckWhetherLiesInsideMap(finalCoordinate);
            return finalCoordinate;


        }
    }
}
