using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    class PracticingGenerics
    {
        private List<Keeper> _keeper = new List<Keeper>();

        public void AddKeepers(List<Keeper> keepers)
        {
            _keeper.AddRange(keepers);
        }


    }
}
