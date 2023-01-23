using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.AlgoExpert
{
    public class TandemBicycle
    {
        public int TandemBicycleSpeed(int[] red, int[] blue, bool fastest)
        {
            Array.Sort(red);
            Array.Sort(blue);

            if (fastest)
            {
                Array.Reverse(blue);
            }
            int speed = 0;
            for (int i = 0; i < blue.Length; i++)
            {
                if (blue[i] > red[i])
                {
                    speed += blue[i];
                }
                else
                {
                    speed += red[i];
                }
            }
            return speed;
        }
    }
}