using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    internal class PrimeNumber
    {
        public static void IsPrime()
        {
            Console.WriteLine("Starting number of input range");
            int srtNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input ending of range");
            int endNo = Convert.ToInt32(Console.ReadLine());
            for(int number = srtNo; number <= endNo; number++) 
            {
                int count = 0;

                for (int i = srtNo; i <= endNo; i++)
                {
                    if(number % i == 0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                    Console.WriteLine(number);

                }
            }
            Console.ReadLine();
        }

    }
}
