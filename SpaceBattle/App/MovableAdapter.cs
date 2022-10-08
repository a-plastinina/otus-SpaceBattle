using SpaceBattle.Interface;

namespace SpaceBattle
{
    public class MovableAdapter : IMovable
    {
        private readonly IUniversalObject _obj;

        public MovableAdapter(IUniversalObject obj)
        {
            _obj = obj;
        }

        public Vector Position { get => (Vector)_obj["position"]; set => _obj["velocity"] = value; }

        public Vector Velocity { get => (Vector)_obj["velocity"]; }
    }
}