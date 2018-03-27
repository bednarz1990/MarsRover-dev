using System.Collections.Generic;

namespace LawnMowers.Core
{
    public  class Rectangle : Shape
    {
        public Rectangle() : base() { }
     
        public Rectangle(Point start) { }
        public override Point Start
        {
            get
            {
                return base.Start;
            }

            set
            {
                base.Start = value;
            }
        }
        public override Point UpperRight
        {
            get
            {
                return base.UpperRight;
            }

            set
            {
                base.UpperRight = value;
            }
        }
        
        public override void Sow()
        {
            UpperRight.Y = UpperRight.Y + 1;

            List<Point> tiles = new List<Point>();
            for (int i = Start.X; i <= UpperRight.X; i++)
                for (int j = Start.Y; j <= UpperRight.Y; j++)
                    tiles.Add(new Point { X = i, Y = j });
        }

        
    }
}
