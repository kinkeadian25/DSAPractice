using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class MaxSubset
    {
        public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            else if (array.Length == 1)
            {
                return array[0];
            }
            var maxSums = new int[array.Length];
            maxSums[0] = array[0];
            maxSums[1] = Math.Max(array[0], array[1]);

            for (var i = 2; i < array.Length; i++)
            {
                maxSums[i] = Math.Max(maxSums[i - 1], maxSums[i - 2] + array[i]);
            }

            int solution = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxSums[i] > solution)
                {
                    solution = maxSums[i];
                }
            }
            return solution;
        }
    }
}