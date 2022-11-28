using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class TwoNumberSum
    {
        public static int[] TwoNumberSumMethod(int[] array, int targetSum)
        {
            if (array == null || array.Length < 2)
                return new int[0];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (dic.ContainsKey(targetSum - array[i]))
                    return new int[] { array[i], dic[targetSum - array[i]] };
                else if (!dic.ContainsKey(array[i]))
                    dic.Add(array[i], array[i]);
            }

            return new int[0];
        }
    }
}
