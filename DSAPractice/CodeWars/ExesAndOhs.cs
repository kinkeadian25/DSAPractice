using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class ExesAndOhs
    {
        public static bool XO(string input)
        {
            int foundX = 0;
            int foundO = 0;
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i].ToString().ToLower() == "x") { foundX++; }
                else if (chars[i].ToString().ToLower() == "o") { foundO++; }

            }
            if (foundX == foundO)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
