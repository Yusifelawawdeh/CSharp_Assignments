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

            try
            {
                MapLocation mapLocation = new MapLocation(4, 2, map);
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (GameExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
