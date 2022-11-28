using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class NonConstructibleChange
    {
        public int NonConstructibleChangeMethod(int[] coins)
        {
            Array.Sort(coins);
            int change = 0;
            foreach (int coin in coins)
            {
                if (coin > change + 1)
                {
                    return change + 1;
                }
                else
                {
                    change += coin;
                }
            }
            return change + 1;
        }
    }
}
