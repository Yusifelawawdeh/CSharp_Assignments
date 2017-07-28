using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionGeneric.Common
{
    public static class IntExtensions
    {
        public static bool IsEven(this int value)
        {   
            // bitwise operator here
            return (value & 1) == 0;
            //return (value % 2) == 0;
        }
    }
}
