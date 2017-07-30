﻿using System;
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
                Path path = new Path(
                    new []
                    {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(6, 2, map)
                    });

  
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (GameExceptions)
            {
                Console.WriteLine("unhandeled game exception");

            }
            catch (Exception ex)
            {
                Console.WriteLine(" unhandled exception  " + ex);
            }

        }
    }
}
