using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }


        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        public bool IsOnPath(MapLocation mapLocation)
        {
            return Array.IndexOf(_path, mapLocation) >= 0;
        }
    }
}
