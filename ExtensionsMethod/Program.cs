using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionGeneric.Collections.Generic;
using ExtensionGeneric.Common;
//using methods in a specific class ~~{Scoping}~~
//using static ExtensionGeneric.Common.IntExtensions;

namespace ExtensionsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            5.IsEven();

            string myString = null;
            myString.Split(',', 3);
            myString.IsNullOrEmpty();

            var synonymsForBest = new List<string>
            {
                "cool",
                "awesome",
                "bawler",
                "Bamf",
                "smokin",
                "coolest",
                "Rugged",
                "MVP",
                "Hardy",
                "lit",
                "noice"
            };

            var best = synonymsForBest.FirstOr(s => s.Length.IsEven(), synonymsForBest.RandomItem);

            Console.WriteLine($"My man... i am the only {synonymsForBest.RandomItem()} person you will ever meet.");
            Console.ReadLine();
        }
    }
}
