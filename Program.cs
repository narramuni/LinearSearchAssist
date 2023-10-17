using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            int[] array = { 5, 12, 7, 34, 89, 15, 28, 47, 62, 50 };

            Console.WriteLine("Array values: " + string.Join(", ", array));



            Console.Write("Enter a value to search for: ");
            int target = int.Parse(Console.ReadLine());

            int index = LinearSearch.LinearSearchValues(array, target);

            if (index != -1)
            {
                Console.WriteLine($"{target} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"{target} not found in the array.");
            }
            Console.ReadLine();
        }

        //public static int LinearSearch(int[] array, int target)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] == target)
        //        {
        //            return i; // Element found, return the index
        //        }
        //    }
        //    return -1; // Element not found
        
     
        //}


    }

}
