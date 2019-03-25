using MarsRover.Business.Abstract;
using MarsRover.Business.Concrete.Commands;
using MarsRover.Business.Concrete.Orientations;
using MarsRover.Business.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Business.Test
{
    [TestClass]
    public class CommandHelperTest
    {
        [TestMethod]
        public void Get_Move_Forward_For_M()
        {
            IRoverCommand command = CommandHelper.RoverCommandFactory("M");
            Assert.AreSame(typeof(MoveForward), command.GetType());
        }

        [TestMethod]
        public void Get_Turn_Left_For_L()
        {
            IRoverCommand command = CommandHelper.RoverCommandFactory("L");
            Assert.AreSame(typeof(TurnLeft), command.GetType());
        }

        [TestMethod]
        public void Get_Turn_Right_For_R()
        {
            IRoverCommand command = CommandHelper.RoverCommandFactory("R");
            Assert.AreSame(typeof(TurnRight), command.GetType());
        }

        [TestMethod]
        public void Get_Null_For_InvalidCommand()
        {
            IRoverCommand command = CommandHelper.RoverCommandFactory("X");
            Assert.AreSame(null, command);
        }


        [TestMethod]
        public void Get_North_For_N()
        {
            OrientationState orientation = CommandHelper.OrientationFactory("N");
            Assert.AreSame(typeof(North), orientation.GetType());
        }

        [TestMethod]
        public void Get_West_For_W()
        {
            OrientationState orientation = CommandHelper.OrientationFactory("W");
            Assert.AreSame(typeof(West), orientation.GetType());
        }

        [TestMethod]
        public void Get_North_For_InvalidCommand()
        {
            OrientationState orientation = CommandHelper.OrientationFactory("X");
            Assert.AreSame(typeof(North), orientation.GetType());
        }
    }
}
