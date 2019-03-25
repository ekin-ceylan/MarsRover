namespace MarsRover.Business.Abstract
{
    public abstract class OrientationState
    {
        protected internal abstract OrientationState TurnLeft();
        protected internal abstract OrientationState TurnRight();
        protected internal abstract ICoordinate MoveForward(IRover rover, IPlateau plateau);
    }
}
