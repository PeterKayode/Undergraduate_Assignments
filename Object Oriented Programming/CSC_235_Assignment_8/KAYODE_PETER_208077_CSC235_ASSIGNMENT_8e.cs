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
            string s= "I know and I know if I can trust Him, He can save me from the impending doom if only I believe in Him";
            Console.WriteLine();

            // Spliting the sentence using space
            string [] a = s.Split(' ');

            // Reverse the sentence
            Array.Reverse(a);

            Console.WriteLine("The reverse sentence is: ");

            // loop the splited reversed string 
            for(int i=0;i<=a.Length-1;i++)

            {
                // Printing the reversed sentenced
                Console.Write(a[i]+""+' ');
            }
            Console.WriteLine();
        }
    }
}