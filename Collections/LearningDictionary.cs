using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    class LearningDictionary
    {
        private HashSet<Keeper> _keepers = new HashSet<Keeper>();
        public IEnumerable<Keeper> Keepers { get { return _keepers; } }

        public void AddKeepers2(IEnumerable<Keeper> keepers)
        {
            _keepers.UnionWith(keepers);
        }
    }
}
