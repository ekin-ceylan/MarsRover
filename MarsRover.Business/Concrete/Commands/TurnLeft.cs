using MarsRover.Business.Abstract;

namespace MarsRover.Business.Concrete.Commands
{
    public class TurnLeft : IRoverCommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnLeft();
        }
    }
}
