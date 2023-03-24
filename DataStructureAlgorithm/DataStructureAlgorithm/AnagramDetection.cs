using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    internal class AnagramDetection
    {
        public static void Anagram()
        {
            string str1 = "heart";
            string str2 = "earth";
            //now convert every character to lowerCase and copies the characters to a unicode character Array
            char[] ch = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            //now sort a array 
            Array.Sort(ch); 
            Array.Sort(ch2);
            string string1 = new string(ch);
            string string2 = new string(ch2);

            if(string1 == string2) 
            {
                Console.WriteLine("both the string are Anagram");
            }
            else
            {
                Console.WriteLine("both string are not anagram");
            }
        }
        
    }
}
