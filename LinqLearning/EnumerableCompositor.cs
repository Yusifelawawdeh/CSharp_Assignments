using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LinqLearning
{
    class EnumerableCompositor<T> : IEnumerable<T>
    {
        private List<IEnumerable<T>> _collections;


        /// <summary>
        /// Initializer for collections that instantiate the enumerable compositer
        /// </summary>
        public EnumerableCompositor()
        {
            _collections = new List<IEnumerable<T>>();
        }
        /// <summary>
        /// constructor that takes Ienumerable interaface to store lists sets and arrays in a collection
        /// </summary>
        /// <param name="collections">any type of collection passed in</param>
        public EnumerableCompositor(IEnumerable<IEnumerable<T>> collections)
        {
            _collections = collections.ToList();
        }

        public void Add(IEnumerable<T> collection)
        {
            _collections.Add(collection);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var collection in _collections)
            {
                foreach (var item in collection)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
