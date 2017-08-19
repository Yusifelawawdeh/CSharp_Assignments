using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public int Health { get; private set; } = 2;

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsDead { get { return Health <= 0; }}

        public bool IsAlive { get { return !(IsDead || HasScored); }}

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += 1;

        public void DecreaseHealth(int factor) => Health -= factor;


    }
}

