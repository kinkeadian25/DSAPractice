using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class MinimumWaitingTime
    {
        public int MinimumWaitingTimeMethod(int[] queries)
        {
            Array.Sort(queries);
            int helper = 0;
            int solution = 0;

            foreach (int unit in queries)
            {
                solution = solution + helper;
                helper = helper + unit;
            }
            return solution;
        }
    }
}
