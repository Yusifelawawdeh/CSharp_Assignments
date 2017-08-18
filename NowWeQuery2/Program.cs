using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowWeQuery2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var searchParameters = new BirdSearch
            {
                Size = "Medium",
                Country = "United States",
                Colors = new List<string> { "White", "Brown", "Black"},
                Page = 0,
                PageSize = 5
            };

            Console.WriteLine("Type any key to begin a search");

            var birds = BirdRepository.LoadBirds();

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine($"Page: {searchParameters.Page} ");

                birds.Search(searchParameters).ToList().ForEach(b =>
                {
                    Console.WriteLine($"Common Name : {b.CommonName}");
                });
                searchParameters.Page++;
                break;
            }

            var listA = Enumerable.Range(0, 10000);
            var listB = Enumerable.Range(50000, 10000);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var listC = listA.Union(listB);
            stopWatch.Stop();

            var unionTicks = stopWatch.ElapsedTicks;
            stopWatch.Restart();


            var listD = listA.Concat(listB).Distinct();
            stopWatch.Stop();
            var concatTicks = stopWatch.ElapsedTicks;

            Console.WriteLine(string.Format("Union took {0} ticks.", unionTicks));
            Console.WriteLine(string.Format("Concat took {0} ticks.", concatTicks));

            if (unionTicks > concatTicks)
            {
                Console.WriteLine("Concat is faster by {0}", (unionTicks - concatTicks));
            }
            else if (concatTicks > unionTicks)
            {
                Console.WriteLine("Union is faster by {0}", (concatTicks - unionTicks));
            }

        }


    }
}