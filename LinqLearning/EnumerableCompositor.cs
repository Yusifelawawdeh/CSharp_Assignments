using System;
using System.Collections;
using System.Collections.Generic;


namespace LinqLearning
{
    class EnumerableCompositor<T> : IEnumerable<T>
    {
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
