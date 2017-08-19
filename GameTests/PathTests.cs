using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTests
{
    public class PathTests
    {
        private Map _map3x3;
        private MapLocation[] _pathLocation3x3;
        private Path _path3;

        public PathTests()
        {
            _map3x3 = new Map(3, 3);

            _pathLocation3x3 = new MapLocation[]
            {
                new MapLocation(0, 1, _map3x3),
                new MapLocation(1, 1, _map3x3),
                new MapLocation(2, 1, _map3x3)
            };

            _path3 = new Path(_pathLocation3x3);
        }

        [TestMethod()]
        public void MapLocationIsOnPath()
        {
            var target = _path3;
            Assert.IsTrue(target.IsOnPath(new MapLocation(0, 1, _map3x3)));
        }

        [TestMethod()]
        public void MapLocationIsNotOnPath()
        {
            var target = _path3;
            Assert.IsFalse(target.IsOnPath(new MapLocation(-1, 1, _map3x3)));
        }
    }
}
