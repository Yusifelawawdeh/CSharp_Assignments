using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    partial class Program
    {
        public static void main(string[] args)
        {
            #region earlier version
            //var book = new Book { Isbn = "1234", Title = "Dark Star"};


            ////var numbers = new GenericList<int>();
            ////numbers.Add(10);

            ////var books = new BookList();
            ////books.Add(book)

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("anything goes", new Book()); 
            #endregion

            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

        }
    }
}
