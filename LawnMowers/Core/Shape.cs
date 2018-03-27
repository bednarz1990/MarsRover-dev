namespace LawnMowers.Core
{
    public abstract class Shape
    {
        public virtual Point Start
        {
            get; set;
        }
     
        public virtual Point UpperRight
        {
            get; set;
        }

        public virtual void Sow () { }

        public Shape() { }

        public Shape(params string[] args)
        {
            UpperRight.X = int.Parse(args[0].ToString());
            UpperRight.Y = int.Parse(args[1].ToString());
        }

        public Shape(int x, int y)
        {
         
            UpperRight.X = x;
            UpperRight.Y = y;
        }
        
    }
}
