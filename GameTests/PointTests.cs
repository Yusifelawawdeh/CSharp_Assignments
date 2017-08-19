using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Tests
{
    [TestClass()]
    public class PointTests
    {
        [TestMethod()]
        public void PointTest()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);

            Assert.Equals(x, point.X);
            Assert.Equals(y, point.Y);


        }

        [TestMethod()]
        public void DistanceToTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DistanceToTest1()
        {
            var point = new Point(3, 4);
            var target = new Point(0, 0);

            var expected = 5.0;

            var actual = target.DistanceTo(point);

            Assert.AreEqual(expected, actual, 2);
        }
    }
}