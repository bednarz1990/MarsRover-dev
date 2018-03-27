using LawnMowers.Core;

namespace LawnMowers.Interfaces
{
    public interface IMover
    {
        void Forward();
        void TurnRight();
        void TurnLeft();
        Point PositionMower { get; set; }
        Direction Direction { get; set; }
        void Move(TypesMoves typ);
        
    }
}