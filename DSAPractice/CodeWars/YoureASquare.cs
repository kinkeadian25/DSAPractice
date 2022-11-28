using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class YoureASquare
    {
        public static bool IsSquare(int n)
        {
            double square = Math.Sqrt(n);
            if (square % 1 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
