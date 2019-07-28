using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverI
{
    public interface IDirection
    {
        string CharacterTellerOfDirectionOfEachClass();
        Coordinate MoveForward(Coordinate currentCoordinates, Map map);
         IDirection TurnLeft();
          IDirection TurnRight();
    }
}
