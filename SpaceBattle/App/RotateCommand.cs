using SpaceBattle.Interface;

namespace SpaceBattle.App
{
    public class RotateCommand
    {
        IRotable _rotable;
        public RotateCommand(IRotable rotable)
        {
            _rotable = rotable;
        }
        public void Execute()
        {
            _rotable.Direction = (_rotable.Direction + _rotable.AngularVelocity) % _rotable.DirectionsNumber;
        }
    }
}