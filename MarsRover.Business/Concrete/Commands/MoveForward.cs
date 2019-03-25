using MarsRover.Business.Abstract;

namespace MarsRover.Business.Concrete.Commands
{
    public class MoveForward : IRoverCommand
    {
        public void Execute(IRover rover)
        {
            rover.MoveForward();
        }
    }
}
