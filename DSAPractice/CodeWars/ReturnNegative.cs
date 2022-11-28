using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class ReturnNegative
    {
        public static int MakeNegative(int number)
        {
            if (number > 0)
            {
                return number * -1;
            }
            else
            {
                return number;
            }
        }
    }
}
