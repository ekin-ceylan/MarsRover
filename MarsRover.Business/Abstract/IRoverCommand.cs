namespace MarsRover.Business.Abstract
{
    public interface IRoverCommand
    {
        void Execute(IRover rover);
    }
}