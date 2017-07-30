using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Bird> birds = new List<Bird>
            {
                new Bird { Name = "Cardinal", Color = "red", Sightings = 3},
                new Bird { Name = "Dove", Color = "White", Sightings = 1},
                new Bird { Name = "Crow", Color = "black", Sightings = 6},
            };

            birds.Add(new Bird {Name = "robin", Color = "blue", Sightings = 9});

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird.Name + bird.Color);
            }

            //List<int> highList = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9}; 
            //List<int> list = new List<int>();

            //foreach (int listy in highList)
            //{
            //    if (listy > 2)
            //    {
            //        list.Add(listy);
            //    }
            //}
            //var linewList = list.Where(n => n > 3);

            //Console.WriteLine(linewList);

            ////from listy in list where listy > 3 select listy;

            Console.ReadLine();

        }



    }
}
