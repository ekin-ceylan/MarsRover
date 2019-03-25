using MarsRover.Business.Abstract;

namespace MarsRover.Business.Concrete
{
    public struct Coordinate : ICoordinate
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}