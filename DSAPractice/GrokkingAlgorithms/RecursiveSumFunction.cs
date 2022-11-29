using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.GrokkingAlgorithms
{
    public class RecursiveSumFunction
    {
        public static int Sum(int[] arr, int pointer)
        {
            if (arr.Length == 0) return 0;
            if(pointer <= 1) 
            {
                return arr[0];
            }
            else
            {
                pointer--;
                return arr[pointer] + Sum(arr, pointer);
            }
        }
    }
}