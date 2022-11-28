using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class NthFibonacci
    {
        public static int GetNthFib(int n)
        {
            if (n <= 2)
            {
                return n - 1;
            }

            return GetNthFib(n - 1) + GetNthFib(n - 2);
        }
    }
}
