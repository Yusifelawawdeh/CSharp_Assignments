using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionGeneric.Collections.Generic;

namespace ExtensionsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine($"My man... i am the only {synonymsForBest.RandomItem()} person you will ever meet.");
            Console.ReadLine();
        }
    }
}
