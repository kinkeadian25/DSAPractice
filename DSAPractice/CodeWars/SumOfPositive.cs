using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            int[] solution = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    solution[i] = arr[i];
                }
                else
                {
                    solution[i] = 0;
                }
            }
            return solution.Sum();
        }
    }
}
