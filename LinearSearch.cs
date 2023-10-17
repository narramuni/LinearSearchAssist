using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchAssist
{
    public class LinearSearch
    {
        public static int LinearSearchValues(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; // Element found, return the index
                }
            }
            return -1; // Element not found


        }
    }
}
