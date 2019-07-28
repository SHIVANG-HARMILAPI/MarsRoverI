using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverI
{
    public class InstructionSetForRover
    {
        Dictionary<string, IDirection> _currentFacingDirections=new Dictionary<string, IDirection>();
    
        public string PassInstructions(string[] instructions)
        {
            _currentFacingDirections.Add("N", new North());
            _currentFacingDirections.Add("S", new South());
            _currentFacingDirections.Add("E", new East());
            _currentFacingDirections.Add("W", new West());
            _currentFacingDirections.Add("NW", new NorthWest());
            _currentFacingDirections.Add("SW", new SouthWest());
            _currentFacingDirections.Add("NE", new NorthEast());
            _currentFacingDirections.Add("SE", new SouthEast());
     
            var map = new Map();
            map.width = int.Parse(instructions[0].Split(' ')[0]);
            map.length = int.Parse(instructions[0].Split(' ')[1]);
            var coordinate = new Coordinate();
            coordinate.X = int.Parse(instructions[1].Split(' ')[0]);
            coordinate.Y = int.Parse(instructions[1].Split(' ')[1]);
            
            var rDirection = _currentFacingDirections[instructions[1].Split(' ')[2]];
            //rDirection.direction = instructions[1].Split(' ')[2];
            var rover = new Rover(map,coordinate, rDirection);
            var response = Rover.RoverMovement(instructions[2]);
         
            string finalResponse = response[0].ToString() +" "+ response[1].ToString()+" " + response[2];
            
            return finalResponse;
        }
    }
}
