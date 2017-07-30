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
            int index = 0;

            while (index < invaders.Length)
            {
                Invader invader = invaders[index];
                // do stuff to invader

                index++;
            }

        }

    }
}
