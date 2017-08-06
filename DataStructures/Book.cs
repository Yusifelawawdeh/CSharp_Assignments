using System;

namespace DataStructures
{
    public class Book
    {
        public string Isbn { get; internal set; }
        public string Title { get; internal set; }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }
}