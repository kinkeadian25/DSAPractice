using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.GrokkingAlgorithms
{
    public class ListCountRecursive
    {
        public static int Count(IEnumerable<int> list)
        {
            if(!list.Any()) return 0;

            return 1 + Count(list.Skip(1));
        }
    }
}