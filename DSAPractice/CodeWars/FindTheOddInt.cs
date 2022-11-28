using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {
            int count = 0;
            Array.Sort(seq);
            int[] arr = seq;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count % 2 != 0)
                {
                    return arr[i];
                }

            }

            return -1;
        }
    }
}
