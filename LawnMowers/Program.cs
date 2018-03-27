using LawnMowers.Core;
using LawnMowers.Interfaces;
using System;

namespace LawnMowers
{
    class Program
    {

        static void Main(string[] args)
        {

            string inputSize = Console.ReadLine();
            Rectangle rectangle = new Rectangle();
            rectangle.Start = new Point(0, 0);
            rectangle.UpperRight = new Point(inputSize.Split(' '));
            IGenericFactory<Shape> kwadrat = new LawnFactory<Rectangle>();
            Shape lawn = kwadrat.Create();
            lawn = rectangle;
            lawn.Sow();



            string moverPosition = Console.ReadLine();
            string moverPoint = moverPosition.Remove(3);
            Point start = new Point(moverPoint.Split(' '));
            Direction course = (Direction)Enum.Parse(typeof(Direction), moverPosition[4].ToString());

            Mower mover = new Mower(course, start);
            string commands = Console.ReadLine();
            for (int i = 0; i < commands.Length; i++)
            {
                TypesMoves movement = (TypesMoves)commands[i];
                mover.Move(movement);

            }
            

            string moverPosition2 = Console.ReadLine();
            string moverPoint2 = moverPosition2.Remove(3);
            Point start2 = new Point(moverPoint2.Split(' '));
            Direction course2 = (Direction)Enum.Parse(typeof(Direction), moverPosition2[4].ToString());

            Mower mover2 = new Mower(course2, start2);
            string commands2 = Console.ReadLine();
            mover2.StartMoving(commands2);
            
            Console.WriteLine("{0}, {1}, {2}", mover.PositionMower.X, mover.PositionMower.Y, mover.Direction.ToString());
            Console.WriteLine("{0}, {1}, {2}", mover2.PositionMower.X, mover2.PositionMower.Y, mover2.Direction.ToString());
            Console.ReadKey();

        }


    }
}
