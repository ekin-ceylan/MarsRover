using System;
using MarsRover.Business.Abstract;

namespace MarsRover.Business.Concrete
{
    public class Rover : IRover
    {
        private readonly Plateau _plateau;
        private ICoordinate _coordinate;

        public Rover(Coordinate coordinate, OrientationState orientation, Plateau plateau)
        {
            Orientation = orientation;
            _plateau = plateau;
            _coordinate = coordinate;
            _coordinate.X = Math.Min(plateau.X1, Math.Max(coordinate.X, plateau.X0));
            _coordinate.Y = Math.Min(plateau.Y1, Math.Max(coordinate.Y, plateau.Y0));
        }

        public OrientationState Orientation { get; set; }

        public void TurnLeft()
        {
            Orientation = Orientation.TurnLeft();
        }

        public void TurnRight()
        {
            Orientation = Orientation.TurnRight();
        }

        public void MoveForward()
        {
            _coordinate = Orientation.MoveForward(this, _plateau);
        }

        public override string ToString()
        {
            return $"{X} {Y} {Orientation}";
        }

        public int X => _coordinate.X;
        public int Y => _coordinate.Y;
    }
}
