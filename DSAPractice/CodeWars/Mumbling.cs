using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class Mumbling
    {
        public static string Accum(string s)
        {
            char[] array = s.ToCharArray();
            string solution = "";
            for (int i = 0; i < array.Length; i++)
            {
                solution += array[i].ToString().ToUpper();

                for (int j = 0; j < i; j++)
                {
                    solution += array[i].ToString().ToLower();
                }
                solution += "-";
            }
            return solution.TrimEnd('-');
        }
    }
}
