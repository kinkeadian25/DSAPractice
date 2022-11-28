using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class PalindromeCheck
    {
        public static bool IsPalindrome(string str)
        {
            int start = 0;
            for (int i = str.Length - 1; i > 0; i--)
            {
                if (str[i] != str[start]) return false;
                start++;
            }
            return true;
        }
    }
}
