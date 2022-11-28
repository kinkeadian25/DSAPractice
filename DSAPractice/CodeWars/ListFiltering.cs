using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.CodeWars
{
    public class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> ints = listOfItems.OfType<int>().ToList();

            return ints;
        }
    }
}
