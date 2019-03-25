﻿using System;
using MarsRover.Business.Abstract;

namespace MarsRover.Business.Concrete.Orientations
{
    public class West : OrientationState
    {
        protected internal override OrientationState TurnLeft()
        {
            return new South();
        }

        protected internal override OrientationState TurnRight()
        {
            return new North();
        }

        protected internal override ICoordinate MoveForward(IRover rover, IPlateau plateau)
        {
            int newX = Math.Min(Math.Max(rover.X - 1, plateau.X0), plateau.X1);
            return new Coordinate(newX, rover.Y);
        }

        public override string ToString()
        {
            return "W";
        }
    }
}
