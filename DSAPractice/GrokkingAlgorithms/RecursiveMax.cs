using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.GrokkingAlgorithms
{
    public class RecursiveMax
    {
        public static int Max(IEnumerable<int> list)
        {
            if(list.Count() <= 2) return list.First() > list.Skip(1).First() ? list.First() : list.Skip(1).First();

            int testMax = Max(list.Skip(1));
            return list.First() > testMax ? list.First() : testMax;
        }
    }
}