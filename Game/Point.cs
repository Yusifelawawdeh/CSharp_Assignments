using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Cartesion Distance Formula does some math and returns the distance from a point to another point on the map
        /// </summary>
        /// <param name="x"> takes an x coordinate </param>
        /// <param name="y">takes a y coordinate</param>
        /// <returns> does some math and returns the distance to a tower on a map</returns>
        public int DistanceTo(int x, int y)
        {
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);


            // refactored version of the formula
            // return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(y-y, 2));
            
        }
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }

    }
}
