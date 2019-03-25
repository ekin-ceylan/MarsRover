using System;
using MarsRover.Business.Abstract;

namespace MarsRover.Business.Concrete.Orientations
{
    public class North : OrientationState
    {
        protected internal override OrientationState TurnLeft()
        {
            return new West();
        }

        protected internal override OrientationState TurnRight()
        {
            return new East();
        }

        protected internal override ICoordinate MoveForward(IRover rover, IPlateau plateau)
        {
            int newY = Math.Min(Math.Max(rover.Y + 1, plateau.Y0), plateau.Y1);
            return new Coordinate(rover.X, newY);
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
