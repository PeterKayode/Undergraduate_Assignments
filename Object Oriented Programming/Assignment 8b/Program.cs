// NAME: KAYODE PETER TEMITOPE
// MATRIC NUMBER: 208077
// DEPARTMENT: COMPUTER SCIENCE(200 LEVEL)


using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Program 
    {
        public static void Main()
        {
            // Declaring the variable string
			string str;
			
			str = "abracadabra";
			Console.WriteLine();
			
            // Assigning the character "a" to be counted
            char ch = 'a';
 
            int freq = str.Count(f => (f == ch));

            // To display the number of "a'(s)" in the string inputed
            Console.WriteLine("There are " + freq + " a's in the word, " + str);
        }
    }
}