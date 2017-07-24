using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    class Repetition
    {
        class Program
        {
            static void Repetition()
            {
                // TODO Declare and assign a "thing" string variable.
                // Example: "movie", "book", "color", etc.

                string movie = "movie";
                string book = "book";
                string color = "color";


                // TODO Prompt the user with the text "What is your name?" 
                // and assign their value to a "name" string variable.
                Console.WriteLine("tell me a good " + movie);
                string goodMovie = Console.ReadLine();
                Console.WriteLine("Nice");

                Console.WriteLine("tell me a good " + book);
                Console.ReadLine();

                Console.WriteLine("tell me your favorite " + color);
                Console.ReadLine();

                // TODO Prompt the user with the text 
                // "What is your favorite <thing>?" 
                // and assign their value to a "favoriteThing" string variable.

                // TODO Write the user's name and favorite thing to the console.
                // Example: "My name is James and my favorite movie is Toy Story."
            }
        }
    }
}
