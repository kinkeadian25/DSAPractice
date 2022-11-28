using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class SumOfDigitsDigitalRoot
    {
        public int DigitalRoot(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }
    }
}
