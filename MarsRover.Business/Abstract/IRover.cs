namespace MarsRover.Business.Abstract
{
    public interface IRover
    {
        int X { get; }
        int Y { get; }
        void MoveForward();
        void TurnLeft();
        void TurnRight();
    }
}
