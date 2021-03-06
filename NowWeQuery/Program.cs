﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowWeQuery
{

    public class Program
    {
        //delegate void SayGreeting(string name);



        public static void SayHello(string name)
        {
            Console.WriteLine(string.Format("Hello, {0}", name));
        }

        //public static void SayGoodBye(string name)
        //{
        //    Console.WriteLine(string.Format("Hello, {0}", name));

        //}

        static void Main(string[] args)
        {
            Action<string> sayGreeting;

            Func<string, string> conversate = (message) =>
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            };

            string input = conversate("What's your name?");

            sayGreeting = (greeting) =>
            {
                Console.WriteLine(string.Format(greeting, input));
            };



            sayGreeting("Hello, {0}");
            conversate("Nice to meet you");
            conversate("are you doing well ?");
            sayGreeting("Later, {0}");

            //Console.WriteLine("What's your name ?");
            //string input = Console.ReadLine();

            //Console.ReadLine();
            ////sayGreeting = new SayGreeting(SayGoodBye);
            //sayGreeting = delegate (string name)
            //{
            //    Console.WriteLine(string.Format("Later, {0}", name));
            //};



            ListLooperAlpha();
            ListLooper();
            TheBirds();

            // query syntax 
            // from i in rubble where i > 10 select i;

            Console.WriteLine(Birdlier());
            Console.WriteLine(SinglerEin());
            Console.WriteLine(GiveBird());


            var colors = new List<string> { "red", "Green", "Blue" };

            var numbers = new List<int> { 1, 2, 3, 4, 6, 7, 8, 13, 23, 41, 654, 4234, 32, 1111 };

            var birders = new List<Bird>
            {
                new Bird {Name = "Cardinal", Color = "Red", Sightings = 24},
                new Bird {Name = "Dove", Color = "White", Sightings = 2},
                new Bird {Name = "Crow", Color = "Black", Sightings = 310}
            };

            var gimiBirds = birders.OrderBy(b => b.Name.Length).TakeWhile(b => b.Name.Length < 6);

            Console.WriteLine(gimiBirds);


            ColorsPlease();



            var colorizer = from b in gimiBirds group b by b.Color;

            var grouper = gimiBirds.GroupBy(b => b.Color);

            Console.WriteLine(colorizer);
            Console.WriteLine(grouper);

            var thingy = birders.GroupBy(b => b.Color).Select(g => new { Color = g.Key, Count = birders.Count() });

            Console.WriteLine(thingy);


            //+ Operators

            var sumer = birders.Sum(b => b.Sightings);

            var averager = birders.Average(b => b.Sightings);

            var selector = birders.Select(b => b.Color);

            var distinctcor = birders.Select(b => b.Color).Distinct();

            var excluder = colors.Except(birders.Select(b => b.Color).Distinct());

            var unioner = colors.Union(birders.Select(b => b.Color).Distinct());

            var intersector = colors.Intersect(birders.Select(b => b.Color).Distinct());

            var concater = colors.Concat(birders.Select(b => b.Color));

            //+ generator operators

            var ranger = Enumerable.Range(0, 1000);

            var repeater = Enumerable.Repeat("lol", 20);

            var emptyer = Enumerable.Empty<Bird>();

            var defIfEmptyer = numbers.DefaultIfEmpty();

            //+ List Operators

            var toLister = birders.Where(b => b.Color == "Red").ToList();

            var toArrayer = birders.Where(b => b.Color == "Red").ToArray();

            var thingers = numbers.Where(n => n > 10);

            //var kloor = birders.GroupBy(k = > k.Color).Select(g => new
            //{
            //    Color = g.key,
            //    Sightings = g.Sum(b => b.Sightings)
            //});

            Console.WriteLine(BirdColors());

        }

        public static void TheBirds()
        {

            List<Bird> FirstBirds = new List<Bird>
            {
                new Bird {Name = "Cardinal", Color = "Red", Sightings = 24},
                new Bird {Name = "Dove", Color = "White", Sightings = 2},
                new Bird {Name = "Crow", Color = "Black", Sightings = 310}
            };

            for (var i = 0; i < FirstBirds.Count; i++)
            {
                Console.WriteLine(FirstBirds[i].Name + " " + FirstBirds[i].Color + " " + FirstBirds[i].Sightings);
            }

        }

        public static void ListLooper()
        {

            List<int> rubble = new List<int> { 1, 2, 3, 45, 66, 75, 243, 23, 23456, 2345, 345, 90 };
            List<int> greaterthanrubble = new List<int>();

            for (var i = 0; i < rubble.Count; i++)
            {
                if (rubble[i] > 10)
                {
                    greaterthanrubble.Add(rubble[i]);
                }

            }
            greaterthanrubble.ForEach(Console.WriteLine);

        }

        public static void ListLooperAlpha()
        {
            List<double> doublet = new List<double> { 22.3, 34.5, 22.3, 4342.0, 209080.1 };

            for (var i = 0; i < doublet.Count; i++)
            {
                Console.WriteLine("value : " + doublet[i]);
            }
        }

        //public static void QueryBirds()
        //{
        //    Bird birds = new Bird();

        //    //var birdQuery = from b in birds where b.Color == "Red" select b;

        //    //birds.where((b) => birds.Color == "Red");

        //    //var Tora = birds.Where((b) => { return b.Color == "Red"; });

        //    // IQueryable<Bird> birdy = from b in birds
        //    //orderby b.Color
        //    //select b;
        //      birds.Where(b => b.Color == "Red").OrderBy(b => b.Name);
        //}

        //public static List<Bird> Something()
        //{
        //    var birdsy = new List<Bird>
        //         {
        //        new Bird {Name = "Cardinal", Color = "Red", Sightings = 24},
        //        new Bird {Name = "Dove", Color = "White", Sightings = 2},
        //        new Bird {Name = "Crow", Color = "Black", Sightings = 310}
        //    };

        //    return from b in birdsy where b.Color == "Red" select b;
        //}

        public static Tuple<bool, IEnumerable<Bird>, bool> Birdlier()
        {
            var birds = new List<Bird>
            {
                new Bird {Name = "Cardinal", Color = "Red", Sightings = 24},
                new Bird {Name = "Dove", Color = "White", Sightings = 2},
                new Bird {Name = "Crow", Color = "Black", Sightings = 310}
            };

            var stringer = birds.Any(b => b.Name == "Crow");
            var stringlier = birds.Where(b => b.Name == "Crow");
            var stringliest = birds.Any(b => b.Name == "Crow");

            var result = Tuple.Create<bool, IEnumerable<Bird>, bool>(stringer, stringlier, stringliest);

            return result;

        }

        public static int SinglerEin()
        {
            var numbers = new List<int> { 2, 4, 5, 6, 7 };



            return numbers.SingleOrDefault(n => n == 2);
        }

        public static object GiveBird()
        {
            var birds = new List<Bird>
            {
                new Bird {Name = "Cardinal", Color = "Red", Sightings = 24},
                new Bird {Name = "Dove", Color = "White", Sightings = 2},
                new Bird {Name = "Crow", Color = "Black", Sightings = 310}
            };

            return birds.Take(3);
        }

        public static void ColorsPlease()
        {
            var birds = new List<Bird>
            {
                new Bird {Name = "Cardinal", Color = "Red", Sightings = 24},
                new Bird {Name = "Dove", Color = "White", Sightings = 2},
                new Bird {Name = "Crow", Color = "Black", Sightings = 310}
            };

            var colors = new List<string> { "red", "Green", "Blue" };

            var result = from b in birds join c in colors on b.Color equals c select b;



            Console.WriteLine(result);
        }

        public static string BirdColors()
        {
            var birds = new List<Bird>
            {
                new Bird {Name = "Cardinal", Color = "Red", Sightings = 24},
                new Bird {Name = "Dove", Color = "White", Sightings = 2},
                new Bird {Name = "Crow", Color = "Black", Sightings = 310}
            };

           var biders =  birds.Select(b => b.Color).ToString();

            return biders;
        }



    }

    public class Bird
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Sightings { get; set; }
    }


}
