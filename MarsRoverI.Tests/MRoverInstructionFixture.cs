using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
namespace MarsRoverI.Tests
{
    public class MRoverInstructionFixture
    {
        /// </summary>
        [Fact]
        public void Basic_RoverInstructionTest()
        {
            string[] instructions = { "5 5", "1 2 N", "LL" };
            var expectedResponse = "1 2 W";

            var iset = new InstructionSetForRover();
            var response = iset.PassInstructions(instructions);
            response.Should().Be(expectedResponse);

        }

        [Fact]
        public void Basic_RoverInstructionTestExtra()
        {
            string[] instructions = { "5 5", "1 2 N", "RRMM" };
            var expectedResponse = "3 2 E";

            var iset = new InstructionSetForRover();
            var response = iset.PassInstructions(instructions);
            response.Should().Be(expectedResponse);

        }


        [Fact]
        public void check_for_rover_exceeding_the_map_limits()
        {
            string[] instructions = { "5 5", "1 2 N", "LMM" };
            var iset = new InstructionSetForRover();
            Assert.Throws<ArgumentException>(() => iset.PassInstructions(instructions));

        }
       /* public void Basic_RoverInstructionTestI()
        {
            string[] instructions = { "5 5", "3 3 E", "MMRMMRMRRM" };
            var expectedResponse = "5 1 E";

            var iset = new InstructionSetForRover();
            var response = iset.PassInstructions(instructions);
            response.Should().Be(expectedResponse);

        }
*/
    }
}
