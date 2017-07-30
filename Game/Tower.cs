using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            // honestly while loop reads easier
            //int index = 0;
            //while (index < invaders.Length)
            //{
            //    Invader invader = invaders[index];
            //    // do stuff to invader
            //    index++;
            //}

            // for loop
            //for (int i = 0; i < invaders.Length; i++)
            //{
            //    Invader invader = invaders[i];
            //    // do stuff to invader
            //}

            foreach (Invader invader in invaders)
            {
                //do stuff with invader
                if (invader.IsAlive && _location.InRangeOf(invader.Location, 1))
                {
                    invader.DecreaseHealth(1);
                    break;
                }
            }
        }

    }
}
