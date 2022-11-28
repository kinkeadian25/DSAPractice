using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class ValidateSubsequence
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int countArr = 0;
            int countSeq = 0;

            while (countArr < array.Count && countSeq < sequence.Count)
            {
                if (sequence[countSeq] == array[countArr])
                {
                    countSeq++;
                }
                countArr++;
            }
            return sequence.Count == countSeq;
        }
    }
}
