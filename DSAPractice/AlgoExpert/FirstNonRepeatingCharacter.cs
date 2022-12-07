using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class FirstNonRepeatingCharacter
    {
        public int FirstNonRepeatingCharacterMethod(string str) 
        {
            Dictionary<int, char> dict = new();

            for (int i = 0; i < str.Length; i++)
            {
                if(!dict.ContainsValue(str[i]))
                {
                    dict.Add(i, str[i]);
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if(!dict.ContainsValue(str[i]))
                {
                    return i;
                }
            } 
            return 0;           
	    }
    }
}