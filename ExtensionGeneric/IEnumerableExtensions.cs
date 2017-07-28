using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionGeneric.Common
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }

        public static bool IsEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.Any();
        }
    }
}
