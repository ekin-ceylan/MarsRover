using MarsRover.Business.Abstract;
using MarsRover.Business.Concrete;
using MarsRover.Business.Concrete.Orientations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Business.Test
{
    [TestClass]
    public class RoverTest
    {
        private Plateau _plateau;
        private Rover _rover;
        private readonly int _inputPlateauX = 5;
        private readonly int _inputPlateauY = 4;
        private readonly int _inputRoverX = 1;
        private readonly int _inputRoverY = 2;
        private readonly OrientationState _inputOrientation = new East();

        [TestInitialize]
        public void TestInitialize()
        {
            _plateau = new Plateau(new Coordinate(_inputPlateauX, _inputPlateauY));
            _rover = new Rover(new Coordinate(_inputRoverX, _inputRoverY), _inputOrientation, _plateau);
        }

        [TestMethod]
        public void When_Create_Rover_The_Initial_Position_Equals_To_Inputs()
        {
            Assert.AreEqual(_inputRoverX, _rover.X);
            Assert.AreEqual(_inputRoverY, _rover.Y);
        }

        [TestMethod]
        public void When_Create_Rover_The_Initial_Orientation_Equals_To_Input()
        {
            Assert.AreSame(_inputOrientation.GetType(), _rover.Orientation.GetType());
        }

        [TestMethod]
        public void When_Rover_Is_Oriented_North_And_Turn_Right_The_Orientation_Is_East()
        {
            _rover.Orientation = new North();
            _rover.TurnRight();

            Assert.AreSame(typeof(East), _rover.Orientation.GetType());
        }

        [TestMethod]
        public void When_Rover_Is_Oriented_North_And_Move_Forward_The_Orientation_Is_North()
        {
            _rover.Orientation = new North();
            _rover.MoveForward();

            Assert.AreSame(typeof(North), _rover.Orientation.GetType());
        }

        [TestMethod]
        public void When_Rover_Is_Oriented_North_And_Move_Forward_LocationY_Increase_1()
        {
            _rover.Orientation = new North();
            _rover.MoveForward();

            Assert.AreEqual(_inputRoverY + 1, _rover.Y);
            Assert.AreEqual(_inputRoverX, _rover.X);
        }

        [TestMethod]
        public void Rover_Position_Cannot_Exceed_Plateau_XBoundaries()
        {
            _rover.Orientation = new East();

            for (int i = 0; i <= _plateau.X1; i++)
            {
                _rover.MoveForward();
            }

            Assert.IsTrue(_plateau.X0 <= _rover.X && _rover.X <= _plateau.X1 );
        }
    }
}
