using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class ArrayDiff
    {
        public static int[] ArrayDiffMethod(int[] a, int[] b)
        {
            List<int> filteredList = a.Where(e => !b.Contains(e)).ToList();
            return filteredList.ToArray();
        }
    }
}
