using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverI
{
    public class Rover
    {
        public static Map map;
        public static Coordinate coordinate;
        public static IDirection currentFacingDirection;
        public Rover(Map maps, Coordinate coordinates, IDirection direction)
        {
            map = maps;
            coordinate = coordinates;
            currentFacingDirection = direction;
        }

        public static List<Object> RoverMovement(string instruction)
        {
            List<Object> list = new List<Object>();
            string returning = "";
            char[] stepByStepInstruction = instruction.ToCharArray();
            foreach (char fetchOneByOne in stepByStepInstruction)
            {
                if (fetchOneByOne == 'L')
                   currentFacingDirection= currentFacingDirection.TurnLeft();
                else if (fetchOneByOne == 'R')
                    currentFacingDirection= currentFacingDirection.TurnRight();
                else
                    coordinate = currentFacingDirection.MoveForward(coordinate,map);
            }
            list.Add(coordinate.X);
            list.Add(coordinate.Y);
            list.Add(currentFacingDirection.CharacterTellerOfDirectionOfEachClass());
            //returning = returning + coordinate.X + " " + coordinate.Y + " " + currentFacingDirection;
            return list;
        }
    }
}
