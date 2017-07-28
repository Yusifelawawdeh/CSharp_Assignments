using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionGeneric.Collections.Generic
{
    public static class IListExtensions
    {
        private static Random _random = new Random();

        public static T RandomItem<T>(this IList<T> list)
        {
            return list[_random.Next(0, list.Count)];
        }
    }
}
