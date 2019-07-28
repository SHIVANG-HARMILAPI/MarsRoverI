using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverI
{
   public class North : IDirection
    {
        
        public Coordinate MoveForward(Coordinate coordinate,Map map)
        {

            Coordinate finalCoordinate = new Coordinate();
            finalCoordinate.X = coordinate.X;
            finalCoordinate.Y = coordinate.Y + 1;
            map.CheckWhetherLiesInsideMap(finalCoordinate);
            return finalCoordinate;
        }
        public string CharacterTellerOfDirectionOfEachClass()
        {
        
            return "N";
        }
        public IDirection TurnRight()
        {
            return new NorthEast();
        }
        public IDirection TurnLeft()
        {
            return new NorthWest();
        }
       
    }
}
