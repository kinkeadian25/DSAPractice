using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.GrokkingAlgorithms
{
    public class QuickSortRecursive
    {
        public static IEnumerable<int> QuickSort(IEnumerable<int> list)
        {
            if (list.Count() <= 1) return list;
            var pivot = list.First();
            var less = list.Skip(1).Where(i => i <= pivot);
            var greater = list.Skip(1).Where(i => i > pivot);
            return QuickSort(less).Union(new List<int> { pivot }).Union(QuickSort(greater));   
        }
    }
}