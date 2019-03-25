using System;
using MarsRover.Business.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Business.Test
{
    [TestClass]
    public class PlateauTest
    {
        private Plateau _plateau;
        private int _inputX = 5;
        private int _inputY = 5;

        [TestInitialize]
        public void TestInitialize()
        {
            _plateau = new Plateau(new Coordinate(_inputX, _inputY));
        }

        [TestMethod]
        public void When_Create_Plateau_The_Lower_Position_Equals_To_0_0()
        {
            Assert.AreEqual(0, _plateau.X0);
            Assert.AreEqual(0, _plateau.Y0);
        }

        [TestMethod]
        public void When_Create_Plateau_The_Upper_Position_Equals_To_Inputs()
        {
            Assert.AreEqual(_inputX, _plateau.X1);
            Assert.AreEqual(_inputY, _plateau.Y1);
        }
    }
}
