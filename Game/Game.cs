using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game
    {
        public static void Main(string[] args)
        {
            // instantiated objects
            Map map = new Map(8, 5);
            Point point = new Point(4, 2);

            Console.WriteLine(point.DistanceTo(5,5));
            Console.ReadLine();
        }
    }
}
