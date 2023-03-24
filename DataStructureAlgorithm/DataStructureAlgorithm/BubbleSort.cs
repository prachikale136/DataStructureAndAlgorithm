using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    internal class BubbleSort
    {
        public static void SortArrayUsingBubbleSort()
        {
            int[] array = new int[] { 5, 6, 2, 3, 1 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            for(int i = 0; i <= array.Length - 2; i++)
            {
                for(int j = 0; j <= array.Length -2; j++) 
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[ j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("after soeting element is:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }


    }
}
