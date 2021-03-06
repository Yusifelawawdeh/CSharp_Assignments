﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    class PracticingGenerics
    {

        private List<Keeper> _keeper = new List<Keeper>();

        public IEnumerable<Keeper> Keepers { get { return _keeper; } }

        /// <summary>
        /// Method calls addrange method on a Ienumerable collection of keepers     
        /// </summary>
        /// <param name="keepers"></param>
        public void AddKeepers(IEnumerable<Keeper> keepers)
        {
            _keeper.AddRange(keepers);
        }
    }
}
