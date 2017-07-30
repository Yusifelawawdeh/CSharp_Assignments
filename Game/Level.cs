using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }


        /// <summary>
        /// this method is what allows the game to be played, that means seting up the feild, the invaders, and the movement on the path
        /// </summary>
        /// <returns>returns a true or false</returns>
        public bool Play()
        {
          
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

            }

            remainingInvaders = 0;
            foreach (Invader invader in _invaders)
            {
                if (invader.IsAlive)
                {
                    invader.Move();
                    if (invader.HasScored)
                    {
                        return false;
                    }

                    remainingInvaders++;
                }
            }

            return true;
        
        }
    }
}
