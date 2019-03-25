using MarsRover.Business.Abstract;

namespace MarsRover.Business.Concrete
{
    public class Plateau : IPlateau
    {
        public Plateau(ICoordinate coordinate)
        {
            X0 = 0;
            Y0 = 0;

            X1 = coordinate.X;
            Y1 = coordinate.Y;
        }

        public int X0 { get; }
        public int Y0 { get; }
        public int X1 { get; }
        public int Y1 { get; }
    }
}
