using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class BinarySearch
    {
        public static int BinarySearchMethod(int[] array, int target)
        {
            int start = 0;
            int end = array.Length - 1;

            while(start <= end)
            {
                int mid = (start + end)/2;
                int guess = array[mid];
                if(guess == target) return mid;
                if(guess > target) 
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}