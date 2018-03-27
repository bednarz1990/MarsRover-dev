namespace LawnMowers.Core
{
    public class Point
    {
        public Point()
        {

        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(params string[] args)
        {
            X = int.Parse(args[0].ToString());
            Y = int.Parse(args[1].ToString());

        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}