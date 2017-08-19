using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private readonly MapLocation _location;
        private const double _accuracy = .75;

        private static readonly System.Random _random = new System.Random();

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
           return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {

            foreach (Invader invader in invaders)
            {
                //do stuff with invader
                if (invader.IsAlive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot the invader !!");

                        if (invader.IsDead)
                        {
                            Console.WriteLine("Invader is toast !!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Missed the invader !!");
                    }
                    break;

                }
            }
        }

    }
}
