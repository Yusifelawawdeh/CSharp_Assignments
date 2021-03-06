﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqLearning.EnumerableCompositor;

namespace LinqLearning
{
    class Program
    {
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        static void Main(string[] args)
        {
            var list1 = new List<int> {1, 2, 3, 4, 5};
            var list2 = new List<int> { 2, 4, 6, 8, 10 };
            var set1 = new HashSet<int> { 3, 6, 9, 12, 15 };
            var array1 = new[] { 4, 8, 12, 16, 20 };

            int numOdd = EC(list1, list2, set1, array1).Count(x => IsOdd(x));

            HashSet<int> set = EC(list1, list2, set1, array1).To<HashSet<int>>();

            #region learning how to use yields

            //IEnumerable<int> firstThree = Utils.Take(list1, 3);

            //foreach (var item in firstThree)
            //{

            //} 

            #endregion

            #region Middle Way with out Ienumerable instance collection

            //var ec = new EnumerableCompositor<int>(new IEnumerable<int>[] {list1, list2, set1, array1});
            //int numOdd = ec.Count(x => IsOdd(x)); 

            #endregion

            #region long way 

            //foreach (var value in list1)
            //{
            //    if (IsOdd(value))
            //    {
            //        numOdd++;
            //    }
            //}
            //foreach (var value in list2)
            //{
            //    if (IsOdd(value))
            //    {
            //        numOdd++;
            //    }
            //}
            //foreach (var value in set1)
            //{
            //    if (IsOdd(value))
            //    {
            //        numOdd++;
            //    }
            //}
            //foreach (var value in array1)
            //{
            //    if (IsOdd(value))
            //    {
            //        numOdd++;
            //    }
            //} 

            #endregion

        }



    }
}
