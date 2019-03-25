using MarsRover.Business.Abstract;

namespace MarsRover.Business.Concrete.Commands
{
    public class TurnRight : IRoverCommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnRight();
        }
    }
}
