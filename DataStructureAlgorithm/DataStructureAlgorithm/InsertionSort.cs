using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    internal class InsertionSort
    {
        public static void Sort()
        {
            //integer array
            int[] array = new int[5] { 10, 2, 1, 6, 4 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
            for(int i = 1; i < array.Length; i++) 
            {
                
                int value = array[i];
                int j = i - 1;
                //check whether left elemnet is greater or less than current elemnt
                while((j>=0) && (array[j].CompareTo(value) > 0))
                {
                    //moving left side elemnt to the forward direction
                    array[j+1] = array[j];
                    j--;
                }
                //stored correct elemnts to its correct position
                 array[j + 1] = value;
            }
            Console.WriteLine("after soeting element is:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
