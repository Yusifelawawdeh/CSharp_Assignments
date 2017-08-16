using System;
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
            var numbers = new List<int> {2, 4, 5, 6, 7};



            return numbers.SingleOrDefault(n => n == 2);
        }

    }

    public class Bird
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Sightings { get; set; }
    }

}
