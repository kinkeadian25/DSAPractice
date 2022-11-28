using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class WhoLikesIt
    {
        public static string Likes(string[] name)
        {
            string[] solution = new string[name.Length];
            if (name.Length == 0)
            {
                return "no one likes this";
            }
            for (int i = 0; i < name.Length; i++)
            {
                solution[i] = name[i];
            }
            if (name.Length == 1)
            {
                return $"{solution[0]} likes this";
            }
            if (name.Length == 2)
            {
                return $"{solution[0]} and {solution[1]} like this";
            }
            if (name.Length == 3)
            {
                return $"{solution[0]}, {solution[1]} and {solution[2]} like this";
            }
            if (name.Length > 3)
            {
                return $"{solution[0]}, {solution[1]} and {(name.Length - 2).ToString()} others like this";
            }
            return "";

        }
    }
}
