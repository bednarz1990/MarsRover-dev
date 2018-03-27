using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LawnMowers.Core;
using LawnMowers.Interfaces;

namespace UnitTestLawnMowers
{
    [TestClass]
    public class UnitTestLawnMowers
    {
        [TestMethod]
        public void MowerBuildTest()
        {
            Mower newMower = new Mower(Direction.N, new Point(1, 2));
            Assert.AreEqual(newMower.Direction, (Direction)Enum.Parse(typeof(Direction),"N"));
            Assert.AreEqual(newMower.PositionMower.X, 1);
            Assert.AreEqual(newMower.PositionMower.Y, 2);
        }

        [TestMethod()]
        public void StartMoving()
        {
            Mower firstMower = new Mower(Direction.N, new Point(1, 2));
            firstMower.StartMoving("LMLMLMLMM");

            Mower secondMower = new Mower(Direction.E, new Point(3, 3));
            secondMower.StartMoving("MMRMMRMRRM");

            Assert.AreEqual(firstMower.Direction, (Direction)Enum.Parse(typeof(Direction), "N"));
            Assert.AreEqual(firstMower.PositionMower.X, 1);
            Assert.AreEqual(firstMower.PositionMower.Y, 3);

            Assert.AreEqual(secondMower.Direction, (Direction)Enum.Parse(typeof(Direction), "E"));
            Assert.AreEqual(secondMower.PositionMower.X, 5);
            Assert.AreEqual(secondMower.PositionMower.Y, 1);

        }
    }
}
