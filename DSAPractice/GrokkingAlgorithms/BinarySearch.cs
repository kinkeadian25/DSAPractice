using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.GrokkingAlgorithms
{
    public class BinarySearch
    {
        //binary search log2n
        //binary search of 128 items is at worst 7 tries 128,64,32,16,8,4,2,1
        //binary search of 356 items is at worst 8 tries 356,128,64,32,16,8,4,2,1
        public static int? NumberOfSteps128(int[] array, int target)
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
            return null;
        }
    }
}