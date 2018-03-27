using LawnMowers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LawnMowers.Core
{
    public class Mower : IMover
    {
        private Point start;
        public Point PositionMower
        {
            get { return start; }
            set { start = value; }
        }
        
        public Direction Direction
        {
            get; set;
        }

        private static Dictionary<TypesMoves, Action<Mower>> strategy;

        public Mower(Direction course, Point start)
        {
            this.Direction = course;
            this.PositionMower = start;
            strategy = new Dictionary<TypesMoves, Action<Mower>>();
            strategy.Add(TypesMoves.M, m => Forward());
            strategy.Add(TypesMoves.L, t => TurnLeft());
            strategy.Add(TypesMoves.R, r => TurnRight());
        }

        public void Forward()
        {
            if (this.Direction == Direction.N)
                this.PositionMower.Y = PositionMower.Y + 1;
            if (this.Direction == Direction.S)
                this.PositionMower.Y = PositionMower.Y - 1;
            if (this.Direction == Direction.E)
                this.PositionMower.X = PositionMower.X + 1;
            if (this.Direction == Direction.W)
                this.PositionMower.X = PositionMower.X - 1;
        }

        public void TurnRight()
        {
            var nextValueQuery = Enum.GetValues(typeof(Direction)).Cast<Direction>().SkipWhile(e => e != this.Direction).Skip(1);
            if (nextValueQuery.Count() != 0)
            {
                this.Direction = (Direction)nextValueQuery.First();
            }
            else
            {
                this.Direction = Direction.N;
            }

        }

        public void StartMoving(string commands)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                TypesMoves someMove = (TypesMoves)commands[i];
                this.Move(someMove);
            }
        }

        public void TurnLeft()
        {
            var nextValueQuery = Enum.GetValues(typeof(Direction)).Cast<Direction>().Reverse().SkipWhile(e => e != this.Direction).Skip(1);
            if (nextValueQuery.Count() != 0)
            {
                this.Direction = (Direction)nextValueQuery.First();
            }
            else
            {
                this.Direction = Direction.W;
            }
        }

        public void Move(TypesMoves type)
        {
            strategy[type].Invoke(this);
        }
    }


}