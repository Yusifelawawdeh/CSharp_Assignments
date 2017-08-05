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
        /// constructor that takes Ienumerable interaface to store lists sets and arrays in a collection
        /// </summary>
        /// <param name="collections">any type of collection passed in</param>
        public EnumerableCompositor(IEnumerable<IEnumerable<T>> collections)
        {
            _collections = collections.ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
