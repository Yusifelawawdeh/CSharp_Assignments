using System;

namespace DataStructures
{
    public class GenericList<T>
    {

        public void Add(T value)
        {
            
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey Key, TValue value)
        {
            
        }

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