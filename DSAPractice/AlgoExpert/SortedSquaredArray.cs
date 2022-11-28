using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class SortedSquaredArray
    {
        public int[] SortedSquaredArrayMethod(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            int[] solution = new int[array.Length];

            for (int i = end; end >= start; i--)
            {
                if (array[start] * array[start] > array[end] * array[end])
                {
                    solution[i] = array[start] * array[start];
                    start++;
                }
                else
                {
                    solution[i] = array[end] * array[end];
                    end--;
                }
            }
            return solution;
        }
    }
}
