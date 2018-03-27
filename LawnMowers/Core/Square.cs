namespace LawnMowers.Core
{
    public class Square : Shape
    {
        public Square():base()
        { }
     
        public Square(int x, int y) : base(x,y) { }

        public static explicit operator Square(Rectangle v)
        {
            Square square = new Square() { Start = v.Start, UpperRight = v.UpperRight };
            return square;
            
        }
    }
}
